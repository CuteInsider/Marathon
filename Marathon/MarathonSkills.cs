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
    public partial class MarathonSkills : Form
    {

        static bool tr = false;

        public MarathonSkills()
        {
            InitializeComponent();
        }

        private void MarathonSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            AboutMarathon Frm = new AboutMarathon();
            Frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MarathonMap MarathonMapfrm = new MarathonMap();
            MarathonMapfrm.Show();
        }
    }
}
