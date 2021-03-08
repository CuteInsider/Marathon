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
    public partial class HowLongMarathon : Form
    {
        static bool tr = false;

        public HowLongMarathon()
        {
            InitializeComponent();
        }

        private void HowLongMarathon_Load(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Formula 1";
            label3.Text = "Maximum speed Formula 1 345km/h. It will take 14 minutes to complete the 42km marathon";
            pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "Slug";
            label3.Text = "Maximum speed Slug 0.01km/h. It will take 4 200 hour to complete the 42km marathon";
            pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Horse";
            label3.Text = "Maximum speed Horse 15km/h. It will take 200 minutes to complete the 42km marathon";
            pictureBox1.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "Sloth";
            label3.Text = "Maximum speed Sloth 0.12km/h. It will take 350 hour to complete the 42km marathon";
            pictureBox1.Image = pictureBox5.Image;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "Capybara";
            label3.Text = "Maximum speed Capybara 35km/h. It will take 80 minutes to complete the 42km marathon";
            pictureBox1.Image = pictureBox6.Image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "Jaguar";
            label3.Text = "Maximum speed Jaguar 80km/h. It will take 32 minutes to complete the 42km marathon";
            pictureBox1.Image = pictureBox7.Image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "Worm";
            label3.Text = "Maximum speed Worm 0.03km/h. It will take 1 400 hour to complete the 42km marathon";
            pictureBox1.Image = pictureBox8.Image;
        }

        //2-я Вкладка
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "Bus";
            label3.Text = "Length of Bus 10m. It will take the 4 200 of them to cover the distance of the 42 km marathon";
            pictureBox1.Image = pictureBox9.Image;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "Pair of Havaianas";
            label3.Text = "Length of Pair of Havaianas 0.245m. It will take the 171 428 of them to cover the distance of the 42 km marathon";
            pictureBox1.Image = pictureBox10.Image;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Text = "Airbus A380";
            label3.Text = "Length of Airbus A380 73m. It will take the 575.3 of them to cover the distance of the 42 km marathon";
            pictureBox1.Image = pictureBox11.Image;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "Football Field";
            label3.Text = "Length of Football Field 105m. It will take the 400 of them to cover the distance of the 42 km marathon";
            pictureBox1.Image = pictureBox12.Image;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "Ronaldinho";
            label3.Text = "Length of Ronaldinho 1.81m. It will take the 23 204,4 of them to cover the distance of the 42 km marathon";
            pictureBox1.Image = pictureBox13.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            AboutMarathon AboutMarathonForm = new AboutMarathon();
            AboutMarathonForm.Show();
        }

        private void HowLongMarathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
