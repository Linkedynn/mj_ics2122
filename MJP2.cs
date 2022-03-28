namespace proj2{
    using System.Text;
    class mjp2{
        public static void product(String path){
            string fileContents;
            int products = 1;
              using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
               {
                   fileContents = streamReader.ReadToEnd();
               }
               string[] numbers = fileContents.Split('\n');
               foreach (var number in numbers)
               {
                   products = products * Convert.ToInt32(number);
               }


            Console.Write(products); 
            Console.ReadKey();

            /*using proj2;

           products.product("numbers2.txt");

            // to run "dotnet run" */
          }
    }
}
