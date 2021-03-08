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
    public partial class MarathonMap : Form
    {
        static bool tr = false;

        public MarathonMap()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MarathonSkills MarathonSkills = new MarathonSkills();
            MarathonSkills.Show();
        }

        private void MarathonMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }

        private void MarathonMap_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Avenida Rudge";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = false;
            lblInfo.Visible = false;
            Medical.Visible = false;
            lblMedical.Visible = false;
            Toilets.Visible = false;
            lblToilets.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Theatro Municipal";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = true;
            Information.Location = new Point(14, 164);
            lblInfo.Visible = true;
            lblInfo.Location = new Point(70, 178);
            Medical.Visible = true;
            Medical.Location = new Point(14, 220);
            lblMedical.Visible = true;
            lblMedical.Location = new Point(70, 233);
            Toilets.Visible = true;
            Toilets.Location = new Point(14, 276);
            lblToilets.Visible = true;
            lblToilets.Location = new Point(70, 288);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Parque do Ibirapuera";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = false;
            lblInfo.Visible = false;
            Medical.Visible = false;
            lblMedical.Visible = false;
            Toilets.Visible = true;
            Toilets.Location = new Point(14, 164);
            lblToilets.Visible = true;
            lblToilets.Location= new Point(70, 178);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Jardim Luzitania";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = false;
            lblInfo.Visible = false;
            Medical.Visible = true;
            Medical.Location = new Point(14, 164);
            lblMedical.Visible = true;
            lblMedical.Location = new Point(70, 178);
            Toilets.Visible = true;
            Toilets.Location = new Point(14, 220);
            lblToilets.Visible = true;
            lblToilets.Location = new Point(70, 233);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Iguatemi";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = true;
            Information.Location = new Point(14, 164);
            lblInfo.Visible = true;
            lblInfo.Location = new Point(70, 178);
            Medical.Visible = false;
            lblMedical.Visible = false;
            Toilets.Visible = true;
            Toilets.Location = new Point(14, 220);
            lblToilets.Visible = true;
            lblToilets.Location = new Point(70, 233);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(20, 66);
            panel4.Visible = true;
            panel4.Location = new Point(550, 66);
            CheckPointName.Text = "Rua Lisboa";
            Drinks.Visible = true;
            lblDrinks.Visible = true;
            EnergyBars.Visible = true;
            lblEnergy.Visible = true;
            Information.Visible = false;
            lblInfo.Visible = false;
            Medical.Visible = false;
            lblMedical.Visible = false;
            Toilets.Visible = true;
            Toilets.Location = new Point(14, 164);
            lblToilets.Visible = true;
            lblToilets.Location = new Point(70, 178);
        }
    }
}
