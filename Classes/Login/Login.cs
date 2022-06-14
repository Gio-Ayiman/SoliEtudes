using Soli_Etudes.Classes.Database;
namespace Soli_Etudes.Classes
{
    public static class Login
    {
        
        internal static void loginUI()
        {
            Console.WriteLine("1 - Faire une preincription");
            Console.WriteLine("2 - Me connecter");
        }

        internal static void login()
        {
            Console.Clear();
            string type = DataAccess.getTypeEmployee();


            Console.WriteLine("Saisir nom d'utilisateur");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Saisir mot de passe");
            string inputPassword = Console.ReadLine();

            checkTypeOfEmployee(type);;
        }

        internal static void checkTypeOfEmployee(string type)
        {
            if (type.Equals("caissier"))
            {
                Menus.menuCaissier();
            } else if(type.Equals("chargeScolarite"))
            {
                Menus.menuChargeScolarite();
            } else
            {
                Utils.UsernameOrPasswordInvalid();
            }
        }
    }
}
