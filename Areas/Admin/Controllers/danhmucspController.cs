using Lollipop_boutique.Areas.Admin.Models;
using doan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ErrorViewModel = Lollipop_boutique.Areas.Admin.Models.ErrorViewModel;


namespace Lollipop_boutique.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class danhmucspController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LietKeCategory()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            return View(context.GetListCategory());
        }
        public IActionResult EnterCategory()
        {

            return View();
        }

        public IActionResult CreateCategory(danhmucsp tp)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.CreateCategory(tp);
            if (count > 0)
                ViewData["thongbao"] = "Them category thanh cong";
            else
                ViewData["thongbao"] = "Them category khong thanh cong";
            return View();
        }

        public void UpdateCategory(danhmucsp kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateCategory(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewCategory(int MADANHMUC)
        {
            System.Diagnostics.Debug.WriteLine(MADANHMUC);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            danhmucsp kh = context.ViewCategory(MADANHMUC);
            ViewData.Model = kh;
            return View();
        }
        public IActionResult DeleteCategory(int MADANHMUC)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.DeleteCategory(MADANHMUC);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
