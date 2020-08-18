using System; 

class URI {

    static void Main(string[] args) { 

    double x = 1,z,sum=0;
            for (int i = 3; i <= 39; i += 2)
            {
                x = x * 2;
                z = i / x;
                sum += z;
            }
            Console.WriteLine("{0:0.00}",sum+1);

    }

}
