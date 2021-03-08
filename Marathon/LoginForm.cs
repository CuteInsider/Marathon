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
    public partial class LoginForm : Form
    {
        static bool tr = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            if (MainForm.Arrow == true)
            {
                MainForm form = new MainForm();
                form.Show();
            }
            else
            {
                RegOrLoginForm RegOrLoginForm = new RegOrLoginForm();
                RegOrLoginForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RegOrLoginForm RegOrLoginForm = new RegOrLoginForm();
            RegOrLoginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection.Authorization(txtLogin.Text, txtPassword.Text);
            switch (DBConnection.Role)
            {
                case "R":
                    DBConnection.GetEmail = txtLogin.Text;
                    tr = true;
                    this.Close();
                    RunnerMenu Form = new RunnerMenu();
                    Form.Show();
                    break;
                case "A":
                    tr = true;
                    this.Close();
                    AdminMenu AdminMenuFrm = new AdminMenu();
                    AdminMenuFrm.Show();
                    break;
                case "c":
                    tr = true;
                    this.Close();
                    CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                    coordinatorMenu.Show();
                    break;
                case null:
                    MessageBox.Show("Неверные данные");
                    break;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            CoordinatorMenu Frm = new CoordinatorMenu();
            Frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RunnerMenu Frm = new RunnerMenu();
            Frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            AdminMenu Frm = new AdminMenu();
            Frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 64 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && e.KeyChar != 36 && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
