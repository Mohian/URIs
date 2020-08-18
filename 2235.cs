using System; 

class URI {

    static void Main(string[] args) { 

    string[] x = Console.ReadLine().Split();
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            int c = int.Parse(x[2]);

            if (a - b == 0)
            {
                Console.WriteLine("S");
            }
            else if (a - c == 0)
            {
                Console.WriteLine("S");
            }
            else if (b - c == 0)
            {
                Console.WriteLine("S");
            }
            else if ((a + b) - c == 0)
            {
                Console.WriteLine("S");
            }
            else if ((b + c) - a == 0)
            {
                Console.WriteLine("S");
            }
            else if ((a + c) - b == 0)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }

    }

}
