using BankerBuddy.Core.FileModel;
using BankerBuddy.Core.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileWriter
{
    public interface IFileReader
    {
        public StreamReader GetFileReader(SaveableFile saveableFile, UserInformation userInformation);
    }
}
