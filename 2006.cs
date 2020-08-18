using System; 

class URI {

    static void Main(string[] args) { 

       int x = int.Parse(Console.ReadLine());
            int[] y=new int[5];
            int flag = 0;
            string[] z = Console.ReadLine().Split();
            for (int i = 0; i < 5; i++)
            {
                y[i] = int.Parse(z[i]);
            }
            for(int i=0;i<5;i++)
            {
                if (y[i] == x)
                {
                    flag++;
                }
            }
            Console.WriteLine(flag);

    }

}
