using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    internal class ListPhoneBook
    {
        private static ListPhoneBook instance;

        internal static ListPhoneBook Instance
        {
            get 
            { 
                if (instance == null)
                {
                    instance = new ListPhoneBook();
                }
                return instance;
            } 
            set => instance = value; 
        }


        List<PhoneBook> listPhoneBooks;
        internal List<PhoneBook> ListPhoneBooks { get => listPhoneBooks; set => listPhoneBooks = value; }

        ListPhoneBook()
        {
            listPhoneBooks = new List<PhoneBook>();
            //listPhoneBooks.Add(new PhoneBook("0908888801", "FPT SoftWare", "Huy Hoàng", "Giám đốc"));
            //listPhoneBooks.Add(new PhoneBook("0908888802", "VNG", "Phúc An", "Quản lý"));
            //listPhoneBooks.Add(new PhoneBook("0908888803", "Viettel", "Trọng Tín", ""));
            //listPhoneBooks.Add(new PhoneBook("0908888804", "Intel Corporation", "Hoài Bảo", "Nhân viên"));
        }
    }
}
