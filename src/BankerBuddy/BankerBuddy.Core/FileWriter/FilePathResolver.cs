using BankerBuddy.Core.FileModel;
using BankerBuddy.Core.User;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileWriter
{
    public class FilePathResolver
    {
        private Options.FileOptions fileOptions;
        private IHostEnvironment environment;
        private readonly ILogger<FilePathResolver> logger;

        public FilePathResolver(IOptions<Core.Options.FileOptions> fileOptions,
            IHostEnvironment environment,
            ILogger<FilePathResolver> logger)
        {
            this.fileOptions = fileOptions.Value;
            this.environment = environment;
            this.logger = logger;
        }

        public string GetPath(SaveableFile saveableFile, UserInformation userInformation)
        {
            var currentDir = GetCurrentApplicationPath();

            var targetFilePath = Path.Combine(currentDir, this.fileOptions.BaseFileSavePath, userInformation.UserGuid.ToString(), saveableFile.FileType);

            var extension = ".csv";

            var fileName = saveableFile.FileIdentifier.ToString() + "_uploaded" + extension;

            if (!Directory.Exists(targetFilePath))
            {
                Directory.CreateDirectory(targetFilePath);
                this.logger.LogInformation("The folder {folder} didn't exist and was created.", targetFilePath);
            }

            return Path.Combine(targetFilePath, fileName);
        }

        private string GetCurrentApplicationPath()
        {
            return environment.ContentRootPath;
        }
    }
}
