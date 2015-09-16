using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFollow.Models
{
    public class ProductOwners
    {
        [Key]
        public string Email { get; set; }

        public string CompanyName { get; set; }

        public string Description { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string FoundedIn { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }


        public string WebsiteURL { get; set; }

        public string TwitterHandler { get; set; }

        public string FacebookPageURL { get; set; }





    }
  
}