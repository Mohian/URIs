using System; 

class URI {

    static void Main(string[] args) { 
string x;
            while ((x = Console.ReadLine()) != null)
            {
                string[] y = x.Split();
                ulong sum;
                ulong a = ulong.Parse(y[0]);
                ulong b = ulong.Parse(y[1]);
                if (a < b)
                {
                    sum = b - a;
                }
                else
                {
                    sum = a - b;
                }

                Console.WriteLine(sum);
            }

    }

}
