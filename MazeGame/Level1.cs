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
    public partial class Level1 : Form
    {
        int sec;
        int lifes;
        public Level1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right) x += 10;
            else if (e.KeyCode == Keys.Left) x -= 10;
            else if (e.KeyCode == Keys.Up) y -= 10;
            else if (e.KeyCode == Keys.Down) y += 10;

            pictureBox1.Location = new Point(x, y);

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox10.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox12.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                pictureBox1.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox1.Left = 95;
                pictureBox1.Top = 50;
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

        public void Form1_Load(object sender, EventArgs e)
        {
            sec = 15;
            lifes = 3;
            label3.Text = lifes.ToString();
            label4.Text = sec.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
