using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Level2 : Form
    {
        int sec;
        int lifes;
        public Level2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown);

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox21.Location.X;
            int y = pictureBox21.Location.Y;

            if (e.KeyCode == Keys.Right) x += 1;
            else if (e.KeyCode == Keys.Left) x -= 1;
            else if (e.KeyCode == Keys.Up) y -= 1;
            else if (e.KeyCode == Keys.Down) y += 1;

            pictureBox21.Location = new Point(x, y);

            if (pictureBox21.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox9.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox10.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox12.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox15.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox16.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox17.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox18.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox19.Bounds) ||
                pictureBox21.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                pictureBox21.Left = 95;
                pictureBox21.Top = 50;
                lifes -= 1;
                label3.Text = lifes.ToString();
            }
            if (lifes == 0)
            {
                this.Hide();
                var GameOver = new GameOver();
                GameOver.Closed += (s, args) => this.Close();
                GameOver.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sec = 15;
            lifes = 3;
            label3.Text = lifes.ToString();
            label4.Text = sec.ToString();
        }
    }
}
