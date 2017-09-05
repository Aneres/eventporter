﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPorter.Models
{
    public class Adam
    {
        Random r = new Random();
        [Display(Name = "Username")]
        [Required]
        [RegularExpression("[a-zA-Z]+")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password must be at least 7 characters in length", MinimumLength = 7)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password must be at least 7 characters in length", MinimumLength = 7)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string PassConf { get; set; }
        [Required]
        public string Location { get; set; }

        //auto-set vairables for site logic are below
        public int UserId { get { return UserId; } set { UserId = r.Next(); } }

        public DateTime RegDate { get { return RegDate; } set { RegDate = DateTime.Now; } }

        public int EventNo { get; set; }

        public bool EventOwner { get; set; }



    }
}