using System; 

class URI {

    static void Main(string[] args) { 

      int[] x = new int[10];
            int v = int.Parse(Console.ReadLine());
            x[0] = v;
            for (int i = 1; i<10; i++)
            {
                v = v * 2;
                x[i] = v;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, x[i]);
            }
    }

}
