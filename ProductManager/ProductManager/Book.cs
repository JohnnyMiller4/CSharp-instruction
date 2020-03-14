using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager
{
    //extend from Product class
    class Book : Product
    {
        public string Author { get; set; }

        public Book(string c, string d, double p, string a) : base(c, d, p)
        {
            Author = a;
        }

    }
}
