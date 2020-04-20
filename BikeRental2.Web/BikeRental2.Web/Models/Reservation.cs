using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental2.Web.Models
{
    public class Reservation
    {
        private Bike _selectedBike;
        private DateTime _startDate;
        private DateTime _endDate;

        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [Required, Display(Name = "Klant")]
        public virtual Customer Customer { get; set; }
        public int SelectedBikeId { get; set; }
        [Required]
        public virtual Bike SelectedBike
        {
            get => _selectedBike;
            set
            {
                _selectedBike = value;
                TotalPrice = GetRate(StartDate, EndDate, value.DailyRate);
            }
        }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                TotalPrice = GetRate(value, EndDate, SelectedBike.DailyRate);
            }
        }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                TotalPrice = GetRate(StartDate, value, SelectedBike.DailyRate);
            }
        }
        public virtual Store PickUpStore { get; set; }
        public virtual Store DropOffStore { get; set; }
        [Required]
        public double TotalPrice { get; set; }

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