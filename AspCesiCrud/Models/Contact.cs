﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace AspCesiCrud.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserId { get; set; }
       
    }
}
