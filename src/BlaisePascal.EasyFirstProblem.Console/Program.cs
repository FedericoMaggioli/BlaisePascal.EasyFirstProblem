public class Program
{
    public static void Main()
    {
        Console.WriteLine("Insert client name.");

        string clientName = Console.ReadLine();

        Console.WriteLine("Are you a student? yes/no.");

        string isClientAStudent = Console.ReadLine();

        if (isClientAStudent != "yes" && isClientAStudent != "no")
        {
            Console.WriteLine("Invalid answer. Please enter 'yes' or 'no'.");
            return;
        }

        Console.WriteLine("Insert the delivery type: delivery/retire.");

        string deliveryType = Console.ReadLine();

        if (deliveryType != "delivery" && deliveryType != "retire")
        {
            Console.WriteLine("Invalid delivery type. Please enter 'delivery' or 'retire'.");
            return;
        }

        Console.WriteLine("Insert the number of bought books.");

        int booksNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert the cost for single book.");

        int singleBookCost = int.Parse(Console.ReadLine());

        int totalCost = 0;
        int speditionCost = 0;

        if (deliveryType == "delivery")
        {
            totalCost = singleBookCost * booksNumber + 5;

        }
        else if (deliveryType == "retire")
        {
            totalCost = singleBookCost * booksNumber;
        }

        if (booksNumber <= 0)
        {
            Console.WriteLine("The number of books cannot be less or equal to 0.");
            return;

        }
        else if (singleBookCost < 0)
        {
            Console.WriteLine("The cost of books cannot be negative.");
            return;
        }

        if (totalCost < 30)
        {
            Console.WriteLine($"Thank you for your low import purchase of {booksNumber} books, {clientName}.");
        }
        else
        {
            Console.WriteLine($"Thank you for your purchase of {booksNumber} books, {clientName}.");
        }


        Console.WriteLine($"The selected delivery type is: {deliveryType}, and the total cost is: {totalCost}, of which {speditionCost} is for shipping");

    }
}


