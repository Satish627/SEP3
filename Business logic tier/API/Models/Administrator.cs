﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}