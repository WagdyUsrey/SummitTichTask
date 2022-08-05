using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SummitTichTask.Models
{
    public class Trip
    {
        public int ID { get; private set; }
        public string Destination { get; set; }
        public int ReservationCount { get; set; }
        public decimal SeatCost { get; set; }
        public DateTime GoingDate { get; set; }
        public DateTime ComingBackDate { get; set; }
        public Trip(int ID, string Destination, int ReservationCount, decimal SeatCost, DateTime GoingDate, DateTime ComingBackDate)
        {
            this.ID = ID;
            this.Destination = Destination;
            this.ReservationCount = ReservationCount;
            this.SeatCost = SeatCost;
            this.GoingDate = GoingDate;
            this.ComingBackDate = ComingBackDate;
        }
        public Trip(){}
    }
}
