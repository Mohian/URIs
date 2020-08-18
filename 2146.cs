using System; 

class URI 
{

    static void Main(string[] args) 
    { 

    string z;
            while (( z = Console.ReadLine()) != null)
            {
               
                int x = Convert.ToInt32(z);
                if (z ==null)
                {
                    break;
                }
                else
                {
                    x--;
                    Console.WriteLine(x);
                }
            }

    }

}
