using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Program Created by Maya Redford-Haines

namespace final
{
    public partial class Final : Form
    {
        Random randGen = new Random();

        int playerhp = 150;
        int rivalhp = 150;
        int playeratk = 10;
        int rivalatk = 10;
        int accuracy;
        int critical;
        int playerbasehp = 150;
        public Final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //graphics
            Graphics g = rivalHealthLabel.CreateGraphics();
            Pen drawPen = new Pen(Color.LightGreen, 10);
            SolidBrush drawBrush = new SolidBrush(Color.LightGreen);
            Graphics g2 = userHealthLabel.CreateGraphics();

            //random
            accuracy = randGen.Next(1, 101);
            critical = randGen.Next(1, 17);

            //Player's Values

            if (accuracy <= 95)
            {
                outputLabel.Text = "";
                rivalhp -= playeratk;

                if (critical == 1)
                {
                    rivalhp -= (int)(playeratk * 1.5);
                    outputLabel.Text = "A critical hit!";
                }
            }
            if (accuracy > 95)
            {
                outputLabel.Text = "Your attack missed!";
            }

            if (playerhp <= 0)
            {
                outputLabel.Text = "Game Over";
            }
            if (rivalhp <= 0)
            {
                outputLabel.Text = "You Win!";
                hpLabel.Text = "0/150";
            }
            //health bars
            g.Clear(Color.Gray);
            g.FillRectangle(drawBrush, 0, 0, rivalhp, 15);

            g2.Clear(Color.Gray);
            g2.FillRectangle(drawBrush, 0, 0, playerhp, 15);

            hpLabel.Text = playerhp + "/150";

            Thread.Sleep(1000);

            if (rivalhp > 0)
            {
                RivalTurn(g, drawBrush, g2);

            }

        }

        private void RivalTurn(Graphics g, SolidBrush drawBrush, Graphics g2)
        {
            //=====Rival's Turn=====//
            accuracy = randGen.Next(1, 101);
            critical = randGen.Next(1, 17);

            //Rival's Values

            if (accuracy <= 95)
            {
                playerhp -= rivalatk;
                outputLabel.Text = "";
                if (critical == 1)
                {
                    playerhp -= (int)(rivalatk * 1.5);
                    outputLabel.Text = "A critical hit!";
                }
            }
            if (accuracy > 95)
            {
                outputLabel.Text = "The opponent's attack missed!";
            }

            if (playerhp <= 0)
            {
                outputLabel.Text = "Game Over";
                hpLabel.Text = "0/150";
            }
            if (rivalhp <= 0)
            {
                outputLabel.Text = "You Win!";
            }
            //health bars
            g.Clear(Color.Gray);
            g.FillRectangle(drawBrush, 0, 0, rivalhp, 15);

            g2.Clear(Color.Gray);
            g2.FillRectangle(drawBrush, 0, 0, playerhp, 15);

            hpLabel.Text = playerhp + "/" + playerbasehp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}