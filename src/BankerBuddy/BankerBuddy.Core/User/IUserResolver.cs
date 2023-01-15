using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.User
{
    public interface IUserResolver
    {
        public Task<UserInformation> GetUser(CancellationToken cancellationToken = default);
    }
}
