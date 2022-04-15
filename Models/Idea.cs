using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web1640.Models
{
    public class Idea
    {
        public int id { get; set; }
        public int categoriesTd { get; set; }
        public int staffId { get; set; }
        public char title { get; set; }
        public string content { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
}
