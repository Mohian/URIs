using System; 

class URI {

    static void Main(string[] args) { 
int a, b, c, d, e, f=0, q, r;
                string[] x = Console.ReadLine().Split();
                a = int.Parse(x[0]);
                b = int.Parse(x[1]);
                if (a < 0)
                {
                    e = b;
                    if (b < 0) e = b * -1;
                    for (r = 0; r < e; r++)
                    {
                        f = a - r;
                        if (f % b == 0) break;
                    }
                    q = f / b;
                }
                else
                {
                    q = a / b;
                    r = a % b;
                }

            Console.WriteLine("{0} {1}", q, r);

    }

}
