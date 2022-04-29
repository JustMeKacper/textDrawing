using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanieTekstem
{
    class ciapong
    {
        public static void pokazPedolino(int kolor, int startY, char tragedia)
        {
            bool bloodOnTrain = false;
            if (tragedia == 'T')
                bloodOnTrain = true;

            if (kolor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (kolor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (kolor == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            for (int i = 0; i < 60; i++)
            {
                if (i > 0 && i < 10 || i > 12)
                {
                    Console.SetCursorPosition(0 + i, startY + 1);
                    Console.Write("_");
                    Console.SetCursorPosition(0 + i, startY + 8);
                    Console.Write("_");
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(10, startY + 2 + i);
                Console.Write("|||");
                Console.SetCursorPosition(40, startY + 2 + i);
                Console.Write("|");
            }
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(60 + i, startY + 2 + i);
                Console.Write("\\");
            }
            Console.SetCursorPosition(64, startY + 6);
            Console.Write(")");
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(63 - i, startY + 7 + i);
                if (i == 1)
                {
                    Console.SetCursorPosition(61 - i, startY + 7 + i);
                    Console.Write("__/");
                }
                else
                    Console.Write("/");
            }
            List<int> xIndexWindow = new List<int> { 3, 16, 23 };
            foreach (int id in xIndexWindow)
            {
                square(id, 8);
            }
            int tmp = 0;
            for (int j = 0; j < 2; j++)
            {
                if (j > 0)
                    tmp = 4;
                for (int i = 0; i < 8; i++)
                {
                    Console.SetCursorPosition(30 + i, 8 + tmp);
                    if (i != 3)
                    {
                        Console.Write("_");
                    }
                }
            }
            tmp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.SetCursorPosition(29 + tmp, 9 + j);
                    Console.Write("|");
                }
                if (i == 1)
                    tmp += 5;
                else if (i == 2)
                {
                    Console.SetCursorPosition(31, 11);
                    Console.Write("0");
                    Console.SetCursorPosition(35, 11);
                    Console.Write("0");
                }
                else
                    tmp += 4;

            }
            tmp = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.SetCursorPosition(43 + j, 8 + tmp);
                    Console.Write("_");
                }
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                        Console.SetCursorPosition(42 + tmp, 9 + j);
                    else
                        Console.SetCursorPosition(43 + tmp, 9 + j);
                    Console.Write("|");
                }
                tmp = 4;
            }
            Console.SetCursorPosition(55, 7);
            Console.Write("-----");
            Console.SetCursorPosition(55, 9);
            Console.Write("_______");
            Console.SetCursorPosition(54, 8);
            Console.Write("|");
            Console.SetCursorPosition(54, 9);
            Console.Write("|");
            Console.SetCursorPosition(54, 7);
            Console.Write("┌");
            Console.SetCursorPosition(53, startY + 1);
            Console.Write("^");
            for (int i = 0; i < 120; i++)
            {
                Console.SetCursorPosition(0 + i, startY + 10);
                Console.Write("/");
                Console.SetCursorPosition(0 + i, startY + 9);
                Console.Write("/");

            }
            if (bloodOnTrain)
            {
                tragediaZLosSantos();
            }



        }
        static void tragediaZLosSantos()
        {
            //gościu
            Console.SetCursorPosition(18, 0);
            Console.Write("O");
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(19 + i, 0);
                if (i != 2)
                    Console.Write("_");
                else
                    Console.Write("┌---");
                Console.SetCursorPosition(18, 1 + i);
                Console.Write("|");
                if (i > 0)
                {
                    Console.SetCursorPosition(18 - i, i);
                    Console.Write("/");
                }
                Console.SetCursorPosition(18 - 1 - i, 4 + i);
                Console.Write("/");
                Console.SetCursorPosition(18 + 1 + i, 4 + i);
                Console.Write("\\");
            }
            //gościu #2
            int MovePoint = 20;
            Console.SetCursorPosition(18 + MovePoint, 0);
            Console.Write("O");
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(18 + MovePoint, 1 + i);
                Console.Write("|");
                if (i > 0)
                {
                    Console.SetCursorPosition(17 + MovePoint, i);
                    Console.Write("|");
                    Console.SetCursorPosition(19 + MovePoint, i);
                    Console.Write("|");
                }
                Console.SetCursorPosition(18 + MovePoint - 1 - i, 4 + i);
                Console.Write("/");
                Console.SetCursorPosition(18 + MovePoint + 1 + i, 4 + i);
                Console.Write("\\");
            }
        }
        static void square(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("___");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("___");
            Console.SetCursorPosition(x - 1, y + 1);
            Console.Write("|");
            Console.SetCursorPosition(x - 1, y + 2);
            Console.Write("|");
            Console.SetCursorPosition(x + 3, y + 1);
            Console.Write("|");
            Console.SetCursorPosition(x + 3, y + 2);
            Console.Write("|");
        }
    }
}
