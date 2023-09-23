using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    internal class PhoneBook
    {
        private string numberPhone;
        private string organization;
        private string chief;
        private string note;

        //constructor
        public PhoneBook(string numberPhone, string organization, string chief, string note)
        {
            this.numberPhone = numberPhone;
            this.organization = organization;
            this.chief = chief;
            this.note = note;
        }

        // property
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Organization { get => organization; set => organization = value; }
        public string Chief { get => chief; set => chief = value; }
        public string Note { get => note; set => note = value; }

        public PhoneBook(DataRow row)
        {
            numberPhone = row["NumberPhone"].ToString();
            organization = row["Organzirion"].ToString();
            chief = row["Chief"].ToString();
            note = row["NumberPhone"].ToString();

        }
    }
}
