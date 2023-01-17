using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Core.FileModel
{
    public class SaveableFile
    {
        public Guid FileIdentifier { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;    
    }
}
