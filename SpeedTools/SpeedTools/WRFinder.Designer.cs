namespace SpeedTools
{
    partial class WRFinder
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
            this.back = new System.Windows.Forms.Button();
            this.WRButton = new System.Windows.Forms.Button();
            this._game = new System.Windows.Forms.RichTextBox();
            this._WR = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(114, 252);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 21);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // WRButton
            // 
            this.WRButton.Location = new System.Drawing.Point(-4, 129);
            this.WRButton.Name = "WRButton";
            this.WRButton.Size = new System.Drawing.Size(309, 57);
            this.WRButton.TabIndex = 1;
            this.WRButton.Text = "Find WR";
            this.WRButton.UseVisualStyleBackColor = true;
            this.WRButton.Click += new System.EventHandler(this.WRButton_Click);
            // 
            // _game
            // 
            this._game.Location = new System.Drawing.Point(-4, 24);
            this._game.Name = "_game";
            this._game.Size = new System.Drawing.Size(310, 38);
            this._game.TabIndex = 2;
            this._game.Text = "";
            // 
            // _WR
            // 
            this._WR.Location = new System.Drawing.Point(12, 212);
            this._WR.Name = "_WR";
            this._WR.Size = new System.Drawing.Size(280, 34);
            this._WR.TabIndex = 3;
            this._WR.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(101, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(101, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "World Record:";
            // 
            // _cat
            // 
            this._cat.Location = new System.Drawing.Point(-4, 93);
            this._cat.Name = "_cat";
            this._cat.Size = new System.Drawing.Size(309, 38);
            this._cat.TabIndex = 6;
            this._cat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(110, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category:";
            // 
            // WRFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._WR);
            this.Controls.Add(this._game);
            this.Controls.Add(this.WRButton);
            this.Controls.Add(this.back);
            this.Name = "WRFinder";
            this.Text = "SpeedTools - WR Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button WRButton;
        private System.Windows.Forms.RichTextBox _game;
        private System.Windows.Forms.RichTextBox _WR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox _cat;
        private System.Windows.Forms.Label label3;
    }
}