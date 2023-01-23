using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Lollipop_boutique.Areas.Admin.Models
{
    public class dondathang
    {
        public int MaDDH { get; set; }
        public int MaKH { get; set; }
        public int MaVoucher { get; set; }
        public float TongDonHang { get; set; }
        public float SoTienGiam { get; set; }
        public float ThanhTien { get; set; }
        public DateTime NgayDatHang { get; set; }
        public int MaNVC { get; set; }
        public int MaNV { get; set; }
        public string TENNGUOINHAN { get; set; }
        public string SDTNGUOINHAN { get; set; }
        public string DIACHINHAN { get; set; }
        public int TINHTRANGDONHANG { get; set; }

    }
}
