using System; 

class URI {

    static void Main(string[] args) { 

        int win;int sum;
            string[] x = Console.ReadLine().Split();
            int p = int.Parse(x[0]);
            int j1 = int.Parse(x[1]);
            int j2 = int.Parse(x[2]);
            int r = int.Parse(x[3]);
            int a = int.Parse(x[4]);
            sum = j1 + j2;
            if ((sum % 2 == 0 && p == 1) || (sum % 2 == 1 && p == 0)) win = 1;
            else win = 2;
            if ((r == 1 && a == 0) || (r == 0 && a == 1)) win = 1;
            else if (r == 1 && a == 1) win = 2;
            Console.WriteLine("Jogador {0} ganha!", win);

    }

}
