namespace Medicine_Project
{
    partial class AddTemperature
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
            this.label2 = new System.Windows.Forms.Label();
            this.BackButtonAT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTXT = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TempTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TemperatureSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(82, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 45);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add Temperature";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButtonAT
            // 
            this.BackButtonAT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackButtonAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButtonAT.FlatAppearance.BorderSize = 0;
            this.BackButtonAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButtonAT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButtonAT.Location = new System.Drawing.Point(118, 374);
            this.BackButtonAT.Name = "BackButtonAT";
            this.BackButtonAT.Size = new System.Drawing.Size(184, 39);
            this.BackButtonAT.TabIndex = 28;
            this.BackButtonAT.Text = "Back";
            this.BackButtonAT.UseVisualStyleBackColor = false;
            this.BackButtonAT.Click += new System.EventHandler(this.BackButtonAT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tempreature";
            // 
            // DateTXT
            // 
            this.DateTXT.Location = new System.Drawing.Point(118, 219);
            this.DateTXT.Name = "DateTXT";
            this.DateTXT.Size = new System.Drawing.Size(184, 23);
            this.DateTXT.TabIndex = 23;
            this.DateTXT.Text = "23.01.2023";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AddButton.Location = new System.Drawing.Point(118, 319);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(184, 39);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TempTXT
            // 
            this.TempTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TempTXT.Location = new System.Drawing.Point(118, 112);
            this.TempTXT.Name = "TempTXT";
            this.TempTXT.Size = new System.Drawing.Size(184, 23);
            this.TempTXT.TabIndex = 22;
            this.TempTXT.Text = "36.6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date";
            // 
            // TimeTXT
            // 
            this.TimeTXT.Location = new System.Drawing.Point(118, 279);
            this.TimeTXT.Name = "TimeTXT";
            this.TimeTXT.Size = new System.Drawing.Size(184, 23);
            this.TimeTXT.TabIndex = 30;
            this.TimeTXT.Text = "10:30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Time";
            // 
            // TemperatureSlider
            // 
            this.TemperatureSlider.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.TemperatureSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TemperatureSlider.Location = new System.Drawing.Point(118, 141);
            this.TemperatureSlider.Maximum = 4000;
            this.TemperatureSlider.Minimum = 3400;
            this.TemperatureSlider.Name = "TemperatureSlider";
            this.TemperatureSlider.Size = new System.Drawing.Size(184, 45);
            this.TemperatureSlider.TabIndex = 32;
            this.TemperatureSlider.Value = 3660;
            this.TemperatureSlider.Scroll += new System.EventHandler(this.TemperatureSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "34.00°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "40.00°C";
            // 
            // AddTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TemperatureSlider);
            this.Controls.Add(this.TimeTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButtonAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTXT);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TempTXT);
            this.Controls.Add(this.label6);
            this.Name = "AddTemperature";
            this.Text = "AddTemperature";
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button BackButtonAT;
        private Label label5;
        private TextBox DateTXT;
        private Button AddButton;
        private TextBox TempTXT;
        private Label label6;
        private TextBox TimeTXT;
        private Label label1;
        private TrackBar TemperatureSlider;
        private Label label3;
        private Label label4;
    }
}