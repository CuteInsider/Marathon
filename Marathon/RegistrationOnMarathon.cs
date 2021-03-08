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
    public partial class RegistrationOnMarathon : Form
    {
        static public int Cross = 0;

        static bool tr = false;
        string swichOption = null;
        static float TotalAmount = 0;
        static public int Option = 0;
        float A = 0;
        public RegistrationOnMarathon()
        {
            InitializeComponent();
        }

        private void RegistrationOnMarathon_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            CharityPanel.Visible = false;
            CharityPanel.Location = new Point(155, 170);

            cmbContribution.DataSource = DBConnection.LoadcmbContribution();
            cmbContribution.ValueMember = "CharityId";
            cmbContribution.DisplayMember = "CharityName";
            cmbContribution.SelectedIndex = -1;

            if ((RegForm.Cross <= 2 || RegForm.Cross == 4) && RegForm.Cross != 0)
            {
                DBConnection.GetEditMarathon(DBConnection.GetEmail);
                switch (DBConnection.GetKitOptions)
                {
                    case "A":
                        rbtnA.Checked = true;
                        break;

                    case "B":
                        rbtnB.Checked = true;
                        break;

                    case "C":
                        rbtnC.Checked = true;
                        break;
                }
                cmbContribution.SelectedValue = DBConnection.GetContribution;
                txtAmount.Text = DBConnection.GetAmountContribution.Replace(".", ",");
                DBConnection.GetMarathon(DBConnection.GetEmail);
                cbSD.Checked = DBConnection.FR;
                cbSM.Checked = DBConnection.SM;
                cbFM.Checked = DBConnection.FM;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnA.Checked == true)
            {
                TotalAmount = TotalAmount + 0;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = "A";
            }
            else
            {
                TotalAmount = TotalAmount - 0;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = null;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnB.Checked == true)
            {
                TotalAmount = TotalAmount + 20;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = "B";
            }
            else
            {
                TotalAmount = TotalAmount - 20;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = null;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnC.Checked == true)
            {
                TotalAmount = TotalAmount + 45;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = "C";
            }
            else
            {
                TotalAmount = TotalAmount - 45;
                label10.Text = ("$" + TotalAmount.ToString());
                swichOption = null;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFM.Checked == true)
            {
                TotalAmount = TotalAmount + 145;
                label10.Text = ("$" + TotalAmount.ToString());
            }
            else
            {
                TotalAmount = TotalAmount - 145;
                label10.Text = ("$" + TotalAmount.ToString());
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSM.Checked == true)
            {
                TotalAmount = TotalAmount + 75;
                label10.Text = ("$" + TotalAmount.ToString());
            }
            else
            {
                TotalAmount = TotalAmount - 75;
                label10.Text = ("$" + TotalAmount.ToString());
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSD.Checked == true)
            {
                TotalAmount = TotalAmount + 20;
                label10.Text = ("$" + TotalAmount.ToString());
            }
            else
            {
                TotalAmount = TotalAmount - 20;
                label10.Text = ("$" + TotalAmount.ToString());
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            float TotalAmountAndContribution = 0;
            if (txtAmount.Text != "")
            {
                A = Convert.ToSingle(txtAmount.Text.Replace(".", ","));
                TotalAmountAndContribution = TotalAmount + A;
                label10.Text = ("$" + TotalAmountAndContribution.ToString());
            }
            else
            {
                TotalAmount = TotalAmount - A;
                A = 0;
                label10.Text = ("$" + TotalAmount.ToString());
            }
        }

        private void RegistrationOnMarathon_Click(object sender, EventArgs e)
        {
            label10.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CharityPanel.Visible = true;
            btnDescription.Visible = false;
            CharityName.Text = cmbContribution.Text;//DBConnection.GetCharityName(comboBox1.SelectedItem.ToString());
            CharityDescription.Text = DBConnection.GetCharityDescription(cmbContribution.SelectedValue.ToString());
            CharityLogo.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "CharityLogo\\" + DBConnection.GetCharityLogo(cmbContribution.SelectedValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CharityPanel.Visible = false;
            btnDescription.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((cbFM.Checked == true || cbSM.Checked == true || cbSD.Checked == true) &&
                (rbtnA.Checked == true || rbtnB.Checked == true || rbtnC.Checked == true))
            {
                switch (RegForm.Cross)
                {
                    case 0:
                        {
                            DBConnection.AddUserAndRunner(DBConnection.GetEmail, RegForm.Password, RegForm.FirstName,
                                RegForm.SurName, RegForm.Gender, RegForm.DateOfBirth, RegForm.County, RegForm.PathToPhoto);

                            DBConnection.RegOnMarathon(swichOption, TotalAmount.ToString(),
                                cmbContribution.SelectedValue.ToString(), txtAmount.Text);

                            DBConnection.AddCharity(cmbContribution.Text, txtAmount.Text);

                            tr = true;
                            this.Close();
                            ConfirmReg Form = new ConfirmReg();
                            Form.Show();
                            break;
                        }

                    case 4:
                    case 1:
                    case 2:
                        {
                            if (RegForm.Cross != 4)
                            {
                                DBConnection.EditUserAndRunner(DBConnection.GetEmail, RegForm.Password, RegForm.FirstName,
                                RegForm.SurName, RegForm.Gender, RegForm.DateOfBirth, RegForm.County, RegForm.PathToPhoto);
                            }

                            DBConnection.EditMarathon(swichOption, TotalAmount.ToString(),
                                cmbContribution.SelectedValue.ToString(), txtAmount.Text);

                            DBConnection.EditCharity(cmbContribution.Text, txtAmount.Text);

                            if (cbSD.Checked == true)
                                DBConnection.AddFR();
                            else
                                DBConnection.DeleteFR();

                            if (cbSM.Checked == true)
                                DBConnection.AddHM();
                            else
                                DBConnection.DeleteHM();

                            if (cbFM.Checked == true)
                                DBConnection.AddFM();
                            else
                                DBConnection.DeleteFM();

                            switch (RegForm.Cross)
                            {
                                case 1:
                                    tr = true;
                                    this.Close();
                                    RunnerControl RCMenu = new RunnerControl();
                                    RCMenu.Show();
                                    break;

                                case 4:
                                case 2:
                                    tr = true;
                                    this.Close();
                                    RunnerMenu RMenu = new RunnerMenu();
                                    RMenu.Show();
                                    break;
                            }
                            break;
                        }
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "At least 1 marathon must be selected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Leave Regestration?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                switch (RegForm.Cross)
                {
                    case 1:
                        tr = true;
                        this.Close();
                        RunnerControl RCForm = new RunnerControl();
                        RCForm.Show();
                        return;

                    case 0:
                    case 2:
                    case 4:
                        tr = true;
                        Cross = 0;
                        this.Close();
                        RunnerMenu RunnerMenu = new RunnerMenu();
                        RunnerMenu.Show();
                        return;
                }
            }
            else
            {
                switch (RegForm.Cross)
                {
                    case 1:
                        tr = true;
                        this.Close();
                        RunnerControl RCForm = new RunnerControl();
                        RCForm.Show();
                        return;

                    case 0:
                    case 2:
                    case 4:
                        tr = true;
                        Cross = 0;
                        this.Close();
                        RunnerMenu RunnerMenu = new RunnerMenu();
                        RunnerMenu.Show();
                        return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbFM.Checked == true || cbSM.Checked == true || cbSD.Checked == true || rbtnA.Checked == true
                || rbtnB.Checked == true || rbtnC.Checked == true || cmbContribution.SelectedIndex != -1 || txtAmount.Text != "")
            {
                DialogResult = MessageBox.Show("Leave Form?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    switch (RegForm.Cross)
                    {
                        case 0:
                        case 1:
                        case 2:
                            tr = true;
                            this.Close();
                            RegForm.Cross = 3;
                            RegForm RegForm1 = new RegForm();
                            RegForm1.Show();
                            return;

                        case 4:
                            tr = true;
                            Cross = 0;
                            this.Close();
                            RunnerMenu RunnerMenu = new RunnerMenu();
                            RunnerMenu.Show();
                            return;
                    }
                }

            }
            else
            {
                switch (RegForm.Cross)
                {
                    case 0:
                    case 1:
                    case 2:
                        tr = true;
                        this.Close();
                        RegForm.Cross = 3;
                        RegForm RegForm1 = new RegForm();
                        RegForm1.Show();
                        return;

                    case 4:
                        tr = true;
                        Cross = 0;
                        this.Close();
                        RunnerMenu RunnerMenu = new RunnerMenu();
                        RunnerMenu.Show();
                        return;
                }
            }

        }

        private void RegistrationOnMarathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void cmbContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContribution.SelectedIndex > -1)
            {
                btnDescription.Enabled = true;
            }
            else
            {
                btnDescription.Enabled = false;
            }
        }
    }
}