using TicketingApplication;

TicketingDriver ticketingDriver = new TicketingDriver();

while (true)
{
    Console.WriteLine("Please enter 1 to book a ticket.");
    Console.WriteLine("Please enter 2 to see seating chart.");
    Console.WriteLine("Please enter 3 to exit the application.");

    string input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine("Please enter the passenger's first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter the passenger's last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Please enter 1 for a Window seat preference, 2 for an Aisle seat preference, or hit enter to pick first available seat:");
        string seatPreference = Console.ReadLine();

        ticketingDriver.BookTicket(firstName, lastName, seatPreference);
    }
    else if (input == "2")
    {
        ticketingDriver.DisplaySeatingChart();
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
