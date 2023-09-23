using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Logout
{
    internal class TaiKhoan
    {
        private string tenTK;
        private string matKhau;
        //Phân quyền người dùng
        private loaiTK loaiTaiKhoan;
        public enum loaiTK
        {
            giamdoc,
            quanly,
            nhanvien
        }
        //hiển thị trong textBox
        private string tenHienThi;
        //property
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public loaiTK LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenHienThi {
            get
            {
                switch (loaiTaiKhoan)
                {
                    case loaiTK.giamdoc:
                        {
                            tenHienThi = "Giám đốc";
                            break;
                        }
                    case loaiTK.quanly:
                        {
                            tenHienThi = "Quản lý";
                            break;
                        }
                    default:
                        {
                            tenHienThi = "Nhân viên";
                            break;
                        }
                }
                return tenHienThi;
            }
            set => tenHienThi = value; 
        }

        //constructor 
        public TaiKhoan(string tenTK, string matKhau, loaiTK loaiTaiKhoan)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }
       

    }
}
