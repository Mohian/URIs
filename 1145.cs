using System; 

class URI {

    static void Main(string[] args) { 

        string[] x = Console.ReadLine().Split();
                int X = int.Parse(x[0]);
                int Y = int.Parse(x[1]);
                int b = 0;
                for (int a = 1; a <= Y; a++)
                {
                    b++;
                    if (b == X)
                    {
                        Console.Write("{0}", a);
                    }
                    else
                    {
                        Console.Write("{0} ", a);
                    }
                    if (b == X)
                    {
                        b = 0; Console.Write("\n");
                    }
                }

    }

}
