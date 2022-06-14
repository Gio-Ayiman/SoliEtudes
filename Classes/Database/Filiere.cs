namespace Soli_Etudes.Classes.Database
{
    public class Filiere
    {
        private string name;

        public Filiere(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}