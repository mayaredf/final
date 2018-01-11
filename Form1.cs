using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
            
            int playerhp = 25;
            int rivalhp = 25;
            int percentHealth;
            int accuracy;
            int critical;

            //instead of this.create graphics replace this with the label name
            //progress bar takes values of hp
            //if (playerhp == 0) ;
            //if (rivalhp == 0) ;
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = rivalHealthLabel.CreateGraphics();
            Pen drawPen = new Pen(Color.LightGreen, 10);
            SolidBrush drawBrush = new SolidBrush(Color.LightGreen);
            g.FillRectangle(drawBrush, 0, 0, 150, 15);
            Graphics g2 = userHealthLabel.CreateGraphics();
            g2.FillRectangle(drawBrush, 0, 0, 150, 15);
        }
    }
}
