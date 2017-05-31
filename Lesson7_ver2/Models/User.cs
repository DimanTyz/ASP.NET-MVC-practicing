using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson7_ver2.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Lenght must be at least 5")]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        [Compare("Password", ErrorMessage = "It must match ur password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(16,50)]
        public int Age { get; set; }

        [ScaffoldColumn(true)]
        [MyAttributeForBool(ErrorMessage = "U must accept the terms")]
        public bool Accepted { get; set; }
    }
}