namespace Shotgun_gameinlämningsuppgift_2
{
    partial class Main
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
            this.bulletLabel = new System.Windows.Forms.Label();
            this.LoadShotGunButton = new System.Windows.Forms.Button();
            this.ShootBullet = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.bulletLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.aiWinsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bulletLabel
            // 
            this.bulletLabel.AutoSize = true;
            this.bulletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletLabel.Location = new System.Drawing.Point(311, 239);
            this.bulletLabel.Name = "bulletLabel";
            this.bulletLabel.Size = new System.Drawing.Size(32, 33);
            this.bulletLabel.TabIndex = 0;
            this.bulletLabel.Text = "0";
            // 
            // LoadShotGunButton
            // 
            this.LoadShotGunButton.Location = new System.Drawing.Point(65, 244);
            this.LoadShotGunButton.Name = "LoadShotGunButton";
            this.LoadShotGunButton.Size = new System.Drawing.Size(96, 35);
            this.LoadShotGunButton.TabIndex = 1;
            this.LoadShotGunButton.Text = "Load a bullet";
            this.LoadShotGunButton.UseVisualStyleBackColor = true;
            this.LoadShotGunButton.Click += new System.EventHandler(this.loadShotGunButton_Click);
            // 
            // ShootBullet
            // 
            this.ShootBullet.Location = new System.Drawing.Point(65, 285);
            this.ShootBullet.Name = "ShootBullet";
            this.ShootBullet.Size = new System.Drawing.Size(96, 35);
            this.ShootBullet.TabIndex = 2;
            this.ShootBullet.Text = "Shoot";
            this.ShootBullet.UseVisualStyleBackColor = true;
            this.ShootBullet.Click += new System.EventHandler(this.shootBullet_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(65, 326);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(96, 35);
            this.BlockButton.TabIndex = 3;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // bulletLabel2
            // 
            this.bulletLabel2.AutoSize = true;
            this.bulletLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletLabel2.Location = new System.Drawing.Point(500, 236);
            this.bulletLabel2.Name = "bulletLabel2";
            this.bulletLabel2.Size = new System.Drawing.Size(32, 33);
            this.bulletLabel2.TabIndex = 4;
            this.bulletLabel2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "AI";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(627, 372);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(96, 35);
            this.RestartButton.TabIndex = 7;
            this.RestartButton.Text = "Restart game";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bullets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wins";
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWinsLabel.Location = new System.Drawing.Point(311, 287);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(32, 33);
            this.playerWinsLabel.TabIndex = 10;
            this.playerWinsLabel.Text = "0";
            // 
            // aiWinsLabel
            // 
            this.aiWinsLabel.AutoSize = true;
            this.aiWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWinsLabel.Location = new System.Drawing.Point(500, 285);
            this.aiWinsLabel.Name = "aiWinsLabel";
            this.aiWinsLabel.Size = new System.Drawing.Size(32, 33);
            this.aiWinsLabel.TabIndex = 11;
            this.aiWinsLabel.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aiWinsLabel);
            this.Controls.Add(this.playerWinsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulletLabel2);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.ShootBullet);
            this.Controls.Add(this.LoadShotGunButton);
            this.Controls.Add(this.bulletLabel);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bulletLabel;
        private System.Windows.Forms.Button LoadShotGunButton;
        private System.Windows.Forms.Button ShootBullet;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Label bulletLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.Label aiWinsLabel;
    }
}

