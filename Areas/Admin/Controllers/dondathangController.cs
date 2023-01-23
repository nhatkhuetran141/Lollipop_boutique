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
    public class dondathangController : Controller
    {

        private readonly ILogger<dondathangController> _logger;

        public dondathangController(ILogger<dondathangController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult revenue(int THANHTIEN)
        //{
        //    AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
        //    return View(context.Revenue(THANHTIEN));
        //}
        //public IActionResult revenue(int THANHTIEN)
        //{
        //    AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
        //    ViewBag.Revenue = context.Revenue(THANHTIEN);
        //    return View();
        //}
        public IActionResult ViewOrder_Product(int MaKH)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            return View(context.GetListOrder_product(MaKH));


        }
        public IActionResult ViewOrderAll()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            ViewBag.ListOrderAll = context.GetListOrder();
            return View();
        }
        public IActionResult ViewOrder(int MADDH)
        {
            System.Diagnostics.Debug.WriteLine(MADDH);
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            dondathang kh = context.ViewOrder(MADDH);
            ViewData.Model = kh;
            return View();
        }
        public void UpdateOrder(dondathang kh)
        {
            int count;
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            count = context.UpdateOrder(kh);
            //if (count > 0)
            //    ViewData["thongbao"] = "Update thành công";
            //else
            //    ViewData["thongbao"] = "Update không thành công";
            //return View();
        }
        public IActionResult ViewOrderDetail(int MADDH)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            ViewBag.ListOrderDetail = context.OrderDetail(MADDH);
            return View();
        }
        //public IActionResult orderDetail(string order_id, string namecustomer, string phone, string address, DateTime date_invoice, string nameDetail, string idproduct, string nameproduct, string size, int price, int quantify, int total_amountd)
        //{
        //    AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
        //    ViewBag.List = context.ViewOrderdetail(order_id, namecustomer, phone, address, date_invoice, nameDetail, idproduct, nameproduct, size, price, quantify, total_amountd);
        //    return View();


        //}

        //public IActionResult orderDetail(string order_id, string namecustomer, string phone, string address, DateTime date_invoice, string nameDetail, string idproduct, string nameproduct, string size, int price, int quantify, int total_amount)
        //{
        //    AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
        //    context.ViewOrderdetail(order_id, namecustomer, phone, address, date_invoice, nameDetail, idproduct, nameproduct, size, price, quantify, total_amount);
        //    return View();


        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
