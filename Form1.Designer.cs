namespace PE18
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonTypecomboBox = new System.Windows.Forms.ComboBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.LicenceIDtextBox = new System.Windows.Forms.TextBox();
            this.GPAtextBox = new System.Windows.Forms.TextBox();
            this.GendergroupBox = new System.Windows.Forms.GroupBox();
            this.ClassgroupBox = new System.Windows.Forms.GroupBox();
            this.HimradioButton = new System.Windows.Forms.RadioButton();
            this.HerradioButton = new System.Windows.Forms.RadioButton();
            this.ThemradioButton = new System.Windows.Forms.RadioButton();
            this.FreshmanradioButton = new System.Windows.Forms.RadioButton();
            this.SophomoreradioButton = new System.Windows.Forms.RadioButton();
            this.JuniorradioButton = new System.Windows.Forms.RadioButton();
            this.SeniorradioButton = new System.Windows.Forms.RadioButton();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ClassOfTextbox = new System.Windows.Forms.TextBox();
            this.GendergroupBox.SuspendLayout();
            this.ClassgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Licence ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "GPA";
            // 
            // PersonTypecomboBox
            // 
            this.PersonTypecomboBox.FormattingEnabled = true;
            this.PersonTypecomboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.PersonTypecomboBox.Location = new System.Drawing.Point(179, 78);
            this.PersonTypecomboBox.Name = "PersonTypecomboBox";
            this.PersonTypecomboBox.Size = new System.Drawing.Size(121, 21);
            this.PersonTypecomboBox.TabIndex = 6;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(179, 130);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 7;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(179, 183);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailtextBox.TabIndex = 8;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(179, 243);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(100, 20);
            this.AgetextBox.TabIndex = 9;
            // 
            // LicenceIDtextBox
            // 
            this.LicenceIDtextBox.Location = new System.Drawing.Point(179, 305);
            this.LicenceIDtextBox.Name = "LicenceIDtextBox";
            this.LicenceIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.LicenceIDtextBox.TabIndex = 10;
            // 
            // GPAtextBox
            // 
            this.GPAtextBox.Location = new System.Drawing.Point(179, 362);
            this.GPAtextBox.Name = "GPAtextBox";
            this.GPAtextBox.Size = new System.Drawing.Size(100, 20);
            this.GPAtextBox.TabIndex = 11;
            // 
            // GendergroupBox
            // 
            this.GendergroupBox.Controls.Add(this.ThemradioButton);
            this.GendergroupBox.Controls.Add(this.HerradioButton);
            this.GendergroupBox.Controls.Add(this.HimradioButton);
            this.GendergroupBox.Location = new System.Drawing.Point(438, 78);
            this.GendergroupBox.Name = "GendergroupBox";
            this.GendergroupBox.Size = new System.Drawing.Size(200, 100);
            this.GendergroupBox.TabIndex = 12;
            this.GendergroupBox.TabStop = false;
            this.GendergroupBox.Text = "Gender";
            // 
            // ClassgroupBox
            // 
            this.ClassgroupBox.Controls.Add(this.ClassOfTextbox);
            this.ClassgroupBox.Controls.Add(this.SeniorradioButton);
            this.ClassgroupBox.Controls.Add(this.JuniorradioButton);
            this.ClassgroupBox.Controls.Add(this.SophomoreradioButton);
            this.ClassgroupBox.Controls.Add(this.FreshmanradioButton);
            this.ClassgroupBox.Location = new System.Drawing.Point(705, 78);
            this.ClassgroupBox.Name = "ClassgroupBox";
            this.ClassgroupBox.Size = new System.Drawing.Size(200, 185);
            this.ClassgroupBox.TabIndex = 13;
            this.ClassgroupBox.TabStop = false;
            this.ClassgroupBox.Text = "Class";
            // 
            // HimradioButton
            // 
            this.HimradioButton.AutoSize = true;
            this.HimradioButton.Location = new System.Drawing.Point(7, 20);
            this.HimradioButton.Name = "HimradioButton";
            this.HimradioButton.Size = new System.Drawing.Size(43, 17);
            this.HimradioButton.TabIndex = 0;
            this.HimradioButton.TabStop = true;
            this.HimradioButton.Text = "Him";
            this.HimradioButton.UseVisualStyleBackColor = true;
            // 
            // HerradioButton
            // 
            this.HerradioButton.AutoSize = true;
            this.HerradioButton.Location = new System.Drawing.Point(7, 48);
            this.HerradioButton.Name = "HerradioButton";
            this.HerradioButton.Size = new System.Drawing.Size(42, 17);
            this.HerradioButton.TabIndex = 1;
            this.HerradioButton.TabStop = true;
            this.HerradioButton.Text = "Her";
            this.HerradioButton.UseVisualStyleBackColor = true;
            // 
            // ThemradioButton
            // 
            this.ThemradioButton.AutoSize = true;
            this.ThemradioButton.Location = new System.Drawing.Point(7, 77);
            this.ThemradioButton.Name = "ThemradioButton";
            this.ThemradioButton.Size = new System.Drawing.Size(52, 17);
            this.ThemradioButton.TabIndex = 2;
            this.ThemradioButton.TabStop = true;
            this.ThemradioButton.Text = "Them";
            this.ThemradioButton.UseVisualStyleBackColor = true;
            // 
            // FreshmanradioButton
            // 
            this.FreshmanradioButton.AutoSize = true;
            this.FreshmanradioButton.Location = new System.Drawing.Point(7, 20);
            this.FreshmanradioButton.Name = "FreshmanradioButton";
            this.FreshmanradioButton.Size = new System.Drawing.Size(71, 17);
            this.FreshmanradioButton.TabIndex = 0;
            this.FreshmanradioButton.TabStop = true;
            this.FreshmanradioButton.Text = "Freshman";
            this.FreshmanradioButton.UseVisualStyleBackColor = true;
            // 
            // SophomoreradioButton
            // 
            this.SophomoreradioButton.AutoSize = true;
            this.SophomoreradioButton.Location = new System.Drawing.Point(7, 48);
            this.SophomoreradioButton.Name = "SophomoreradioButton";
            this.SophomoreradioButton.Size = new System.Drawing.Size(79, 17);
            this.SophomoreradioButton.TabIndex = 1;
            this.SophomoreradioButton.TabStop = true;
            this.SophomoreradioButton.Text = "Sophomore";
            this.SophomoreradioButton.UseVisualStyleBackColor = true;
            // 
            // JuniorradioButton
            // 
            this.JuniorradioButton.AutoSize = true;
            this.JuniorradioButton.Location = new System.Drawing.Point(7, 77);
            this.JuniorradioButton.Name = "JuniorradioButton";
            this.JuniorradioButton.Size = new System.Drawing.Size(53, 17);
            this.JuniorradioButton.TabIndex = 2;
            this.JuniorradioButton.TabStop = true;
            this.JuniorradioButton.Text = "Junior";
            this.JuniorradioButton.UseVisualStyleBackColor = true;
            // 
            // SeniorradioButton
            // 
            this.SeniorradioButton.AutoSize = true;
            this.SeniorradioButton.Location = new System.Drawing.Point(7, 103);
            this.SeniorradioButton.Name = "SeniorradioButton";
            this.SeniorradioButton.Size = new System.Drawing.Size(55, 17);
            this.SeniorradioButton.TabIndex = 3;
            this.SeniorradioButton.TabStop = true;
            this.SeniorradioButton.Text = "Senior";
            this.SeniorradioButton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(626, 365);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 14;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(798, 365);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ClassOfTextbox
            // 
            this.ClassOfTextbox.Location = new System.Drawing.Point(50, 138);
            this.ClassOfTextbox.Name = "ClassOfTextbox";
            this.ClassOfTextbox.Size = new System.Drawing.Size(100, 20);
            this.ClassOfTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 481);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.ClassgroupBox);
            this.Controls.Add(this.GendergroupBox);
            this.Controls.Add(this.GPAtextBox);
            this.Controls.Add(this.LicenceIDtextBox);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.PersonTypecomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GendergroupBox.ResumeLayout(false);
            this.GendergroupBox.PerformLayout();
            this.ClassgroupBox.ResumeLayout(false);
            this.ClassgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PersonTypecomboBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.TextBox LicenceIDtextBox;
        private System.Windows.Forms.TextBox GPAtextBox;
        private System.Windows.Forms.GroupBox GendergroupBox;
        private System.Windows.Forms.RadioButton ThemradioButton;
        private System.Windows.Forms.RadioButton HerradioButton;
        private System.Windows.Forms.RadioButton HimradioButton;
        private System.Windows.Forms.GroupBox ClassgroupBox;
        private System.Windows.Forms.RadioButton SeniorradioButton;
        private System.Windows.Forms.RadioButton JuniorradioButton;
        private System.Windows.Forms.RadioButton SophomoreradioButton;
        private System.Windows.Forms.RadioButton FreshmanradioButton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TextBox ClassOfTextbox;
    }
}

