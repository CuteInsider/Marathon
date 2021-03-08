using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Marathon
{
    public partial class RunnersInfo : Form
    {
        static bool tr = false;
        static bool update = false;

        public RunnersInfo()
        {
            InitializeComponent();
        }

        private void RunnersControl_Load(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = -1;
            cmbFilterDistance.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;
            btnASC.Enabled = false;
            btnDESC.Enabled = false;
        }

        private async void RunnersInfo_Shown(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Factory.StartNew(() =>
            {
                DBConnection.GetRunners();
                return DBConnection.dtRunners;
            }
            , TaskCreationOptions.LongRunning);

            lblRowCount.Text = dataGridView1.RowCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath;
            string fileName = path + "\\Runners.csv";
            FileStream fsOutput = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter swOutput = new StreamWriter(fsOutput, Encoding.GetEncoding(1251));
            swOutput.WriteLine("Email; FirstName; SurName; Gender; Date Of Birth; Country Code;");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                swOutput.Write(dataGridView1.Rows[i].Cells["Email"].Value.ToString());
                swOutput.Write(";");
                swOutput.Write(dataGridView1.Rows[i].Cells["FirstName"].Value.ToString());
                swOutput.Write(";");
                swOutput.Write(dataGridView1.Rows[i].Cells["Surname"].Value.ToString());
                swOutput.Write(";");
                swOutput.Write(dataGridView1.Rows[i].Cells["Gender"].Value.ToString());
                swOutput.Write(";");
                swOutput.Write(dataGridView1.Rows[i].Cells["DateOfBirth"].Value.ToString());
                swOutput.Write(";");
                swOutput.Write(dataGridView1.Rows[i].Cells["CountryCode"].Value.ToString());
                swOutput.WriteLine();
            }
            swOutput.Close();
            MessageBox.Show("Экспорт успешно завершен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath;
            string fileName = path + "\\Email.txt";
            FileStream fsOutput = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter swOutput = new StreamWriter(fsOutput);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                swOutput.Write(dataGridView1.Rows[i].Cells["Email"].Value.ToString());
                swOutput.WriteLine();
            }
            swOutput.Close();
            MessageBox.Show("Экспорт успешно завершен");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update = true;
            cmbFilterStatus.SelectedIndex = -1;
            cmbFilterDistance.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;
            update = false;
            btnASC.Enabled = false;
            btnDESC.Enabled = false;
            DBConnection.TypeSort = "ASC";
            DBConnection.GetRunners();
            dataGridView1.DataSource = DBConnection.dtRunners;
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == false)
            {
                if (cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1 && cmbSort.SelectedIndex == -1)
                {
                    DBConnection.FilterStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString());
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbSort.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1 && cmbFilterStatus.SelectedIndex > -1)
                {
                    DBConnection.SortStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbSort.SelectedIndex > -1)
                {
                    DBConnection.SortAndFilterStatus(cmbFilterStatus.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbFilterStatus.SelectedIndex > -1)
                {
                    DBConnection.FilterStatus(cmbFilterStatus.SelectedItem.ToString());
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void cmbFilterDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == false)
            {
                if (cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1 && cmbSort.SelectedIndex == -1)
                {
                    DBConnection.FilterStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString());
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbSort.SelectedIndex > -1 && cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1)
                {
                    DBConnection.SortStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbSort.SelectedIndex > -1)
                {
                    DBConnection.SortAndFilterDistance(cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    return;
                }
                if (cmbFilterDistance.SelectedIndex > -1)
                {
                    DBConnection.FilterDistance(cmbFilterDistance.SelectedItem.ToString());
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == false)
            {
                if (cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1)
                {
                    DBConnection.SortStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    btnASC.Enabled = false;
                    btnDESC.Enabled = true;
                    return;
                }
                if (cmbFilterStatus.SelectedIndex > -1)
                {
                    btnASC.Enabled = false;
                    btnDESC.Enabled = true;
                    DBConnection.SortAndFilterStatus(cmbFilterStatus.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    return;
                }
                if (cmbFilterDistance.SelectedIndex > -1)
                {
                    btnASC.Enabled = false;
                    btnDESC.Enabled = true;
                    DBConnection.SortAndFilterDistance(cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    return;
                }
                if (cmbSort.SelectedIndex > -1)
                {
                    DBConnection.SortRunner(cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                    dataGridView1.DataSource = DBConnection.dtRunners;
                    lblRowCount.Text = dataGridView1.RowCount.ToString();
                    btnASC.Enabled = false;
                    btnDESC.Enabled = true;
                }
            }
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            if (cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1)
            {
                btnASC.Enabled = false;
                btnDESC.Enabled = true;
                DBConnection.TypeSort = "ASC";
                DBConnection.SortStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            if (cmbFilterStatus.SelectedIndex > -1)
            {
                btnASC.Enabled = false;
                btnDESC.Enabled = true;
                DBConnection.TypeSort = "ASC";
                DBConnection.SortAndFilterStatus(cmbFilterStatus.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            if (cmbFilterDistance.SelectedIndex > -1)
            {
                btnASC.Enabled = false;
                btnDESC.Enabled = true;
                DBConnection.TypeSort = "ASC";
                DBConnection.SortAndFilterDistance(cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            btnASC.Enabled = false;
            btnDESC.Enabled = true;
            DBConnection.TypeSort = "ASC";
            DBConnection.SortRunner(cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            if (cmbFilterStatus.SelectedIndex > -1 && cmbFilterDistance.SelectedIndex > -1)
            {
                btnASC.Enabled = true;
                btnDESC.Enabled = false;
                DBConnection.TypeSort = "DESC";
                DBConnection.SortStatusAndDistance(cmbFilterStatus.SelectedItem.ToString(), cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            if (cmbFilterStatus.SelectedIndex > -1)
            {
                btnASC.Enabled = true;
                btnDESC.Enabled = false;
                DBConnection.TypeSort = "DESC";
                DBConnection.SortAndFilterStatus(cmbFilterStatus.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            if (cmbFilterDistance.SelectedIndex > -1)
            {
                btnASC.Enabled = true;
                btnDESC.Enabled = false;
                DBConnection.TypeSort = "DESC";
                DBConnection.SortAndFilterDistance(cmbFilterDistance.SelectedItem.ToString(), cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
                return;
            }
            btnASC.Enabled = true;
            btnDESC.Enabled = false;
            DBConnection.TypeSort = "DESC";
            DBConnection.SortRunner(cmbSort.SelectedItem.ToString(), DBConnection.TypeSort);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DBConnection.GetEmail = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tr = true;
                this.Close();
                RunnerControl Form = new RunnerControl();
                Form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr = true;
            this.Close();
            CoordinatorMenu Form = new CoordinatorMenu();
            Form.Show();
        }

        private void RunnersControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tr != true)
                Application.OpenForms[0].Close();
        }
    }
}
