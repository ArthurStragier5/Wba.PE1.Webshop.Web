using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.PE1.Webshop.Web.Services
{
    public class FileStoreService : IFileStoreService
    {
        private readonly IHostingEnvironment _hostingEnviroment;
        private FileStream fileStream;
        public FileStoreService(IHostingEnvironment hostingEnviroment)
        {
            _hostingEnviroment = hostingEnviroment;
        }

        public async Task<string> StorePhoneImage(IFormFile file)
        {
            string fullFileName = $"{Guid.NewGuid().ToString()}_{file.FileName}";
            string filePath = Path.Combine(_hostingEnviroment.WebRootPath, "images", "phones", fullFileName);
            fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return fullFileName;
        }
    }
}
