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
    public partial class BMICalculator : Form
    {
        static bool tr = false;

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            label16.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void SelectMale(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            panel3.BackColor = Color.Gray;
            panel4.BackColor = Color.Gainsboro;
        }

        private void SelecFemale(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            panel4.BackColor = Color.Gray;
            panel3.BackColor = Color.Gainsboro;
        }

        private void BMICalculator_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            panel3.BackColor = Color.Gainsboro;
            panel4.BackColor = Color.Gainsboro;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs E)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float H = Convert.ToSingle(textBox1.Text);
            float W = Convert.ToSingle(textBox2.Text);
            H = H / 100;
            float BMI = W / (H * H);
            BMI = Convert.ToSingle(Math.Round(BMI, 1));
            label17.Text = BMI.ToString();
            float ArrowLocation;

            if (BMI <= 18.5)
            {
                pictureBox4.Image = Marathon.Properties.Resources.bmi_underweight_icon;
                pictureBox3.Location = new Point(-12, 20);
                ArrowLocation = BMI * Convert.ToSingle(2.7);
                pictureBox3.Location = new Point(Convert.ToInt32(ArrowLocation), 20);
                int Loacation = pictureBox3.Location.X;
                if (Loacation < -6)
                {
                    label17.Location = new Point(Convert.ToInt32(ArrowLocation + 15), 20);
                    label17.Text = "~ " + BMI;
                }
                else
                    label17.Location = new Point(Convert.ToInt32(ArrowLocation- 14), 0);
            }

            if (BMI >= 18.5 && BMI <= 24.9)
            {
                pictureBox4.Image = Marathon.Properties.Resources.bmi_healthy_icon;
                pictureBox3.Location = new Point(37, 58);
                float s = BMI - Convert.ToSingle(18.5);
                textBox2.Text = s.ToString();
                ArrowLocation = 37 + (s * Convert.ToSingle(7.6));
                pictureBox3.Location = new Point(Convert.ToInt32(ArrowLocation), 20);
                label17.Location = new Point(Convert.ToInt32(ArrowLocation - 14), 0);
            }

            if (BMI >= 25 && BMI <= 29.9)
            {
                pictureBox4.Image = Marathon.Properties.Resources.bmi_overweight_icon;
                pictureBox3.Location = new Point(87, 58);
                float s = BMI - Convert.ToSingle(24.9);
                textBox2.Text = s.ToString();
                ArrowLocation = 87 + (s * Convert.ToSingle(10.2));
                pictureBox3.Location = new Point(Convert.ToInt32(ArrowLocation), 20);
                label17.Location = new Point(Convert.ToInt32(ArrowLocation - 14), 0);
            }

            if (BMI >= 30 && BMI <= 35)
            {
                pictureBox4.Image = Marathon.Properties.Resources.bmi_obese_icon;
                pictureBox3.Location = new Point(136, 58);
                float s = BMI - Convert.ToSingle(30);
                ArrowLocation = 136 + (s * 15);
                pictureBox3.Location = new Point(Convert.ToInt32(ArrowLocation), 20);
                label17.Location = new Point(Convert.ToInt32(ArrowLocation - 14), 0);
            }

            if (BMI > 35)
            {
                pictureBox4.Image = Marathon.Properties.Resources.bmi_obese_icon;
                pictureBox3.Location = new Point(186, 20);
                label17.Location = new Point(150, 20);
            }

            BMICalculator_Click(sender, e);
            button1.Enabled = false;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
                DialogResult = MessageBox.Show("Leave Form?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                tr = true;
                this.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                AboutMarathon AboutMarathonForm = new AboutMarathon();
                AboutMarathonForm.Show();
                return;
            }
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            AboutMarathon AboutMarathonForm1 = new AboutMarathon();
            AboutMarathonForm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                    DialogResult = MessageBox.Show("Leave Form?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    tr = true;
                    this.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    AboutMarathon AboutMarathonForm = new AboutMarathon();
                    AboutMarathonForm.Show();
                    return;
                }
                tr = true;
                this.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                AboutMarathon AboutMarathonForm1 = new AboutMarathon();
                AboutMarathonForm1.Show();
            }
        }

        private void BMICalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
