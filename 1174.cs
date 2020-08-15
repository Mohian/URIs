using System; 

class URI 
{

    static void Main(string[] args) 
    { 

        double[] x = new double[100];
            for (int i = 0; i < 100; i++)
                {
                    x[i] = double.Parse(Console.ReadLine());
                }

            for (int i = 0; i < 100; i++)
                {
                    if (x[i] <= 10)
                    {
                        Console.WriteLine("A[{0}] = {1:0.0}",i,x[i]);		
                    }
                }

    }

}