using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental2.Web.Models
{
    public class Reservation
    {
        private double _totalPrice;

        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [Required, Display(Name = "Klant")]
        public virtual Customer Customer { get; set; }
        public int SelectedBikeId { get; set; }
        public virtual Bike SelectedBike { get; set; }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual Store PickUpStore { get; set; }
        public virtual Store DropOffStore { get; set; }
        [Required]
        public double TotalPrice
        {
            get => _totalPrice; set
            {
                _totalPrice = GetRate(StartDate, EndDate, SelectedBike.DailyRate);
            }
        }

        [Timestamp]
        public byte[] DateAdded { get; set; }

        public double GetRate(DateTime startDate, DateTime endDate, double dailyRate)
        {
            int days = (endDate - startDate).Days;
            double totalRate = days * dailyRate;
            return totalRate;
        }
    }
}