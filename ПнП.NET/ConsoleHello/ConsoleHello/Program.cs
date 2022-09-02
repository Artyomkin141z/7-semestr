namespace ConsoleHello
{ // создаваемое пространство имен
    class Program
    { // имя класса по умолчанию
        static void Main(string[] args)
        {
            int[,] points = { { 2, -2 }, { 3, -22 }, { 0, 4 } };
            les2(points);
        }

        public static void les2(int[,] mass)
        {
            int X1 = 0, Y1 = 0, X2 = 0, Y2 = 0, distance = 0;
            int[,] answer;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                int x1 = mass[i, 0];
                int y1 = mass[i, 1];
                for(int j = 0; j < mass.GetLength(0); j++)
                {
                    int x2 = mass[j, 0];
                    int y2 = mass[j, 1];

                    int localDistance = (int) Math.Sqrt(
                        Math.Pow(Convert.ToDouble(x2 - x1), 2) + 
                        Math.Pow(Convert.ToDouble(y2 - y1), 2)
                        );
                    

                    if (localDistance > distance)
                    {
                        distance = localDistance;   
                        X1 = x1;
                        Y1 = y1;
                        X2 = x2;
                        Y2 = y2;
                    }
                }
            }
            Console.WriteLine("Lesson1 1");
            Console.WriteLine("Maximum distance between points: " + distance.ToString());
            Console.WriteLine("Points: ("
            + X1.ToString() + ", "
            + Y1.ToString() + ") and ("
            + X2.ToString() + ", " 
            + Y2.ToString() + ")");
        }

        public static void les3()
        {

        }
    }
}