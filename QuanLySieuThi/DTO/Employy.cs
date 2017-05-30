using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
   public class Employy
    {
        private int id;
        private string name;
        private string phone;
        private string address;

        public Employy(int id, string name, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }

        public Employy(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Phone = row["phone"].ToString();
            this.Address = row["address"].ToString();
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}
