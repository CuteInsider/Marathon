namespace Marathon
{
    partial class MyRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGWMyRecords = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgGnder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarathonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfMarathon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceInCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMyRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 60);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "All Records";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Go back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marathon Skills 2018";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 3;
            // 
            // dGWMyRecords
            // 
            this.dGWMyRecords.AllowUserToAddRows = false;
            this.dGWMyRecords.AllowUserToDeleteRows = false;
            this.dGWMyRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGWMyRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMyRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarathonName,
            this.TypeOfMarathon,
            this.Time,
            this.Place,
            this.PlaceInCategory});
            this.dGWMyRecords.Location = new System.Drawing.Point(12, 323);
            this.dGWMyRecords.Name = "dGWMyRecords";
            this.dGWMyRecords.ReadOnly = true;
            this.dGWMyRecords.Size = new System.Drawing.Size(760, 179);
            this.dGWMyRecords.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "My Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender:";
            // 
            // lblgGnder
            // 
            this.lblgGnder.AutoSize = true;
            this.lblgGnder.Location = new System.Drawing.Point(244, 298);
            this.lblgGnder.Name = "lblgGnder";
            this.lblgGnder.Size = new System.Drawing.Size(61, 22);
            this.lblgGnder.TabIndex = 6;
            this.lblgGnder.Text = "load...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(453, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age category:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(599, 298);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(61, 22);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "load...";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(152, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 54);
            this.label4.TabIndex = 7;
            this.label4.Text = "My Results - This is a list with all the results of your races";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarathonName
            // 
            this.MarathonName.DataPropertyName = "EventName";
            this.MarathonName.FillWeight = 151.0198F;
            this.MarathonName.HeaderText = "Marathon";
            this.MarathonName.Name = "MarathonName";
            this.MarathonName.ReadOnly = true;
            // 
            // TypeOfMarathon
            // 
            this.TypeOfMarathon.DataPropertyName = "EventTypeId";
            this.TypeOfMarathon.FillWeight = 151.0198F;
            this.TypeOfMarathon.HeaderText = "Marathon type";
            this.TypeOfMarathon.Name = "TypeOfMarathon";
            this.TypeOfMarathon.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "RaceTime";
            this.Time.FillWeight = 63.455F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Place
            // 
            this.Place.FillWeight = 58.36321F;
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // PlaceInCategory
            // 
            this.PlaceInCategory.FillWeight = 76.14212F;
            this.PlaceInCategory.HeaderText = "Category Place";
            this.PlaceInCategory.Name = "PlaceInCategory";
            this.PlaceInCategory.ReadOnly = true;
            // 
            // MyRecords
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgGnder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWMyRecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MyRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRecords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyRecords_FormClosing);
            this.Load += new System.EventHandler(this.MyRecords_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMyRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGWMyRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgGnder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfMarathon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceInCategory;
    }
}