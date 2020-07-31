using System; 

class URI {

    static void Main(string[] args) { 

       string[]x=new string[2];
   x=Console.ReadLine().Split();
   int[]n= new int[2];
   for(int i=0;i<2;i++)
   {
       n[i]=int.Parse(x[i]);
   }
   if(n[0]>n[1]||n[0]==n[1])
   {
       Console.WriteLine("{0}",n[0]);
   }
   else
   {
       Console.WriteLine("{0}",n[1]);
   }

    }

}
