using System; 

class URI {

    static void Main(string[] args) { 

        string[] x = Console.ReadLine().Split();
            float y = float.Parse(x[0]);
            float z = float.Parse(x[1]);
            float b = y/z;
            Console.WriteLine("{0:0.00}",b);

    }

}
