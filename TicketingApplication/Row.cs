using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingApplication.Enum;

namespace TicketingApplication
{
    public class Row
    {
        public List<Seat> Seats { get; set; }

        public Row()
        {
            Seats = new List<Seat>();
            Seats.Add(new Seat(SeatLabel.A, SeatPosition.W));
            Seats.Add(new Seat(SeatLabel.B, SeatPosition.A));
            Seats.Add(new Seat(SeatLabel.C, SeatPosition.A));
            Seats.Add(new Seat(SeatLabel.D, SeatPosition.W));

        }
    }
}
