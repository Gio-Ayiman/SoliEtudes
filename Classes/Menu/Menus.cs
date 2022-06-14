
namespace Soli_Etudes.Classes
{

    public static class Menus
    {
        internal static void menu()
        {
            Console.Clear();
            bool condition = true;
            do
            {
                bool otherCondition = true;
                do
                {
                    Login.loginUI();
                    int optionSelected = int.Parse(Console.ReadLine());

                    switch (optionSelected)
                    {
                        case 1:
                            menuPreinsciption();
                            break;
                        case 2:
                            Login.login();
                            break;
                        default:
                            Utils.InvalidOption();
                            condition = false;
                            break;
                    };

                    otherCondition = false;

                } while (otherCondition);

                condition = false;
            } while (condition);

        }

        internal static void menuChargeScolarite()
        {
            throw new NotImplementedException();
        }

        private static void menuPreinsciption()
        {
            Console.Clear();

            bool condition = true;

            do
            {

                Console.WriteLine("1 - Consulter la liste des filieres");
                Console.WriteLine("2 - Se preinscrire");
                Utils.moveBack(menu);

                int optionSelected = int.Parse(Console.ReadLine());

                switch (optionSelected)
                {
                    case 1:
                        Utils.printFilieres();
                        Utils.moveBack(menuPreinsciption);
                        break;
                    case 2:
                        Student.formPreinscription();
                        break;
                    default:
                        Utils.InvalidOption();
                        break;

                };

                condition = false;

            } while (condition);
        }

        internal static void menuCaissier()
        {
            bool condition = true;

            do
            {
                Console.WriteLine("1- Lister les etudiants ayant payes");
                Console.WriteLine("2- Lister les etudiants qui n'ont pas payes");
                string n = Console.ReadLine();

                switch (Int32.Parse(n))
                {
                    case 1:
                        Console.WriteLine("giovanni");
                        break;
                    case 2:
                        Console.WriteLine("giovanni");
                        break;
                    default:
                        Console.WriteLine("Entrer une valeur comprise entre 1 et 2");
                        break;
                }

                condition = false;
            } while (condition);
        }
    }
}

