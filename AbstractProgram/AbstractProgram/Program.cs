using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProgram
{
    public abstract class Shopper
    {
        public string ID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public abstract string GetDisplayShopperInfo(string sep);
        
        public Shopper()
        {
        }

        public Shopper(string id, int age, string gender)
        {
            this.ID = id;
            this.Age = age;
            this.Gender = gender;
        }

        public class Mystery : Shopper
        {
            public string Area { get; set; }
            public Mystery()
            {
            }
            public Mystery(string id, int age, string gender, string area) : base(id, age, gender)
            {
                this.Area = area;
            }

            public override string GetDisplayShopperInfo(string sep) =>
                this.ID + sep + this.Age + sep + this.Gender + sep + this.Area;

        }

        public class Regular : Shopper
        {
            public string Name { get; set; }


            public Regular(string id, int age, string gender, string name) : base(id, age, gender)
            {
                this.Name = name;
            }
            public override string GetDisplayShopperInfo(string sep) =>
                this.ID + sep + this.Age + sep + this.Gender + sep + this.Name;
        }

        static void Main(string[] args)
        {
            Mystery mystery1 = new Mystery("KC02122006", 13, "Female", "Drapery");
            Mystery mystery2 = new Mystery("NT21102021", 48, "Male", "Electrical");
            Mystery mystery3 = new Mystery("KZ18072013", 29, "Female", "Tourism");
            Regular regular = new Regular("XM19111996", 23, "Male", "Marx");

            Shopper shopper;
            shopper = mystery1;
            Console.WriteLine(shopper.GetDisplayShopperInfo("\n"));
            Console.WriteLine();

            shopper = mystery2;
            Console.WriteLine(shopper.GetDisplayShopperInfo("\n"));
            Console.WriteLine();

            shopper = mystery3;
            Console.WriteLine(shopper.GetDisplayShopperInfo("\n"));

            Console.WriteLine();
            //shopper = regular;
            Console.WriteLine(regular.GetDisplayShopperInfo("\n"));

            Console.ReadKey();
        }
    }
}
