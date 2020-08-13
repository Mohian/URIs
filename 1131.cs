using System; 

class URI {

    static void Main(string[] args) { 

       int l = 0, j = 0, k = 0, c = 0, d = 0, e = 0;
            while (true)
            {
                string[] str = Console.ReadLine().Split();
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                //scanf("%d%d", &a, &b);
                if (a > b)
                {
                    l++;
                }

                if (a < b)
                {
                    k++;
                }

                if (a == b)
                {
                    j++;
                }

                c += a;
                d += b;
                e++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int f = int.Parse(Console.ReadLine());
                if (f == 1)
                    continue;
                if (f == 2)
                    break;
            }
            Console.WriteLine("{0} grenais",e);
            Console.WriteLine("Inter:{0}", l);
            Console.WriteLine("Gremio:{0}", k);
            Console.WriteLine("Empates:{0}", j);
            if (l > k)
                Console.WriteLine("Inter venceu mais");
            if (l < k)
                Console.WriteLine("Gremio venceu mais");
            if (k == l)
                Console.WriteLine("Nao houve vencedor");

    }

}
