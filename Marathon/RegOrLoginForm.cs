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
    public partial class RegOrLoginForm : Form
    {
        static bool tr = false;

        public RegOrLoginForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void RegOrLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            if (DBConnection.Connect() == true)
            {
                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();
            }
            else
            {
                RegOrLoginForm Form = new RegOrLoginForm();
                Form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            if (DBConnection.Connect() == true)
            {
                RegForm RegForm = new RegForm();
                RegForm.Show();
            }
            else
            {
                RegOrLoginForm Form = new RegOrLoginForm();
                Form.Show();
            }
        }
    }
}
