using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SummitTichTask.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TripID { get; set; }
        public string reservedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public Reservation(){}
        public Reservation(int ID, string Name, int TripID, string reservedBy, DateTime AddedDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.TripID = TripID;
            this.reservedBy = reservedBy;
            this.AddedDate = AddedDate;
        }
    }
}
