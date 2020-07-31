using System; 

class URI 
{

    static void Main(string[] args) 
    { 

     string[] n= new string[4] ;
   int[] N=new int[4];
   n=Console.ReadLine().Split();
    for(int i=0;i<4;i++)
    {
        N[i]=int.Parse(n[i]);
    }
    for(int i=0;i<4;i++)
    {
        for (int j=i+1;j<4;j++)
        {
            if(N[i]>N[j])
            {
                int temp=N[i];
                N[i]=N[j];
                N[j]=temp;
            }
        }
    }
    int g=N[0]+N[1];
    int f=N[1]+N[2];
    if(N[3]<f || N[2]<g)
    {
        Console.WriteLine("S");
    }
    else
    {
        Console.WriteLine("N");
    }

    }

}
