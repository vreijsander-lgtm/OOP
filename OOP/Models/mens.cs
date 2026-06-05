using OOP.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class mens
    {
        public string name {  get; set; }
        public int Phone_number { get; set; }
        public string email { get; set; }
        public string wachtwoord { get; set; }

        public UserType usertype { get; set; }
        public mens (string email, string wachtwoord)
        {
            this.wachtwoord = wachtwoord;
            this.email = email;
        }

        public void Login()
        {

        }
    }
   
}
