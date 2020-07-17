using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public partial class WelcomeForm : Form
    {
        SLGame game;
        public WelcomeForm()
        {
            InitializeComponent();
            game = new SLGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerOneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            game.PlayerOneGameLabel.Text = this.PlayerOneTB.Text;
            game.PlayerTwoGameLabel.Text = this.PlayerTwoTB.Text;
            game.Show();
            this.Hide();
        }
    }
}
