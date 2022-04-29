using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanieTekstem
{
    class Lodówka
    {
        public static void Rysuj(int kolor, int gotLonelyAsk)
        {
            bool lonely;
            if (gotLonelyAsk == 2)
                lonely = false;
            else
                lonely = true;
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
            rysujLodówke(lonely);
            if (!lonely)
                rysujKuchnie();
        }
        static void rysujLodówke(bool samotna)
        {
            List<int> moveList = new List<int> { 10, 22, 23, 30 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i == 0 && j == 0 || i == 0 && j == 9)
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (j == 9)
                                Console.SetCursorPosition(1 + j + 22, moveList[i] + k + 1);
                            else
                                Console.SetCursorPosition(1 + j, moveList[i] + k + 1);
                            Console.Write("|");
                        }
                    }
                    Console.SetCursorPosition(2 + j, moveList[i]);
                    Console.Write("_");
                }
            }
            Console.SetCursorPosition(50, 3);
            if (samotna)
                Console.Write("No i po co Ci taka smutna lodówka :c");
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (j > 6 && j < 9)
                        {
                            Console.SetCursorPosition(i + 14, 10 + j);
                            Console.Write("(");
                            Console.SetCursorPosition(i + 14, 20 + j);
                            Console.Write("(");
                            Console.SetCursorPosition(i + 19, 20 + j);
                            Console.Write(")");
                            Console.SetCursorPosition(i + 19, 10 + j);
                            Console.Write(")");
                        }
                        Console.SetCursorPosition(i + 16, 11 + j);
                        Console.Write("!");
                        Console.SetCursorPosition(i + 17, 11 + j);
                        Console.Write("!");
                    }
                }
                else
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.SetCursorPosition(i + 15, 24 + j);
                        Console.Write("!");
                        Console.SetCursorPosition(i + 16, 24 + j);
                        Console.Write("!");
                    }
                }
            }
        }
        static void rysujKuchnie()
        {
            int startX = 34, commonY = 20;
            List<int> listOfSidesSzafek = new List<int> { 0, 15, 30, 31, 43, 55 };
            //dolne szafki
            foreach (int id in listOfSidesSzafek)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(startX - 1 + id, commonY + i + 1);
                    if (id == 15 || id == 43)
                        Console.Write("!");
                    else
                        Console.Write("|");

                }
            }
            List<int> xIdKlamki = new List<int> { 5, 20, 35, 47 };
            //klamki
            foreach (int oneId in xIdKlamki)
            {
                Console.SetCursorPosition(startX + oneId, commonY + 1);
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("_");
                }
            }
            //filar pod blatem
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(120 - 5 + i, commonY + j + 1);
                    if (j < 9)
                        Console.Write("|");
                    else
                        if (i == 0)
                    {
                        Console.SetCursorPosition(120 - 6 + i, commonY + j + 1);
                        Console.Write("/");
                    }
                    else
                    {
                        Console.SetCursorPosition(120 - 4 + i, commonY + j + 1);
                        Console.Write("\\");
                    }


                }
            }
            //blat kuchenny
            for (int i = 0; i < 120 - startX; i++)
            {
                Console.SetCursorPosition(startX + i, commonY-1);
                Console.Write("_");
                Console.SetCursorPosition(startX + i, commonY);
                Console.Write("#");
            }
            //szafki
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.SetCursorPosition(startX + 10, 4);
                    for (int j = 0; j < 10; j++)
                    {
                        Console.SetCursorPosition(startX + 9, 5 + j);
                        Console.Write("|");
                    }
                    Console.SetCursorPosition(startX + 10, 4);
                }
                else
                {
                    Console.SetCursorPosition(startX + 10, 14);
                    for (int j = 0; j < 10; j++)
                    {
                        Console.SetCursorPosition(startX + 60, 5 + j);
                        Console.Write("|");
                    }
                    Console.SetCursorPosition(startX + 10, 14);
                }
                for (int j = 0; j < 50; j++)
                {
                    Console.Write("_");
                }
            }


            //przerwy w szafkach
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                        Console.SetCursorPosition(startX + 35, 5 + j);
                    else
                        Console.SetCursorPosition(startX + 36, 5 + j);
                    Console.Write("|");
                }
            }


            //y od 5 do 14 a x 15->30, x2 36 -> 45
            for (int i = 15; i < 30; i++)
            {
                if (i==15)
                {
                    for (int j = 7; j < 13; j++)
                    {
                        Console.SetCursorPosition(startX + i-1, j);
                        Console.Write("|");
                    }
                }
                else if(i == 29)
                {
                    for (int j = 7; j < 13; j++)
                    {
                        Console.SetCursorPosition(startX + i + 1, j);
                        Console.Write("|");
                    }
                }
                else if (i >19 && i < 24)
                {
                    Console.SetCursorPosition(startX + i, 13);
                    Console.Write("_");

                }
                Console.SetCursorPosition(startX + i, 6);
                Console.Write("_");
                Console.SetCursorPosition(startX + i, 12);
                Console.Write("_");
            }
            for (int i = 43; i < 55; i++)
            {
                if (i>45 && i < 52)
                {
                    Console.SetCursorPosition(startX + i, 13);
                    Console.Write("^^");
                }
    
            }
        }//koniec kuchni
    }//koniec voida
}
