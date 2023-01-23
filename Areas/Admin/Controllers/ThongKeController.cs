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
    public class ThongKeController : Controller
    {
        private readonly AdminContext _context;

        public ThongKeController(AdminContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SanPham_DanhMuc()

        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            var listdmsp = new SortedList<string, int>();
            listdmsp = context.slSanPham_DanhMuc();
            ViewBag.ListDMSP = listdmsp;
            return View();
        }
        public IActionResult DanhThu_Thang(int year)
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            SortedList<string, int> listdtt = _context.DanhSo_Thang();
            ViewBag.ListDTT = listdtt;

            return View();
        }
        public IActionResult Top10DonHang()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            List<dondathang> listdh = context.get10_Dondathang();
            ViewBag.ListDH = listdh;
            return View();

        }
        public IActionResult TK_NhaVanChuyen()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            var listnvc = new SortedList<string, int>();
            listnvc = context.TK_NhaVanChuyen();
            ViewBag.ListNVC = listnvc;
            return View();
        }
        public IActionResult DoanhThu_Ngay()
        {
            AdminContext context = HttpContext.RequestServices.GetService(typeof(Lollipop_boutique.Areas.Admin.Models.AdminContext)) as AdminContext;
            var listDT = new SortedList<string, int>();
            listDT = context.DanhSo_Ngay();
            ViewBag.ListDT = listDT;
            return View();
        }
    }
}
