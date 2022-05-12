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
    public partial class Form1 : Form
    {
        int speed;
        int score;
        Random rand = new Random();
        bool gameover = false;
        WMPLib.WindowsMediaPlayer play1 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer play2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer play3 = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            restart();
            play1.URL = "bomb.mp3";
            play2.URL = "balloon.mp3";
            play3.URL = "game.mp3";
        }
        //Sự kiện click bóng
        private void blue_Click(object sender, EventArgs e)
        {
            play2.controls.play();
            if (gameover == false)
            {
                blue.Top = rand.Next(700, 1000);
                blue.Left = rand.Next(5, 550);
                score++;
            }
        }
        private void purple_Click(object sender, EventArgs e)
        {
            play2.controls.play();
            if (gameover == false)
            {
                purple.Top = rand.Next(700, 1000);
                purple.Left = rand.Next(5, 550);
                score++;
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            play2.controls.play();
            if (gameover == false)
            {
                red.Top = rand.Next(700, 1000);
                red.Left = rand.Next(5, 550);
                score++;
            }
        }

        private void green_Click(object sender, EventArgs e)
        {
            play2.controls.play();
            if (gameover == false)
            {
                green.Top = rand.Next(700, 1000);
                green.Left = rand.Next(5, 550);
                score++;
            }
        }
        //Sự kiện click bom
        private void bom_Click(object sender, EventArgs e)
        {
            play1.controls.play();
            if (gameover == false)
            {
                timer1.Stop();
                bom.Image = Properties.Resources.bomm_removebg_preview;
                MessageBox.Show("Score: " + score, "Game Over", MessageBoxButtons.OK,MessageBoxIcon.None);
                label3.Text = "       Game Over!\nPress Enter to restart";
                gameover = true;
            }
        }
        private void bom1_Click(object sender, EventArgs e)
        {
            play1.controls.play();
            if (gameover == false)
            {
                timer1.Stop();
                bom1.Image = Properties.Resources.bomm_removebg_preview;
                MessageBox.Show("Score: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                label3.Text = "       Game Over!\nPress Enter to restart";
                gameover = true;
            }
        }
        //Picturebox di chuyển
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = "Score :" + score;
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top -= speed;
                    if (X.Top < -100)
                    {
                        X.Top = rand.Next(700, 1000);
                        X.Left = rand.Next(5, 550);
                    }
                    // Kiểm tra 2 bóng chèn nhau 
                    //bom_balloon
                    if (bom.Bounds.IntersectsWith(red.Bounds))
                    {
                        bom.Top = rand.Next(700, 1000);
                        bom.Left = rand.Next(5, 550);
                    }
                    if (bom.Bounds.IntersectsWith(blue.Bounds))
                    {
                        bom.Top = rand.Next(700, 1000);
                        bom.Left = rand.Next(5, 550);
                    }
                    if (bom.Bounds.IntersectsWith(purple.Bounds))
                    {
                        bom.Top = rand.Next(700, 1000);
                        bom.Left = rand.Next(5, 550);
                    }
                    if (bom.Bounds.IntersectsWith(green.Bounds))
                    {
                        bom.Top = rand.Next(700, 1000);
                        bom.Left = rand.Next(5, 550);
                    }
                    if (bom.Bounds.IntersectsWith(bom1.Bounds))
                    {
                        bom.Top = rand.Next(700, 1000);
                        bom.Left = rand.Next(5, 550);
                    }
                    //bom1_balloon
                    if (bom1.Bounds.IntersectsWith(red.Bounds))
                    {
                        bom1.Top = rand.Next(700, 1000);
                        bom1.Left = rand.Next(5, 550);
                    }
                    if (bom1.Bounds.IntersectsWith(blue.Bounds))
                    {
                        bom1.Top = rand.Next(700, 1000);
                        bom1.Left = rand.Next(5, 550);
                    }
                    if (bom1.Bounds.IntersectsWith(purple.Bounds))
                    {
                        bom1.Top = rand.Next(700, 1000);
                        bom1.Left = rand.Next(5, 550);
                    }
                    if (bom1.Bounds.IntersectsWith(green.Bounds))
                    {
                        bom1.Top = rand.Next(700, 1000);
                        bom1.Left = rand.Next(5, 550);
                    }
                    //red_balloon
                    if (red.Bounds.IntersectsWith(purple.Bounds))
                    {
                        red.Top = rand.Next(700, 1000);
                        red.Left = rand.Next(5, 550);
                    }
                    if (red.Bounds.IntersectsWith(blue.Bounds))
                    {
                        red.Top = rand.Next(700, 1000);
                        red.Left = rand.Next(5, 550);
                    }
                    if (red.Bounds.IntersectsWith(green.Bounds))
                    {
                        red.Top = rand.Next(700, 1000);
                        red.Left = rand.Next(5, 550);
                    }
                    //purple_balloon
                    if (purple.Bounds.IntersectsWith(green.Bounds))
                    {
                        purple.Top = rand.Next(700, 1000);
                        purple.Left = rand.Next(5, 550);
                    }
                    if (purple.Bounds.IntersectsWith(blue.Bounds))
                    {
                        purple.Top = rand.Next(700, 1000);
                        purple.Left = rand.Next(5, 550);
                    }
                    //green_balloon
                    if (green.Bounds.IntersectsWith(blue.Bounds))
                    {
                        green.Top = rand.Next(700, 1000);
                        green.Left = rand.Next(5, 550);
                    }
                }
            }
            if (score >= 15)
            {
                speed = 7;
            }
            if (score >= 30)
            {
                speed = 9;
            }
            if (score >= 55)
            {
                speed = 11;
            }
            if (score >= 70)
            {
                speed = 13;
            }
            if (score >= 85)
            {
                speed = 15;
            }
        }
        //Chơi lại game
        private void restart()
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    X.Top = rand.Next(700, 1000);
                    X.Left = rand.Next(5, 550);
                }
            }
            bom.Image = Properties.Resources.bom_smile_removebg_preview;
            bom1.Image = Properties.Resources.bom_smile_removebg_preview;
            speed = 5;
            score = 0;
            gameover = false;
            label3.Text = "";
            label1.Text = "Score :" + score;
            timer1.Start();
            play3.controls.play();
        }
        //nhấn Enter thì gọi hàm chơi lại
        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameover == true)
            {
                restart();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            play3.controls.play();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
            play3.close();
        }

        
    }
}
