using System; 

class URI 
{

    static void Main(string[] args) 
    { 

     int x = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = x; i > 0; i--)
            {
                a = a * i;
            }
            Console.WriteLine(a);

    }

}
