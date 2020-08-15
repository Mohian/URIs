using System; 

class URI {

    static void Main(string[] args) { 

      int[] x=new int[20]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            for (int i = 19; i >= 0; i--)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[{0}] = {1}",i,x[i]);
            }

    }

}
