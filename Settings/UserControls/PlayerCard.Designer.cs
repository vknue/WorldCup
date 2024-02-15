namespace Forms.UserControls
{
    partial class PlayerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblCaptain = new Label();
            lblShirtNumber = new Label();
            lblPosition = new Label();
            pbProfilePicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AccessibleName = "";
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCaptain.ForeColor = Color.Lime;
            lblCaptain.Location = new Point(284, 18);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(20, 21);
            lblCaptain.TabIndex = 1;
            lblCaptain.Text = "C";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblShirtNumber.ForeColor = SystemColors.MenuHighlight;
            lblShirtNumber.Location = new Point(142, -18);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(94, 86);
            lblShirtNumber.TabIndex = 2;
            lblShirtNumber.Text = "-1";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(240, 23);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(26, 15);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "MC";
            // 
            // pbProfilePicture
            // 
            pbProfilePicture.BackgroundImage = Properties.Preferences.profilePictureBackholder;
            pbProfilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfilePicture.InitialImage = Properties.Preferences.profilePictureBackholder;
            pbProfilePicture.Location = new Point(3, 3);
            pbProfilePicture.Name = "pbProfilePicture";
            pbProfilePicture.Size = new Size(65, 53);
            pbProfilePicture.TabIndex = 4;
            pbProfilePicture.TabStop = false;
            pbProfilePicture.Click += pbProfilePicture_Click;
            // 
            // PlayerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Preferences.player_background;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(pbProfilePicture);
            Controls.Add(lblPosition);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblCaptain);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Name = "PlayerCard";
            Size = new Size(307, 59);
            Load += PlayerCard_Load;
            MouseDown += PlayerCard_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCaptain;
        private Label lblShirtNumber;
        private Label lblPosition;
        private PictureBox pbProfilePicture;
    }
}
