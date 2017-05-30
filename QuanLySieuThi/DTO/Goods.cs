using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DTO
{
    public class Goods
    {
        private int id;
        private string name;
        private float price;
        private int amount;

        public Goods(int id,string name,float price,int amount)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
        }

        public Goods(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = (float)row["price"];
            this.Amount = (int)row["amount"];
        }

        public int Amount
        {
            get
            {
                return Amount;
            }

            set
            {
                Amount = value;
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

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
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
    }
}
