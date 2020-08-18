using System; 

class URI {

    static void Main(string[] args) { 

       int a, b, c = 0;
            int z;
            int x = int.Parse(Console.ReadLine());
            do
            {
                z = int.Parse(Console.ReadLine());
            }
            while (x >= z);
            {
                for (a = x, b = 0; b < z; a++)
                {
                    b += a;
                    c++;
                }

            }
            Console.WriteLine(c);

    }

}
