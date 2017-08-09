using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class GuitarSpec
    {
        public string Model { get; set; }

        public Builder Builder { get; set; }

        public override bool Equals(object obj)
        {
            var spec = obj as GuitarSpec;

            if (spec.Model.Equals(Model) && spec.Builder.Equals(Builder))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Model.GetHashCode() + Builder.GetHashCode();
        }
    }


}
