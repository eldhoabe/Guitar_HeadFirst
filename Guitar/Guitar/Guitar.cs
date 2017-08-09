using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class Guitar
    {
        public string SerialNumber { get; set; }

        public double Price { get; set; }

        public GuitarSpec Spec { get; set; }


        public override bool Equals(object obj)
        {
            var guitar = obj as Guitar;

            if (guitar.SerialNumber.Equals(SerialNumber) && guitar.Spec.Equals(Spec))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return SerialNumber.GetHashCode();
        }
    }
}
