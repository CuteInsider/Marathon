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
    public partial class CoordinatorMenu : Form
    {
        static bool tr = false;

        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            LoginForm Form = new LoginForm();
            Form.Show();
        }

        private void CoordinatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void CoordinatorMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RunnersInfo Form = new RunnersInfo();
            Form.Show();
        }
    }
}
