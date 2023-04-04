namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        public static void Task1()
        {
            Console.WriteLine("Please enter the first number");  //просим ввести первое число
            int operand1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number"); //просим ввести второе число
            int operand2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Possible arithmetic operations: +, -, *, /");
            Console.WriteLine("Choose an arithmetic operation");  //просим ввести арифметическую операцию

            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("Answer " + (operand1 + operand2));
                    break;
                case "-":
                    Console.WriteLine("Answer " + (operand1 - operand2));
                    break;
                case "*":
                    Console.WriteLine("Answer " + (operand1 * operand2));
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("Answer " + (operand1 / operand2));
                    }
                    else
                        Console.WriteLine("Division by 0 is not allowed");
                    break;
                default:
                    Console.WriteLine("Choose an arithmetic operation");
                    break;
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Please enter a number from 0 to 100");

            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine(number + " is in between [0-14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine(number + " is in between [15-35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine(number + " is in between [36-50]");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine(number + " is in between [51-100]");
            }
            else
            {
                Console.WriteLine("Please enter a number from 0 to 100");
            }
        }
        public static void Task3()
        {
            Console.WriteLine("Ведите слово из словаря: дождливо, пасмурно, ветрено, снежно, тепло, солнечно, туманно, душно, облачно, холодно");

            string weather = Console.ReadLine();

            switch (weather)
            {
                case "дождливо":
                    Console.WriteLine("rainy");
                    break;
                case "пасмурно":
                    Console.WriteLine("mainly cloudy");
                    break;
                case "ветрено":
                    Console.WriteLine("windy");
                    break;
                case "снежно":
                    Console.WriteLine("snowy");
                    break;
                case "тепло":
                    Console.WriteLine("warm");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "туманно":
                    Console.WriteLine("hazy");
                    break;
                case "душно":
                    Console.WriteLine("stuffy");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                default:
                    Console.WriteLine("Такого слова нет в словаре");
                    break;
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Chislo chetnoe");
            }
            else
            {
                Console.WriteLine("Chislo nechetnoe");
            }
        }
    }
}
