using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace SppLauncher.Windows.Launcher
{
    public class ServerConfig
    {
        public enum ExpansionType
        {
            Classic,
            TBC,
            WOTLK
        }

        private static ExpansionType expansion;
        public static void PlayClassic()
        {
            Expansion = ExpansionType.Classic;
            LaunchGame(Expansion);
        }

        public static void PlayTBC()
        {
            Expansion = ExpansionType.TBC;
            LaunchGame(Expansion);
        }

        public static void PlayWoTLK()
        {
            Expansion = ExpansionType.WOTLK;
            LaunchGame(Expansion);
        }

        public static void LaunchGame(ExpansionType expansion)
        {
            Launcher lan2 = new Launcher();
            lan2.ExpansionSelection(expansion);
            MessageBox.Show("Launch Game for " + expansion.ToString());
            lan2.ShowDialog();
        }

        public static ExpansionType Expansion
        {
            get
            {
                return expansion;
            }
            set
            {
                expansion = value;
            }
        }
    }
}
