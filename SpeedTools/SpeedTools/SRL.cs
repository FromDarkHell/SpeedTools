using System.Windows.Forms;
using System;
namespace SpeedTools {
    public partial class SRL : Form {
        public SRL() {
            InitializeComponent();
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            string gaem = richTextBox1.Text;
            if (gaem == null)
            {
                Browser.Url = new System.Uri("http://speedruntools.com/bingo/generic", System.UriKind.Absolute);
            }
            if (gaem != null)
            {
                if (gaem.Contains("Link to the Past"))
                {
                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/alttp", System.UriKind.Absolute);
                }
                else
                {
                    if (gaem.Contains("Antichamber"))
                    {
                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/antichamber", System.UriKind.Absolute);
                    }
                    else
                    {
                        if (gaem.Contains("Banjo-Tooie"))
                        {
                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/bt", System.UriKind.Absolute);
                        }
                        else
                        {
                            if (gaem.Contains("Bully: SE"))
                            {
                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/bully", System.UriKind.Absolute);
                            }
                            else
                            {
                                if (gaem.Contains("Bully: SE Short"))
                                {
                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/bully-short", System.UriKind.Absolute);
                                }
                                else
                                {
                                    if (gaem.Contains("ET"))
                                    {
                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/et", System.UriKind.Absolute);
                                    }
                                    else
                                    {
                                        if (gaem.Contains("Friday 13th"))
                                        {
                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/ft13", System.UriKind.Absolute);
                                        }
                                        else
                                        {
                                            if (gaem.Contains("HP2"))
                                            {
                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/hp2", System.UriKind.Absolute);
                                            }
                                            else
                                            {
                                                if (gaem.Contains("LEGO Star Wars"))
                                                {
                                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/lego-starwars", System.UriKind.Absolute);
                                                }
                                                else
                                                {
                                                    if (gaem.Contains("Superstar Saga"))
                                                    {
                                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/mlss", System.UriKind.Absolute);
                                                    }
                                                    else
                                                    {
                                                        if (gaem.Contains("Majora's Mask"))
                                                        {
                                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/mm", System.UriKind.Absolute);
                                                        }
                                                        else
                                                        {
                                                            if (gaem.Contains("Metroid Prime"))
                                                            {
                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/mp1", System.UriKind.Absolute);
                                                            }
                                                            else
                                                            {
                                                                if (gaem.Contains("Oblivion"))
                                                                {
                                                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/oblivion", System.UriKind.Absolute);
                                                                }
                                                                else
                                                                {
                                                                    if (gaem.Contains("Pac-World 2"))
                                                                    {
                                                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/pacworld2", System.UriKind.Absolute);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (gaem.Contains("Paper Mario"))
                                                                        {
                                                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/pmario", System.UriKind.Absolute);
                                                                        }
                                                                        else
                                                                        {
                                                                            if (gaem.Contains("TTYD"))
                                                                            {
                                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/ttyd", System.UriKind.Absolute);
                                                                            }
                                                                            else
                                                                            {
                                                                                if (gaem.Contains("Red/Blue"))
                                                                                {
                                                                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/pkmn-redblue", System.UriKind.Absolute);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (gaem.Contains("Ruby/Sapphire"))
                                                                                    {
                                                                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/pkmn-rubysapphire", System.UriKind.Absolute);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (gaem.Contains("Snap"))
                                                                                        {
                                                                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/pkmn-snap", System.UriKind.Absolute);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (gaem.Contains("Rayman 3"))
                                                                                            {
                                                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/rayman3", System.UriKind.Absolute);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (gaem.Contains("SHAR"))
                                                                                                {
                                                                                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/simpsons-hr", System.UriKind.Absolute);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (gaem.Contains("Sonic R"))
                                                                                                    {
                                                                                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/sonicr", System.UriKind.Absolute);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (gaem.Contains("SA2B"))
                                                                                                        {
                                                                                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/sab2", System.UriKind.Absolute);
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (gaem.Contains("SM64"))
                                                                                                            {
                                                                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/sm64", System.UriKind.Absolute);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (gaem.Contains("Symphonia"))
                                                                                                                {
                                                                                                                    Browser.Url = new System.Uri("http://speedruntools.com/bingo/tos", System.UriKind.Absolute);
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (gaem.Contains("Talos"))
                                                                                                                    {
                                                                                                                        Browser.Url = new System.Uri("http://speedruntools.com/bingo/talos", System.UriKind.Absolute);
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (gaem.Contains("Ty"))
                                                                                                                        {
                                                                                                                            Browser.Url = new System.Uri("http://speedruntools.com/bingo/ty", System.UriKind.Absolute);
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (gaem.Contains("Warframe"))
                                                                                                                            {
                                                                                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/warframe", System.UriKind.Absolute);
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                Browser.Url = new System.Uri("http://speedruntools.com/bingo/wl4", System.UriKind.Absolute);
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                button2.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
                string url = Browser.Url.ToString();
                if (url != null)
                {
                    MessageBox.Show(url + " is the URL");
                    Clipboard.SetDataObject(url, true);
                }
            }
        private void SRL_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            var Inf = new Main();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();
        }
    }
    }