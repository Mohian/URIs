using System; 

class URI {

    static void Main(string[] args) { 

      int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int m = 0;
            if (x>y)
            {
                for (int i =y;i<=x;i++)
                {
                    if (i % 13!= 0)
                        m = m + i;
                }

            }else
            {
                
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                        m = m + i;
                }
            }
            Console.WriteLine(m);

    }

}
