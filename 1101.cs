using System; 

class URI 
{

    static void Main(string[] args) 
    { 

        while (true)
            {
                string[] x = Console.ReadLine().Split();
                int X = int.Parse(x[0]);
                int Y = int.Parse(x[1]);
                if (Y >= X && X>0)
                {
                    int b = 0;
                    for (int a = X; a <= Y; a++)
                    {
                        b += a;
                        Console.Write("{0} ",a);

                    }
                    Console.WriteLine("Sum={0}", b);
                }
                else if (X >= Y && Y>0)
                {
                    int b = 0;
                    for (int a = Y; a <= X; a++)
                    {
                        b += a;
                        Console.Write("{0} ", a);

                    }
                    Console.WriteLine("Sum={0}", b);
                }
                else if (X <= 0 || Y <= 0)
                {
                    break;

                }
            }

    }

}
