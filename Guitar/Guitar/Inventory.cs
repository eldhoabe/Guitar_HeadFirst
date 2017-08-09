using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class Inventory
    {
        IList<Guitar> _guitars = new List<Guitar>();

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            _guitars.Add(new Guitar
            {
                SerialNumber = serialNumber,
                Price = price,
                Spec = spec,
            });
        }


        public List<Guitar> Search(GuitarSpec spec)
        {
            var matchingGuitars = new List<Guitar>();

            foreach (var guitar in _guitars)
            {
                if (guitar.Spec.Equals(spec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
