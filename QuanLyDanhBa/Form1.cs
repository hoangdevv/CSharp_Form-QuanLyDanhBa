using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDanhBa
{
    public partial class Form1 : Form
    {
        //tạo biến toàn cục
        string status = "";
        int index = -1;
        int indexSearch = -1;

        DataTable dataTableWrite = new DataTable();
        DataTable dataTableRead = new DataTable();

        DataSet dataSetWrite = new DataSet();
        DataSet dataSetRead = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readXML();
            loadListPhoneBook();
            enabledControls(false,true);
            buttonHuy.Enabled = buttonLuu.Enabled = false;
        }

        #region Method

        DataTable createColumnDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn colNumberPhone = new DataColumn("NumberPhone");
            DataColumn colOrganization = new DataColumn("Organization");
            DataColumn colChief = new DataColumn("Chief");
            DataColumn colNote = new DataColumn("Note");

            dataTable.Columns.AddRange(new DataColumn[]
            {
                colNumberPhone,colOrganization, colChief, colNote
            });

            return dataTable;
        }
        void writeXML()
        {
            dataTableWrite = createColumnDataTable();

            foreach(var item in ListPhoneBook.Instance.ListPhoneBooks)
            {
                dataTableWrite.Rows.Add(item.NumberPhone,item.Organization,item.Chief,item.Note);
            }
            dataSetWrite.Tables.Add(dataTableWrite);
            dataSetWrite.WriteXml("data.xml"); //tao file xml
        }
        void readXML()
        {
            dataSetRead.ReadXml("data.xml"); //doc file
            dataTableRead = dataSetRead.Tables[0]; // trong set chỉ có 1 table, nên là thứ 0

            foreach(DataRow item in dataTableRead.Rows)
            {
                PhoneBook newPhoneBook = new PhoneBook(item); // cứ 1 item = 1 newphonebook
                ListPhoneBook.Instance.ListPhoneBooks.Add(newPhoneBook); //sau khi có newPhoneBook sẽ add vào trong danh sách
            }
        }

        void createCoulumnForDataGridView()
        {
            var colOrganization = new DataGridViewTextBoxColumn(); //Tên cơ quan
            var colNumberPhone = new DataGridViewTextBoxColumn(); //SDT
            var colChief = new DataGridViewTextBoxColumn(); //Người đại diện
            var colNote = new DataGridViewTextBoxColumn(); // ghi chú

            colOrganization.HeaderText = "Tên cơ quan";
            colNumberPhone.HeaderText = "Số điện thoại";
            colChief.HeaderText = "Người đại diện";
            colNote.HeaderText = "Ghi chú";

            colOrganization.DataPropertyName = "Organization";
            colNumberPhone.DataPropertyName = "NumberPhone";
            colChief.DataPropertyName = "Chief";
            colNote.DataPropertyName = "Note";

            colOrganization.Width = 200;
            colNumberPhone.Width = 120;
            colChief.Width = 200;
            colNote.Width = 150;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                colNumberPhone,
                colOrganization,
                colChief,
                colNote
            });
        }

        void loadListPhoneBook()
        {
            dataGridView1.DataSource = null;  //cho bằng rỗng
            createCoulumnForDataGridView();   //tạo lại cột
            dataGridView1.DataSource = ListPhoneBook.Instance.ListPhoneBooks;// sau đó đỗ dữ liệu lên
            dataGridView1.Refresh();
        }

        void enabledControls(bool enabledTextBox, bool enabledGridView)
        {
             txtSDT.Enabled = txtTenCoQuan.Enabled = txtNguoiDaiDien.Enabled = txtGhiChu.Enabled = enabledTextBox;
             dataGridView1.Enabled = enabledGridView;
        }

        void clearTextBox()
        {
            foreach(var item in this.Controls)
            {
                TextBox itemTxtBox = item as TextBox;
                if(itemTxtBox != null )
                {
                    itemTxtBox.Clear();
                }
            }
        }

        int checkForPhoneNumber(string phonenumber)
        {
            foreach(var item in ListPhoneBook.Instance.ListPhoneBooks)
            {
                if(item.NumberPhone == phonenumber)
                {
                    DialogResult result = MessageBox.Show("Số điện thoại đã có người dùng! Bạn có chắc đây là số điện thoại của bạn","Thông báo",MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes) 
                    {
                        ListPhoneBook.Instance.ListPhoneBooks.Remove(item); //xóa sdt của người đã tồn tại trước đó
                        return 1; // kiểm tra sdt có trùng ko, nếu trùng thì trả về 1
                    }
                }
                return 0; // ko trùng thì trả về  0
            }
            return -1; 
        }

        bool checkInput()
        {
            if (txtSDT.Text == "" || txtTenCoQuan.Text == "" || txtNguoiDaiDien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            long result;
            if(!long.TryParse(txtSDT.Text, out result))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại!", "Cảnh báo", MessageBoxButtons.OK);
                return false;
            }
            if(result < 0)
            {
                MessageBox.Show("Hãy xóa dấu '-'","Cảnh báo",MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        #endregion method

        #region event
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //add
        private void buttonThem_Click(object sender, EventArgs e)
        {
            status = "add";
            enabledControls(true, false);
            buttonHuy.Enabled = buttonLuu.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
        }
        //fig
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(index < 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            status = "fix";
            enabledControls(true, false);

            buttonHuy.Enabled = buttonLuu.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;

            txtSDT.Text = ListPhoneBook.Instance.ListPhoneBooks[index].NumberPhone;
            txtTenCoQuan.Text = ListPhoneBook.Instance.ListPhoneBooks[index].Organization;
            txtNguoiDaiDien.Text = ListPhoneBook.Instance.ListPhoneBooks[index].Chief;
            txtGhiChu.Text = ListPhoneBook.Instance.ListPhoneBooks[index].Note;
        }

        //save
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            if (checkForPhoneNumber(txtSDT.Text) == 1 || checkForPhoneNumber(txtSDT.Text) == 0)
            {
                string organization = txtTenCoQuan.Text;
                string numberPhone = txtSDT.Text;
                string chief = txtNguoiDaiDien.Text;
                string note = txtGhiChu.Text;
                if(status == "add")
                {
                ListPhoneBook.Instance.ListPhoneBooks.Add(new PhoneBook(numberPhone, organization, chief, note));
                }
            }
            if (status == "fix")
            {
                ListPhoneBook.Instance.ListPhoneBooks[index].NumberPhone = txtSDT.Text;
                ListPhoneBook.Instance.ListPhoneBooks[index].Organization = txtTenCoQuan.Text;
                ListPhoneBook.Instance.ListPhoneBooks[index].Chief = txtNguoiDaiDien.Text;
                ListPhoneBook.Instance.ListPhoneBooks[index].Note = txtGhiChu.Text;
            }
            enabledControls(false, true); // textBox đóng, grid mở 
            loadListPhoneBook();
            clearTextBox(); // xóa dữ liệu trên text box
            buttonHuy.Enabled = buttonLuu.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
        }

        // click vào hàng muốn truy vấn
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(status == "search")
            {
                indexSearch = e.RowIndex;
                for(int i = 0; i < ListPhoneBook.Instance.ListPhoneBooks.Count; i++)
                {
                    if (ListPhoneBook.Instance.ListPhoneBooks[i].Organization == dataGridView1.Rows[indexSearch].Cells[1].Value.ToString())
                    {
                        index = i;
                    }
                }
            }
            else
            {
            index = e.RowIndex; //lưu biến idex là mảng idex
            }
        }

        // remove
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có chắn chắn muốn xóa","Thông bóa",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListPhoneBook.Instance.ListPhoneBooks.RemoveAt(index);
                loadListPhoneBook();
            }
        }

        //cancel
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            clearTextBox();
            enabledControls(false, true);
            buttonHuy.Enabled = buttonLuu.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
        }

        //search
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            txtTenCoQuan.Enabled = true;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = true;
            status = "search";
        }
        private void txtTenCoQuan_TextChanged(object sender, EventArgs e)
        {
            string seachText = txtTenCoQuan.Text;
            List<PhoneBook> listSearchs = new List<PhoneBook>(); // list phụ
            foreach (var item in ListPhoneBook.Instance.ListPhoneBooks)
            {
                if (item.Organization.ToLower().Contains(seachText.ToLower())) // sử dụng contains để kiểm tra searchText có chuỗi nào là của Organization ko?
                {
                    listSearchs.Add(item);
                }
            }
            dataGridView1.DataSource = null;
            createCoulumnForDataGridView();
            dataGridView1.DataSource = listSearchs;
        }

        // closing form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeXML();
        }
        #endregion event


    }
      
}
