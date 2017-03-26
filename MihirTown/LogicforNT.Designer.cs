namespace MihirTown
{
    partial class LogicforNT
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
            this.kick = new System.Windows.Forms.Button();
            this.undercut = new System.Windows.Forms.Button();
            this.heal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodHealth = new System.Windows.Forms.ProgressBar();
            this.badenergy = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GoodEnergy = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.energyTimer = new System.Windows.Forms.Timer(this.components);
            this.badguyattack = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.badguyenergytimer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.slice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MihirTown.Properties.Resources.image_17_535x535;
            this.pictureBox1.Location = new System.Drawing.Point(8, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MihirTown.Properties.Resources._230639_unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(815, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // kick
            // 
            this.kick.BackColor = System.Drawing.Color.Aqua;
            this.kick.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kick.Location = new System.Drawing.Point(58, 294);
            this.kick.Name = "kick";
            this.kick.Size = new System.Drawing.Size(75, 23);
            this.kick.TabIndex = 5;
            this.kick.Text = "Back Kick";
            this.kick.UseVisualStyleBackColor = false;
            this.kick.Click += new System.EventHandler(this.kick_Click);
            // 
            // undercut
            // 
            this.undercut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.undercut.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undercut.Location = new System.Drawing.Point(58, 265);
            this.undercut.Name = "undercut";
            this.undercut.Size = new System.Drawing.Size(75, 23);
            this.undercut.TabIndex = 6;
            this.undercut.Text = "Undercut";
            this.undercut.UseVisualStyleBackColor = false;
            this.undercut.Click += new System.EventHandler(this.undercut_Click);
            // 
            // heal
            // 
            this.heal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.heal.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heal.Location = new System.Drawing.Point(58, 238);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(75, 23);
            this.heal.TabIndex = 7;
            this.heal.Text = "Heal";
            this.heal.UseVisualStyleBackColor = false;
            this.heal.Click += new System.EventHandler(this.heal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trajan Pro 3", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(52, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Attacks";
            // 
            // GoodHealth
            // 
            this.GoodHealth.ForeColor = System.Drawing.Color.Blue;
            this.GoodHealth.Location = new System.Drawing.Point(188, 406);
            this.GoodHealth.Name = "GoodHealth";
            this.GoodHealth.Size = new System.Drawing.Size(100, 23);
            this.GoodHealth.TabIndex = 9;
            this.GoodHealth.Value = 100;
            // 
            // badenergy
            // 
            this.badenergy.Location = new System.Drawing.Point(709, 406);
            this.badenergy.Name = "badenergy";
            this.badenergy.Size = new System.Drawing.Size(100, 23);
            this.badenergy.TabIndex = 10;
            this.badenergy.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(201, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Health";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MihirTown.Properties.Resources.yL8TFJn;
            this.pictureBox3.Location = new System.Drawing.Point(12, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::MihirTown.Properties.Resources.yL8TFJn;
            this.pictureBox4.Location = new System.Drawing.Point(86, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trajan Pro 3", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(325, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 70);
            this.label3.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::MihirTown.Properties.Resources.tumblr_inline_mr7u2jrI171qz4rgp;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = global::MihirTown.Properties.Resources.tumblr_inline_mr7u2jrI171qz4rgp;
            this.pictureBox5.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(985, 550);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(723, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Health";
            // 
            // GoodEnergy
            // 
            this.GoodEnergy.Location = new System.Drawing.Point(188, 466);
            this.GoodEnergy.Name = "GoodEnergy";
            this.GoodEnergy.Size = new System.Drawing.Size(100, 23);
            this.GoodEnergy.TabIndex = 17;
            this.GoodEnergy.Value = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(201, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "energy";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Motorwerk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(186, 270);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(76, 24);
            this.error.TabIndex = 19;
            this.error.Text = "Wait For\nEnergy!";
            this.error.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.error.Visible = false;
            // 
            // energyTimer
            // 
            this.energyTimer.Enabled = true;
            this.energyTimer.Interval = 1000;
            this.energyTimer.Tick += new System.EventHandler(this.energyTimer_Tick);
            // 
            // badguyattack
            // 
            this.badguyattack.Enabled = true;
            this.badguyattack.Interval = 5000;
            this.badguyattack.Tick += new System.EventHandler(this.badguyattack_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(709, 466);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Value = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(723, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Energy";
            // 
            // badguyenergytimer
            // 
            this.badguyenergytimer.Interval = 1000;
            this.badguyenergytimer.Tick += new System.EventHandler(this.badguyenergytimer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trajan Pro 3", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 74);
            this.label7.TabIndex = 22;
            this.label7.Text = "NinjaTown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(714, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ultimate Edition";
            // 
            // slice
            // 
            this.slice.BackColor = System.Drawing.Color.Lime;
            this.slice.Font = new System.Drawing.Font("Tekton Pro Ext", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slice.Location = new System.Drawing.Point(58, 323);
            this.slice.Name = "slice";
            this.slice.Size = new System.Drawing.Size(75, 23);
            this.slice.TabIndex = 4;
            this.slice.Text = "Spin Slice";
            this.slice.UseVisualStyleBackColor = false;
            this.slice.Click += new System.EventHandler(this.slice_Click);
            // 
            // LogicforNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MihirTown.Properties.Resources.tumblr_inline_mr7u2jrI171qz4rgp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 542);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoodEnergy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.badenergy);
            this.Controls.Add(this.GoodHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.undercut);
            this.Controls.Add(this.kick);
            this.Controls.Add(this.slice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Name = "LogicforNT";
            this.Text = "NinjaTown Ultimate Edition";
            this.Load += new System.EventHandler(this.LogicforNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button kick;
        private System.Windows.Forms.Button undercut;
        private System.Windows.Forms.Button heal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar GoodHealth;
        private System.Windows.Forms.ProgressBar badenergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar GoodEnergy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Timer energyTimer;
        private System.Windows.Forms.Timer badguyattack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer badguyenergytimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button slice;
    }
}

