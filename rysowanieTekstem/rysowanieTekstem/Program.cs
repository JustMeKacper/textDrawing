using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rysowanieTekstem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pomoc1;
            int rozmiar = 1, kolor;
            char pomoc, sofaAdd1 = 'n', sofaAdd2 = 'n', continueProgram, pociagStrachu = 'N';
            do
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Podaj kształt do wyświetlenia");
                    Console.WriteLine("1 - Sofa, \n2 - Lodówka,\n3 - Pociąg");
                    pomoc = Console.ReadKey().KeyChar;
                    if (pomoc == '1' || pomoc == '2' || pomoc == '3')
                        break;
                    else
                    {
                        Console.WriteLine("\nWpisz prosze 1, 2 lub 3.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Podaj kolor krztałtu:\n1 - Niebiecki\n2 - Czerwony\n3 - Zielony");
                    pomoc1 = Console.ReadLine();
                    if (pomoc1 == "")
                    {
                        pomoc1 = "4";
                        kolor = int.Parse(pomoc1);
                    }
                    else
                        try
                        {
                            kolor = int.Parse(pomoc1);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nWpisujesz cokolwiek tylko nie cyfrę... Wstyd!");
                            continue;
                        }
                    break;
                }
                if (pomoc == '1')
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ilu osobowa? (2 do 4)");
                            rozmiar = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAle ciężko wpisać to o co się prosi?. Chyba widzisz na klawiaturze 2, 3 lub 4...");
                            continue;
                        }
                    } while (rozmiar < 2 || rozmiar > 4);
                    Console.WriteLine("Lampka do tego? (T - tak, N - nie)");
                    sofaAdd1 = Char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine("\nA może komodę żeby było wygodniej? (T - tak, N - nie)");
                    sofaAdd2 = Char.ToLower(Console.ReadKey().KeyChar);
                }
                else if (pomoc == '2')
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("1. Samotna, 2. W kuchni.");
                            rozmiar = int.Parse(Console.ReadLine().ToString());
                            if (rozmiar == 1 || rozmiar == 2)
                                break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wpisz czy chcesz lodówkę która jest smutna czy szczęśliwa.");
                            continue;
                        }
                    }

                }
                else if (pomoc == '3')
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Chcesz zobaczyć tragedię z Los Santos? (T - Tak, N - Nie)");
                            pociagStrachu = Char.ToUpper(Console.ReadKey().KeyChar);
                            if (pociagStrachu != 'T' && pociagStrachu != 'N')
                            {
                                Console.WriteLine("\nTak lub nie. Nie ma innej opcji...");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Tak lub nie. Nie ma innej opcji...");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("?");
                }

                Console.Clear();
                if (pomoc == '1')
                    sofa.Rysuj(rozmiar * 20, kolor, sofaAdd1, sofaAdd2);
                else if (pomoc == '2')
                    Lodówka.Rysuj(kolor, rozmiar);
                else if (pomoc == '3')
                    ciapong.pokazPedolino(kolor, 5, pociagStrachu);
                if (pomoc == '1' || pomoc == '2')
                    Console.SetCursorPosition(0, 0);
                else
                    Console.SetCursorPosition(0, 29);
                Console.Write("Czy chcesz wykonać program ponownie? Wciśnij \"T\" jeśli tak!");
                continueProgram = Console.ReadKey().KeyChar;
            } while (continueProgram == 't');
        }
    }
}
