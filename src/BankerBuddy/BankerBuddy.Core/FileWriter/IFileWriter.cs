using BankerBuddy.Core.Files;
using BankerBuddy.Core.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileWriter
{
    public interface IFileWriter
    {
        public Stream GetFileStream(SaveableFile saveableFile, UserInformation userInformation);
    }
}
