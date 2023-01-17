using BankerBuddy.Api.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace BankerBuddy.Controllers
{
    [ApiController]
    [Route("[controller]/{userGuid}")]
    public class TransactionsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Transaction>> GetAsync([FromRoute] Guid UserGuid, [FromQuery] string fileType, CancellationToken cancellationToken)
        {
            // 1. Get all the files from the folder files/useGuid/fileType
            // 2. Go through the files and try to read them using the BankerBuddy.Core.CsvReader class (to be implemented)
            // 3. Map the data returned from the CsvReader to the return type
            return new List<Transaction>();
        }

    }
}
