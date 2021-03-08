using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class RunnerMenu : Form
    {
        static bool tr = false;

        public RunnerMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            MainForm Form = new MainForm();
            Form.Show();
        }

        private void RunnerMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RegForm.Cross = 4;
            RegistrationOnMarathon RegistrationOnMarathon1 = new RegistrationOnMarathon();
            RegistrationOnMarathon1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            MyRecords.RecorcdsArrow = 1;
            MyRecords Form = new MyRecords();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr = true;
            RegForm.Cross = 2;
            this.Close();
            RegForm Form = new RegForm();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
        }
    }
}
