Double Century = Convert.ToInt32(Console.ReadLine());
Double Year = Convert.ToInt32(Console.ReadLine());
Double Month = Convert.ToInt32(Console.ReadLine());
Double Day = Convert.ToInt32(Console.ReadLine());

if (Month > 2){
    Month = Month - 2;
} else {
    Month = Month + 10;
}

Double weekDay = (Day + (2.6 * Month - 0.2) - 2* Century + Year + (Year/4) + (Century/4))%7;

Console.WriteLine(weekDay);
Console.ReadKey();
