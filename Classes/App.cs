using Soli_Etudes.Classes.Database;

namespace Soli_Etudes.Classes;

class App
{
    public static void Main(string[] args)
    {

        

        Menus.menu();
        /*bool condition = true;

        do
        {

            bool loginCondition = true;
            do
            {
                Console.WriteLine("Saisir nom d'utilisateur");
                string username = Console.ReadLine();

                if (username == "caissier")
                {
                    Console.Clear();
                    Console.WriteLine("Bonjour le caissier");
                    Menu.menuCaissier();
                }
                else if (username == "etudiant")
                {
                    Console.Clear();

                    Console.WriteLine("Bonjour l'etudiant");
                }
                else if (username == "scolarite")
                {
                    Console.Clear();

                    Console.WriteLine("Bonjour le charge de scolarite");
                }
                else
                {
                    loginCondition = false;
                    Console.WriteLine("Incorrect");

                }
            } while (!loginCondition);

            condition = false;

        } while (condition);*/
    }
}
