using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program Created by Maya Redford-Haines

namespace final
{
    public partial class Final : Form
        
    {
        Random randGen = new Random();

        int playerhp = 150;
        int rivalhp = 150;
        int percentHealth;
        int accuracy;
        int critical;

        public Final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics g = rivalHealthLabel.CreateGraphics();
            Pen drawPen = new Pen(Color.LightGreen, 10);
            SolidBrush drawBrush = new SolidBrush(Color.LightGreen);          
            Graphics g2 = userHealthLabel.CreateGraphics();



            accuracy = randGen.Next(1, 101);
            critical = randGen.Next(1, 17);

            if (accuracy <= 50)
            {
                playerhp -= 10;
                outputLabel.Text = "";
                if (critical == 1)
                {
                    playerhp -= 15;
                    outputLabel.Text = "A critical hit!";
                }
            }
            if (accuracy > 50)
            {
                outputLabel.Text = "The attack missed!";
            }

            if (playerhp <= 0)
            {
                outputLabel.Text = "Game Over";
            }
            if (rivalhp <= 0)
            {
                outputLabel.Text = "You Win!";
            }

            g.FillRectangle(drawBrush, 0, 0, rivalhp, 15);
            g2.Clear(Color.Red);
            g2.FillRectangle(drawBrush, 0, 0, playerhp, 15);

            hpLabel.Text = playerhp + "/150";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerhp = 150;  
        }
    }
}
