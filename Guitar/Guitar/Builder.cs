using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class Builder
    {
        public string Type { get; set; }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
