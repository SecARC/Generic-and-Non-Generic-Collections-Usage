using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace week08_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            string s = "Today, weather is very good";
            int x = 5, y = 8;
            DateTime t = DateTime.Now;

            Car car = new Car() { id = 1, brand = "Audi", modelYear = 2021 };
            Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };

            list.Add(s);
            list.Add(x);
            list.Add(t);
            list.Add(car);
            list.Add(book);

            list[1] = y;

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            list.RemoveAt(0);
            labelResult.Text += "\n" + list[3];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortedList list = new SortedList();

            string s = "Today, weather is very good";
            int x = 5, y = 8;
            DateTime t = DateTime.Now;

            Car car = new Car() { id = 1, brand = "Audi", modelYear = 2021 };
            Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };

            list.Add("message", s);
            list.Add("number", x);
            list.Add("date", t);
            list.Add("car", car);
            list.Add("book", book);

            list["number"] = y;

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (DictionaryEntry item in list)
            {
                labelResult.Text += "\n" + item.Key + " : " + item.Value;
            }
            labelResult.Text += "\n----------------------------------";
            list.RemoveAt(0);
            labelResult.Text += "\n" + list["car"];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hashtable list = new Hashtable();

            string s = "Today, weather is very good";
            int x = 5, y = 8;
            DateTime t = DateTime.Now;

            Car car = new Car() { id = 1, brand = "Audi", modelYear = 2021 };
            Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };

            list.Add("message", s);
            list.Add("number", x);
            list.Add("date", t);
            list.Add("car", car);
            list.Add("book", book);

            list["number"] = y;

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (DictionaryEntry item in list)
            {
                labelResult.Text += "\n" + item.Key + " : " + item.Value;
            }
            labelResult.Text += "\n----------------------------------";
            list.Remove("book");
            labelResult.Text += "\n" + list["car"];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queue list = new Queue();

            string s = "Today, weather is very good";
            int x = 5, y = 8;
            DateTime t = DateTime.Now;

            Car car = new Car() { id = 1, brand = "Audi", modelYear = 2021 };
            Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };

            list.Enqueue(s);
            list.Enqueue(x);
            list.Enqueue(t);
            list.Enqueue(car);
            list.Enqueue(book);

            //list[1] = y; error

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            var deletedItem = list.Dequeue();
            labelResult.Text += "\n" + deletedItem;
            labelResult.Text += "\n" + list.Peek();
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stack list = new Stack();

            string s = "Today, weather is very good";
            int x = 5, y = 8;
            DateTime t = DateTime.Now;

            Car car = new Car() { id = 1, brand = "Audi", modelYear = 2021 };
            Book book = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };

            list.Push(s);
            list.Push(x);
            list.Push(t);
            list.Push(car);
            list.Push(book);

            //list[1] = y; error

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            var deletedItem = list.Pop();
            labelResult.Text += "\n" + deletedItem;
            labelResult.Text += "\n" + list.Peek();
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Car> list = new List<Car>();

            list.Add(new Car() { id = 1, brand = "Audi", modelYear = 2021 });
            list.Add(new Car() { id = 2, brand = "Bmw", modelYear = 2021 });
            list.Add(new Car() { id = 3, brand = "Mercedes", modelYear = 2021 });
            list.Add(new Car() { id = 4, brand = "Nissan", modelYear = 2021 });

            list[3] = new Car() { id = 4, brand = "Renault", modelYear = 2021 };


            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            list.RemoveAt(3);
            labelResult.Text += "\n" + list[1];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SortedList<string, Book> list = new SortedList<string, Book>();

            Book book1 = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };
            list.Add(book1.ISBN, book1);
            Book book2 = new Book() { ISBN = "2362119789750", title = "Az bilenler için C# ile Programlamaya Giriş", author = "Zahid Gürbüz" };
            list.Add(book2.ISBN, book2);
            Book book3 = new Book() { ISBN = "5023697897211", title = "İyi bilenler için C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            list.Add(book3.ISBN, book3);
            Book book4 = new Book() { ISBN = "9797586210231", title = "Her şeyi Bilenler için C# ile Programlamaya Giriş", author = "Tuğra Gündüz" };
            list.Add(book4.ISBN, book4);

            list["2362119789750"] = new Book() { ISBN = "2362119789750", title = "Biraz bilenler için C# ile Programlamaya Giriş", author = "M. Zahid Gürbüz" };

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item.Key + " : " + item.Value;
            }
            labelResult.Text += "\n----------------------------------";
            list.RemoveAt(3);
            labelResult.Text += "\n" + list["5023697897211"];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dictionary<string, Book> list = new Dictionary<string, Book>();

            Book book1 = new Book() { ISBN = "9789750236211", title = "Hiç Bilmeyenler için C# ile Programlamaya Giriş", author = "Aybar Karaçay" };
            list.Add(book1.ISBN, book1);
            Book book2 = new Book() { ISBN = "2362119789750", title = "Az bilenler için C# ile Programlamaya Giriş", author = "Zahid Gürbüz" };
            list.Add(book2.ISBN, book2);
            Book book3 = new Book() { ISBN = "5023697897211", title = "İyi bilenler için C# ile Programlamaya Giriş", author = "Mustafa Gürbüz" };
            list.Add(book3.ISBN, book3);
            Book book4 = new Book() { ISBN = "9797586210231", title = "Her şeyi Bilenler için C# ile Programlamaya Giriş", author = "Tuğra Gündüz" };
            list.Add(book4.ISBN, book4);
            Book book5 = new Book() { ISBN = "9797586210231", title = "Bilenler için C# ile Programlamaya Giriş", author = "Tuğra Gündüz" };
            if (list.ContainsKey(book5.ISBN))
                list[book5.ISBN] = book5;
            else
                list.Add(book5.ISBN, book5);


            list["2362119789750"] = new Book() { ISBN = "2362119789750", title = "Biraz bilenler için C# ile Programlamaya Giriş", author = "M. Zahid Gürbüz" };

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item.Key + " : " + item.Value;
            }
            labelResult.Text += "\n----------------------------------";
            list.Remove("9797586210231");
            labelResult.Text += "\n" + list["5023697897211"];
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Queue<Car> list = new Queue<Car>();

            list.Enqueue(new Car() { id = 1, brand = "Audi", modelYear = 2021 });
            list.Enqueue(new Car() { id = 2, brand = "Bmw", modelYear = 2021 });
            list.Enqueue(new Car() { id = 3, brand = "Mercedes", modelYear = 2021 });
            list.Enqueue(new Car() { id = 4, brand = "Nissan", modelYear = 2021 });

            //list[3] = new Car() { id = 4, brand = "Renault", modelYear = 2021 };

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            var deletedItem = list.Dequeue();
            labelResult.Text += "\n" + deletedItem;
            labelResult.Text += "\n" + list.Peek();
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stack<Car> list = new Stack<Car>();

            list.Push(new Car() { id = 1, brand = "Audi", modelYear = 2021 });
            list.Push(new Car() { id = 2, brand = "Bmw", modelYear = 2021 });
            list.Push(new Car() { id = 3, brand = "Mercedes", modelYear = 2021 });
            list.Push(new Car() { id = 4, brand = "Nissan", modelYear = 2021 });

            //list[3] = new Car() { id = 4, brand = "Renault", modelYear = 2021 };

            labelResult.Text = "Count of items in list: " + list.Count;
            labelResult.Text += "\n----------------------------------";
            foreach (var item in list)
            {
                labelResult.Text += "\n" + item;
            }
            labelResult.Text += "\n----------------------------------";
            var deletedItem = list.Pop();
            labelResult.Text += "\n" + deletedItem;
            labelResult.Text += "\n" + list.Peek();
            labelResult.Text += "\nCount of items in list: " + list.Count;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FiveCell list = new FiveCell();
            list.Add(5);
            list.Add(8);
            list.Add(13);
            list.Add(21);
            list.Add(34);
            //list.Add(55);

            list[3] = 6;

            FiveCell<string> slist = new FiveCell<string>();

            slist.Add("cat");
            slist.Add("dog");
            slist.Add("bear");
            slist.Add("panter");

            FiveCell<double> dlist = new FiveCell<double>();

            dlist.Add(6.12);
            dlist.Add(7.70);
            dlist.Add(23.40);
            dlist.Add(1.06);

        }
    }
}
