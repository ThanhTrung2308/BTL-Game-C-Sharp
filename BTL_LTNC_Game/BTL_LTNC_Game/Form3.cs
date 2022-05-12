using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTNC_Game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int score = 0;
        int sp = 1;
        Random ran = new Random();
        bool mLeft, mRight, shot, checkGameOver, pause = false;


        private void Form3_Load(object sender, EventArgs e)
        {
            ballonChange(pictureBox3);
            ballonChange(pictureBox4);
            ballonChange(pictureBox5);
            ballonChange(pictureBox6);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = score.ToString();

            pictureBox3.Top += sp;
            pictureBox4.Top += sp;
            pictureBox5.Top += sp;
            pictureBox6.Top += sp;


            if (mRight == true && planes.Left < this.Width - 75)
            {
                planes.Left += (sp + 10);
            }

            if (mLeft == true && planes.Left > 0)
            {
                planes.Left -= (sp + 10);
            }

            foreach (Control X in this.Controls)
            {

                if (X is PictureBox && X.Tag == "bullet")
                {
                    X.Top -= (sp + 12);

                    if (X.Top < 10)
                    {
                        RemoveBullet((PictureBox)X);
                    }

                    if (X.Bounds.IntersectsWith(pictureBox3.Bounds))
                    {
                        score += 1;
                        RemoveBullet((PictureBox)X);
                        ballonChange(pictureBox3);
                    }

                    if (X.Bounds.IntersectsWith(pictureBox4.Bounds))
                    {
                        score += 1;
                        RemoveBullet((PictureBox)X);
                        ballonChange(pictureBox4);
                    }

                    if (X.Bounds.IntersectsWith(pictureBox5.Bounds))
                    {
                        score += 1;
                        RemoveBullet((PictureBox)X);
                        ballonChange(pictureBox5);
                    }

                    if (X.Bounds.IntersectsWith(pictureBox6.Bounds))
                    {
                        score += 1;
                        RemoveBullet((PictureBox)X);
                        ballonChange(pictureBox6);
                    }
                }
            }

            if (pictureBox3.Bounds.IntersectsWith(planes.Bounds) || pictureBox4.Bounds.IntersectsWith(planes.Bounds) || pictureBox5.Bounds.IntersectsWith(planes.Bounds) || pictureBox6.Bounds.IntersectsWith(planes.Bounds))
            {
                gameOver();
            }

            if (pictureBox3.Top > this.Height || pictureBox4.Top > this.Height || pictureBox5.Top > this.Height || pictureBox6.Top > this.Height)
            {
                gameOver();
            }

            levelUp();
        }



        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && shot == false)
            {
                makeBullet();
                shot = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                mRight = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                mLeft = true;
            }
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && shot == true)
            {
                shot = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                mRight = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                mLeft = false;
            }

            if (e.KeyCode == Keys.Space && checkGameOver == true)
            { resetGame(); }

            if (e.KeyCode == Keys.Escape && pause == false && checkGameOver == false)
            {
                timer1.Stop();
                pause = true;
                label2.Text = "Pause!";
            }
            else if (e.KeyCode == Keys.Escape && pause == true)
            {
                timer1.Start();
                label2.Text = null;
                pause = false;
            }


        }

        private void gameOver()
        {
            timer1.Stop();
            MessageBox.Show("Game Over" + '\n' + "Diem: " + score.ToString());
            label2.Text = "Press Space to try again";
            checkGameOver = true;

        }

        private void resetGame()
        {
            score = 0;
            sp = 1;
            timer1.Start();
            mLeft = false;
            mRight = false;
            shot = false;
            checkGameOver = false;
            ballonChange(pictureBox6);
            ballonChange(pictureBox3);
            ballonChange(pictureBox4);
            ballonChange(pictureBox5);
            label1.Text = score.ToString();
            label2.Text = null;

        }

        public void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Transparent;
            bullet.Height = 30;
            bullet.Width = 10;
            bullet.Location = new Point(planes.Location.X + 23, planes.Location.Y - 28);
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
            bullet.Image = BTL_LTNC_Game.Properties.Resources.gold_bullet_png_images_download_7_116185712220iwefhwhxn;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void ballonChange(PictureBox pb)
        {
            pb.Top = ran.Next(-70, -45);
            pb.Left = ran.Next(0, this.Width - 55);
        }

        private void levelUp()
        {
            if (score > 5 && score < 10)
            {
                sp = 2;

            }

            if (score > 20 && score < 25)
            {
                sp = 3;

            }

            if (score > 30 && score < 35)
            {
                sp = 4;
            }

            if (score > 40 && score < 45)
            {
                sp = 5;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
