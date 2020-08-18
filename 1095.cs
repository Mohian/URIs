using System; 

class URI {

    static void Main(string[] args) { 

            int i = 1;
            int j = 60;
            Console.WriteLine("I={0} J={1}", i, j);
            while (j != 0)
            {
                j -= 5;
                i += 3;
                Console.WriteLine("I={0} J={1}", i, j);
            }
    }

}
