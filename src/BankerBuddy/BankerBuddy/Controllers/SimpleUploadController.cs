using BankerBuddy.Api.Upload;
using BankerBuddy.Core.FileWriter;
using BankerBuddy.Core.User;
using Microsoft.AspNetCore.Mvc;

namespace BankerBuddy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleUploadController : ControllerBase
    {
        private readonly IFileWriter fileWriter;
        private readonly IUserResolver userResolver;

        public SimpleUploadController(IFileWriter fileWriter, IUserResolver userResolver)
        {
            this.fileWriter = fileWriter;
            this.userResolver = userResolver;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromForm] UploadFile uploadFile, CancellationToken cancellationToken)
        {
            var currentUser = await userResolver.GetUser(cancellationToken);

            using var destinationFileStream = fileWriter.GetFileStream(new Core.FileModel.SaveableFile()
            {
                FileName = uploadFile.FormFile.FileName,
                FileType = uploadFile.FileType
            }, currentUser);

            await uploadFile.FormFile.CopyToAsync(destinationFileStream, cancellationToken);
            return Ok();
        }
    }
}
