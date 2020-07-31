using System; 

class URI 
{

    static void Main(string[] args) 
    { 

      int n =int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] x = Console.ReadLine().Split();
                if(x[0]=="Thor")
                    Console.WriteLine("Y");
                else
                {
                    Console.WriteLine("N");
                }
            }

    }

}
