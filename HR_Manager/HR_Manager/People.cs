
namespace HR_Manager
{
    public class People
    {
        private int id;
        public int ID 
        { 
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return "\n[x] ID: " + ID + " --- Name: " + Name + " --- E-Mail: " + Email;
        }
    }
}
