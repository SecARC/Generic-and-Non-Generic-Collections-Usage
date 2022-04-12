using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_1
{
    public class Book
    {
        public string ISBN { get; set; }
        public string title { get; set; }
        public string author { get; set; }

        public override string ToString()
        {
            return $"Book: {ISBN} -> {title} {author}";
        }
    }
}
