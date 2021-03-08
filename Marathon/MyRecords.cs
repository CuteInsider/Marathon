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
    public partial class MyRecords : Form
    {
        bool tr = false;
        public static int RecorcdsArrow = 0;
        public static DateTime DateOfBirth;
        public static string Gender;
        public static int SwitchMethod;
        public MyRecords()
        {
            InitializeComponent();
        }

        private void MyRecords_Load(object sender, EventArgs e)
        {
            DBConnection.GetDR(DBConnection.GetEmail);
            TimeSpan Age = DateTime.Now - DateOfBirth;
            lblgGnder.Text = Gender;
            float AgeGroup= Convert.ToSingle(Age.Days / 365.5);
            if (AgeGroup < 18)
            {
                lblAge.Text = "< 18";
                SwitchMethod = 0;
            }
            if (AgeGroup >= 18 && AgeGroup <= 29)
            {
                lblAge.Text = "18 - 29";
                SwitchMethod = 1;
            }
            if (AgeGroup >= 30 && AgeGroup <= 39)
            {
                lblAge.Text = "30 - 39";
                SwitchMethod = 2;
            }
            if (AgeGroup >= 40 && AgeGroup <= 55)
            {
                lblAge.Text = "40 - 55";
                SwitchMethod = 3;
            }
            if (AgeGroup >= 56 && AgeGroup <= 70)
            {
                lblAge.Text = "56 - 70";
                SwitchMethod = 4;
            }
            if (AgeGroup > 70)
            {
                lblAge.Text = "> 70";
                SwitchMethod = 5;
            }
            DBConnection.GetMyRecords();
            dGWMyRecords.DataSource = DBConnection.dtMyRecords;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MyRecords.RecorcdsArrow == 1)
            {
                tr = true;
                this.Close();
                RunnerMenu RMForm = new RunnerMenu();
                RMForm.Show();
            }
            else
            {
                tr = true;
                this.Close();
                RunnerControl RCForm = new RunnerControl();
                RCForm.Show();
            }
        }

        private void MyRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
