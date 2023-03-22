using System;

namespace My_Norton
{
    class Program
    {
        static void Main(string[] args)
        {
            Directories D = new Directories();
            Console.WriteLine(Directories.ShortDir(D.GetDir()));

            string s = Console.ReadLine();
            D.SetDir(s);
            Console.WriteLine(D.GetDir());

            D.PrintDir(D);

            Command.makeDir(D, "Sheeeesh");
        }
    }
}
