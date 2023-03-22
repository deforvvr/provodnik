using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace My_Norton
{
    public class Command
    {
        public static void makeDir(Directories D, string NameDir)
        {
            var st = D.curdir + '\\' + NameDir;
            if (Directory.Exists(st))
            {
                Console.WriteLine("Already exist");
            }
            else if (NameDir== "") 
            {
                Console.WriteLine("Uncorrect name");
            }
            else
            {
                Directory.CreateDirectory(st);
            }
        }
    }
}
