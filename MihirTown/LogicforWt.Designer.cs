namespace MihirTown
{
    partial class LogicforWT
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.energyTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoodHealth = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.GoodEnergy = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.badenergy = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.badhealth = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.heal = new System.Windows.Forms.Button();
            this.slam = new System.Windows.Forms.Button();
            this.fireball = new System.Windows.Forms.Button();
            this.vader = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.badguyattack = new System.Windows.Forms.Timer(this.components);
            this.badguyenergytimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MihirTown.Properties.Resources.animated_gifs_of_fighting_game_backgrounds_25;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MihirTown.Properties.Resources.Wizard_info;
            this.pictureBox2.Location = new System.Drawing.Point(745, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // energyTimer
            // 
            this.energyTimer.Enabled = true;
            this.energyTimer.Tick += new System.EventHandler(this.energyTimer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MihirTown.Properties.Resources.Wizard3;
            this.pictureBox3.Location = new System.Drawing.Point(24, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(339, 317);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(650, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "WizardTown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(718, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ultimate Edition";
            // 
            // GoodHealth
            // 
            this.GoodHealth.Location = new System.Drawing.Point(263, 368);
            this.GoodHealth.Name = "GoodHealth";
            this.GoodHealth.Size = new System.Drawing.Size(100, 23);
            this.GoodHealth.TabIndex = 5;
            this.GoodHealth.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Andy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(280, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Health";
            // 
            // GoodEnergy
            // 
            this.GoodEnergy.Location = new System.Drawing.Point(263, 439);
            this.GoodEnergy.Name = "GoodEnergy";
            this.GoodEnergy.Size = new System.Drawing.Size(100, 23);
            this.GoodEnergy.TabIndex = 7;
            this.GoodEnergy.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Andy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(275, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Energy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Andy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(683, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Energy";
            // 
            // badenergy
            // 
            this.badenergy.Location = new System.Drawing.Point(667, 439);
            this.badenergy.Name = "badenergy";
            this.badenergy.Size = new System.Drawing.Size(100, 23);
            this.badenergy.TabIndex = 12;
            this.badenergy.Value = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Andy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(687, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Health";
            // 
            // badhealth
            // 
            this.badhealth.Location = new System.Drawing.Point(667, 368);
            this.badhealth.Name = "badhealth";
            this.badhealth.Size = new System.Drawing.Size(100, 23);
            this.badhealth.TabIndex = 10;
            this.badhealth.Value = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trajan Pro 3", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(138, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Attacks";
            // 
            // heal
            // 
            this.heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.heal.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heal.Location = new System.Drawing.Point(130, 223);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(110, 23);
            this.heal.TabIndex = 15;
            this.heal.Text = "Heal";
            this.heal.UseVisualStyleBackColor = false;
            this.heal.Click += new System.EventHandler(this.heal_Click);
            // 
            // slam
            // 
            this.slam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slam.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slam.Location = new System.Drawing.Point(130, 281);
            this.slam.Name = "slam";
            this.slam.Size = new System.Drawing.Size(111, 23);
            this.slam.TabIndex = 16;
            this.slam.Text = "TelekSlam";
            this.slam.UseVisualStyleBackColor = false;
            // 
            // fireball
            // 
            this.fireball.BackColor = System.Drawing.Color.Aqua;
            this.fireball.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireball.Location = new System.Drawing.Point(129, 252);
            this.fireball.Name = "fireball";
            this.fireball.Size = new System.Drawing.Size(111, 23);
            this.fireball.TabIndex = 17;
            this.fireball.Text = "Fireball 2.0";
            this.fireball.UseVisualStyleBackColor = false;
            this.fireball.Click += new System.EventHandler(this.fireball_Click);
            // 
            // vader
            // 
            this.vader.BackColor = System.Drawing.Color.Lime;
            this.vader.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vader.Location = new System.Drawing.Point(130, 310);
            this.vader.Name = "vader";
            this.vader.Size = new System.Drawing.Size(111, 23);
            this.vader.TabIndex = 18;
            this.vader.Text = "Darth Vader";
            this.vader.UseVisualStyleBackColor = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Motorwerk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(271, 268);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(76, 24);
            this.error.TabIndex = 20;
            this.error.Text = "Wait For\nEnergy!";
            this.error.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.error.Visible = false;
            // 
            // badguyattack
            // 
            this.badguyattack.Enabled = true;
            this.badguyattack.Interval = 5000;
            this.badguyattack.Tick += new System.EventHandler(this.badguyattack_Tick);
            // 
            // badguyenergytimer
            // 
            this.badguyenergytimer.Tick += new System.EventHandler(this.badguyenergytimer_Tick);
            // 
            // LogicforWT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MihirTown.Properties.Resources.animated_gifs_of_fighting_game_backgrounds_25;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 542);
            this.Controls.Add(this.error);
            this.Controls.Add(this.vader);
            this.Controls.Add(this.fireball);
            this.Controls.Add(this.slam);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.badenergy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.badhealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoodEnergy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoodHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogicforWT";
            this.Text = "WizardTown Ultimate Edition";
            this.Load += new System.EventHandler(this.LogicforWT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer energyTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar GoodHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar GoodEnergy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar badenergy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar badhealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button heal;
        private System.Windows.Forms.Button slam;
        private System.Windows.Forms.Button fireball;
        private System.Windows.Forms.Button vader;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Timer badguyattack;
        private System.Windows.Forms.Timer badguyenergytimer;
    }
}