using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Logout
{
    public partial class FormChuongTrinh : Form
    {
        public bool isThoat = true;
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            phanQuyen();
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) {
                Application.Exit();
            }
        }

        public event EventHandler DangXuat;
        //button dang xuat
        private void buttonDangXuat_Click(object sender, EventArgs e)
        {

            /*  
            Cach 1:
            isThoat = false;
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();   
            */
            // Cach 2 tạo 1 event để ủy thác (sử dụng linh hoạt, ủy thác cho những nơi khác có thể dùng)
            DangXuat(this, new EventArgs());
        }

        void phanQuyen()
        {
            switch (Const.taiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.loaiTK.quanly:
                    buttonQLTK.Enabled = false;
                    break;
                case TaiKhoan.loaiTK.nhanvien:
                    buttonQLTK.Enabled = buttonSua.Enabled = buttonThemMoi.Enabled =buttonXem.Enabled = buttonXoa.Enabled = false;
                    break;
            }
            textBox.Text = Const.taiKhoan.TenHienThi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void FormChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat) 
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true; //cancel: quay lại -> cho phép

                }
            }
        }
            

    }
}
