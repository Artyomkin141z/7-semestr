using System.Text;

namespace ConsoleHello
{ // создаваемое пространство имен
    class Program
    { // имя класса по умолчанию
        public static void Main(string[] args)
        {
            string[] firstNames = { "Саша", "Маша", "Олег", "Света", "Игорь" };
            TestStringBuilder();
        }
        public static void TestStringBuilder()
        {
            StringBuilder s1 = new StringBuilder("ABC"),
            s2 = new StringBuilder("CDE"), s3 = new StringBuilder();
            s3 = s1.Append(s2);
            bool b1 = (s1 == s3);
            char ch1 = s1[0], ch2 = s2[0];
            Console.WriteLine("s1={0}, s2={1}, b1={2}," + "ch1={3},ch2 ={ 4}", s1, s2, b1, ch1, ch2);
            StringBuilder s = new StringBuilder("Zenon");
            s[0] = 'L'; Console.WriteLine(s);
        }
        public static void PrintAr(string name, Array A)
        {
            Console.WriteLine(name);
            switch (A.Rank)
            {
                case 1:
                    for (int i = 0; i < A.GetLength(0); i++)
                        Console.Write("\t" + name + "[{0}]={1}", i, A.GetValue(i));
                    Console.WriteLine();
                    break;
                case 2:
                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                            Console.Write("\t" + name + "[{0},{1}]={2}", i, j,
                            A.GetValue(i, j));
                        Console.WriteLine();
                    }
                    break;
                default: break;
            }
        }
        static string CharArrayToString(char[] ar)
        {
            string result = "";
            for (int i = 0; i < ar.Length; i++) result += ar[i];
            return (result);
        }
        static void PrintCharAr(string name, char[] ar)
        {
            Console.WriteLine(name);
            for (int i = 0; i < ar.Length; i++) Console.Write(ar[i]);
            Console.WriteLine();
        }
        public static void TestCharArAndString()
        {
            string hello = "Здравствуй, Мир!";
            char[] strM1 = hello.ToCharArray();
            PrintCharAr("strM1", strM1);
            char[] World = new char[3];
            Array.Copy(strM1, 12, World, 0, 3); //копирование подстроки
            PrintCharAr("World", World);
            Console.WriteLine(CharArrayToString(World));
        }
    }
}