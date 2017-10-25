using System;
using System.Windows.Forms;

namespace FightClub
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                FormFightClub game = new FormFightClub(tbName.Text);

                Hide();
                game.Show();
            }
            else
            {
                MessageBox.Show("Please, enter your name");
            }
        }
    }
}
