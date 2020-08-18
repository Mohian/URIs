using System; 

class URI {

    static void Main(string[] args) { 

      int n = int.Parse(Console.ReadLine());
            for(int i=2;i<=n;i+=2)
            {
                int b = 0;
                b = i * i;
                Console.WriteLine("{0}^2 = {1}",i,b);
            }

    }

}
