using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SppLauncher.Windows.Launcher
{
    class ExpSelector
    {
        public static void ExpSelected()
        {
            var lines = File.ReadAllLines("../ClassicFile.txt");
            Console.WriteLine(lines);
        }
    }
}
