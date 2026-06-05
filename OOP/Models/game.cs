using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class game
    {
        public int game_id { get; set; }
        public string game_name { get; set; }
        public int price { get; set; }
        public string game_designer_name { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
        public List<string> Reviews { get; set; } = new List<string>();
    }
}
