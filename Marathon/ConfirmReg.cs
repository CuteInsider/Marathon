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
    public partial class ConfirmReg : Form
    {
        static bool tr = false;

        public ConfirmReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RunnerMenu Form = new RunnerMenu();
            Form.Show();
        }

        private void ConfirmReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
