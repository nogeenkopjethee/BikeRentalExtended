using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeRental2.Web.Models;

namespace BikeRental2.Web.ViewModels
{
    public class ReservationsViewModel
    {
        private BikeStoreModel _db = new BikeStoreModel();
        public SelectList SelectStores { get; set; }
        public SelectList SelectBikes { get; set; }
        public Bike SelectedBike { get; set; }
        public Store SelectedStore { get; set; }
        public ReservationsViewModel()
        {
            var allBikes = _db.Bikes
                .AsEnumerable()
                .Select(s => new
                {
                    BikeID = s.Id,
                    ListData = $"{s.BikeModel} -- {s.BikeGender} -- Beschikbaar bij {s.Stores.Count} winkels"
                })
                .ToList();


            SelectStores = new SelectList(_db.Stores, "Id", "Name");
            SelectBikes = new SelectList(allBikes, "BikeID", "ListData");
        }
    }
}