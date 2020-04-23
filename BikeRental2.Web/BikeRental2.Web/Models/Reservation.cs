using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental2.Web.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public int Customer_Id { get; set; }
        [ForeignKey("Customer_Id"), Display(Name = "Klant")]
        public virtual Customer Customer { get; set; }
        public int SelectedBike_Id { get; set; }
        [ForeignKey("SelectedBike_Id")]
        public virtual Bike SelectedBike { get; set; }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public virtual Store PickUpStore { get; set; }
        public virtual Store DropOffStore { get; set; }
        [Required]
        public double TotalPrice { get; set; }

            [Timestamp]
        public byte[] DateAdded { get; set; }
    }
}