using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace My_Norton
{
    public class Interface
    {
        public static void Print(int x, int y, string s, ConsoleColor fg = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = fg;
            Console.Write(s);
        }
        public static void Print1(int x, int y, string s, ConsoleColor bg = ConsoleColor.Cyan, ConsoleColor fg1 = ConsoleColor.Black)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = fg1;
            Console.BackgroundColor = bg;
            Console.Write(s);
        }

        // ConsoleColor bg = ConsoleColor.Cyan, ConsoleColor fg1 = ConsoleColor.Black
        //   clck.ru/ZRExx - страничка с символами

        public static void MainWindow()
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 28;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Print(0, 0, "╔");
            for (int i = 1; i < 79; i++)
            {
                Print(i, 0, "═");
                Print(i, 23, "─");
                Print(i, 25, "═");
            }
            Print(79, 0, "╗");

            for (int i = 1; i < 25; i++)
            {
                Print(0, i, "║");
                Print(79, i, "║");
                Print(39, i, "║");
                Print(40, i, "║");


            }
            Print(0, 25, "╚");
            Print(79, 25, "╝");

            for (int i = 1; i < 23; i++)
            {
                Print(13, i, "│");
                Print(26, i, "│");
                Print(53, i, "│");
                Print(66, i, "│");
            }
            for (int i = 1; i < 79; i++)
            {
                Print(i, 23, "─");
            }

            Print(13, 23, "┴");
            Print(26, 23, "┴");
            Print(53, 23, "┴");
            Print(66, 23, "┴");
            Print(39, 23, "║");
            Print(40, 23, "║");
            Print(13, 0, "╤");
            Print(26, 0, "╤");
            Print(53, 0, "╤");
            Print(66, 0, "╤");
            Print(39, 0, "╗");
            Print(40, 0, "╔");
            Print(40, 25, "╚");
            Print(39, 25, "╝");
            Print(0, 23, "╟");
            Print(40, 23, "╟");
            Print(79, 23, "╢");
            Print(39, 23, "╢");
            Print(5, 1, "Name");
            Print(18, 1, "Name");
            Print(31, 1, "Name");
            Print(45, 1, "Name");
            Print(58, 1, "Name");
            Print(71, 1, "Name");
            Print(0, 27, "1");
            Print1(1, 27, "Help  ");
            Print(8, 27, "2");
            Print1(9, 27, "      ");
            Print(16, 27, "3");
            Print1(17, 27, "      ");
            Print(24, 27, "4");
            Print1(25, 27, "      ");
            Print(32, 27, "5");
            Print1(33, 27, "      ");
            Print(40, 27, "6");
            Print1(41, 27, "      ");
            Print(48, 27, "7");
            Print1(49, 27, "      ");
            Print(56, 27, "8");
            Print1(57, 27, "      ") ;
            Print(64, 27, "9");
            Print1(65, 27, "      ");
            Print(72, 27, "10");
            Print1(74, 27, "Quit  ");

            //Print(16, 0, Console.WriteLine(Directories.ShortDir(D.GetDir())));
            Directories D = new Directories();
            Print(5, 0, Directories.ShortDir(D.GetDir()));


            bool pr = true;
            int a;
            while (pr)
            {
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 10: break;
                }
                
            }
        }
    }
}
