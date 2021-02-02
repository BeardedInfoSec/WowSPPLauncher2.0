using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SppLauncher.Windows.Launcher
{
    public partial class ServerSelector : Form
    {
        public ServerSelector()
        {
            InitializeComponent();
        }
        

        private void ClassicBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ServerConfig.PlayClassic();
        }

        private void TbcBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ServerConfig.PlayTBC();
        }

        private void WotlkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ServerConfig.PlayWoTLK();
        }
    }
}
