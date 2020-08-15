using System; 

class URI {

    static void Main(string[] args) { 

        int a, b, c, d, e;
            int N = int.Parse(Console.ReadLine());
            for (a = 1; a <= N; a++)
            {
                string[] str = Console.ReadLine().Split();
                int X = int.Parse(str[0]);
                int Y = int.Parse(str[1]);
                if (X % 2 == 1)
                {
                    c = 0;
                    for (b = 1; b <= Y; b++)
                    {
                        c += X;
                        X += 2;
                    }

                    Console.WriteLine(c);
                }
                else
                {
                    X++;
                    c = 0;
                    for (b = 1; b <= Y; b++)
                    {
                        c += X;
                        X += 2;
                    }
                    Console.WriteLine(c);
                }
            }

    }

}
