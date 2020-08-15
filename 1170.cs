using System; 

class URI {

    static void Main(string[] args) { 

       int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                int day = 0;
                float a = float.Parse(Console.ReadLine());
                while (a > 1)
                {
                    a= a / 2;
                    day++;
                }

                Console.WriteLine("{0} dias",day);
            }

    }

}
