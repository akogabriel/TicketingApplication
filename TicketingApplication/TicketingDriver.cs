using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingApplication.Enum;


namespace TicketingApplication
{
    public class TicketingDriver
    {

        public void BookTicket()
        {
            Console.WriteLine("Please enter the passenger's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter the passenger's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter 1 for a Window seat preference, 2 for an Aisle seat preference, or hit enter to pick the first available seat:");
            string seatPreference = Console.ReadLine();

            SeatLabel preferredSeat = SeatLabel.A; // Default seat preference in case user hits ENTER
            if (seatPreference == "1")
            {
                preferredSeat = SeatLabel.A;
            }
            else if (seatPreference == "2")
            {
                preferredSeat = SeatLabel.B;
            }

            Passenger passenger = new Passenger(firstName, lastName, preferredSeat);

            SeatingChart airlineSeatCharts = new SeatingChart();

            airlineSeatCharts.InitializeSeatingChart();

            bool seatFound = false;
            foreach (Row row in airlineSeatCharts.AirlineSeats)
            {
                foreach (Seat seat in row.Seats)
                {
                    if (!seat.IsBooked)
                    {
                        if (seat.Label == preferredSeat)
                        {
                            seatFound = true;
                            seat.Passenger = passenger;
                            seat.IsBooked = true;
                            passenger.Seat = seat;
                            break;
                        }
                    }
                }
                if (seatFound) break;
            }

            if (seatFound)
            {
                Console.WriteLine($"The seat located in 1 {passenger.Seat.Label} has been booked.");
            }
            else
            {
                Console.WriteLine("Sorry, the plane is fully booked.");
            }
        }

        public void DisplaySeatingChart()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach (var seat in SeatingChart[i].Seats)
                {
                    if (seat.IsBooked)
                    {
                        Console.Write($"{seat.Passenger} ({seat.Label}) ");
                    }
                    else
                    {
                        Console.Write("Available ");
                    }
                }
                Console.WriteLine();
            }
        }

    }

   
}
