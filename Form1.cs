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
            playerhp -= 10;
            Graphics g = rivalHealthLabel.CreateGraphics();
            Pen drawPen = new Pen(Color.LightGreen, 10);
            SolidBrush drawBrush = new SolidBrush(Color.LightGreen);
            g.FillRectangle(drawBrush, 0, 0, rivalhp, 15);
            Graphics g2 = userHealthLabel.CreateGraphics();
            g2.Clear(Color.Red);
            g2.FillRectangle(drawBrush, 0, 0, playerhp, 15);

            hpLabel.Text = playerhp + "/150";

            if (playerhp == 0)
            {
                outputLabel.Text = "Game Over";

            }
            if (rivalhp == 0)
            {
                outputLabel.Text = "You Win!";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
