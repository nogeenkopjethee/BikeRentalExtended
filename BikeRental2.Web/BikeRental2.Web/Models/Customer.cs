using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental2.Web.Models
{
    public class Customer
    {
        [Index(IsUnique = true)]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public int Height { get; set; }
        [Required]
        public string Email { get; set; }
    }

    public enum Gender
    {
        Man,
        Vrouw,
        Overig
    }
}