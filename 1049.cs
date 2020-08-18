using System; 

class URI {

    static void Main(string[] args) { 

      
            string x = Console.ReadLine();
            if (x == "vertebrado")
            {
                string y = Console.ReadLine();
                if (y == "ave")
                {
                    string z = Console.ReadLine();
                    if (z == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (y == "mamifero")
                {
                    string z = Console.ReadLine();
                    if (z == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (x == "invertebrado")
            {
                string y = Console.ReadLine();
                if (y == "inseto")
                {
                    string z = Console.ReadLine();
                    if (z == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (y == "anelideo")
                {
                    string z = Console.ReadLine();
                    if (z == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
    }

}
