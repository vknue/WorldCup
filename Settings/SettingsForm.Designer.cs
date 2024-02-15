namespace Settings
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            gbGender = new GroupBox();
            gbLanguage = new GroupBox();
            rbEnglish = new RadioButton();
            rbCroatian = new RadioButton();
            label3 = new Label();
            gbDataAccessMode = new GroupBox();
            rbApi = new RadioButton();
            rbFile = new RadioButton();
            label4 = new Label();
            btnSave = new Button();
            gbGender.SuspendLayout();
            gbLanguage.SuspendLayout();
            gbDataAccessMode.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Settings";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(6, 10);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(36, 19);
            rbMale.TabIndex = 2;
            rbMale.TabStop = true;
            rbMale.Text = "M";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(48, 10);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(31, 19);
            rbFemale.TabIndex = 3;
            rbFemale.Text = "F";
            rbFemale.TextAlign = ContentAlignment.TopCenter;
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rbMale);
            gbGender.Controls.Add(rbFemale);
            gbGender.Location = new Point(116, 36);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(89, 31);
            gbGender.TabIndex = 4;
            gbGender.TabStop = false;
            gbGender.UseCompatibleTextRendering = true;
            // 
            // gbLanguage
            // 
            gbLanguage.Controls.Add(rbEnglish);
            gbLanguage.Controls.Add(rbCroatian);
            gbLanguage.Location = new Point(116, 81);
            gbLanguage.Name = "gbLanguage";
            gbLanguage.Size = new Size(166, 31);
            gbLanguage.TabIndex = 6;
            gbLanguage.TabStop = false;
            gbLanguage.UseCompatibleTextRendering = true;
            // 
            // rbEnglish
            // 
            rbEnglish.AutoSize = true;
            rbEnglish.Checked = true;
            rbEnglish.Location = new Point(6, 10);
            rbEnglish.Name = "rbEnglish";
            rbEnglish.Size = new Size(63, 19);
            rbEnglish.TabIndex = 2;
            rbEnglish.TabStop = true;
            rbEnglish.Text = "English";
            rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            rbCroatian.AutoSize = true;
            rbCroatian.Location = new Point(87, 10);
            rbCroatian.Name = "rbCroatian";
            rbCroatian.Size = new Size(70, 19);
            rbCroatian.TabIndex = 3;
            rbCroatian.Text = "Croatian";
            rbCroatian.TextAlign = ContentAlignment.TopCenter;
            rbCroatian.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Language";
            // 
            // gbDataAccessMode
            // 
            gbDataAccessMode.Controls.Add(rbApi);
            gbDataAccessMode.Controls.Add(rbFile);
            gbDataAccessMode.Location = new Point(116, 131);
            gbDataAccessMode.Name = "gbDataAccessMode";
            gbDataAccessMode.Size = new Size(110, 31);
            gbDataAccessMode.TabIndex = 8;
            gbDataAccessMode.TabStop = false;
            gbDataAccessMode.UseCompatibleTextRendering = true;
            // 
            // rbApi
            // 
            rbApi.AutoSize = true;
            rbApi.Checked = true;
            rbApi.Location = new Point(6, 10);
            rbApi.Name = "rbApi";
            rbApi.Size = new Size(43, 19);
            rbApi.TabIndex = 2;
            rbApi.TabStop = true;
            rbApi.Text = "API";
            rbApi.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            rbFile.AutoSize = true;
            rbFile.Location = new Point(55, 10);
            rbFile.Name = "rbFile";
            rbFile.Size = new Size(43, 19);
            rbFile.TabIndex = 3;
            rbFile.Text = "File";
            rbFile.TextAlign = ContentAlignment.TopCenter;
            rbFile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Data Access Mode";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 256);
            Controls.Add(btnSave);
            Controls.Add(gbDataAccessMode);
            Controls.Add(label4);
            Controls.Add(gbLanguage);
            Controls.Add(label3);
            Controls.Add(gbGender);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Settings";
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            gbLanguage.ResumeLayout(false);
            gbLanguage.PerformLayout();
            gbDataAccessMode.ResumeLayout(false);
            gbDataAccessMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox gbGender;
        private GroupBox gbLanguage;
        private RadioButton rbEnglish;
        private RadioButton rbCroatian;
        private Label label3;
        private GroupBox gbDataAccessMode;
        private RadioButton rbApi;
        private RadioButton rbFile;
        private Label label4;
        private Button btnSave;
    }
}