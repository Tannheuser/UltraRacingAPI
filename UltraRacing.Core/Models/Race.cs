using System;

namespace UltraRacing.Core.Models
{
    public class Race : BaseItem
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
    }
}