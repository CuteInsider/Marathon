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
    public partial class PrintCertificate : Form
    {
        static bool tr = false;
        static public string ComboBoxValue = null;
        static public string FirstName;
        static public string SurName;
        static public int MyTime;
        static public int MyPlace;
        static public string MyCountry;
        static public string MyProfit;

        public PrintCertificate()
        {
            InitializeComponent();
        }

        private void PrintCard_Load(object sender, EventArgs e)
        {
            cmbMarathon.SelectedIndex = 0;
            //ComboBoxValue = cmbMarathon.SelectedItem.ToString();
            //DBConnection.GetCertificate(DBConnection.GetEmail);
            //MyPlace = MyPlace + 1;
            //MyTime = MyTime / 60;
            //lblComgratulation.Text = FirstName + " " + SurName + "Congratulations for involvement in " + cmbMarathon.SelectedValue.ToString() + ". Your result time" + MyTime + " and " + MyPlace + "rd place";
            //lblCountry.Text = MyCountry;
            //lblProfit.Text = "also you earned " + MyProfit + " $";
        }

        private void cmbMarathon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarathon.SelectedIndex != -1)
            {
                ComboBoxValue = cmbMarathon.SelectedItem.ToString();
                DBConnection.GetCertificate(DBConnection.GetEmail);
                MyPlace = MyPlace + 1;
                MyTime = MyTime / 60;
                if (MyTime == 0)
                    lblComgratulation.Text = FirstName + " " + SurName + " Congratulations for involvement in " + ComboBoxValue + ". Your result " + MyPlace + "rd place";
                else
                    lblComgratulation.Text = FirstName + " " + SurName + " Congratulations for involvement in " + ComboBoxValue + ". Your result time " + MyTime + " and " + MyPlace + "rd place";
                lblCountry.Text = MyCountry;
                lblProfit.Text = "also you earned " + MyProfit + " $";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RunnerControl Form = new RunnerControl();
            Form.Show();
        }

        private void PrintCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
