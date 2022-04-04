
Double a = Convert.ToDouble(Console.ReadLine());
if (a == 0){
    Console.WriteLine("Can't be 0!");
    Console.ReadKey();
} else{
    Double b = Convert.ToDouble(Console.ReadLine());
    Double c = Convert.ToDouble(Console.ReadLine());
   
    Double multi = 2 * a; 

    double sr = Math.Sqrt(b * b - 4*a*c);
    if(Convert.ToString(sr) == "NaN"){
        Console.WriteLine("No Roots!");
        Console.ReadKey();
    }else if (sr == 0){
        Console.WriteLine(-b / multi);
        Console.ReadKey();
    }
    else{
    double r1 = -b + sr;
    double r2 = -b - sr;
    Console.WriteLine(r1/multi);
    Console.WriteLine(r2/multi);
    Console.ReadKey();
    }

}
