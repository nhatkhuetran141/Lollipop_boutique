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
    public class voucherController : Controller
    {
        private readonly ILogger<voucherController> _logger;

        public voucherController(ILogger<voucherController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LietKeVoucher()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            return View(context.GetListVoucher());
        }
        public IActionResult EnterVoucher()
        {

            return View();
        }

        public IActionResult CreateVoucher(voucher kh)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.InsertVoucher(kh);
            //if (count > 0)
            //    _notifyService.Success("Create New Customer Success");
            //else
            //    _notifyService.Success("Create New Customer Unuccess");
            return View();
        }
        public void UpdateVoucher(voucher kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateVoucher(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewVoucher(int MaVoucher)
        {
            System.Diagnostics.Debug.WriteLine(MaVoucher);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            voucher kh = context.ViewVoucher(MaVoucher);
            ViewData.Model = kh;
            return View();
        }

        public IActionResult DeleteVoucher(int MaVoucher)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            int count = context.DeleteVoucher(MaVoucher);
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
