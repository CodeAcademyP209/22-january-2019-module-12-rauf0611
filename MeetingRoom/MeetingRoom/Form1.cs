using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //HOVER EFFECTS
        private void label1_Hover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;

        }
        private void label1_Leave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LemonChiffon;
        }
        private void label2_Hover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LemonChiffon;

        }
        private void label2_Leave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;

        }
        private void label3_Hover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }
        private void label3_Leave(object sender, EventArgs e)
        {
            
            label3.ForeColor = Color.LemonChiffon;
        }
        private void label4_Hover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }
        private void label4_Leave(object sender, EventArgs e)
        {

            label4.ForeColor = Color.LemonChiffon;
        }
        private void label5_Hover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }
        private void label5_Leave(object sender, EventArgs e)
        {

            label5.ForeColor = Color.LemonChiffon;
        }
        private void label6_Hover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }
        private void label6_Leave(object sender, EventArgs e)
        {

            label6.ForeColor = Color.LemonChiffon;
        }
        private void label7_Hover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.LemonChiffon;
        }
        private void label7_Leave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }
        private void label8_Hover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }
        private void label8_Leave(object sender, EventArgs e)
        {

            label8.ForeColor = Color.LemonChiffon;
        }


        //ON FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }


        //FOR TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            EnterMeeting et = new EnterMeeting(this);
            et.ShowDialog();
        }
    }
}
