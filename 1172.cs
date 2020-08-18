using System; 

class URI {

    static void Main(string[] args) { 

       int[] x = new int[10];
            for (int i = 0; i < 10; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                if (x[i]<= 0)
                {
                    x[i] = 1;
                }
            }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("X[{0}] = {1}", i, x[i]);
                }

    }

}
