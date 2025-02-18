
import pandas as pd
from sklearn.ensemble import RandomForestClassifier
from sklearn.metrics import accuracy_score, precision_score

class MatchPredictor:
	def __int__(self):
		self.file_path = "..\wwwroot\resources\matches.csv"
		self.matches = None
		self.model = RandomForestClassifier(n_estimators=50, min_samples_split=10, random_state=1)

	def load_data(self):
		self.matches = pd.read_csv(self.file_path)
        self.matches["DateTime"] = pd.to_datetime(self.matches["DateTime"])
        self.matches["HomeTeam_Code"] = self.matches["HomeTeam"].astype("category").cat.codes
        self.matches["AwayTeam_Code"] = self.matches["AwayTeam"].astype("category").cat.codes
        self.matches["hour"] = self.matches["DateTime"].dt.hour.astype("int")
        self.matches["target_home"] = (self.matches["FTR"] == "H").astype("int")
        self.matches["target_away"] = (self.matches["FTR"] == "A").astype("int")

	def rolling_averages(self, group, cols, new_cols):
        group = group.sort_values("DateTime")
        rolling_stats = group[cols].rolling(7, closed='left').mean()
        group[new_cols] = rolling_stats
        group = group.dropna(subset=new_cols)
        return group

    def preprocess_data(self):
        cols = ["FTHG", "HS", "HST", "HC"]
        new_cols = [f"{c}_rolling" for c in cols]
        self.matches = self.matches.groupby("HomeTeam").apply(lambda x: self.rolling_averages(x, cols, new_cols))
        self.matches = self.matches.droplevel("HomeTeam")
        self.matches.index = range(self.matches.shape[0])
        return new_cols

    def train_and_evaluate(self, predictors):
        train = self.matches[self.matches["DateTime"] < '2022-01-01']
        test = self.matches[self.matches["DateTime"] > '2022-01-01']

        self.model.fit(train[predictors], train["target_home"])
        preds = self.model.predict(test[predictors])

        accuracy = accuracy_score(test["target_home"], preds)
        precision = precision_score(test["target_home"], preds)

        return accuracy, precision, test, preds

    def make_predictions(self, predictors):
        accuracy, precision, test, preds = self.train_and_evaluate(predictors)
        combined = pd.DataFrame(dict(actual=test["target_home"], prediction=preds), index=test.index)
        combined = combined.merge(self.matches[["DateTime", "HomeTeam", "AwayTeam", "FTR"]], left_index=True, right_index=True)
        return combined, accuracy, precision