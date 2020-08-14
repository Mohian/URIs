using System; 

class URI {

    static void Main(string[] args) { 

       while (true)
            {
                string[] x = Console.ReadLine().Split();
                int y = int.Parse(x[0]);
                int z = int.Parse(x[1]);
                if (y == 0 && z == 0)
                {
                    break;
                }
                else
                {
                    int w = y + z;
                    Console.WriteLine(w);
                }
            }

    }

}
