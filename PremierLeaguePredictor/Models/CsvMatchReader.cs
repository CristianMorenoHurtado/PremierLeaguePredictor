using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace PremierLeaguePredictor.Models
{
    /// <summary>
    /// Class used for reading the match csv file.
    /// </summary>
    public class CsvMatchReader
    {
        /// <summary>
        /// Method used for reading the match csv file.
        /// </summary>
        /// <returns>A list of MatchData objects.</returns>
        public static List<MatchData> ReadCsvFile()
        {
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "resources", "results.csv");

            using StreamReader reader = new(filepath);
            using CsvReader csv = new(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,  // First row is headers
                MissingFieldFound = null // Ignore missing fields
            });

            IEnumerable<MatchData> records = csv.GetRecords<MatchData>();
            return records.ToList();
        }
    }
}