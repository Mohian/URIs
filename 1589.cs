using System; 

class URI 
{

    static void Main(string[] args) 
    { 

      int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                string[] str = Console.ReadLine().Split();
                int fu = int.Parse(str[0]);
                int z = int.Parse(str[1]);
                int f = z + fu;
                Console.WriteLine(f);
            }
            

    }

}
