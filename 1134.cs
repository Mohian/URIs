using System; 

class URI {

    static void Main(string[] args) { 

       int a = 0;
            int b = 0;
            int c = 0;
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    a += 1;
                }
                else if (x == 2)
                {
                    b += 1;
                }
                else if (x == 3)

                {
                    c += 1;
                }
                else if (x == 4)
                {
                    break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", a, b, c);

    }

}
