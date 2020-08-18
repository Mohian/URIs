using System; 

class URI 
{

    static void Main(string[] args) 
    { 

       while (true)
                    {
                        int x = int.Parse(Console.ReadLine());
                        if (x == 2002)
                        {
                            Console.WriteLine("Acesso Permitido");
                            break;
                        }
                        else
                            Console.WriteLine("Senha Invalida");
                        
                    }
    }

}
