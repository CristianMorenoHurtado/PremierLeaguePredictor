namespace PremierLeaguePredictor.Models
{
    /// <summary>
    /// Class used to match a row in the csv file.
    /// </summary>
    public class MatchData
    {
        private readonly string season;
        private readonly DateTime dateTime;
        private readonly string homeTeam;
        private readonly string awayTeam;
        private readonly int fTHG;
        private readonly int fTAG;
        private readonly string fTR;
        private readonly int hTHG;
        private readonly int hTAG;
        private readonly string hTR;
        private readonly string referee;
        private readonly int hS;
        private readonly int aS;
        private readonly int hST;
        private readonly int aST;
        private readonly int hC;
        private readonly int aC;
        private readonly int hF;
        private readonly int aF;
        private readonly int hY;
        private readonly int aY;
        private readonly int hR;
        private readonly int aR;

        /// <summary>
        /// The constructor for the <see cref="MatchData"/> class.
        /// </summary>
        /// <param name="season">The football match season.</param>
        /// <param name="dateTime">The match date and time.</param>
        /// <param name="homeTeam">The home team.</param>
        /// <param name="awayTeam">The away team.</param>
        /// <param name="fTHG">The full time home team goals.</param>
        /// <param name="fTAG">The full time away team goals.</param>
        /// <param name="fTR">The full time result (H = Home win, D = Draw, A = Away win)</param>
        /// <param name="hTHG">The half time home team goals.</param>
        /// <param name="hTAG">The half time away team goals.</param>
        /// <param name="hTR">The half time result (H = Home win, D = Draw, A = Away win)</param>
        /// <param name="referee">The match referee.</param>
        /// <param name="hS">The home team shots.</param>
        /// <param name="aS">The away team shots.</param>
        /// <param name="hST">The home team shots on target.</param>
        /// <param name="aST">The away team shots on target</param>
        /// <param name="hC">The home team corners.</param>
        /// <param name="aC">The away team corners.</param>
        /// <param name="hF">The home team fouls.</param>
        /// <param name="aF">The away team fouls.</param>
        /// <param name="hY">The home team yellow cards.</param>
        /// <param name="aY">The away team yellow cards.</param>
        /// <param name="hR">The home team red cards.</param>
        /// <param name="aR">The away team red cards.</param>
        public MatchData(string season, DateTime dateTime, string homeTeam, string awayTeam, int fTHG, int fTAG, string fTR, int hTHG, int hTAG, string hTR,
            string referee, int hS, int aS, int hST, int aST, int hC, int aC, int hF, int aF, int hY, int aY, int hR, int aR)
        {
            this.season = season;
            this.dateTime = dateTime;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.fTHG = fTHG;
            this.fTAG = fTAG;
            this.fTR = fTR;
            this.hTHG = hTHG;
            this.hTAG = hTAG;
            this.hTR = hTR;
            this.referee = referee;
            this.hS = hS;
            this.aS = aS;
            this.hST = hST;
            this.aST = aST;
            this.hC = hC;
            this.aC = aC;
            this.hF = hF;
            this.aF = aF;
            this.hY = hY;
            this.aY = aY;
            this.hR = hR;
            this.aR = aR;
        }

        /// <summary>
        /// The football match season.
        /// </summary>
        public string Season { get => season; }

        /// <summary>
        /// The match date and time.
        /// </summary>
        public DateTime DateTime { get => dateTime; }

        /// <summary>
        /// The home team.
        /// </summary>
        public string HomeTeam { get => homeTeam; }

        /// <summary>
        /// The away team.
        /// </summary>
        public string AwayTeam { get => awayTeam; }

        /// <summary>
        /// The full time home team goals.
        /// </summary>
        public int FullTimeHomeGoals { get => fTHG; }

        /// <summary>
        /// The full time away team goals.
        /// </summary>
        public int FullTimeAwayGoals { get => fTAG; }

        /// <summary>
        /// The full time result (H = Home win, D = Draw, A = Away win)
        /// </summary>
        public string FullTimeResult { get => fTR; }

        /// <summary>
        /// The half time home team goals.
        /// </summary>
        public int HalfTimeHomeGoals { get => hTHG; }

        /// <summary>
        /// The half time away team goals.
        /// </summary>
        public int HalfTimeAwayGoals { get => hTAG; }

        /// <summary>
        /// The half time result (H = Home win, D = Draw, A = Away win)
        /// </summary>
        public string HalfTimeResult { get => hTR; }

        /// <summary>
        /// The match referee.
        /// </summary>
        public string Referee { get => referee; }

        /// <summary>
        /// The home team shots.
        /// </summary>
        public int HomeShots { get => hS; }

        /// <summary>
        /// The away team shots.
        /// </summary>
        public int AwayShots { get => aS; }

        /// <summary>
        /// The home team shots on target.
        /// </summary>
        public int HomeShotsOnTarget { get => hST; }

        /// <summary>
        /// The away team shots on target.
        /// </summary>
        public int AwayShotsOnTarget { get => aST; }

        /// <summary>
        /// The home team corners.
        /// </summary>
        public int HomeCorners { get => hC; }

        /// <summary>
        /// The away team corners.
        /// </summary>
        public int AwayCorners { get => aC; }

        /// <summary>
        /// The home team fouls.
        /// </summary>
        public int HomeFouls { get => hF; }

        /// <summary>
        /// The away team fouls.
        /// </summary>
        public int AwayFouls { get => aF; }

        /// <summary>
        /// The home team yellow cards.
        /// </summary>
        public int HomeYellowCards { get => hY; }

        /// <summary>
        /// The away team yellow cards.
        /// </summary>
        public int AwayYellowCards { get => aY; }

        /// <summary>
        /// The home team red cards.
        /// </summary>
        public int HomeRedCards { get => hR; }

        /// <summary>
        /// The away team red cards.
        /// </summary>
        public int AwayRedCards { get => aR; }
    }
}
