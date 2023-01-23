using Lollipop_boutique.Areas.Admin.Models;
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
    public class KhachhangController : Controller
    {


        private readonly ILogger<KhachhangController> _logger;

        public KhachhangController(ILogger<KhachhangController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LietKeKH()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            return View(context.GetListKhachHang());
        }
        public IActionResult EnterCustomer()
        {

            return View();
        }

        public IActionResult CreateCustomer(Khachhang kh)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.InsertKH(kh);
            //if (count > 0)
            //    _notifyService.Success("Create New Customer Success");
            //else
            //    _notifyService.Success("Create New Customer Unuccess");
            return View();
        }
        public void UpdateKhachHang(Khachhang kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateKhachHang(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewKhachHang(int MAKH)
        {
            System.Diagnostics.Debug.WriteLine(MAKH);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            Khachhang kh = context.ViewKhachHang(MAKH);
            ViewData.Model = kh;
            return View();
        }

        public IActionResult DeleteKhachHang(int MAKH)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.DeleteKhachHang(MAKH);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }


        //public IActionResult SearchCustomer(string name)
        //{
        //    AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
        //    return View(context.SearchKH(name));
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
