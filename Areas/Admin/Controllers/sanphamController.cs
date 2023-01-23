using Lollipop_boutique.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lollipop_boutique.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class sanphamController : Controller
    {
        private readonly ILogger<sanphamController> _logger;

        public sanphamController(ILogger<sanphamController> logger)
        {
            _logger = logger;
        }
        public IActionResult LietKeSP()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            ViewBag.ListSP = context.GetListProduct();
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        public IActionResult EnterProduct(sanpham kh)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.InsertSP(kh);
            if (count > 0)
                ViewData["thongbao"] = "Them SP thanh cong";
            else
                ViewData["thongbao"] = "Them SP khong thanh cong";
            return View();
        }
        public void UpdateSP(sanpham kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateSP(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewSP(int MASP)
        {
            System.Diagnostics.Debug.WriteLine(MASP);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            sanpham kh = context.ViewSP(MASP);
            ViewData.Model = kh;
            return View();
        }

        public IActionResult DeleteSP(int MASP)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.DeleteSP(MASP);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
