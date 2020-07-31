using System; 

class URI 
{

    static void Main(string[] args)
    { 

    int n=int.Parse(Console.ReadLine());
if (n==1)
   Console.WriteLine("Top 1");
else if (n>1 && n<=3)
   Console.WriteLine("Top 3");
else if (n>3 && n<=5)
    Console.WriteLine("Top 5");
else if (n>5 && n<=10)
    Console.WriteLine("Top 10");
else if (n>10 && n<=25)
    Console.WriteLine("Top 25");
else if (n>25 && n<=50)
    Console.WriteLine("Top 50");
else if (n>50 && n<=100)
    Console.WriteLine("Top 100"); 
    }

}
