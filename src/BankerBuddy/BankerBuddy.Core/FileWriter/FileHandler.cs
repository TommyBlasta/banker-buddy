using BankerBuddy.Core.FileModel;
using BankerBuddy.Core.User;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileWriter
{
    public class FileHandler : IFileWriter, IFileReader
    {
        private readonly FilePathResolver filePathResolver;

        public FileHandler(FilePathResolver filePathResolver)
        {
            this.filePathResolver = filePathResolver;
        }

        public StreamReader GetFileReader(SaveableFile saveableFile, UserInformation userInformation)
        {
            var filePath = filePathResolver.GetPath(saveableFile, userInformation);
            return File.OpenText(filePath);
        }

        public Stream GetFileStream(SaveableFile saveableFile, UserInformation userInformation)
        {
            var filePath = filePathResolver.GetPath(saveableFile, userInformation);

            return File.Create(Path.Combine(filePath));
        }
    }
}
