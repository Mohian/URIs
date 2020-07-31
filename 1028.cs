using System; 

class URI {

    static void Main(string[] args) { 

       int i, n, a, b;

            int dividendo, divisor, c;



            n = int.Parse(Console.ReadLine());



            for (i = 0; i < n; ++i)

            {

                string[]stri = Console.ReadLine().Split();
                a = int.Parse(stri[0]);
                b = int.Parse(stri[1]);


                if (b > a)
                {

                    dividendo = b;

                    divisor = a;

                }
                else
                {

                    dividendo = a;

                    divisor = b;

                }



                while (dividendo % divisor != 0)

                {

                    c = dividendo % divisor;

                    dividendo = divisor;

                    divisor = c;

                }



                Console.WriteLine("{0}", divisor);

            }
    }

}
