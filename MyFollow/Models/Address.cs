using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Address
    {
            [Key]
            public string Street1 { get; set; }

            public string Street2 { get; set; }
            public string City { get; set; }

            public string State { get; set; }
            public string Country { get; set; }

            public char Pin { get; set; }
        }
    }
