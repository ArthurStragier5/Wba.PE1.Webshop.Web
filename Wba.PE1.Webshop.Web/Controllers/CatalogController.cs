using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.PE1.Webshop.Web.Data;
using Wba.PE1.Webshop.Web.Services;
using Wba.PE1.Webshop.Web.ViewModels;

namespace Wba.PE1.Webshop.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        //private IFileStoreService _fileStoreService;

        public CatalogController(ApplicationDbContext applicationDbContext)//IFileStoreService fileStoreService,
        {
            _applicationDbContext = applicationDbContext;
            //_fileStoreService = fileStoreService;
        }

        public IActionResult Index()
        {
            PhoneIndexViewModel phoneIndexViewModel = new PhoneIndexViewModel();
            phoneIndexViewModel.Phones = new List<ProductShowPhoneInfoViewModel>();
            foreach (var phone in  _applicationDbContext.Products)
            {
                phoneIndexViewModel.Phones.Add
                    (new ProductShowPhoneInfoViewModel
                    {
                        Id = phone?.Id,
                        ProductName = phone?.ProductName,
                        Image = phone.Image
                    }
                    );
            }
            return View(phoneIndexViewModel);
        }
    }
}
