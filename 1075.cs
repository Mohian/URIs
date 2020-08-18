using System; 

class URI {

    static void Main(string[] args) { 

         int x = int.Parse(Console.ReadLine());
            for(int i=1;i<=10000;i++)
            {
                if(i%x==2)
                {
                    Console.WriteLine("{0}",i);
                }
            }

    }

}
