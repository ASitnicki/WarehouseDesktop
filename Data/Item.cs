using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDesktop.Data
{
    class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public DateTime expirationDate { get; set; }
        public String barcode { get; set; }
        public Item(int id, string name, double price, int quantity, DateTime expirationDate, string barcode)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.barcode = barcode;
        }
    }
}
