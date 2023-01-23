using doan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace doan.Controllers
{
    public class SanphamController : Controller
    {
        private readonly LollipopContext _context;
        public SanphamController(LollipopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(doan.Models.StoreContext)) as StoreContext;
            List<Sanpham> listSP = context.GetListSanPham();
            ViewData.Model = listSP;
            List<string> listHA = new List<string>();
            foreach (var item in listSP)
            {
                string str = context.HinhAnhSP(item.MaSp)[0].LinkHinhAnh;
                listHA.Add(str);
            }
            ViewBag.HinhAnhSP = listHA;
            return View();


        }




        //[Route ("/{id}.html"), Name = "ProductDetails")]
        

        public IActionResult Details(int MaSp)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(doan.Models.StoreContext)) as StoreContext;
            ViewBag.SanPham = context.getSPInfo(MaSp);
            ViewBag.HinhAnhSP = context.GethinhanhbyID(MaSp);
            return View();

        }
    }
}