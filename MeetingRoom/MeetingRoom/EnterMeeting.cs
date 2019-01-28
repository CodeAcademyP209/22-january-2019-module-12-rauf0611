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
    public partial class EnterMeeting : Form
    {
        raufEntities db = new raufEntities();
        public EnterMeeting(Form1 aa)
        {
            var ab = aa;
            ab.Refresh();
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==-1 || textBox2.Text == "")
            {
                MessageBox.Show("PLEASE SELECT YOUR DEPARTMENT AND ID","WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(textBox2.Text);
            string dep = comboBox1.Text;
            var depID = db.Departments.SingleOrDefault(x => x.Name == dep).ID;
            var isci = db.Employers.FirstOrDefault(x => x.ID == id && x.DepartmentID == depID);
            
            if(isci != null && depID == 2)
            {
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Zehmet olmasa melumatlarinizi yeniden yoxlayin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         


        }

        private void EnterMeeting_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(db.Departments.Select(x => x.Name).ToArray());
        }
    }
}
