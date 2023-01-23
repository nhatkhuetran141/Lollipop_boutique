using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop_boutique.Areas.Admin.Models
{
    public class AdminContext
    {
        public string ConnectionString { get; set; }
        public object Sanpham { get; internal set; }

        public AdminContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<Khachhang> GetListKhachHang()
        {
            List<Khachhang> list = new List<Khachhang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from khachhang order by MaKH desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Khachhang()
                        {
                            MaKH = Convert.ToInt32(reader["MaKH"]),
                            TenKH = reader["TenKH"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            DiaChi =reader["DiaChi"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),                           
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            LoaiKH = reader["LoaiKH"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }
        ///add ham truy van tai day
        public int InsertKH(Khachhang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into khachhang values(@MaKH, @TenKH, @NgaySinh, @DiaChi, @GioiTinh, @SoDienThoai, @LoaiKH)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaKH",kh.MaKH);
                cmd.Parameters.AddWithValue("TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("NgaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("LoaiKH", kh.LoaiKH);       
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateKhachHang(Khachhang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update khachhang set TenKH = @TenKH,NgaySinh = @NgaySinh, DiaChi = @DiaChi, GioiTinh = @GioiTinh, SoDienThoai = @SoDienThoai, LoaiKH = @LoaiKH where MaKH = @MaKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("NgaySinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("LoaiKH", kh.LoaiKH);
                cmd.Parameters.AddWithValue("MaKH", kh.MaKH);

                return (cmd.ExecuteNonQuery());
            }
        }
        public Khachhang ViewKhachHang(int MAKH)
        {

            Khachhang kh = new Khachhang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from khachhang where MaKH = @MaKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaKH", MAKH);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MaKH = Convert.ToInt32(reader["MaKH"]);
                        kh.TenKH = reader["TenKH"].ToString();
                        kh.NgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        kh.DiaChi = reader["DiaChi"].ToString();
                        kh.GioiTinh = reader["GioiTinh"].ToString();                      
                        kh.SoDienThoai = reader["SoDienThoai"].ToString();
                        kh.LoaiKH = reader["LoaiKH"].ToString();
                    }
                }
            }
            return kh;
        }
        public int DeleteKhachHang(int MAKH)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from khachhang where MaKH=@MaKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaKH", MAKH);                
                return (cmd.ExecuteNonQuery());
            }
        }
        //public List<khachhang> SearchKH(string name)
        //{
        //    List<khachhang> list = new List<khachhang>();
        //    using (MySqlConnection conn = GetConnection())
        //    {
        //        conn.Open();
        //        string str = "select * from customer where name=@name";
        //        MySqlCommand cmd = new MySqlCommand(str, conn);
        //        cmd.Parameters.AddWithValue("name", name);
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                list.Add(new khachhang()
        //                {
        //                    customer_id = reader["customer_id"].ToString(),
        //                    name = reader["name"].ToString(),
        //                    date_of_birth = (DateTime)reader["date_of_birth"],
        //                    address = reader["address"].ToString(),
        //                    gender = reader["gender"].ToString(),
        //                    point = Convert.ToInt32(reader["point"]),
        //                    phone = reader["phone"].ToString(),
        //                    customer_type = reader["customer_type"].ToString(),
        //                });
        //            }
        //            reader.Close();
        //        }
        //        conn.Close();

        //    }
        //    return list;
        //}


        public List<dondathang> GetListOrder_product(int MaKH)
        {
            List<dondathang> list = new List<dondathang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from dondathang where MaKH = @MaKH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new dondathang()
                        {
                            MaKH = Convert.ToInt32(reader["MaKH"]),
                            MaDDH = Convert.ToInt32(reader["MaDDH"]),
                            MaVoucher = Convert.ToInt32(reader["MaVoucher"]),
                            TongDonHang = Convert.ToInt32(reader["TongDonHang"]),
                            ThanhTien = Convert.ToInt32(reader["MaDDH"]),
                            NgayDatHang = Convert.ToDateTime(reader["NgayDatHang"]),
                            TENNGUOINHAN = reader["TENNGUOINHAN"].ToString(),
                            SDTNGUOINHAN = reader["SDTNGUOINHAN"].ToString(),
                            DIACHINHAN = reader["DIACHINHAN"].ToString(),
                            TINHTRANGDONHANG = Convert.ToInt32(reader["TINHTRANGDONHANG"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }

        public List<object> GetListOrder()
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select MaDDH, khachhang.TenKH, TongDonHang, SoTienGiam, ThanhTien, TENNGUOINHAN, SDTNGUOINHAN, DIACHINHAN, TINHTRANGDONHANG, NgayDatHang from dondathang, khachhang WHERE dondathang.MaKH = khachhang.MaKH order by MaDDH desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new
                        {
                            //total_amount = Convert.ToInt32(reader[0]),
                            //date_invoice = (DateTime)reader["date_invoice"],
                            MaDDH = Convert.ToInt32(reader[0]),
                            TenKH = reader[1].ToString(),
                            TongDonHang = Convert.ToInt32(reader[2]),
                            SoTienGiam = Convert.ToInt32(reader[3]),
                            ThanhTien = Convert.ToInt32(reader[4]),
                            TENNGUOINHAN= reader[5].ToString(),
                            SDTNGUOINHAN = reader[6].ToString(),
                            DIACHINHAN = reader[7].ToString(),
                            TINHTRANGDONHANG = Convert.ToInt32(reader[8]),
                            NgayDatHang = Convert.ToDateTime(reader["NgayDatHang"]),
                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public dondathang ViewOrder(int MADDH)
        {

            dondathang kh = new dondathang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select TINHTRANGDONHANG, MaDDH from dondathang where MaDDH = @MaDDH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDDH", MADDH);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MaDDH = Convert.ToInt32(reader["MaDDH"]);
                        kh.TINHTRANGDONHANG = Convert.ToInt32(reader["TINHTRANGDONHANG"]);                       
                    }
                }
            }
            return kh;
        }
        public int UpdateOrder(dondathang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update dondathang set TINHTRANGDONHANG = @TINHTRANGDONHANG where MaDDH=@MaDDH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("TINHTRANGDONHANG", kh.TINHTRANGDONHANG);
                cmd.Parameters.AddWithValue("MaDDH", kh.MaDDH);               

                return (cmd.ExecuteNonQuery());
            }
        }
        public List<object> OrderDetail(int MADDH)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select MaDDH, hinhanh.LINKHINHANH, ctdh.MaSP, SoLuong, ctdh.GiaTien from ctdh, hinhanh where ctdh.MaSP = hinhanh.MaSP and MaDDH=@MaDDH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDDH", MADDH);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new
                        {                                                     
                            MaDDH = Convert.ToInt32(reader[0]),
                            LINKHINHANH = reader[1].ToString(),
                            MaSP= Convert.ToInt32(reader[2]),
                            SoLuong = Convert.ToInt32(reader[3]),
                            GiaTien = Convert.ToInt32(reader[4]),                           

                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        
        public List<danhmucsp> GetListCategory()
        {
            List<danhmucsp> list = new List<danhmucsp>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from danhmucsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new danhmucsp()
                        {
                            MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"]),
                            TenDanhMuc = reader["TenDanhMuc"].ToString(),
                            MoTa = reader["MoTa"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }
        public int CreateCategory(danhmucsp tp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into danhmucsp values(@MaDanhMuc, @TenDanhMuc, @MoTa)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDanhMuc", tp.MaDanhMuc);
                cmd.Parameters.AddWithValue("TenDanhMuc", tp.TenDanhMuc);
                cmd.Parameters.AddWithValue("MoTa", tp.MoTa);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int UpdateCategory(danhmucsp tp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update DANHMUCSP set TenDanhMuc = @TenDanhMuc, MoTa=@MoTa where MaDanhMuc = @MaDanhMuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("TenDanhMuc", tp.TenDanhMuc);
                cmd.Parameters.AddWithValue("MoTa", tp.MoTa);
                cmd.Parameters.AddWithValue("MaDanhMuc", tp.MaDanhMuc);

                return (cmd.ExecuteNonQuery());
            }
        }
        public danhmucsp ViewCategory(int MADANHMUC)
        {

            danhmucsp kh = new danhmucsp();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from DANHMUCSP where MaDanhMuc = @MaDanhMuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDanhMuc", MADANHMUC);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MaDanhMuc= Convert.ToInt32(reader["MaDanhMuc"]);
                        kh.TenDanhMuc= reader["TenDanhMuc"].ToString();
                        kh.MoTa = reader["MoTa"].ToString();
                    }
                }
            }
            return kh;
        }
        public int DeleteCategory(int MADANHMUC)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from DANHMUCSP where MaDanhMuc=@MaDanhMuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDanhMuc", MADANHMUC);
                return (cmd.ExecuteNonQuery());
            }
        }       
       

        public List<object> GetListProduct()
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select SANPHAM.MaSP, TenSP, GiaTien, SoLuong, MoTa, HINHANH.LINKHINHANH from SANPHAM, HINHANH WHERE SANPHAM.MaSP = HINHANH.MaSP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new
                        {
                            //total_amount = Convert.ToInt32(reader[0]),
                            //date_invoice = (DateTime)reader["date_invoice"],
                            MaSP = Convert.ToInt32(reader[0]),
                            TenSP = reader[1].ToString(),                          
                            GiaTien = Convert.ToInt32(reader[2]),
                            SoLuong = Convert.ToInt32(reader[3]),                           
                            MoTa = reader[4].ToString(),
                            LINKHINHANH = reader[5].ToString(),
                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int InsertSP(sanpham kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into SANPHAM values (@MaSP, @TenSP, @GiaTien, @SoLuong, @MaDanhMuc, @MoTa, @MaNCC)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaSP", kh.MaSP);
                cmd.Parameters.AddWithValue("TenSP", kh.TenSP);
                //cmd.Parameters.AddWithValue("type_id ", kh.type_id);
                cmd.Parameters.AddWithValue("GiaTien", kh.GiaTien);
                cmd.Parameters.AddWithValue("SoLuong", kh.SoLuong);
                cmd.Parameters.AddWithValue("MaDanhMuc", kh.MaDanhMuc);
                cmd.Parameters.AddWithValue("MoTa", kh.MoTa);
                cmd.Parameters.AddWithValue("MaNCC", kh.MaNCC);
                return (cmd.ExecuteNonQuery());
            }
        }
        public sanpham ViewSP(int MASP)
        {

            sanpham kh = new sanpham();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from SANPHAM where MaSP = @MaSP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaSP", MASP);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MaSP = Convert.ToInt32(reader["MaSP"]);
                        kh.TenSP = reader["TenSP"].ToString();
                        kh.GiaTien = Convert.ToInt32(reader["GiaTien"]);
                        kh.MaDanhMuc = Convert.ToInt32(reader["MaDanhMuc"]);
                        kh.MoTa = reader["MoTa"].ToString();
                        kh.MaNCC= Convert.ToInt32(reader["MaNCC"]);
                    }
                }
            }
            return kh;
        }
        public int UpdateSP(sanpham tp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update SANPHAM set TenSP= @TenSP, GiaTien=@GiaTien, SoLuong=@SoLuong, MaDanhMuc=@MaDanhMuc, MoTa=@MoTa, MaNCC=@MaNCC where MaSP = @MaSP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("TenSP", tp.TenSP);
                cmd.Parameters.AddWithValue("MaSP", tp.MaSP);
                cmd.Parameters.AddWithValue("GiaTien", tp.GiaTien);
                cmd.Parameters.AddWithValue("SoLuong", tp.SoLuong);
                cmd.Parameters.AddWithValue("MaDanhMuc", tp.MaDanhMuc);
                cmd.Parameters.AddWithValue("MoTa", tp.MoTa);
                cmd.Parameters.AddWithValue("MaNCC", tp.MaNCC);

                return (cmd.ExecuteNonQuery());
            }
        }
        public int DeleteSP(int MASP)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from SANPHAM where MaSP=@MaSP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaSP", MASP);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertHA(hinhanh kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into HINHANH values(@MAHINHANH, @LINKHINHANH, @MASP)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAHINHANH", kh.MAHINHANH);
                cmd.Parameters.AddWithValue("LINKHINHANH", kh.LINKHINHANH);
                //cmd.Parameters.AddWithValue("type_id ", kh.type_id);
                cmd.Parameters.AddWithValue("MASP", kh.MASP);               
                return (cmd.ExecuteNonQuery());
            }
        }
        public hinhanh ViewHA(int MASP)
        {

            hinhanh kh = new hinhanh();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from HINHANH where MASP = @MASP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MASP", MASP);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MAHINHANH = Convert.ToInt32(reader["MAHINHANH"]);
                        kh.LINKHINHANH = reader["LINKHINHANH"].ToString();
                        kh.MASP = Convert.ToInt32(reader["MASP"]);                        
                    }
                }
            }
            return kh;
        }
        public int UpdateHA(hinhanh tp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update HINHANH set LINKHINHANH= @LINKHINHANH, MASP=@MASP where MASP = @MASP";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAHINHANH", tp.MAHINHANH);
                cmd.Parameters.AddWithValue("LINKHINHANH", tp.LINKHINHANH);
                cmd.Parameters.AddWithValue("MASP", tp.MASP);
               

                return (cmd.ExecuteNonQuery());
            }
        }
        public int DeleteHA(int MAHINHANH)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from HINHANH where MAHINHANH=@MAHINHANH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAHINHANH", MAHINHANH);
                return (cmd.ExecuteNonQuery());
            }
        }
        public SortedList<string, int> slSanPham_DanhMuc()
        {
            using (MySqlConnection conn = GetConnection())
            {
                var listdmsp = new SortedList<string, int>();
                conn.Open();
                string key;
                int value;
                var str = @"select dm.MaDanhMuc, TenDanhMuc, COUNT(*) as slsp
                            from DANHMUCSP dm inner
                            join SANPHAM sp on dm.MaDanhMuc = sp.MaDanhMuc
                            group by dm.MaDanhMuc, TenDanhMuc order by slsp desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        key = reader["TenDanhMuc"].ToString();
                        value = Convert.ToInt32(reader["slsp"]);
                        listdmsp.Add(key, value);
                    }
                    reader.Close();
                }
                conn.Close();
                return listdmsp;

            }
        }
        public SortedList<string, int> DanhSo_Thang()
        {
            SortedList<string, int> list = new SortedList<string, int>();
            string key = "";
            int va = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select concat(month(NgayDatHang),'/',year(ngaydathang)) as Thang, sum(ThanhTien) as doanhso
                            from DONDATHANG
                            Group by month(NgayDatHang) ,year(NgayDatHang)";
                MySqlCommand cmd = new MySqlCommand(str, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        key = reader["Thang"].ToString();
                        va = Convert.ToInt32(reader["doanhso"]);
                        list.Add(key, va);

                    }
                    reader.Close();
                }
                conn.Close();

            }

            return list;
        }
        public List<dondathang> get10_Dondathang()
        {
            List<dondathang> list_Ddh = new List<dondathang>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from DONDATHANG order by ThanhTien desc limit 10";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list_Ddh.Add(new dondathang()
                        {
                            MaDDH = Convert.ToInt32(reader["MaDDH"]),
                            MaKH = Convert.ToInt32(reader["MaKh"]),
                            MaVoucher = Convert.ToInt32(reader["MaVoucher"]),
                            TongDonHang = Convert.ToInt32(reader["TongDonHang"]),
                            SoTienGiam = Convert.ToInt32(reader["SoTienGiam"]),
                            ThanhTien = Convert.ToInt32(reader["ThanhTien"]),
                            MaNV = Convert.ToInt32(reader["MaNV"]),
                            NgayDatHang = Convert.ToDateTime(reader["NgayDatHang"]),
                            MaNVC = Convert.ToInt32(reader["MaNvc"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list_Ddh;
        }
        public SortedList<string, int> TK_NhaVanChuyen()
        {
            var sList = new SortedList<string, int>();
            string key;
            int value;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select n.manvc,TenNVC, count(*) as sl
                            from NHAVANCHUYEN n inner join DONDATHANG d on n.manvc = d.manvc
                            group by n.MaNVC, tenNVC
                            order by sl desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        key = reader["TenNVC"].ToString();
                        value = Convert.ToInt32(reader["sl"]);
                        sList.Add(key, value);
                    }
                    reader.Close();
                }
                conn.Close();

            }

            return sList;
        }
        public SortedList<string, int> DanhSo_Ngay()
        {
            SortedList<string, int> list = new SortedList<string, int>();
            string key = "";
            int va = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select  NgayDatHang, sum(ThanhTien) as doanhso
                            from DONDATHANG

                            Group by NgayDatHang";
                MySqlCommand cmd = new MySqlCommand(str, conn);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        key = reader["NgayDatHang"].ToString();
                        va = Convert.ToInt32(reader["doanhso"]);
                        list.Add(key, va);
                    }
                    reader.Close();
                }
                conn.Close();

            }

            return list;
        }
        public List<voucher> GetListVoucher()
        {
            List<voucher> list = new List<voucher>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from voucher order by MaVoucher desc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new voucher()
                        {
                            MaVoucher = Convert.ToInt32(reader["MaVoucher"]),
                            TenVoucher = reader["TenVoucher"].ToString(),
                            TiLeGiamGia = Convert.ToInt32(reader["TiLeGiamGia"]),
                            NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]),
                            NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]),

                        });
                    }
                    reader.Close();
                }
                conn.Close();

            }
            return list;
        }
        ///add ham truy van tai day
        public int InsertVoucher(voucher kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into voucher values(@MaVoucher, @TenVoucher, @TiLeGiamGia, @NgayBatDau, @NgayKetThuc)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaVoucher", kh.MaVoucher);
                cmd.Parameters.AddWithValue("TenVoucher", kh.TenVoucher);
                cmd.Parameters.AddWithValue("TiLeGiamGia", kh.TiLeGiamGia);
                cmd.Parameters.AddWithValue("NgayBatDau", kh.NgayBatDau);
                cmd.Parameters.AddWithValue("NgayKetThuc", kh.NgayKetThuc);                
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateVoucher(voucher kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update voucher set TenVoucher = @TenVoucher,TiLeGiamGia = @TiLeGiamGia, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc where MaVoucher= @MaVoucher";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("TenVoucher", kh.TenVoucher);
                cmd.Parameters.AddWithValue("TiLeGiamGia", kh.TiLeGiamGia);
                cmd.Parameters.AddWithValue("NgayBatDau", kh.NgayBatDau);
                cmd.Parameters.AddWithValue("NgayKetThuc", kh.NgayKetThuc);                
                cmd.Parameters.AddWithValue("MaVoucher", kh.MaVoucher);

                return (cmd.ExecuteNonQuery());
            }
        }
        public voucher ViewVoucher(int MaVoucher)
        {

            voucher kh = new voucher();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from voucher where MaVoucher = @MaVoucher";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaVoucher", MaVoucher);
                System.Diagnostics.Debug.WriteLine(str);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kh.MaVoucher = Convert.ToInt32(reader["MaVoucher"]);
                        kh.TenVoucher = reader["TenVoucher"].ToString();
                        kh.TiLeGiamGia = Convert.ToInt32(reader["TiLeGiamGia"]);
                        kh.NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]);
                        kh.NgayKetThuc = Convert.ToDateTime(reader["NgayKetThuc"]);

                    }
                }
            }
            return kh;
        }
        public int DeleteVoucher(int MaVoucher)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from voucher where MaVoucher=@MaVoucher";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaVoucher", MaVoucher);
                return (cmd.ExecuteNonQuery());
            }
        }
        public AdminContext()
        {
        }
    }
}
