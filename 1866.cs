using System; 

class URI {

    static void Main(string[] args) { 

      int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                int b = 0;
                int y = int.Parse(Console.ReadLine());
                for (int j = 1; j <= y; j++)
                {
                    if (j % 2 != 0)
                    {
                        b++;
                    }
                    else
                    {
                        b--;
                    }
                }

                Console.WriteLine(b);

            }

    }

}
