using System;
using System.Windows.Forms;

namespace SpeedTools {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
        private void WRF_Click(object sender, EventArgs e) {
            this.Hide();
            var WRF = new WRFinder();
            WRF.Closed += (s, args) => this.Close();
            WRF.Show();
        }
        private void Livesplit_Click(object sender, EventArgs e) {
            this.Hide();
            var Inf = new Livesplit();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();

        }
        private void SRL_Click(object sender, EventArgs e) {
            this.Hide();
            var Inf = new SRL();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();

        }
        private void info_Click(object sender, EventArgs e) {
            this.Hide();
            var Inf = new Info();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();
        }
    }
}
