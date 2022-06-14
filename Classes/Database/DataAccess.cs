using MySql.Data.MySqlClient;

namespace Soli_Etudes.Classes.Database
{
    public sealed class DataAccess
    {
        public static MySqlConnection ConnectionToDatabase()
        {
            string databaseAdress = "server=localhost;uid=root;password=root;database=soli-etude";

            MySqlConnection connection = new MySqlConnection(databaseAdress);

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return connection;
        }

        public static void Request(string request)
        {
            MySqlConnection connexion = ConnectionToDatabase();
            MySqlCommand mySqlCommand = new(request, connexion);

            try
            {
                mySqlCommand.Prepare();
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static List<Filiere> getFiliere()
        {
            string request = "select name from filiere;";
            MySqlConnection connexion = ConnectionToDatabase();
            MySqlCommand command = new(request, connexion);
            MySqlDataReader commandReader = command.ExecuteReader();
            List<Filiere> lists = new();
            try
            {
                while (commandReader.Read())
                {
                    lists.Add(new Filiere(commandReader.GetString(0).ToString()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return lists;
        }

        public static string getTypeCaissier()
        {
            string request = "select username, password, fonction from employee;";
            MySqlConnection connexion = ConnectionToDatabase();
            MySqlCommand command = new(request, connexion);
            MySqlDataReader commandReader = command.ExecuteReader();
            string type = "";
            List<Employee> employees = new();

            try
            {
                while (commandReader.Read())
                {
                    employees.Add(new Employee(commandReader.GetString(0).ToString(), commandReader.GetString(1).ToString(), commandReader.GetString(2).ToString()));
                }

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.Type);
                    if (employee.Type.Equals("caissier"))
                    {
                        type = "caissier";
                    }
                    else
                    {
                        type = "";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return type;
        }

        public static string getTypeChargeScolarite()
        {
            string request = "select username, password, fonction from employee;";
            MySqlConnection connexion = ConnectionToDatabase();
            MySqlCommand command = new(request, connexion);
            MySqlDataReader commandReader = command.ExecuteReader();
            string type = "";
            List<Employee> employees = new();

            try
            {
                while (commandReader.Read())
                {
                    employees.Add(new Employee(commandReader.GetString(0).ToString(), commandReader.GetString(1).ToString(), commandReader.GetString(2).ToString()));
                }

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.Type);
                    if (employee.Type.Equals("chargeScolarite"))
                    {
                        type = "caissier";
                    }
                    else
                    {
                        type = "";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return type;
        }
    }
}
