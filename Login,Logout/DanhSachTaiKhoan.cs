using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Logout
{
    internal class DanhSachTaiKhoan
    {
        //thao tác với Danh sách tài khoản sẽ thông qua  instace
        private static DanhSachTaiKhoan instance;
        internal static DanhSachTaiKhoan Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new DanhSachTaiKhoan();
                }
                return instance;
            }
            set => instance = value; 
        }
        
        List<TaiKhoan> listTaiKhoan;
        internal List<TaiKhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        DanhSachTaiKhoan()
        {
            ListTaiKhoan = new List<TaiKhoan>();
            ListTaiKhoan.Add(new TaiKhoan("huyhoang", "123",TaiKhoan.loaiTK.giamdoc));
            ListTaiKhoan.Add(new TaiKhoan("ngovanhuyhoang", "123456",TaiKhoan.loaiTK.quanly));
            ListTaiKhoan.Add(new TaiKhoan("hoangdev", "hoangdev",TaiKhoan.loaiTK.nhanvien));
        }

    }
}
