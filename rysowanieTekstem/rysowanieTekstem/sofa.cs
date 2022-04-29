using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rysowanieTekstem
{



    class sofa
    {
        public static void Rysuj(int size, int kolor, char zL, char zK)
        {
            int startY = 10;
            bool lampka, komoda;
            if (zK == 't')
                komoda = true;
            else
                komoda = false;
            if (zL == 't')
                lampka = true;
            else
                lampka = false;

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
            topTheSofa(size, startY);
            bokiTheSofy(size, startY);
            podusie(size, startY);
            wypełnienieSofy(size, startY);
            if (lampka)
                rysujLampke(size, startY);
            if (komoda)
                rysujKomode(size, startY,lampka);
        }


        static void rysujKomode(int size, int Yindex, bool lampka)
        {
            Yindex++;

            int width = 0;

            if (lampka)
            {
                size += 24;
                width = 15;
            }
            else
            {
                size += 7;
                width = 25;
            }

            int rightStrona = 0;

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(size+ rightStrona, i + Yindex);
                    Console.Write("|");
                }
                rightStrona += width;
            }


            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < width+1; i++)
                {
                    Console.SetCursorPosition(size+i,Yindex+j);
                    if (j == 0)
                        Console.Write("_");
                    else
                        Console.Write("#");
                }

            }


            for (int i = 0; i < width-1; i++)
            {
                Console.SetCursorPosition(size + 1+i, Yindex + 3);
                Console.Write("_");
                if (lampka)
                {
                    /*
                        width = 25;
                        width = 15;
                     */
                    if (i==7)
                    {
                        Console.SetCursorPosition(size + i, Yindex + 2);
                        Console.Write("_");
                        Console.SetCursorPosition(size +1+ i, Yindex + 2);
                        Console.Write("_");
                    }
                }
                else
                {
                    if (i == 12)
                    {
                        Console.SetCursorPosition(size + i, Yindex + 2);
                        Console.Write("_");
                        Console.SetCursorPosition(size + 1 + i, Yindex + 2);
                        Console.Write("_");
                    }
                }
            }


            for (int i = 0; i < width - 1; i++)
            {
                Console.SetCursorPosition(size + 1 + i, Yindex + 5);
                Console.Write("_");
                if (lampka)
                {
                    /*
                        width = 25;
                        width = 15;
                     */
                    if (i == 7)
                    {
                        Console.SetCursorPosition(size + i, Yindex + 4);
                        Console.Write("_");
                        Console.SetCursorPosition(size + 1 + i, Yindex + 4);
                        Console.Write("_");
                    }
                }
                else
                {
                    if (i == 12)
                    {
                        Console.SetCursorPosition(size + i, Yindex + 4);
                        Console.Write("_");
                        Console.SetCursorPosition(size + 1 + i, Yindex + 4);
                        Console.Write("_");
                    }
                }
            }


            for (int i = 0; i < width - 1; i++)
            {
                if (i<4||i>width-6)
                {
                    Console.SetCursorPosition(size + 1 + i, Yindex + 9);
                    Console.Write("_");
                }
                else if (i == 4)
                {
                    Console.SetCursorPosition(size + 1 + i, Yindex + 9);
                    Console.Write("|");
                    Console.SetCursorPosition(size + 1 + i, Yindex + 8);
                    Console.Write("|");
                }
                else if (i == width-6)
                {
                    Console.SetCursorPosition(size + 1 + i, Yindex + 9);
                    Console.Write("|");
                    Console.SetCursorPosition(size + 1 + i, Yindex + 8);
                    Console.Write("|");
                }
                else
                {
                    Console.SetCursorPosition(size + 1 + i, Yindex + 7);
                    Console.Write("_");
                }
            }

        }//koniec


        static void rysujLampke(int size, int Yindex)
        {
            Yindex -= 7;
            size += 6;
            Console.SetCursorPosition(size + 5, Yindex);
            Console.Write("____"); //4
            
            for (int i = 1; i < 7; i++)
            {
                Console.SetCursorPosition(size + 5 - i, Yindex + i);
                Console.Write("/");
                Console.SetCursorPosition(size + 8 + i, Yindex + i);
                Console.Write("\\");
            }
            Console.SetCursorPosition(size, Yindex+6);
            for (int i = 0; i < ((size+14)- size); i++)
            {
                Console.SetCursorPosition(size+i, Yindex + 6);
                Console.Write("_");
                if (i== ((size + 14) - size-2))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.SetCursorPosition(size+10, Yindex + 7+j);
                        if (j != 2)
                            Console.Write("|");
                        else
                            Console.Write("*");
                    }
                }
            }
            Console.SetCursorPosition(size + 6, Yindex + 3);
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(size + 5, Yindex + 7+i);
                Console.Write("|  |");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(size + 2+i, Yindex + 17);
                if(i<3||i>6)
                    Console.Write("_");

            }
        }


        static void topTheSofa(int size, int Yindex)
        {
            Console.SetCursorPosition(1, Yindex);
            Console.Write(".-=");
            for (int i = 0; i < size - 6; i++)
            {
                Console.Write('"');
            }
            Console.Write(".-=");
        }


        static void bokiTheSofy(int size, int Yindex)
        {
            int idY = 1;

            for (int j = 0; j < 2; j++)
            {
                if (j > 0)
                {
                    idY = size + 1;
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(idY, i + 1 + Yindex);
                    if (i < 4)
                    {
                        Console.Write("|");
                    }
                    if (i == 4)
                    {
                        if (idY <= 1)
                        {
                            Console.Write(")");
                            Console.SetCursorPosition(idY - 1, i + 1 + Yindex);
                            Console.Write("(");
                            Console.SetCursorPosition(idY, i + 1 + Yindex);
                        }
                        else
                        {
                            Console.Write("(");
                            Console.SetCursorPosition(idY + 1, i + 1 + Yindex);
                            Console.Write(")");
                            Console.SetCursorPosition(idY, i + 1 + Yindex);
                        }
                    }
                    if (i > 4 && i < 9)
                    {
                        Console.Write("|");
                        if (idY > 1)
                            Console.SetCursorPosition(idY + 1, i + 1 + Yindex);
                        else
                            Console.SetCursorPosition(idY - 1, i + 1 + Yindex);
                        Console.Write("|");
                        Console.SetCursorPosition(idY, i + 1 + Yindex);
                    }
                    if (i == 9)
                    {
                        Console.Write("W");

                    }
                }
            }
        }


        static void podusie(int size, int Yindex)
        {
            int start = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(2, start + Yindex);
                for (int j = 0; j < size - 1; j++)
                {
                    Console.Write("_");
                }
                start++;
            }
        }


        static void wypełnienieSofy(int size, int Yindex)
        {

            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < size - 6; j += 4)
                {
                    if (i == 2)
                    {
                        if (j == size - 7)
                        {

                        }
                        else
                        {
                            Console.SetCursorPosition(j + 5, i + Yindex);
                            Console.Write("+");
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(j + 4, i + Yindex);
                        Console.Write("+");
                    }
                }
            }

        }
    }
}
/* 
 ___________________________________________________________________________________________________
  PRZYKŁAD
 ---------------------------------------------------------------------------------------------------
        
    public class Trójkąt
    {
        public int size, kolor;
        public char znak;
        public static void Rysuj(int size, char znak, int kolor)
        {
            if (kolor==1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (kolor ==2)
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

            Console.SetCursorPosition(size, 0);
            Console.WriteLine(znak);
            for (int i = 0; i < size-2; i++)
            {
                Console.SetCursorPosition(size - i,i);
                Console.Write(znak);
                Console.SetCursorPosition(size + i, i);
                Console.Write(znak);

            }
            Console.SetCursorPosition(2, size - 2);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{znak} ");
            }


        }

 */
