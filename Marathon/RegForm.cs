using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Marathon
{
    public partial class RegForm : Form
    {
        static bool tr = false;
        public static int Cross = 0;

        public static string Password = null;
        public static string FirstName = null;
        public static string SurName = null;
        public static string Gender = null;
        public static string DateOfBirth = null;
        public static string PathToPhoto = null;
        public static string County = null;

        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetForCountryComboBox.country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.dataSetForCountryComboBox.country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetForGenderComboBox.gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.dataSetForGenderComboBox.gender);
            label13.Visible = false;
            GenderComboBox.SelectedIndex = -1;
            CountrycomboBox.SelectedIndex = -1;
            switch (Cross)
            {
                case 0: //Регестрация на марафон

                    break;

                case 2: //Редактирование профиля с RunnerMenu
                case 1: //Редактирование профиля с RunnerControl
                    lblCaption.Text = "Profile Edit";
                    DBConnection.GetEdit(DBConnection.GetEmail);
                    txtEmail.Text = DBConnection.GetEmail;
                    txtName.Text = DBConnection.GetFirstName;
                    txtSurname.Text = DBConnection.GetLastName;
                    if (Cross == 1)
                    {
                        txtPassword.Text = DBConnection.Password;
                        txtCPassword.Text = DBConnection.Password;
                    }
                    GenderComboBox.SelectedValue = DBConnection.GetGender;
                    CountrycomboBox.SelectedValue = DBConnection.GetCountryName;
                    dtDateOfBirth.Text = DBConnection.GetDateOfBirth;
                    if (DBConnection.GetPhoto != null)
                    {
                        txtPath.Text = DBConnection.GetPhoto;
                        pbAvatar.ImageLocation = DBConnection.GetPhoto;
                    }
                    break;

                case 3: //FUCK, GO BACK!!
                    txtEmail.Text = DBConnection.GetEmail;
                    txtPassword.Text = Password;
                    txtName.Text = FirstName;
                    txtSurname.Text = SurName;
                    GenderComboBox.SelectedValue = Gender;
                    dtDateOfBirth.Text = DateOfBirth;
                    CountrycomboBox.SelectedValue = County;
                    if (txtPath != null)
                    {
                        txtPath.Text = PathToPhoto;
                        pbAvatar.ImageLocation = PathToPhoto;
                    }
                    Cross = 0;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BrowsePhoto.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Load(BrowsePhoto.FileName);
                txtPath.Text = pbAvatar.ImageLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "" && txtCPassword.Text != "" && txtName.Text != "" && txtSurname.Text != "" && GenderComboBox.SelectedIndex != -1 && CountrycomboBox.SelectedIndex != -1)
            {
                if (txtPassword.Text.Length >= 6 && txtPassword.Text.Any(Char.IsUpper) && txtPassword.Text.Any(Char.IsNumber))
                {
                    if (txtPassword.Text == txtCPassword.Text)
                    {
                        DateTime Selectedate = new DateTime();
                        Selectedate = Convert.ToDateTime(dtDateOfBirth.Text);

                        DateTime CurrentDate = new DateTime();
                        CurrentDate = DateTime.Now;

                        TimeSpan time = CurrentDate - Selectedate;
                        float RunnerAge = Convert.ToSingle(time.Days / 354.3);
                        RunnerAge = Convert.ToSingle(Math.Round(RunnerAge, 1));

                        if (RunnerAge > 10)
                        {
                            label13.Visible = false;
                            DBConnection.GetEmail = txtEmail.Text;
                            Password = txtPassword.Text;
                            FirstName = txtName.Text;
                            SurName = txtSurname.Text;
                            Gender = GenderComboBox.SelectedValue.ToString();
                            DateOfBirth = dtDateOfBirth.Text;
                            County = CountrycomboBox.SelectedValue.ToString();
                            PathToPhoto = txtPath.Text;
                            tr = true;
                            this.Close();
                            RegistrationOnMarathon ROMForm = new RegistrationOnMarathon();
                            ROMForm.Show();
                        }
                        else
                        {
                            label13.Visible = true;
                            label13.Text = "Runner must be over 10 years old";
                        }
                    }
                    else
                    {
                        label13.Visible = true;
                        label13.Text = "Passwords do not match";
                    }
                }
                else
                {
                    label13.Visible = true;
                    label13.Text = "The password must contain at least 6 characters Minimum 1 capital letter At least 1 digit";
                }
            }
            else
            {
                label13.Visible = true;
                label13.Text = "Fill all Fields";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" || txtPassword.Text != "" || txtCPassword.Text != "" || txtName.Text != "" || txtSurname.Text != "" || GenderComboBox.SelectedIndex != -1 || CountrycomboBox.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Leave Form?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    switch (Cross)
                    {
                        case 0:
                            tr = true;
                            Cross = 0;
                            this.Close();
                            RegOrLoginForm RegOrLoginForm1 = new RegOrLoginForm();
                            RegOrLoginForm1.Show();
                            return;

                        case 1:
                            tr = true;
                            Cross = 0;
                            lblCaption.Text = "Sign Up";
                            this.Close();
                            RunnerControl RunnerControl = new RunnerControl();
                            RunnerControl.Show();
                            return;

                        case 4:
                        case 2:
                            tr = true;
                            Cross = 0;
                            lblCaption.Text = "Sign Up";
                            this.Close();
                            RunnerMenu RunnerMenu = new RunnerMenu();
                            RunnerMenu.Show();
                            return;
                    }
                }
            }
            else
            {
                switch (Cross)
                {
                    case 4:
                    case 0:
                        tr = true;
                        Cross = 0;
                        this.Close();
                        RegOrLoginForm RegOrLoginForm1 = new RegOrLoginForm();
                        RegOrLoginForm1.Show();
                        return;

                    case 1:
                        tr = true;
                        Cross = 0;
                        lblCaption.Text = "Sign Up";
                        this.Close();
                        RunnerControl RunnerControl = new RunnerControl();
                        RunnerControl.Show();
                        return;

                    case 2:
                        tr = true;
                        Cross = 0;
                        lblCaption.Text = "Sign Up";
                        this.Close();
                        RunnerMenu RunnerMenu = new RunnerMenu();
                        RunnerMenu.Show();
                        return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" || txtPassword.Text != "" || txtCPassword.Text != "" || txtName.Text != "" || txtSurname.Text != "" || GenderComboBox.SelectedIndex != -1 || CountrycomboBox.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Leave Form?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    switch (Cross)
                    {
                        case 0:
                            tr = true;
                            Cross = 0;
                            this.Close();
                            RegOrLoginForm RegOrLoginForm1 = new RegOrLoginForm();
                            RegOrLoginForm1.Show();
                            return;

                        case 1:
                            tr = true;
                            Cross = 0;
                            lblCaption.Text = "Sign Up";
                            this.Close();
                            RunnerControl RunnerControl = new RunnerControl();
                            RunnerControl.Show();
                            return;

                        case 2:
                            tr = true;
                            Cross = 0;
                            lblCaption.Text = "Sign Up";
                            this.Close();
                            RunnerMenu RunnerMenu = new RunnerMenu();
                            RunnerMenu.Show();
                            return;
                    }
                }
            }
            else
            {
                switch (Cross)
                {
                    case 4:
                    case 0:
                        tr = true;
                        Cross = 0;
                        this.Close();
                        RegOrLoginForm RegOrLoginForm1 = new RegOrLoginForm();
                        RegOrLoginForm1.Show();
                        return;

                    case 1:
                        tr = true;
                        Cross = 0;
                        lblCaption.Text = "Sign Up";
                        this.Close();
                        RunnerControl RunnerControl = new RunnerControl();
                        RunnerControl.Show();
                        return;

                    case 2:
                        tr = true;
                        Cross = 0;
                        lblCaption.Text = "Sign Up";
                        this.Close();
                        RunnerMenu RunnerMenu = new RunnerMenu();
                        RunnerMenu.Show();
                        return;
                }
            }
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.Exit();
        }
    }
}
