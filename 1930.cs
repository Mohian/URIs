using System; 

class URI {

    static void Main(string[] args) { 

        string[] x = Console.ReadLine().Split();
            int[] a= new int[4];
            int z=0;
            for (int i = 0; i < 4; i++)
            {
                a[i] = int.Parse(x[i]);
            }

            for (int i = 0; i < 4; i++)
            {
              z += a[i];
            }
            Console.WriteLine(z-3);


    }

}
