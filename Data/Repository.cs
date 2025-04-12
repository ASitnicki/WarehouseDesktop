using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDesktop.Data
{
    class Repository
    {
        private static Repository INSTANCE;
        private Repository() { }
        public static Repository getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Repository();
            }
            return INSTANCE;
        }
        public List<Item> GetItems()
        {
            return new List<Item>()
            {
                new Item(1,"keyboard1",99.99,100,new DateTime(2025,4,12), "12345"),
                new Item(2,"keyboard2",99.99,100,new DateTime(2025,4,12), "12345"),
                new Item(3,"keyboard3",99.99,100,new DateTime(2025,4,12), "12345"),
                new Item(4,"mouse",99.99,100,new DateTime(2025,4,12), "12345"),
                new Item(5,"headphones",99.99,100,new DateTime(2025,4,12), "12345"),

            };
        }
    }
}
