using TicketingApplication;

TicketingDriver ticketDriver = new TicketingDriver();

while (true)
{
    Console.WriteLine("Please enter 1 to book a ticket.");
    Console.WriteLine("Please enter 2 to see the seating chart.");
    Console.WriteLine("Please enter 3 to exit the application.");

    string input = Console.ReadLine();
    if (input == "1")
    {
        ticketDriver.BookTicket();
    }
    else if (input == "2")
    {
        ticketDriver.DisplaySeatingChart();
    }
    else if (input == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
    }
}
