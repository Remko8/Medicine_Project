namespace Medicine_Project
{
    partial class Patient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox KNNComboBox;
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.tempMaxLabel = new System.Windows.Forms.Label();
            this.tempAVGLabel = new System.Windows.Forms.Label();
            this.tempMinLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helloUserLabel = new System.Windows.Forms.Label();
            this.AddTmpButton = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.AccountMenuPanel = new System.Windows.Forms.Panel();
            this.KNearestNeighborsButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.NeuralNetworkButton = new System.Windows.Forms.RadioButton();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            KNNComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.AccountMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KNNComboBox
            // 
            KNNComboBox.BackColor = System.Drawing.SystemColors.Window;
            KNNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            KNNComboBox.FormattingEnabled = true;
            KNNComboBox.Items.AddRange(new object[] {
            "\"k = 1\"",
            "\"k = 2\"",
            "\"k = 3\"",
            "\"k = 4\"",
            "\"k = 5\""});
            KNNComboBox.Location = new System.Drawing.Point(3, 60);
            KNNComboBox.Name = "KNNComboBox";
            KNNComboBox.Size = new System.Drawing.Size(178, 23);
            KNNComboBox.TabIndex = 5;
            KNNComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPanel.Controls.Add(this.label8);
            this.backgroundPanel.Controls.Add(this.label7);
            this.backgroundPanel.Controls.Add(this.label6);
            this.backgroundPanel.Controls.Add(this.label5);
            this.backgroundPanel.Controls.Add(this.label4);
            this.backgroundPanel.Controls.Add(this.label3);
            this.backgroundPanel.Controls.Add(this.label2);
            this.backgroundPanel.Controls.Add(this.label1);
            this.backgroundPanel.Controls.Add(this.label0);
            this.backgroundPanel.Controls.Add(this.tempMaxLabel);
            this.backgroundPanel.Controls.Add(this.tempAVGLabel);
            this.backgroundPanel.Controls.Add(this.tempMinLabel);
            this.backgroundPanel.Controls.Add(this.panel9);
            this.backgroundPanel.Controls.Add(this.panel8);
            this.backgroundPanel.Controls.Add(this.panel7);
            this.backgroundPanel.Controls.Add(this.panel6);
            this.backgroundPanel.Controls.Add(this.panel5);
            this.backgroundPanel.Controls.Add(this.panel4);
            this.backgroundPanel.Controls.Add(this.panel3);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Controls.Add(this.panel1);
            this.backgroundPanel.Location = new System.Drawing.Point(51, 78);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(595, 238);
            this.backgroundPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(524, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "23.01";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(463, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "23.01";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(406, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "23.01";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(345, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "23.01";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(285, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "23.01";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(227, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "23.01";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "23.01";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "23.01";
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label0.Location = new System.Drawing.Point(50, 199);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(44, 19);
            this.label0.TabIndex = 11;
            this.label0.Text = "23.01";
            // 
            // tempMaxLabel
            // 
            this.tempMaxLabel.AutoSize = true;
            this.tempMaxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempMaxLabel.Location = new System.Drawing.Point(5, 16);
            this.tempMaxLabel.Name = "tempMaxLabel";
            this.tempMaxLabel.Size = new System.Drawing.Size(44, 21);
            this.tempMaxLabel.TabIndex = 10;
            this.tempMaxLabel.Text = "37°C";
            // 
            // tempAVGLabel
            // 
            this.tempAVGLabel.AutoSize = true;
            this.tempAVGLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempAVGLabel.Location = new System.Drawing.Point(3, 98);
            this.tempAVGLabel.Name = "tempAVGLabel";
            this.tempAVGLabel.Size = new System.Drawing.Size(40, 21);
            this.tempAVGLabel.TabIndex = 9;
            this.tempAVGLabel.Text = "36.5";
            // 
            // tempMinLabel
            // 
            this.tempMinLabel.AutoSize = true;
            this.tempMinLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempMinLabel.Location = new System.Drawing.Point(5, 181);
            this.tempMinLabel.Name = "tempMinLabel";
            this.tempMinLabel.Size = new System.Drawing.Size(28, 21);
            this.tempMinLabel.TabIndex = 8;
            this.tempMinLabel.Text = "36";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel9.Location = new System.Drawing.Point(528, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(40, 180);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel8.Location = new System.Drawing.Point(467, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(40, 180);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel7.Location = new System.Drawing.Point(410, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(40, 180);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel6.Location = new System.Drawing.Point(349, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 180);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Location = new System.Drawing.Point(289, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 180);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Location = new System.Drawing.Point(231, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 180);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(169, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 180);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Location = new System.Drawing.Point(109, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 180);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(53, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // helloUserLabel
            // 
            this.helloUserLabel.AutoSize = true;
            this.helloUserLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloUserLabel.Location = new System.Drawing.Point(50, 12);
            this.helloUserLabel.Name = "helloUserLabel";
            this.helloUserLabel.Size = new System.Drawing.Size(95, 45);
            this.helloUserLabel.TabIndex = 2;
            this.helloUserLabel.Text = "Hello";
            this.helloUserLabel.Click += new System.EventHandler(this.helloUserLabel_Click);
            // 
            // AddTmpButton
            // 
            this.AddTmpButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddTmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTmpButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTmpButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddTmpButton.Location = new System.Drawing.Point(51, 328);
            this.AddTmpButton.Name = "AddTmpButton";
            this.AddTmpButton.Size = new System.Drawing.Size(218, 44);
            this.AddTmpButton.TabIndex = 3;
            this.AddTmpButton.Text = "ADD MEASUREMENT";
            this.AddTmpButton.UseVisualStyleBackColor = false;
            this.AddTmpButton.Click += new System.EventHandler(this.AddTmpButton_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.AccountButton);
            this.panel10.Controls.Add(this.AccountMenuPanel);
            this.panel10.Location = new System.Drawing.Point(670, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(190, 235);
            this.panel10.TabIndex = 4;
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AccountButton.Location = new System.Drawing.Point(3, 3);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(181, 48);
            this.AccountButton.TabIndex = 5;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // AccountMenuPanel
            // 
            this.AccountMenuPanel.BackColor = System.Drawing.Color.White;
            this.AccountMenuPanel.Controls.Add(this.KNearestNeighborsButton);
            this.AccountMenuPanel.Controls.Add(this.button3);
            this.AccountMenuPanel.Controls.Add(this.NeuralNetworkButton);
            this.AccountMenuPanel.Controls.Add(this.SignOutButton);
            this.AccountMenuPanel.Controls.Add(KNNComboBox);
            this.AccountMenuPanel.Location = new System.Drawing.Point(3, 57);
            this.AccountMenuPanel.Name = "AccountMenuPanel";
            this.AccountMenuPanel.Size = new System.Drawing.Size(184, 175);
            this.AccountMenuPanel.TabIndex = 1;
            this.AccountMenuPanel.Visible = false;
            // 
            // KNearestNeighborsButton
            // 
            this.KNearestNeighborsButton.AutoSize = true;
            this.KNearestNeighborsButton.Checked = true;
            this.KNearestNeighborsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KNearestNeighborsButton.Location = new System.Drawing.Point(3, 29);
            this.KNearestNeighborsButton.Name = "KNearestNeighborsButton";
            this.KNearestNeighborsButton.Size = new System.Drawing.Size(174, 25);
            this.KNearestNeighborsButton.TabIndex = 7;
            this.KNearestNeighborsButton.TabStop = true;
            this.KNearestNeighborsButton.Text = "K-Nearest Neighbors";
            this.KNearestNeighborsButton.UseVisualStyleBackColor = true;
            this.KNearestNeighborsButton.CheckedChanged += new System.EventHandler(this.KNearestNeighborsButton_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(3, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NeuralNetworkButton
            // 
            this.NeuralNetworkButton.AutoSize = true;
            this.NeuralNetworkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NeuralNetworkButton.Location = new System.Drawing.Point(3, 3);
            this.NeuralNetworkButton.Name = "NeuralNetworkButton";
            this.NeuralNetworkButton.Size = new System.Drawing.Size(139, 25);
            this.NeuralNetworkButton.TabIndex = 6;
            this.NeuralNetworkButton.Text = "Neural Network";
            this.NeuralNetworkButton.UseVisualStyleBackColor = true;
            this.NeuralNetworkButton.CheckedChanged += new System.EventHandler(this.NeuralNetworkButton_CheckedChanged);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignOutButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SignOutButton.Location = new System.Drawing.Point(3, 90);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(178, 39);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(377, 328);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 525);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.AddTmpButton);
            this.Controls.Add(this.helloUserLabel);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Patient";
            this.Text = "Patient";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.AccountMenuPanel.ResumeLayout(false);
            this.AccountMenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolTip toolTip1;
        private Panel backgroundPanel;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label helloUserLabel;
        private Button AddTmpButton;
        private Label tempAVGLabel;
        private Label tempMinLabel;
        private Label tempMaxLabel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label0;
        private Panel panel10;
        private Button button1;
        private Panel panel11;
        private Button AccountButton;
        private Panel AccountMenuPanel;
        private ComboBox KNNComboBox;
        private Button button3;
        private Button SignOutButton;
        private MonthCalendar monthCalendar1;
        private RadioButton NeuralNetworkButton;
        private RadioButton KNearestNeighborsButton;
    }
}