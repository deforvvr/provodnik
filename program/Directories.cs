using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Norton
{
    public class Directories
    {
        public string curdir { get; set; }

        public string GetDir()
        {
            return Directory.GetCurrentDirectory();
        }

        public void SetDir(string st)
        {
            curdir = st;
            if (Directory.Exists(st))
            {
                Directory.SetCurrentDirectory(st);
            }
            else
            {
                Console.WriteLine("Error 404. Directory not found");
            }
            Directory.SetCurrentDirectory(st);
        }

        public static string ShortDir(string st)
        {
            string newSt = st;
            string[] vs = st.Split('\\');
            if (st.Length > 30 && vs.Length > 3)
            {
                newSt = vs[0] + '\\' + vs[1] + '\\' + vs[2] + "\\...\\" + vs[vs.Length - 1];
            }
            else if (st.Length > 30)
            {
                newSt = st.Substring(0, 29) + '~';
            }

            return newSt;
        }

        public void PrintDir(Directories D)
        {
            string Dir = D.curdir;
            var dir = Directory.GetDirectories(Dir);
            var files = Directory.GetFiles(Dir);

            foreach ( var d in dir)
            {
                Console.WriteLine(d);
            }
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
