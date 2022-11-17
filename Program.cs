using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Düzbucaqlının sahesi");
            Console.WriteLine("2 Düzbucaqlının perimetri");
            Console.WriteLine("3 Hesablama maşını");
            Console.WriteLine("0 düyme çıxış");
            bool exit = false;
            while (exit == false)
            {

                bool check = false;
                int processNumber = 0;
                while (check == false)
                {
                    Console.WriteLine("Proses ededini daxil edin.");
                    string userNumber = Console.ReadLine();
                    int number;
                    bool checkUserNumber = int.TryParse(userNumber, out number);
                    if (checkUserNumber == false || number != 0 && number != 1 && number != 2 && number != 3)
                    {
                        Console.WriteLine("Bele Bir Proses Reqemi Yoxdur !!!");
                    }
                    else
                    {
                        check = true;
                        processNumber = number;
                    }
                   
                }


                if (processNumber == 1)
                {
                    Console.WriteLine("p1");
                    check = true;
                }
                else if (processNumber == 0)
                {
                    exit = true;
                }
                else if (processNumber == 3)
                {
                    Console.WriteLine("Birinci ededi daxil edin");
                    string p3UserNumber1 = Console.ReadLine();
                    Console.WriteLine("Ikinci ededi daxil edin");
                    string p3UserNumber2 = Console.ReadLine();
                    int p3num1;
                    int p3num2;
                    bool checkP3UserNumber1 = int.TryParse(p3UserNumber1, out p3num1);
                    bool checkP3UserNumber2 = int.TryParse(p3UserNumber2, out p3num2);
                    Console.WriteLine("Simvolu daxil edin");
                    string symbol = Console.ReadLine();

                    if (checkP3UserNumber1 == false || checkP3UserNumber2 == false)
                    {
                        Console.WriteLine("xAHIS OLUR   Eded Daxil edin");
                    }
                    else
                    {
                        double result = Calculate(p3num1, p3num2, symbol);
                        Console.WriteLine(result);
                        check = true;

                    }
                }


            }


        }
        static double Calculate(double number1, double number2, string symbol)
        {
            double counter = 0;
            if (symbol == "+")
            {
                counter = number1 + number2;
            }
            else if (symbol == "-")
            {
                counter = number1 - number2;
            }
            else if (symbol == "*")
            {
                counter = number1 * number2;
            }
            else if (symbol == "/")
            {
                counter = number1 / number2;
            }
            return counter;
        }
    }

}
