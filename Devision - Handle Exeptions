class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Welcome to The Devision! ");
            Console.WriteLine("Enter a number you want to devide: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number to be devided: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe result: {num1}/{num2} = {num1 / num2} "); 
        }
        catch(Exception error)
        {
            Console.WriteLine("Please enter a valid value for the division.");
            Console.WriteLine("Error: " + error.Message);
        }
        finally
        {
            Console.WriteLine("\nWanna do it again? Please press Enter.");
        }

        Console.ReadLine(); 
    }
}
