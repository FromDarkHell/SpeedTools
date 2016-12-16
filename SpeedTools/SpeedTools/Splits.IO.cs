using System;
using System.Windows.Forms;
namespace SpeedTools {
    public partial class Splits : Form {
        public Splits() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            Browsie.Url = new Uri("http://splits.io/upload", UriKind.Absolute);
        }
        private void button2_Click(object sender, EventArgs e) {
            Browsie.Url = new Uri("http://splits.io/games", UriKind.Absolute);
        }
    }
}
