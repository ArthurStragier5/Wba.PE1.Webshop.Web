using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.PE1.Webshop.Web.Services
{
    public interface IFileStoreService 
    {
        Task<string> StorePhoneImage(IFormFile file);
    }
}
