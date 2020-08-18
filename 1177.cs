using System; 

class URI 
{

    static void Main(string[] args) 
    { 
            int T = int.Parse(Console.ReadLine());
            int[] x = new int[1000];
            int b = 0;
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % T != 0)
                    {
                        b++;
                    }
                    else if (i % T == 0)
                    {
                        b = 0;
                    }
                    x[i] = b;
                }

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("N[{0}] = {1}", i, x[i]);
                }

            }

    }

}
