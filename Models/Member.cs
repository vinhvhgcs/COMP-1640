using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web1640.Models
{
    public class Member : IdentityUser
    {
        public int UserId { get; set; }
        [Required]
        public char userName { get; set; }
        [Required]
        public char password { get; set; }
        [Required]
        public char full_name { get; set; }
        public char phone { get; set; }
        public char address { get; set; }
        public char avatar { get; set; }
        //public status status { get; set; }
        //public int roleId { get; set; }

    }
}
