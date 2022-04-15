using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web1640.Models
{
    public class Comments
    {
        public int id { get; set; }
        public int staffId { get; set; }
        public int ideaId { get; set; }
        public char message { get; set; }
        public DateTime created { get; set; }
    }
}
