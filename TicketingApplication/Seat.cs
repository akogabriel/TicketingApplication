using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingApplication.Enum;

namespace TicketingApplication
{
    public class Seat
    {
        public Passenger Passenger { get; set; }
        public bool IsBooked { get; set; }
        public SeatLabel Label { get; set; }
        public Row Row { get; set; }
        public SeatPosition WindowAisle { get; set; }


        public Seat(SeatLabel label, SeatPosition windowAisle)
        {
            Label = label;
            IsBooked = false;
            Passenger = null;
            WindowAisle = windowAisle;
        }
    }
}
