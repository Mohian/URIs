using System; 

class URI {

    static void Main(string[] args) { 

       int m = 7;
            int f = 5;
            for (int i = 1; i <= 9; i += 2)
            {
                
                for (int j = m; j >= f; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
                m += 2;
                f += 2;
            }

    }

}
