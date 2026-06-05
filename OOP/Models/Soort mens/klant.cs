using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class klant : mens
    {
        public string username {  get; set; }
        public int klant_id { get; set; }
        public List<string> Games_owned { get; set; } = new List<string>();
        public double amount_money { get; set; }

        public klant(string username, int klant_id, string password, string email) : base(password, email)
        {
            this.username = username;
            this.klant_id = klant_id;
            wachtwoord = password;
            this.email = email;
            amount_money = 0;
        }
        public klant(string username, int klant_id, string password, string email, int money) : base(password, email)
        {
            this.username = username;
            this.klant_id = klant_id;
            wachtwoord = password;
            this.email = email;
            amount_money = money;
        }

    }
}
