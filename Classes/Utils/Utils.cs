
using Soli_Etudes.Classes.Database;

namespace Soli_Etudes.Classes
{
    internal static class Utils
    {
        internal static void InvalidOption()
        {
            Console.WriteLine("\nVous devez choisir une option valide\n\n");
        }

        internal static void printFilieres()
        {
            Console.Clear();
            List<Filiere> filieres = DataAccess.getFiliere();
            int i = 1;

            DataAccess.ConnectionToDatabase();

            Console.WriteLine("=========Liste des filieres===========");
            foreach (Filiere filiere in filieres)
            {
                Console.WriteLine($"{i++}" + " - " + filiere.Name);
            }
        }

        internal static void moveBack(Action method)
        {
            Console.WriteLine("\n0 - Revenir en arriere\n\n");

            int optionSelected2 = int.Parse(Console.ReadLine());
            if (optionSelected2 == 0)
            {
                method.Invoke();
            }
        }

        internal static void UsernameOrPasswordInvalid()
        {
            Console.WriteLine("\nNom d'utilisateur ou mot de passe incorrect", ConsoleColor.Red);
        }
    }
}
