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
    public partial class RunnerControl : Form
    {
        static bool tr = false;

        public RunnerControl()
        {
            InitializeComponent();
        }

        private void RunnerControl_Load(object sender, EventArgs e)
        {
            DBConnection.GetInfoAboutRunner(DBConnection.GetEmail);
            lblEmail.Text = DBConnection.GetEmail;
            lblFirstName.Text = DBConnection.GetFirstName;
            lblSurName.Text = DBConnection.GetLastName;
            lblGender.Text = DBConnection.GetGender;
            lblDateOfBirth.Text = DBConnection.GetDateOfBirth;
            lblCountry.Text = DBConnection.GetCountryName;
            lblDonateOrg.Text = DBConnection.GetDonateOrg;
            lblTotalDonate.Text = DBConnection.GetTotalDonate;
            lblSelectedOption.Text = DBConnection.GetSelectedOption;
            lblTypeOfMarathon.Text = DBConnection.GetTypeOfMarathon;
            if (DBConnection.GetPhoto != null)
                pbPhoto.ImageLocation = DBConnection.GetPhoto;
            switch (DBConnection.GetRegStatus)
            {
                case "1":
                    pbRegistered.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    break;

                case "2":
                    pbRegistered.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbPaymentConfirmed.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    break;

                case "3":
                    pbRegistered.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbPaymentConfirmed.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbRaceKitSent.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    break;

                case "4":
                    pbRegistered.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbPaymentConfirmed.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbRaceKitSent.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    pbRaceAttended.ImageLocation = @"E:\Study\С#\Marathon\Status-icon\tick-icon.png";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegForm.Cross = 1;
            tr = true;
            this.Close();
            RegForm Form = new RegForm();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            RunnersInfo Form = new RunnersInfo();
            Form.Show();
        }

        private void RunnerControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            PrintCertificate Form = new PrintCertificate();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            MyRecords.RecorcdsArrow = 2;
            MyRecords Form = new MyRecords();
            Form.Show();
        }
    }
}
