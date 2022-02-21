using System;
using System.ComponentModel.DataAnnotations;
namespace AjimaExploreTravel.Models
{
    public class Travel
    {
        public int ID { get; set; }
        public string TravelTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookDate { get; set; }
        public string TouristAddress { get; set; }
        public decimal HotelPrice { get; set; }
        public string HotelAddress { get; set; }
    }
}
