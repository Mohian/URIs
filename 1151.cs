using System; 

class URI {

    static void Main(string[] args) { 

    
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i=1;i<n;i++)
            {
                    if (i % 2 == 1)
                    {
                    Console.Write("{0} ",c);
                        c = a + b;
                        a = c;
                    }
                    else if (i == 2)
                    Console.Write("{0} ",c);
                    else if (i % 2 == 0)
                    {
                    Console.Write("{0} ",c);
                        c = a + b;
                        b = c;
                    }
                }
                Console.WriteLine(c);
    }

}
