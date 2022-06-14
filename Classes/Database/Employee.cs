namespace Soli_Etudes.Classes.Database
{
    public class Employee
    {
        private string username;
        private string password;
        private string type;

        public Employee() { }
        public Employee(string username, string password, string type)
        {
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public string Username
        {
            get { return username; } set { username = value; } 
        }

        public string Password 
        { 
            get { return password; } set { password = value; } 
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}