using System.Windows.Forms;
using SpeedrunComSharp;
using System.Linq;
namespace SpeedTools {
    public partial class WRFinder : Form {
        public WRFinder() { 
            InitializeComponent();
        }
        private void WRButton_Click(object sender, System.EventArgs e) {
            string gamenaem = _game.Text;
            string cat = _cat.Text;
            // Creating Client
            var client = new SpeedrunComClient();
            //Searching for game
            var game = client.Games.SearchGame(name: gamenaem);
            #region Null
            if (string.IsNullOrEmpty(cat) == true) {
                // Searching for category
                var cate = game.Categories.First(category => category.Name == "Any%");
                // Finding WR for game
                var WR = cate.WorldRecord;
                // Writing WR Info
                _WR.Text = ("The World Record is " + WR.Times.Primary + "\n" + " by " + WR.Player.Name + " on the" + WR.Platform + "\n" + " submitted on" + WR.DateSubmitted);
                #endregion
                #region Not Null
            }
            else {
            // Searching for category
            var cate = game.Categories.First(category => category.Name == (cat));
                // Finding WR for game
                var WR = cate.WorldRecord;
                // Writing WR Info
                _WR.Text = ("The World Record is " + WR.Times.Primary + "\n" + " by " + WR.Player.Name + " on the" + WR.Platform + "\n" + " submitted on" + WR.DateSubmitted);
            }
            #endregion
        }
        private void back_Click(object sender, System.EventArgs e) {
            this.Hide();
            var Inf = new Main();
            Inf.Closed += (s, args) => this.Close();
            Inf.Show();
        }
    }
}
