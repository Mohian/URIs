using System; 

class URI {

    static void Main(string[] args) { 

    int decimalNumber, quotient;
            int i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[100];
            char temp1;
            decimalNumber = int.Parse(Console.ReadLine());
            quotient = decimalNumber;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }

            for (j = i - 1; j > 0; j--)
            {
                Console.Write(hexadecimalNumber[j]);
                if (j == 1)
                {
                    Console.Write("\n");
                }
            }

    }

}
