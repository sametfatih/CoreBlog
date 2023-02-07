using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace Blog_Project.Controllers
{
    [AllowAnonymous]
    public class ImageController : Controller
    {
        private readonly IHostEnvironment _hostEnvironment;
        public ImageController(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public async Task<JsonResult> UploadBlogImage(List<IFormFile> uploadedFile)
        {
            var vReturnImagePath = string.Empty;


            if (!Directory.Exists(_hostEnvironment.ContentRootPath + ("\\wwwroot\\images\\blogs\\contents\\")))
            {
                Directory.CreateDirectory(_hostEnvironment.ContentRootPath + ("\\wwwroot\\images\\blogs\\contents\\"));
            }
            foreach (var item in uploadedFile)
            {
                var vFileName = Guid.NewGuid().ToString();
                var vExtension = Path.GetExtension(item.FileName);

                string sImageName = vFileName+"_"+ DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

                var path = _hostEnvironment.ContentRootPath + ("\\wwwroot\\images\\blogs\\contents\\") + sImageName + vExtension;
                vReturnImagePath = "/images/blogs/contents/" + sImageName + vExtension;

                // Saving Image in Original Mode  

                using (var fs = new FileStream(path, FileMode.Create))
                {
                    await item.CopyToAsync(fs);
                    fs.Position = 0;
                }
            }
            return Json(Convert.ToString(vReturnImagePath));
        }
    }
}
