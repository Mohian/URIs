using System; 

class URI {

    static void Main(string[] args) { 

      int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int m = 0;
                int c = 0;
                for (int j = 1; j <= 3; j++)
                {
                    m = i * i;
                    c = m * i;

                }
                Console.Write("{0} {1} {2}\n", i, m, c);
            } 

    }

}
