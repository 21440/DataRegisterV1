using System;
using System.IO;

namespace V1
{
    class Program
    {

        public static string filepath;

        static void Main(string[] args)
        {
            
            filepath = args[0];

            var Exist = (File.Exists(filepath));

            if (Exist)
            {

                Console.Clear();
                Procedure();

            }

            else
            {

                Console.Clear();
                addRecord("ID", "First Name", "Last Name", "Age", filepath);
                Console.WriteLine("\nThe file of records has been created!\n");
                Procedure();

            }
        }

        public static void Procedure()
        {

            Console.WriteLine("\n   DataRegister App! V1.0.0\n========================================");
            Console.WriteLine("\nEnter the ID:");
            string id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nEnter the First Name:");
            string fname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nEnter the Last Name:");
            string lname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nEnter the Age:");
            string age = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nSave[S]; Discart[D]; Exit[E]");
            string Selection = Console.ReadLine();

            switch (Selection.ToLower())
            {

                case "s":

                    addRecord(id, fname, lname, age, filepath);
                    Console.Clear();
                    Console.WriteLine("\nRecord registered sucessfully!\n");
                    Procedure();

                    break;

                case "d":

                    Console.Clear();
                    Procedure();

                    break;

                case "e":

                    Console.Clear();
                    break;

                default:

                    Console.WriteLine("\nSomething went wrong, try again later.");

                    break;

            }

        }

        public static void addRecord(string ID, string FirstName, string LastName, string Age, string filepath)
        {

            try
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {

                    file.WriteLine(ID + "," + FirstName + "," + LastName + "," + Age);

                }

            }

            catch(Exception exc)
            {

                throw new ApplicationException("This program failed to run correctly: ", exc);

            }

        }
    }
}
