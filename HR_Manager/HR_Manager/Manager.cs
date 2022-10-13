
namespace HR_Manager
{
    public class Manager
    {
        public List<People> people = new List<People>();

        public void AddPerson(People person) { this.people.Add(person); }

        public List<People> GetID() { return this.people; }

        public bool RemovePerson(People person) { return this.people.Remove(person); }

        public List<People> FindPerson(int ID)
        {
            List<People> findPerson = new List<People>();

            foreach (People person in people)
            {
                if (person.ID == ID)
                { findPerson.Add(person); }
            }

            if (findPerson.Count == 0)
            {
                Console.WriteLine("Invalid ID! Please try again.");
            }

            return findPerson;
        }
    }
}
