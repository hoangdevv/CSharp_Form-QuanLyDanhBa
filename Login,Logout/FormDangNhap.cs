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
    public partial class FormDangNhap : Form
    {

        //private string tentaikhoan ="admin";
        //private string matkhau ="admin";
        //  ===>  có thể làm 1 List tai khoan
        List<TaiKhoan> taiKhoanList = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button dang nhap
        private void button1_Click(object sender, EventArgs e)
        {
            if (KT_TaiKhoan(textBoxTK.Text,textBoxMK.Text))
            {
                FormChuongTrinh formChuongTrinh = new FormChuongTrinh();
                formChuongTrinh.Show();
                this.Hide();
                formChuongTrinh.DangXuat += FormChuongTrinh_DangXuat;
            }
            else 
            {
                for(int i = 0; i < taiKhoanList.Count; i++)
                {
                    if (textBoxTK.Text == taiKhoanList[i].TenTK )
                    {
                        if (textBoxMK.Text != taiKhoanList[i].MatKhau)
                        {
                            MessageBox.Show("Mật khẩu không hợp lệ");
                            textBoxMK.Focus();
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ");
                        textBoxTK.Focus();
                        break;
                    }
                }
            }
            
        }

        //thực hiện sử dụng ủy thác lên form bên kia bằng nút DX
        private void FormChuongTrinh_DangXuat(object sender, EventArgs e)
        {
            (sender as FormChuongTrinh).isThoat = false;
            (sender as FormChuongTrinh).Close();
            this.Show(); //form DangNhap này hiện lên

            //clear tài khoản , làm mới lại
            foreach (var item in panelDangNhap.Controls)
            {
                TextBox itemText = item as TextBox;
                if (itemText != null)
                {
                    itemText.Clear();
                }
            }

        }
        public bool KT_TaiKhoan(string tentaikhoan,string matkhau) 
        { 
            //if(tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            //{
            //    return true;
            //}
            //return false;
            for(int i = 0;i < taiKhoanList.Count;i++)
            {
                if(tentaikhoan == taiKhoanList[i].TenTK && matkhau == taiKhoanList[i].MatKhau)
                {
                    Const.taiKhoan = taiKhoanList[i];
                    return true;
                }
            }
            return false;
        }
    }
}
