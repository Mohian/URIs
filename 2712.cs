using System; 

class URI 
{

    static void Main(string[] args) 
    { 

     int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                string str = Console.ReadLine();
                long strlen = str.Length;
                int flag = 0;
                int flag1 = 0;
                if (strlen <= 100 && strlen>=1)
                {
                    if (strlen == 8)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (str[j] >= 65 && str[j] <= 90)
                            {
                                flag++;
                            }
                        }
                        for (int k = 4; k <= 7; k++)
                        {
                            if (str[k] >= 48 && str[k] <= 57)
                            {
                                flag1++;
                            }
                        }

                        if (str[3] == '-' && flag == 3&&flag1==4)
                        {
                            if (str[7] == '1' || str[7] == '2')
                            {
                                Console.WriteLine("MONDAY");
                            }
                            else if (str[7] == '3' || str[7] == '4')
                            {
                                Console.WriteLine("TUESDAY");
                            }
                            else if (str[7] == '5' || str[7] == '6')
                            {
                                Console.WriteLine("WEDNESDAY");
                            }
                            else if (str[7] == '7' || str[7] == '8')
                            {
                                Console.WriteLine("THURSDAY");
                            }
                            else if (str[7] == '9' || str[7] == '0')
                            {
                                Console.WriteLine("FRIDAY");
                            }
                            else
                            {
                                Console.WriteLine("FAILURE");
                            }

                        }
                        else
                        {
                            Console.WriteLine("FAILURE");
                        }

                    }
                    else
                    {
                        Console.WriteLine("FAILURE");
                    }
                }
            }

    }

}
