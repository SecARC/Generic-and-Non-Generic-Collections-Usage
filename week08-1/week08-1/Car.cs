using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_1
{
    public class Car
    {
        public int id { get; set; }
        public string brand { get; set; }
        public int modelYear { get; set; }

        public override string ToString()
        {
            return $"Car: {id} -> {modelYear} {brand}";
        }
    }
}
