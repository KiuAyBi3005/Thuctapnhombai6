using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    public class Bill
    {
        private int id;
        private DateTime billingDate;

       public Bill(int id,DateTime billingDate)
        {
            this.Id = id;
            this.BillingDate = billingDate;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillingDate = (DateTime)row["billingDate"];
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

        public DateTime BillingDate
        {
            get
            {
                return billingDate;
            }

            set
            {
                billingDate = value;
            }
        }
    }
}
