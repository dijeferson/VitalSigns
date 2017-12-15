using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public int x, i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlView1.Start();
            controlView1.LineColor = Color.LimeGreen;
            controlView1.TimeInterval = 10;
            //controlView1.OffSetX = 1;
            controlView1.OffSetY = controlView1.Height / 2;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            controlView1.Stop();
        }

        private void controlView1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = (int)(Math.Sin(i)*(int)numericUpDown3.Value);
            controlView1.DataY = x;
            
            if(i <=180)
                i++;
            else
                i=0;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            controlView1.OffSetX = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            controlView1.OffSetY = (int)numericUpDown2.Value;

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown4.Value+1;
        }
    }
}