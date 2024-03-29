using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingApplication
{
    public class SeatingChart
    {
        public List<Row> AirlineSeats { get; set; } = new List<Row>();
        public int TotalSeats { get; set; } = 0;

        public void InitializeSeatingChart()
        {
            for (int i = 0; i < 12; i++)
            {
                AirlineSeats.Add(new Row());
                TotalSeats += 4;
            }
        }
    }
}
