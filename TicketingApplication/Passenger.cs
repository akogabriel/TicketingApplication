using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingApplication.Enum;

namespace TicketingApplication
{
    public class Passenger
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public SeatLabel SeatPreference { get; set; }
        public Seat Seat { get; set; }

        public Passenger(string firstName, string lastName, SeatLabel seatPreference)
        {
            Firstname = firstName;
            Lastname = lastName;
            SeatPreference = seatPreference;
            Seat = null;
        }

    }
}
