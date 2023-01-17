using BankerBuddy.Core.FileWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankerBuddy.Core.CSV
{
    public static class CsvReader
    {
        public static async Task<ImportData> ReadImportFileAsync(string filePath, CancellationToken cancellationToken)
        {
            using var streamReader = File.OpenText(filePath);

            var metadata = await GetMetadata(streamReader, cancellationToken);
            var transactions = await GetTransactions(streamReader, cancellationToken);


            return new ImportData()
            {
                MetaData = metadata,
                Transactions = transactions
            };
        }

        private static async Task<string> GetMetadata(StreamReader fileStreamReader, CancellationToken cancellationToken)
        {
            //This should read the .csv part which represents the import metadata
            return "TODO";
        }

        private static async Task<List<Model.Transaction>> GetTransactions(StreamReader fileStreamReader, CancellationToken cancellationToken)
        {
            //This should read the transaction from the .csv file
            return new List<Model.Transaction>()
            {
                //TODO
            };
        }
    }
}
