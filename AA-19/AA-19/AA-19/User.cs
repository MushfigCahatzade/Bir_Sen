using System;
using System.Collections.Generic;
using System.Text;

namespace AA_19.AA_19
{
    internal class User
    {
        public int ID { get; set; }
        List<string> Statuses = new List<string>();
        public string Username { get; set; }
        public void ShareStatus()
        {
            
        }
        public void GetStatusById(int id)
        {
            
        }
        public void GetAllStatuses()
        {
            ID = 12;
            Username = "Mushfig Jahatzada";

        }
        public void FilterStatusByDate()
        {

        }
        public User(string Username)
        {
            this.Username = Username;  
        }
    }
}
