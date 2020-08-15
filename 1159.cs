using System; 

class URI {

    static void Main(string[] args) { 
 while (true)
            {
                int z = 0;
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else if (x % 2 == 0)
                {
                    for (int i = x; i <= (x + 8); i += 2)
                    {
                        z += i;
                    }
                }
                else
                {
                    for (int i = (x + 1); i <= (x + 9); i += 2)
                    {
                        z += i;
                    }
                }


                Console.WriteLine(z);
            }

    }

}
