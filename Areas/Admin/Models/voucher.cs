using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop_boutique.Areas.Admin.Models
{
    public class voucher
    {
        public int MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public int TiLeGiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
