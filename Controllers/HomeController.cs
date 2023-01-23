using doan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace doan.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly LollipopContext _context;
        public HomeController(LollipopContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(doan.Models.StoreContext)) as StoreContext;
            List<Sanpham> listSP = context.getSPBanchay();
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
        /// <summary>
        /// /////////
        /// </summary>
        /// <returns></returns>
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}