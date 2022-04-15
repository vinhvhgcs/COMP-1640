using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web1640.Models
{
    public class Staff
    {
        public int staffId { get; set; }
        public char staffName { get; set; }
        //public int departmentId { get; set; }
        public char password { get; set; }
        public int phone { get; set; }
        public char address { get; set; }
        public char avatar { get; set; }
        public char email { get; set; }
        //public int sex { get; set; }
        public DateTime birthDay { get; set; }
        //public int roleId { get; set; }
        public char rememberToken { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
}
