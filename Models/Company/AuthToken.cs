﻿using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class AuthToken
    {
        [Key]
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Token { get; set; }
    }
}
