
namespace HR_Manager
{
    public class Managing
    {

        public static void ShowList(Manager manager)
        {
            foreach (People aPerson in manager.GetID()) { Console.WriteLine(aPerson); }
        }

        public static People AddPerson()
        {
            People NewPerson = new People();

            Console.WriteLine("\n - Add New Employee's ID: ");
            NewPerson.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n - Add New Employee's Name: ");
            NewPerson.Name = Console.ReadLine();

            Console.WriteLine("\n - Add New Employee's E-Mail: ");
            NewPerson.Email = Console.ReadLine();

            return NewPerson;
        }

        public static void RemovePerson(Manager personManager)
        {
            Console.WriteLine("Are you sure you want to remove an Employee out of the List? \nYes or No? ");
            string delete = Console.ReadLine().ToLower();

            if (delete == "yes")
            {
                Console.WriteLine("\nTo remove an Employee please enter a valid ID: ");
                int deletePerson = Convert.ToInt32(Console.ReadLine());

                List<People> employees = personManager.FindPerson(deletePerson);

                foreach (People employee in employees)
                {
                    personManager.RemovePerson(employee);

                    Console.WriteLine($"{employee.ToString()} \nhas been deleted succesfully. ");
                }
            }
            else if (delete == "no") {}
            else { Console.WriteLine("Please Enter a Valid Input! "); }
        }

        public static void FindPerson(Manager personManager)
        {
            Console.WriteLine("To find an existing Employee please enter a valid ID: ");
            int findPerson = Convert.ToInt32(Console.ReadLine());

            List<People> employees = personManager.FindPerson(findPerson);

            foreach (People employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
