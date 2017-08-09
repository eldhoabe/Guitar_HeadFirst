using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();


            GuitarSpec search = new GuitarSpec { Builder = new Builder { Type = "GM" }, Model = "Traditional" };

            inventory.AddGuitar("123", 100, new GuitarSpec { Builder = new Builder { Type = "Ford" }, Model = "Electric" });
            inventory.AddGuitar("2", 100, new GuitarSpec { Builder = new Builder { Type = "Maruti" }, Model = "Normal" });
            inventory.AddGuitar("5", 100, search);


            var searchResult =   inventory.Search(search);

            foreach (var item in searchResult)
            {
                Console.WriteLine(item.SerialNumber);
            }
            
        }
    }
}
