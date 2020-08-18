using System; 

class URI {

    static void Main(string[] args) { 


            while (true)
            {
                string[] z = Console.ReadLine().Split();
                int x = int.Parse(z[0]);
                int y = int.Parse(z[1]);
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (y > x)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    break;
                }
            }

    }

}
