
namespace HR_Manager
{
    internal class HR_Manager
    {
        public static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("\nWelcome to the HR-Manager! Please choose one of the following options: ");
                Console.WriteLine("1. Show the List of Employees");
                Console.WriteLine("2. Add New Employee");
                Console.WriteLine("3. Remove Existing Employee");
                Console.WriteLine("4. Find Eixising Employee");
                Console.WriteLine("5. Exit the Program");
            }

            Manager manager = new Manager();
            manager.AddPerson(new People() { ID = 1, Name = "Random User", Email = "random.user@email.com"});
            manager.AddPerson(new People() { ID = 2, Name = "Random Male", Email = "random.male@email.com"});
            manager.AddPerson(new People() { ID = 3, Name = "Random Female", Email = "random.female@email.com"});

            int option = 0;
            do
            {
                printOptions();
                try 
                {   
                    option = Convert.ToInt32(Console.ReadLine()); 
                    if (option == 1) { Managing.ShowList(manager); }
                    else if(option == 2) { manager.AddPerson(Managing.AddPerson()); Managing.ShowList(manager); }
                    else if(option == 3) { Managing.RemovePerson(manager); }
                    else if(option == 4) { Managing.FindPerson(manager); }
                    else if(option == 5) { break; }
                    else { Console.WriteLine("*** Please Enter a Valid Input! "); }
                }
                catch { Console.WriteLine("*** Please Enter a Valid Input! "); }
                
            }
            while (option != 5);
            Console.WriteLine("Thank you for using the HR-Manager. Until next time!");
        }
    }
}
