     //MJP1
// MJ Ahmed
// March 3, 2022
List<string> MovieDetails = new List<string>();
List<List<string>> Movies = new List<List<string>>();
List<string> MovieDescriptions = new List<string>(); // creates list
MovieDescriptions.Add("Movie Name: ");
MovieDescriptions.Add("Movie Length: ");
MovieDescriptions.Add("Is It PG13?: ");
MovieDescriptions.Add("Movie Release Date: ");
MovieDescriptions.Add("Movie Rating : ");
MovieDescriptions.Add("Movie Rating Percent: ");
MovieDescriptions.Add("Movie Director: ");
MovieDescriptions.Add("Movie Description: ");
bool loop = true; // loop variable
bool accessLoop = true;


while (loop == true){
accessLoop = true;
Console.Write("Would you like to access a movie or add one? [Add] [Access] [Exit]: ");
string key = Console.ReadLine();
if (key == "Add")
{
     Console.Write("Movie Name: ");
string movieName = Console.ReadLine();
MovieDetails.Add(movieName);

Console.Write("Movie Length: ");
string movieLength = Console.ReadLine();
MovieDetails.Add(movieLength);

Console.Write("Is the movie PG13?: ");
string isPG13 = Console.ReadLine();
MovieDetails.Add(isPG13);

Console.Write("Movie Release Date: ");
string movieReleaseDate = Console.ReadLine();
MovieDetails.Add(movieReleaseDate);

Console.Write("Movie Rating (Numbers Only out of 10): ");
string movieRating = Console.ReadLine();
double movieRatingPercent = (Convert.ToDouble(movieRating)) / 10 * 100;

MovieDetails.Add(movieRating);
MovieDetails.Add(Convert.ToString(movieRatingPercent));

Console.Write("Movie Director: ");
string movieDirector = Console.ReadLine();
MovieDetails.Add(movieDirector);

Console.Write("Movie Description: ");
string movieDescription = Console.ReadLine();
MovieDetails.Add(movieDescription);

Console.Write("Would you like to see what you put? [Yes] [No] ");
string showInput = Console.ReadLine();


if (showInput == "Yes")
{
        for (int i = 0; i <= MovieDetails.Count - 1; i++)
          {      
                 Console.WriteLine($"{MovieDetails[i]}");
           };
       Console.Write("Are these correct? ");
       string correct = Console.ReadLine();
       if (correct == "Yes")
       {
              Movies.Add(MovieDetails);
              Console.ReadKey();
       }
       else{
              Console.WriteLine("Please Reinput The Answers! ");
              Console.ReadKey();

       }
} else
{
       Movies.Add(MovieDetails);
}

} else if(key == "Access"){
       while (accessLoop == true)
       {
           Console.Write("Which would you like to access?: ");
       string access = Console.ReadLine();
       for (int i = 0; i < MovieDetails.Count ; i++)
       {
              Console.WriteLine($@"{MovieDescriptions[i]}                                         " + Movies[Convert.ToInt32(access)][i]);
       };
       Console.WriteLine("Would you like to access any more?: ");
       string loopy = Console.ReadLine();
       if (loopy == "Yes")
       {
              Console.ReadKey();
       } else
       {
              accessLoop = false;
       }    
       }
      
}
else if(key == "Exit"){
       Environment.Exit(0);
} else{
       Console.WriteLine("Please Enter A Valid Answer");
}
};
