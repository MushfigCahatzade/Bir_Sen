using System;
using System.Collections.Generic;
using System.Text;

namespace AA_19.AA_19
{
    internal class Status
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime SharedDate { get; set; }

        public void GetStatusInfo()
        {

        }

        public Status(string Title,string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }
}
