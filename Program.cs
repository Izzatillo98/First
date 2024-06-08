using System.Net.NetworkInformation;

Decimal radius;
Console.WriteLine("Aylanani radiusini kiriting: ");
Console.Write("radius :");
string Yuzi = Console.ReadLine();
radius = Convert.ToDecimal(Yuzi);
Decimal javob = (radius * radius * 3.14m );
Console.Write("Aylananing yuzi :");
Console.WriteLine(javob + " sm^2 ga teng");
