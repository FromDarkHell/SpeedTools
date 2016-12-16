namespace SpeedTools
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
            this.WRF = new System.Windows.Forms.Button();
            this.Livesplit = new System.Windows.Forms.Button();
            this.SRL = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.SPLIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WRF
            // 
            this.WRF.Location = new System.Drawing.Point(0, 0);
            this.WRF.Name = "WRF";
            this.WRF.Size = new System.Drawing.Size(83, 31);
            this.WRF.TabIndex = 0;
            this.WRF.Text = "WR Finder";
            this.WRF.UseVisualStyleBackColor = true;
            this.WRF.Click += new System.EventHandler(this.WRF_Click);
            // 
            // Livesplit
            // 
            this.Livesplit.Location = new System.Drawing.Point(99, 0);
            this.Livesplit.Name = "Livesplit";
            this.Livesplit.Size = new System.Drawing.Size(83, 31);
            this.Livesplit.TabIndex = 1;
            this.Livesplit.Text = "Livesplit";
            this.Livesplit.UseVisualStyleBackColor = true;
            this.Livesplit.Click += new System.EventHandler(this.Livesplit_Click);
            // 
            // SRL
            // 
            this.SRL.Location = new System.Drawing.Point(188, 0);
            this.SRL.Name = "SRL";
            this.SRL.Size = new System.Drawing.Size(83, 31);
            this.SRL.TabIndex = 2;
            this.SRL.Text = "SRL Bingo";
            this.SRL.UseVisualStyleBackColor = true;
            this.SRL.Click += new System.EventHandler(this.SRL_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(99, 88);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(83, 36);
            this.info.TabIndex = 3;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // SPLIO
            // 
            this.SPLIO.Location = new System.Drawing.Point(99, 37);
            this.SPLIO.Name = "SPLIO";
            this.SPLIO.Size = new System.Drawing.Size(83, 31);
            this.SPLIO.TabIndex = 4;
            this.SPLIO.Text = "Splits.IO";
            this.SPLIO.UseVisualStyleBackColor = true;
            this.SPLIO.Click += new System.EventHandler(this.SPLIO_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 119);
            this.Controls.Add(this.SPLIO);
            this.Controls.Add(this.info);
            this.Controls.Add(this.SRL);
            this.Controls.Add(this.Livesplit);
            this.Controls.Add(this.WRF);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "SpeedTools - Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WRF;
        private System.Windows.Forms.Button Livesplit;
        private System.Windows.Forms.Button SRL;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button SPLIO;
    }
}

