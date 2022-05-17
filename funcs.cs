// menu
namespace Code{
    public class Funcs{
        static public String Menu (){ // Menu
         Console.Write("Would you like to access a movie or add one? [Add] [Access] [Exit]: ");
         string menuKey = Console.ReadLine();
         return menuKey;
        }

        public static String saveToFile(string location){ // Save value to file
            string movieDescInput = Console.ReadLine();
            Console.Write("\n");
            using (StreamWriter sw = File.AppendText(location)){
            sw.WriteLine(movieDescInput);
            return null;
        }
        }

        static public String FileName(){ // Set file name
            Console.Write("File Name: ");
            string returnVal = Console.ReadLine();
            returnVal += ".txt"; 
            Console.Clear();
            return returnVal;
        }
    }
}
