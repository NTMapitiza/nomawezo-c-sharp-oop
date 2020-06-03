using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenanceApp
{
    public class Inventory
    {
        public int Item { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Inventory()
        {
        }

        public Inventory(int item, string description, decimal price)
        {
            this.Item = item;
            this.Description = description;
            this.Price = price;
        }

        public virtual string GetDisplayText(string sep)
        {
            return this.Item + sep + this.Description + sep + this.Price.ToString("c");
        }
        public virtual string GetDisplayText()
        {
            //return this.Item + ", " + this.Description + ", " + this.Price.ToString("c");
            return this.Item + "\t" + this.Description + "(" + this.Price.ToString("c") + ")";
        }

        public class Plant : Inventory
        {
            private string Size { get; set; }

            public Plant(int item, string description, decimal price, string size) : base(item, description, price)
            {
                this.Size = size;
            }

            public override string GetDisplayText(string sep) =>
                this.Item + "\t" + this.Size + " " + this.Description + this.Price;
        }

        public class Supply : Inventory
        {
            private string Manufacturer { get; set; }

            public Supply(int item, string description, decimal price, string manufacturer) : base(item, description, price)
            {
                this.Manufacturer = manufacturer;
            }

            public override string GetDisplayText(string sep) =>
                this.Item + "\t" + this.Manufacturer + " " + this.Description + this.Price;
        }
    }
}
