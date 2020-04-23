using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BikeRental2.Web.Models;

namespace BikeRental2.Web.ViewModels
{
    public class ReservationsViewModel
    {
        private BikeStoreModel _db = new BikeStoreModel();

        public SelectList SelectStores { get; set; }
        public SelectList SelectBikes { get; set; }
        public SelectList SelectCustomer { get; set; }

        public Reservation Reservation { get; set; }

        public ReservationsViewModel()
        {
            
            var allBikes = _db.Bikes
                .AsEnumerable()
                .Select(s => new
                {
                    BikeID = s.Id,
                    ListData = $"{s.BikeModel} -- {s.BikeGender} -- Beschikbaar bij {s.Stores.First().Name}"
                })
                .ToList();

            var allCustomers = _db.Customers
                .AsEnumerable()
                .Select(s => new {
                    CustomerId = s.Id,
                    ListData = $"{s.FirstName} {s.LastName}"
                })
                .ToList();

            
            SelectStores = new SelectList(_db.Stores, "Id", "Name");
            SelectBikes = new SelectList(allBikes, "BikeID", "ListData");
            SelectCustomer = new SelectList(allCustomers, "CustomerId", "ListData");
        }


        public double GetRate(DateTime startDate, DateTime endDate, double dailyRate)
        {
            int days = (endDate - startDate).Days;
            double totalRate = days * dailyRate;
            return totalRate;
        }

        public void getTotalPrice()
        {
            var bike = _db.Bikes.First(b => b.Id == Reservation.SelectedBike_Id);
            Reservation.TotalPrice = GetRate(Reservation.StartDate, Reservation.EndDate, bike.DailyRate);
        }
        public void Create()
        {
            _db.Reservations.Add(Reservation);
            _db.SaveChanges();
        }
    }
}