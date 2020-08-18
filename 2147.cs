using System; 

class URI 
{

    static void Main(string[] args) 
    { 

      int x=int.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    string y = Console.ReadLine();
                    float a = y.Length;
                    a = a / 100;
                    Console.WriteLine("{0:0.00}",a);
                }
    }
}
