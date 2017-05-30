using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
   public class BillInfo
    {
        private int id;
        private int idBill;
        private int idGoods;
        private int count;

        public BillInfo(int id,int idBill,int idGoods,int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdGoods = idGoods;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.IdGoods = (int)row["idGoods"];
            this.Count = (int)row["count"];
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

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int IdBill
        {
            get
            {
                return idBill;
            }

            set
            {
                idBill = value;
            }
        }

        public int IdGoods
        {
            get
            {
                return idGoods;
            }

            set
            {
                idGoods = value;
            }
        }
    }
}
