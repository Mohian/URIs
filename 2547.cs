using System; 

class URI {

    static void Main(string[] args) { 

     string input;
            while ((input = Console.ReadLine()) != null)
            {
                string[] x =input.Split();
                int a = int.Parse(x[0]);
                int b = int.Parse(x[1]);
                int c = int.Parse(x[2]);
                int count = 0;
                for (int i = 1; i <= a; i++)
                {
                    int h = int.Parse(Console.ReadLine());
                    if (h >= b && h <= c)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }

    }

}
