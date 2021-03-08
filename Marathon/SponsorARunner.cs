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
    public partial class SponsorARunner : Form
    {
        public bool tr = false;

        public SponsorARunner()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || comboBox1.SelectedIndex != -1 || txtAmount.Text != "")
            //    DialogResult = MessageBox.Show("Покинуть форму?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (DialogResult == DialogResult.Yes)
            //{
            //    tr = true;
            //    this.Close();
            //    MainForm Form = new MainForm();
            //    Form.Show();
            //    return;
            //}
            //tr = true;
            //this.Close();
            //MainForm Form1 = new MainForm();
            //Form1.Show();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label10.Location = new Point(2/(585 - label10.Location.X), 378);
            label10.Text = "$" + hScrollBar1.Value.ToString();
        }

        private void txtDonate_TextChanged(object sender, EventArgs e)
        {
            label10.Location = new Point(2/(585 - label10.Location.X), 378);
            label10.Text = "$" + txtDonate.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            txtDonate.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            txtDonate.Visible = false;
        }

        private void SponsorARunner_Load(object sender, EventArgs e)
        {
            txtDonate.Visible = false;
            button2.Visible = false;
        }
    }
}
