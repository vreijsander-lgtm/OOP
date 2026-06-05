using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models.Soort_mens
{
    public class medewerker : mens
    {
        public int medewerker_id { get; set; }
        public int medewerker_bank_code { get; set; }
        public medewerker(int medewerker_id, int medewerker_bank_code, string password, string email) : base(password, email)
        {
            this.medewerker_id = medewerker_id;
            this.medewerker_bank_code = medewerker_bank_code;
            wachtwoord = password;
            this.email = email;
        }
        public void ban_user(List<mens> mensLijst, List<mens> BannedList)
        {
            Console.WriteLine("Who do you wanna ban?");
            int count = 1;
            foreach (mens human in mensLijst)
            {
                int phonenumber = human.Phone_number;
                string newnumber = human.Phone_number.ToString();
                if (phonenumber == 0)
                {
                    newnumber = "no phone number";
                }
                Console.WriteLine($"{count}) Email: {human.email} Phone number: {newnumber}\n Type: {human.usertype} Password: {human.wachtwoord}");
                count += 1;

            }
            Console.WriteLine("Please type your victims email:");
            string DeadPerson = Console.ReadLine();
            mens user = mensLijst.FirstOrDefault(h => h.email == DeadPerson);
            if (user != null)
            {
                mensLijst.Remove(user);
                mensLijst.Add(user);
                Console.WriteLine($"{user.email} Has been banned");
            }
            else
            {
                Console.WriteLine($"{DeadPerson} not found");
            }
        }
    }
}
