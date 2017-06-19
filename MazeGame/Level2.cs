namespace MazeGame
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Level2 : Form
    {
        int sec;
        int lifes;
        public Level2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Level2_KeyDown);

        }
        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = StudentHero.Location.X;
            int y = StudentHero.Location.Y;

            if (e.KeyCode == Keys.Right) x += 15;
            else if (e.KeyCode == Keys.Left) x -= 15;
            else if (e.KeyCode == Keys.Up) y -= 15;
            else if (e.KeyCode == Keys.Down) y += 15;

            StudentHero.Location = new Point(x, y);

            if (StudentHero.Bounds.IntersectsWith(pictureBox1.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox2.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox3.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox5.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox6.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox7.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox8.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox9.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox10.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox11.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox12.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox13.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox15.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox16.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox17.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox18.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox19.Bounds) ||
                StudentHero.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                StudentHero.Left = 95;
                StudentHero.Top = 50;
                lifes -= 1;
                LifesLabel.Text = lifes.ToString();
            }
            if (StudentHero.Bounds.IntersectsWith(FinishLabel.Bounds))
            {
                this.Hide();
                var Level2 = new Level2();
                Level2.Closed += (s, args) => this.Close();
                Level2.Show();
            }

            if (lifes == 0)
            {
                this.Hide();
                var GameOver = new GameOver();
                GameOver.Closed += (s, args) => this.Close();
                GameOver.Show();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sec = 15;
            lifes = 3;
            LifesLabel.Text = lifes.ToString();
            SecLabel.Text = sec.ToString();
        }
    }
}
