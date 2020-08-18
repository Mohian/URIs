using System; 

class URI {

    static void Main(string[] args) { 

   int a = int.Parse(Console.ReadLine());
            int c, d, e, f;
            for (int b = 1; b <= a; b++)
            {
                c = b * b;
                d = b * b * b;
                Console.WriteLine("{0} {1} {2}", b, c, d);
                e = c + 1;
                f = d + 1;
                Console.WriteLine("{0} {1} {2}", b, e, f);
            }
    }

}
