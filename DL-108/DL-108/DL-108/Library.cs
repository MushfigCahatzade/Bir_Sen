using System;
using System.Collections.Generic;
using System.Text;

namespace DL_108.DL_108
{
    internal class Library
    {
        public int BookLimit { get; set; }

        List<string> Books = new List<string>();

        public void AddBook()
        {
            Library book = new Library();
            book.AddBook();
        }

        public void GetBookById(int ? id)
        {

            if (id == null)
            {
                throw new NullReferenceException();

            }
                      
             return null;
            


        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
           
            return NotFoundException;
        }
    }
}
