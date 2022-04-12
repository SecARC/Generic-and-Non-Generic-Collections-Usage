using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_1
{
    public class FiveCell
    {
        private int[] items = new int[5];
        int count = 0;

        public void Add(int item)
        {
            if(count == 5)
                throw new Exception("Cells are full.");
            items[count] = item;
            count++;
        }

        public int this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }        
    }

    public class FiveCell<T>
    {
        private T[] items = new T[5];
        int count = 0;

        public void Add(T item)
        {
            if (count == 5)
                throw new Exception("Cells are full.");
            items[count] = item;
            count++;
        }

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }
}
