using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyAppT110.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
