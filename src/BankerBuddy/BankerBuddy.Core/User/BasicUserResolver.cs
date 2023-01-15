using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.User
{
    public class BasicUserResolver : IUserResolver
    {

        public BasicUserResolver()
        {
        }

        public Task<UserInformation> GetUser(CancellationToken cancellationToken)
        {
            //TODO: when needed
            return Task.FromResult(new UserInformation()
            {
                Email = "dummy@example.com",
                Name = "Dum",
                UserName = "Dumbo",
                UserGuid = new Guid("ae811b92-1edc-417f-b10d-310bdd922834")
            });
        }
    }
}
