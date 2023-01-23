using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop_boutique.Areas.Admin.Models
{
    public class Khachhang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string LoaiKH { get; set; }
    }
}