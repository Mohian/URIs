using System; 

class URI {

    static void Main(string[] args) { 

      
            int N, M, net, i, cndtn;
            int[] bill = new int[15] {7, 12, 22, 52, 102, 15, 25, 55, 105, 30, 60, 110, 70, 120, 150};
            while (true)
            {
                string[] x = Console.ReadLine().Split();
                N = int.Parse(x[0]);
                M = int.Parse(x[1]);
                if (N == 0 && M == 0) break;
                net = M - N;
                for (i = 0, cndtn = 0; i < 15; i++)
                {
                    if (bill[i] == net)
                    {
                        cndtn = 1;
                        break;
                    }
                }

                if (cndtn==1)
                {
                    Console.Write("possible\n");
                }
                else
                {
                    Console.Write("impossible\n");
                }
            }

    }

}
