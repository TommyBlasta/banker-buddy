using BankerBuddy.Core.FileModel;
using BankerBuddy.Core.User;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileWriter
{
    public class FileWriter : IFileWriter
    {
        private const string BaseFilePath = "files";
        private readonly ILogger<FileWriter> logger;
        private readonly IHostEnvironment environment;

        public FileWriter(ILogger<FileWriter> logger,
            IHostEnvironment environment)
        {
            this.logger = logger;
            this.environment = environment;
        }

        public Stream GetFileStream(SaveableFile saveableFile, UserInformation userInformation)
        {
            var currentDir = GetCurrentApplicationPath();

            var targetFilePath = Path.Combine(currentDir, BaseFilePath, userInformation.UserGuid.ToString(), saveableFile.FileType);

            var fileName =  "uploaded.csv";

            if (!Directory.Exists(targetFilePath))
            {
                Directory.CreateDirectory(targetFilePath);
                this.logger.LogInformation("The folder {folder} didn't exist and was created.", targetFilePath);
            }

            var targetStream = System.IO.File.Create(Path.Combine(targetFilePath, fileName));
            return targetStream;
        }

        private string GetCurrentApplicationPath()
        {
            return environment.ContentRootPath;
        }
    }
}
