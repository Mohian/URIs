using System; 

class URI {

    static void Main(string[] args) { 

         int a, b, c, d, e, N, p=0, min;
             N = int.Parse(Console.ReadLine());
            int[] x= new int[N];
            string[] str = Console.ReadLine().Split();
            for (a = 0; a < N; a++)
                
              x[a] = int.Parse(str[a]);
            min = x[0];
            for (a = 1; a < N; a++)
            {
                if (min > x[a])
                {
                    min = x[a];
                    p = a;
                }
            }
            Console.Write("Menor valor: {0}\nPosicao: {1}\n", min, p);

    }

}
