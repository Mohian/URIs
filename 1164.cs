using System; 

class URI {

    static void Main(string[] args) { 

   int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                long y = long.Parse(Console.ReadLine());
                if (y > 0)
                {
                    long z = y / 2;
                    long sum = 0;
                    for (int j = 1; j <= z; j++)
                    {
                      
                        if (y % j == 0)
                        {
                            sum +=j;
                        }
                        
                    }

                    if (sum == y)
                    {
                        Console.WriteLine("{0} eh perfeito", y);
                    }
                    else
                    {
                        Console.WriteLine("{0} nao eh perfeito", y);
                    }
                }
            }

    }

}
