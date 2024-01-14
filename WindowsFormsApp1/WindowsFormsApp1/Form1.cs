using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int diceFace1;
        private int diceFace2;
        private Timer diceRollTimer = new Timer();
        private int total;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbFormSize.Text = "";
            lbFormSize.Text = "กว้าง" + this.Size.Width + "ยาว" + this.Size.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 1500;
            this.Height = 1000;
            lbFormSize.Text = "กว้าง" + this.Size.Width + "ยาว" + this.Size.Height;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void เต๋า1_Click(object sender, EventArgs e)
        {

        }

        private void เต๋า2_Click(object sender, EventArgs e)
        {

        }

        private void หมุน_MouseHover(object sender, EventArgs e)
        {
           // diceRollTimer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            diceRollTimer.Interval = 100; 
            diceRollTimer.Tick += new EventHandler(DiceRollTimer_Tick);
            diceRollTimer.Start();
            diceRollTimer.Stop();
        }

        private void DiceRollTimer_Tick(object sender, EventArgs e)
        {
            diceFace1 = rnd.Next(1, 7);
            SetDiceImage(เต๋า1, diceFace1);
            diceFace2 = rnd.Next(1, 7);
            SetDiceImage(เต๋า2, diceFace2);
            
        }

        private void หมุน_MouseLeave(object sender, EventArgs e)
        {
            //diceRollTimer.Stop();
        }

        private void SetDiceImage(PictureBox pictureBox, int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice1;
                    break;
                case 2:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice2;
                    break;
                case 3:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice3;
                    break;
                case 4:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice4;
                    break;
                case 5:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice5;
                    break;
                case 6:
                    pictureBox.Image = WindowsFormsApp1.Properties.Resources.dice6;
                    break;
            }
        }

        private void หมุน_MouseDown(object sender, MouseEventArgs e)
        {
            diceRollTimer.Start();
        }

        private void หมุน_MouseUp(object sender, MouseEventArgs e)
        {
            diceRollTimer.Stop();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Natta\OneDrive\Desktop\Y2meta.app - Clapping Sound Effects (320 kbps).wav");
            player.Play();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            total = diceFace1 + diceFace2;
            แสดงผลลูกตัวรวม.Text = "ลูกตัวรวม: " + total.ToString();
        }
    }
}

