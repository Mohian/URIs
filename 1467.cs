using System; 

class URI {

    static void Main(string[] args) { 

        string votes1;
            while ((votes1 = Console.ReadLine()) != null)
            {
                string[] s = votes1.Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                int c = int.Parse(s[2]);
                if (a == 1 && b== 0 && c== 0||(a==0&&b==1&&c==1))
                {
                    Console.WriteLine("A");
                }
                else if (a == 0 && b == 1 && c == 0 || (a == 1 && b == 0 && c == 1))
                {
                    Console.WriteLine("B");
                }
                else if (a == 0 && b == 0 && c == 1 || (a == 1 && b == 1 && c == 0))
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }

    }

}
