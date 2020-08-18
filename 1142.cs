using System; 

class URI {

    static void Main(string[] args) { 

      int x = int.Parse(Console.ReadLine());
            int m = 1;
            int f = 4;
            for (int i = 1; i <= x; i++)
            {
                for (int j = m; j <= f; j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.WriteLine("PUM");
                    }
                    else
                    {
                        Console.Write("{0} ", j);
                    }
                }
                m = m + 4;
                f = f + 4;
            }

    }

}
