using System.Data.SqlTypes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }

        /// <summary>
        /// 1.Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>
        public static void Task1()
        {
            string str1 = "456 test 23 test test 27";
            string[] words = str1.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace("test", "testing");
            }
            string result = String.Join(" ", words);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 2. Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        ///Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string str1 = "Welcome";
            string str2 = "to";
            string str3 = "the";
            string str4 = "TMS";
            string str5 = "lessons";

            string phrase = ("\"" + str1 + "\"" + " " + "\"" + str2 + "\"" + " " + "\"" + str3 + "\"" + " " + "\"" + str4 + "\"" + " " + "\"" + str5 + "\"");
            Console.WriteLine(phrase);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        ///Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string str1 = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string s1 = "abc";
            int index = str1.IndexOf(s1);
            string firstPart = str1.Substring(0, index);
            string secondPart = str1.Substring(index + s1.Length);
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);
        }

        /// <summary>
        /// 4. Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        ///Заменить последний "!" на "?" и вывести результат на консоль
        /// </summary>
        public static void Task4()
        {
            string str1 = "Good day";
            string s1 = str1.Substring(4);
            string s2 = s1.Insert(0, "The best");
            string s3 = s2.Insert(s2.Length, "!!!!!!!!!");
            string s4 = s3.Substring(0, s3.Length - 1) + "?";
            Console.WriteLine(s4);
        }

        /// <summary>
        /// 5. Введите с консоли строку, которая будет содержать буквы и цифры. Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            Console.Write("Enter a string that contains letters and numbers: ");
            string inputString = Console.ReadLine();

            string lettersOnly = new String(inputString.Where(Char.IsLetter).ToArray());
            Console.WriteLine(lettersOnly);
        }

        /// <summary>
        /// 6.Задайте 2 предложения из консоли. Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
            Console.Write("Enter the first sentence: ");
            string sentens1 = Console.ReadLine();

            Console.Write("Enter the second sentence: ");
            string sentens2 = Console.ReadLine();

            foreach (string word in sentens1.Split(' ',','))
            {
                int count = sentens2.Split(new char[] { ' ', ',' })
                .Count(n => n.Equals(word));
                Console.WriteLine("Слово '{0}' встречается во втором предложении {1} раз(а).", word, count);
            }
        }
    }
}

