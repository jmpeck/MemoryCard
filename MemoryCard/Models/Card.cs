using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoryCard.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public Subject Subject { get; set; }
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