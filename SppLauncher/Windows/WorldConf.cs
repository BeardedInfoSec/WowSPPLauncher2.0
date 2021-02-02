using System;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class WorldConf : Form
    {
        readonly IniFileClass MyIni = new IniFileClass("SPP_Classics_V2\\SPP_Server\\Settings\\vanilla\\Mangosd.CONF");


        public WorldConf(string Expansion)
        {
            InitializeComponent();

            if (Expansion == "classic")
            {
                MyIni = new IniFileClass("SPP_Classics_V2\\SPP_Server\\Settings\\vanilla\\mangosd.CONF");
                ReadiniClassic();
            }
            if (Expansion == "tbc")
            {
                MyIni = new IniFileClass("SPP_Classics_V2\\SPP_Server\\Settings\\tbc\\mangosd.CONF");
                Readinitbc();
            }
            if (Expansion == "wotlk")
            {
                MyIni = new IniFileClass("SPP_Classics_V2\\SPP_Server\\Settings\\wotlk\\mangosd.CONF");
                Readiniwotlk();
            }

            //143

        }


        public void ReadiniClassic()
        {
            
            switch (MyIni.Read("mangosd.CONF", "AllFlightPaths"))
            {
                case "1":
                    cbPaths.Text = "Enabled";
                    break;
                case "0":
                    cbPaths.Text = "Disabled";
                    break;
            }

            txbLevel.Text       = MyIni.Read("MangosConf", "StartPlayerLevel");
            txbMoney.Text       = MyIni.Read("MangosConf", "StartPlayerMoney");
            txbHonor.Text       = MyIni.Read("MangosConf", "StartHonorPoints");
            txbArena.Text       = MyIni.Read("MangosConf", "StartArenaPoints");
            txbPoor.Text        = MyIni.Read("MangosConf", "Rate.Drop.Item.Poor");
            txbNormal.Text      = MyIni.Read("MangosConf", "Rate.Drop.Item.Normal");
            txbUncommon.Text    = MyIni.Read("MangosConf", "Rate.Drop.Item.Uncommon");
            txbRare.Text        = MyIni.Read("MangosConf", "Rate.Drop.Item.Rare");
            txbEpic.Text        = MyIni.Read("MangosConf", "Rate.Drop.Item.Epic");
            txbLegendary.Text   = MyIni.Read("MangosConf", "Rate.Drop.Item.Legendary");
            txbArtifact.Text    = MyIni.Read("MangosConf", "Rate.Drop.Item.Artifact");
            txbReferenced.Text  = MyIni.Read("MangosConf", "Rate.Drop.Item.Referenced");
            txbMoneyRate.Text   = MyIni.Read("MangosConf", "Rate.Drop.Money");
            txbKillRate.Text    = MyIni.Read("MangosConf", "Rate.XP.Kill");
            txbQuestRate.Text   = MyIni.Read("MangosConf", "Rate.XP.Quest");
            txbExploreRate.Text = MyIni.Read("MangosConf", "Rate.XP.Explore");
            txbHonorRate.Text   = MyIni.Read("MangosConf", "Rate.Honor");
            txbTalentRate.Text  = MyIni.Read("MangosConf", "Rate.Talent");


           
        }

        public void Readinitbc()
        {

            switch (MyIni.Read("mangosd.CONF", "AllFlightPaths"))
            {
                case "1":
                    cbPaths.Text = "Enabled";
                    break;
                case "0":
                    cbPaths.Text = "Disabled";
                    break;
            }

            txbLevel.Text = MyIni.Read("MangosConf", "StartPlayerLevel");
            txbMoney.Text = MyIni.Read("MangosConf", "StartPlayerMoney");
            txbHonor.Text = MyIni.Read("MangosConf", "StartHonorPoints");
            txbArena.Text = MyIni.Read("MangosConf", "StartArenaPoints");
            txbPoor.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Poor");
            txbNormal.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Normal");
            txbUncommon.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Uncommon");
            txbRare.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Rare");
            txbEpic.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Epic");
            txbLegendary.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Legendary");
            txbArtifact.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Artifact");
            txbReferenced.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Referenced");
            txbMoneyRate.Text = MyIni.Read("MangosConf", "Rate.Drop.Money");
            txbKillRate.Text = MyIni.Read("MangosConf", "Rate.XP.Kill");
            txbQuestRate.Text = MyIni.Read("MangosConf", "Rate.XP.Quest");
            txbExploreRate.Text = MyIni.Read("MangosConf", "Rate.XP.Explore");
            txbHonorRate.Text = MyIni.Read("MangosConf", "Rate.Honor");
            txbTalentRate.Text = MyIni.Read("MangosConf", "Rate.Talent");



        }

        public void Readiniwotlk()
        {

            switch (MyIni.Read("mangosd.CONF", "AllFlightPaths"))
            {
                case "1":
                    cbPaths.Text = "Enabled";
                    break;
                case "0":
                    cbPaths.Text = "Disabled";
                    break;
            }

            txbLevel.Text = MyIni.Read("MangosConf", "StartPlayerLevel");
            txbMoney.Text = MyIni.Read("MangosConf", "StartPlayerMoney");
            txbHonor.Text = MyIni.Read("MangosConf", "StartHonorPoints");
            txbArena.Text = MyIni.Read("MangosConf", "StartArenaPoints");
            txbPoor.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Poor");
            txbNormal.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Normal");
            txbUncommon.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Uncommon");
            txbRare.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Rare");
            txbEpic.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Epic");
            txbLegendary.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Legendary");
            txbArtifact.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Artifact");
            txbReferenced.Text = MyIni.Read("MangosConf", "Rate.Drop.Item.Referenced");
            txbMoneyRate.Text = MyIni.Read("MangosConf", "Rate.Drop.Money");
            txbKillRate.Text = MyIni.Read("MangosConf", "Rate.XP.Kill");
            txbQuestRate.Text = MyIni.Read("MangosConf", "Rate.XP.Quest");
            txbExploreRate.Text = MyIni.Read("MangosConf", "Rate.XP.Explore");
            txbHonorRate.Text = MyIni.Read("MangosConf", "Rate.Honor");
            txbTalentRate.Text = MyIni.Read("MangosConf", "Rate.Talent");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyIni.Write("MangosConf", "StartPlayerLevel", " " + txbLevel.Text);
                MyIni.Write("MangosConf", "StartPlayerMoney", " " + txbMoney.Text);
                MyIni.Write("MangosConf", "StartHonorPoints", " " + txbHonor.Text);
                MyIni.Write("MangosConf", "StartArenaPoints", " " + txbArena.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Poor", " " + txbPoor.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Normal", " " + txbNormal.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Uncommon", " " + txbUncommon.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Rare", " " + txbRare.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Legendary", " " + txbLegendary.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Artifact", " " + txbArtifact.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Referenced", " " + txbReferenced.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Item.Epic", " " + txbEpic.Text);
                MyIni.Write("MangosConf", "Rate.Drop.Money", " " + txbMoneyRate.Text);
                MyIni.Write("MangosConf", "Rate.XP.Kill", " " + txbKillRate.Text);
                MyIni.Write("MangosConf", "Rate.XP.Quest", " " + txbQuestRate.Text);
                MyIni.Write("MangosConf", "Rate.XP.Explore", " " + txbExploreRate.Text);
                MyIni.Write("MangosConf", "Rate.Honor", " " + txbHonorRate.Text);
                MyIni.Write("MangosConf", "Rate.Talent", " " + txbTalentRate.Text);
                
                switch (cbPaths.Text)
                {
                    case "Enabled":
                        MyIni.Write("MangosConf", "AllFlightPaths", " " + "1");
                        break;
                    case "Disabled":
                        MyIni.Write("MangosConf", "AllFlightPaths", " " + "0");
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("Some exception: write", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            MessageBox.Show("World Settings Saved.\nThe changes to take effect, server restart requiered.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txbLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void WorldConf_Load(object sender, EventArgs e)
        {

        }
    }
}
