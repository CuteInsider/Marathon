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
    public partial class AboutMarathon : Form
    {
        public bool tr = false;
        public AboutMarathon()
        {
            InitializeComponent();
        }

        private void AboutMarathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MarathonSkills AboutMarathonFrm = new MarathonSkills();
            AboutMarathonFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MainForm MainFrm = new MainForm();
            MainFrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            HowLongMarathon HowLongMarathonForm = new HowLongMarathon();
            HowLongMarathonForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tr = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Close();
            BMICalculator BMRCalculatorForm = new BMICalculator();
            BMRCalculatorForm.Show();
        }
    }
}
