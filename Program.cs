using System;

namespace Horse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты до хода:");
            string moveBefore = Console.ReadLine();
            Console.WriteLine("Введите координаты после хода:");
            string moveAfter = Console.ReadLine();
            Writer(moveBefore, moveAfter);
        }
        public static void Writer(string moveBefore, string moveAfter)
        {
            char[] arr1 = moveBefore.ToCharArray();
            char[] arr2 = moveAfter.ToCharArray();
            //Если буквы находятся в промежутку от A до H, а цифры в промежутку от 1 до 8, то всё верно и проверяется следующее условие
            if (arr1[0] >= 65 && arr1[0] <= 72 && arr2[0] >= 65 && arr2[0] <= 72 && arr1[1] >= 49 && arr1[1] <= 56 && arr2[1] >= 49 && arr2[1] <= 56)
            {
                //Если буква после хода больше, чем буква до хода на 2(1) и цифра после хода больше, чем цифра до хода на 1(2), то ход верный 
                if ((arr2[0] - arr1[0] == 2) || (arr1[0] - arr2[0] == 2))
                {
                    if ((arr2[1] - arr1[1] == 1) || (arr1[1] - arr2[1] == 1))
                    {
                        Console.WriteLine("Ход верный");
                    }
                    else Console.WriteLine("Ход неверный");
                }
                else if ((arr2[0] - arr1[0] == 1) || (arr1[0] - arr2[0] == 1))
                {
                    if ((arr2[1] - arr1[1] == 2) || (arr1[1] - arr2[1] == 2))
                    {
                        Console.WriteLine("Ход верный");
                    }
                    else Console.WriteLine("Ход неверный");
                }
                else Console.WriteLine("Ход неверный");
            }
            else Console.WriteLine("Координаты не соответствуют необходимому промежутку");
        }
    }
}
