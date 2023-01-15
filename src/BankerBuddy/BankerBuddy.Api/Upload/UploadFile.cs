using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Api.Upload
{
    public class UploadFile
    {
        public IFormFile FormFile { get; set; } = null!;
        public Guid? UserGuid { get; set; }
        public string FileType { get; set; } = null!;    
    }
}
