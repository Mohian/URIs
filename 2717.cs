using System; 

class URI {

    static void Main(string[] args) { 

         int x = int.Parse(Console.ReadLine());
            string[] a =(Console.ReadLine().Split());
            int y = int.Parse(a[0]);
            int z = int.Parse(a[1]);
            if ((y + z) <= x)
            {
                Console.WriteLine("Farei hoje!");
            }
            else
            {
                Console.WriteLine("Deixa para amanha!");
            }

    }

}
