using System;

namespace UltraRacing.Core.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
    }
}