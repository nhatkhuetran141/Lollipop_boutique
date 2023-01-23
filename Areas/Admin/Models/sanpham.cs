using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Lollipop_boutique.Areas.Admin.Models
{
    public class sanpham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaTien { get; set; }
        public int SoLuong { get; set; }
        public int MaDanhMuc { get; set; }
        public string MoTa { get; set; }
        public int MaNCC { get; set; }

    }
}
