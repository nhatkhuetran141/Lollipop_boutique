using Lollipop_boutique.Areas.Admin.Models;
using doan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop_boutique.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class hinhanhController : Controller
    {
        private readonly ILogger<hinhanhController> _logger;

        public hinhanhController(ILogger<hinhanhController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EnterHA()
        {

            return View();
        }

        public IActionResult InsertHA(hinhanh kh)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.InsertHA(kh);
            //if (count > 0)
            //    _notifyService.Success("Create New Customer Success");
            //else
            //    _notifyService.Success("Create New Customer Unuccess");
            return View();
        }
        public void UpdateHA(hinhanh kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateHA(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewHA(int MASP)
        {
            System.Diagnostics.Debug.WriteLine(MASP);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            hinhanh kh = context.ViewHA(MASP);
            ViewData.Model = kh;
            return View();
        }
        public IActionResult DeleteHA(int MAHINHANH)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.DeleteHA(MAHINHANH);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
