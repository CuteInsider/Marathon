namespace Marathon
{
    partial class RegistrationOnMarathon
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CharityPanel = new System.Windows.Forms.Panel();
            this.CharityDescription = new System.Windows.Forms.Label();
            this.CharityLogo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CharityName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFM = new System.Windows.Forms.CheckBox();
            this.cbSM = new System.Windows.Forms.CheckBox();
            this.cbSD = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbContribution = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDescription = new System.Windows.Forms.Button();
            this.CharityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharityLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 0;
            // 
            // CharityPanel
            // 
            this.CharityPanel.BackColor = System.Drawing.Color.Gray;
            this.CharityPanel.Controls.Add(this.CharityDescription);
            this.CharityPanel.Controls.Add(this.CharityLogo);
            this.CharityPanel.Controls.Add(this.button3);
            this.CharityPanel.Controls.Add(this.CharityName);
            this.CharityPanel.Location = new System.Drawing.Point(0, 489);
            this.CharityPanel.Name = "CharityPanel";
            this.CharityPanel.Size = new System.Drawing.Size(500, 255);
            this.CharityPanel.TabIndex = 23;
            // 
            // CharityDescription
            // 
            this.CharityDescription.ForeColor = System.Drawing.Color.White;
            this.CharityDescription.Location = new System.Drawing.Point(0, 144);
            this.CharityDescription.Name = "CharityDescription";
            this.CharityDescription.Size = new System.Drawing.Size(500, 111);
            this.CharityDescription.TabIndex = 3;
            this.CharityDescription.Text = "-";
            // 
            // CharityLogo
            // 
            this.CharityLogo.Location = new System.Drawing.Point(200, 36);
            this.CharityLogo.Name = "CharityLogo";
            this.CharityLogo.Size = new System.Drawing.Size(100, 100);
            this.CharityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharityLogo.TabIndex = 2;
            this.CharityLogo.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CharityName
            // 
            this.CharityName.ForeColor = System.Drawing.Color.White;
            this.CharityName.Location = new System.Drawing.Point(0, 0);
            this.CharityName.Name = "CharityName";
            this.CharityName.Size = new System.Drawing.Size(500, 22);
            this.CharityName.TabIndex = 1;
            this.CharityName.Text = "-";
            this.CharityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 60);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Go back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marathon Skills 2016";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please fill out all the information to register for Marathon Skills 2018. You wil" +
    "l be contacted to clarify the payment and other information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registration On Marathon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(84, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type of the marathon";
            // 
            // cbFM
            // 
            this.cbFM.AutoSize = true;
            this.cbFM.Location = new System.Drawing.Point(87, 275);
            this.cbFM.Name = "cbFM";
            this.cbFM.Size = new System.Drawing.Size(259, 26);
            this.cbFM.TabIndex = 5;
            this.cbFM.Text = "42 km Full Marathon (145$)";
            this.cbFM.UseVisualStyleBackColor = true;
            this.cbFM.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbSM
            // 
            this.cbSM.AutoSize = true;
            this.cbSM.Location = new System.Drawing.Point(88, 238);
            this.cbSM.Name = "cbSM";
            this.cbSM.Size = new System.Drawing.Size(263, 26);
            this.cbSM.TabIndex = 6;
            this.cbSM.Text = "21 km Semi-Marathon (75$)";
            this.cbSM.UseVisualStyleBackColor = true;
            this.cbSM.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbSD
            // 
            this.cbSD.AutoSize = true;
            this.cbSD.Location = new System.Drawing.Point(87, 206);
            this.cbSD.Name = "cbSD";
            this.cbSD.Size = new System.Drawing.Size(249, 26);
            this.cbSD.TabIndex = 7;
            this.cbSD.Text = "5 km Short Distance (20$)";
            this.cbSD.UseVisualStyleBackColor = true;
            this.cbSD.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(482, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kit Options";
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(450, 206);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(305, 48);
            this.rbtnA.TabIndex = 9;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "Option A (0$): Number of nunner \r\n+ RFIB bracelet";
            this.rbtnA.UseVisualStyleBackColor = true;
            this.rbtnA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(450, 263);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(267, 48);
            this.rbtnB.TabIndex = 10;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "Option B (20$):  Option A +\r\n Water Bottle + Baseball cap";
            this.rbtnB.UseVisualStyleBackColor = true;
            this.rbtnB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(450, 319);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(258, 48);
            this.rbtnC.TabIndex = 11;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "Option C (45$): Option B + \r\nT-Shirt + Souvenir bouquet";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(84, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sponsorship Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contribution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount Contribution";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(202, 396);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 29);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // cmbContribution
            // 
            this.cmbContribution.AutoCompleteCustomSource.AddRange(new string[] {
            "Arise",
            "Aves do Brasil",
            "Clara Santos Oliveira Institute",
            "Conquer Cancer - Brazil",
            "Diabetes Brazil",
            "Heart Health São Paulo",
            "Human Rights Centre  - São Paulo",
            "Stay Pumped",
            "Upbeat SP",
            "WWSM Rescue",
            "The Red Cross",
            "Oxfam International",
            "Save the Children Fund",
            "Querstadtein Berlin"});
            this.cmbContribution.FormattingEnabled = true;
            this.cmbContribution.Location = new System.Drawing.Point(202, 348);
            this.cmbContribution.Name = "cmbContribution";
            this.cmbContribution.Size = new System.Drawing.Size(123, 30);
            this.cmbContribution.TabIndex = 17;
            this.cmbContribution.SelectedIndexChanged += new System.EventHandler(this.cmbContribution_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(468, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(481, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 33);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(470, 453);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(302, 30);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "-";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDescription
            // 
            this.btnDescription.Enabled = false;
            this.btnDescription.Location = new System.Drawing.Point(331, 348);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(30, 30);
            this.btnDescription.TabIndex = 24;
            this.btnDescription.Text = "!";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.button5_Click);
            // 
            // RegistrationOnMarathon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CharityPanel);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbContribution);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSD);
            this.Controls.Add(this.cbSM);
            this.Controls.Add(this.cbFM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationOnMarathon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration On Marathon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationOnMarathon_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationOnMarathon_Load);
            this.Click += new System.EventHandler(this.RegistrationOnMarathon_Click);
            this.CharityPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharityLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbFM;
        private System.Windows.Forms.CheckBox cbSM;
        private System.Windows.Forms.CheckBox cbSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbContribution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel CharityPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label CharityDescription;
        private System.Windows.Forms.PictureBox CharityLogo;
        private System.Windows.Forms.Label CharityName;
        private System.Windows.Forms.Button btnDescription;
    }
}

