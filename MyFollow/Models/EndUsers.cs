using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFollow.Models
{
    public class EndUsers
    {
       [Key]
        public string Email { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }


    }
   
}