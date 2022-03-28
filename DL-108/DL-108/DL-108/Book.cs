using System;
using System.Collections.Generic;
using System.Text;

namespace DL_108.DL_108
{
    internal class Book : Product
    {
        public override void Sell()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public string AuthorName { get; set; } 
        public int PageCount { get; set; }

        

        public Book(string name,double price,string authorName,int pageCount)
        {
            this.Name = name;
            this.Price = price;
            this.AuthorName = authorName;
            this.PageCount = pageCount;
        }
    }
}
