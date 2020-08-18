using System; 

class URI {

    static void Main(string[] args) { 

          double a = 0;
            double d = 0;
            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
                else
                {
                    a += x;
                    d++;
                    
                }
            }
            double z = a/d;
            Console.WriteLine("{0:0.00}",z);

    }

}
