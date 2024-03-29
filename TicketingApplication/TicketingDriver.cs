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
        private List<Row> seatingChart;
        private int totalSeats;

        public TicketingDriver()
        {
            seatingChart = new List<Row>();
            totalSeats = 0;
            InitializeSeatingChart();
        }

        private void InitializeSeatingChart()
        {
            for (int i = 0; i < 12; i++)
            {
                seatingChart.Add(new Row());
                totalSeats += 4;
            }
        }
        public void BookTicket(string firstName, string lastName, string seatPreference)
        {
            SeatLabel preferredSeat = SeatLabel.A; // Default seat preference in case the user hits ENTER
            if (seatPreference == "1")
            {
                preferredSeat = SeatLabel.A | SeatLabel.D;
            }
            else if (seatPreference == "2")
            {
                preferredSeat = SeatLabel.B | SeatLabel.C;
            }

            //Create the passenger object
            Passenger passenger = new Passenger(firstName, lastName, preferredSeat);

            bool seatFound = false;

            int rowNumber = 0;  //default row number

            //Search for preferred seat
            foreach (Row row in seatingChart)
            {
                rowNumber++;
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

            if (!seatFound)    //Try to book first seat available since preffered seats are fully booked
            {
                foreach (Row row in seatingChart)
                {
                    rowNumber = 1;
                    foreach (Seat seat in row.Seats)
                    {
                        if (!seat.IsBooked)
                        {
                            if (seat.Label != preferredSeat)
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
            }

            if (seatFound)
            {
                Console.WriteLine($"The seat located in {rowNumber} {passenger.Seat.Label} has been booked.");
            }
            else
            {
                Console.WriteLine("Sorry, the plane is fully booked.");
            }
        }

        public void DisplaySeatingChart()
        {
            foreach (Row row in seatingChart)
            {
                foreach (Seat seat in row.Seats)
                {
                    if (seat.IsBooked)
                    {
                        Console.Write($"{seat.Passenger.Firstname.Substring(0, 1)}{seat.Passenger.Lastname.Substring(0, 1)} ");
                    }
                    else
                    {
                        Console.Write($"{seat.Label} ");
                    }
                }
                Console.WriteLine();
            }
        }

    }

   
}
