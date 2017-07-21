using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemoryCard.Models
{
    public class Card
    {
        public int CardID { get; set; }
        [Required]
        public string Subject { get; set; }
        public string SideOne { get; set; }
        public string SideTwo { get; set; }
        
    }

    public enum Subject
    {
        Spanish,
        Calculus,
        Programming
    }
}