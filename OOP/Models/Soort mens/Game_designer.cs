using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models.Soort_mens
{
    public class Game_designer 
    {
        public int Designer_id { get; set; }
        public string game_designer_name { get; set; }
        public List<string> Games_made { get; set; } = new List<string>();
    }
}
