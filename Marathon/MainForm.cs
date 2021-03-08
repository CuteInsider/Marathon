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
    public partial class MainForm : Form
    {

        Timer timer = new Timer();
        static public bool Arrow = false;

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object source, EventArgs e)
        {
            DateTime Event = new DateTime(2018, 09, 01, 9, 0, 0);
            if (DateTime.Now <= Event)
            {
                TimeSpan RemainingTime = Event - DateTime.Now;
                lblTimer.Text = string.Format(RemainingTime.Days + "d. " + RemainingTime.Hours + "h. " + RemainingTime.Minutes + "m. " + RemainingTime.Seconds + "s. before the start Marathon");
            }
            else
            {
                lblTimer.Text = "Marathon was started";
                timer.Stop();
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            Arrow = false;
            RegOrLoginForm RegOrLoginFormForm = new RegOrLoginForm();
            RegOrLoginFormForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            AboutMarathon Frm = new AboutMarathon();
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            SponsorARunner Form = new SponsorARunner();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer.Stop();
            if (DBConnection.Connect() == true)
            {
                Arrow = true;
                LoginForm Form = new LoginForm();
                Form.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
    }
}
