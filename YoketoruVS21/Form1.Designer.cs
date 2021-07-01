
namespace YoketoruVS21
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(265, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(221, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる２０２１";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(337, 391);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(117, 15);
            this.copyrightLabel.TabIndex = 1;
            this.copyrightLabel.Text = "copyright@2021望月";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Info;
            this.startButton.Location = new System.Drawing.Point(310, 248);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 67);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time 100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(640, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "★：10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.hiLabel.Location = new System.Drawing.Point(282, 205);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(204, 40);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore 100";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Maroon;
            this.gameOverLabel.Location = new System.Drawing.Point(293, 122);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(161, 40);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.Click += new System.EventHandler(this.gameOverLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-422, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Over";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.ForeColor = System.Drawing.Color.Maroon;
            this.clearLabel.Location = new System.Drawing.Point(337, 130);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(68, 32);
            this.clearLabel.TabIndex = 8;
            this.clearLabel.Text = "Clear";
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // titlebutton
            // 
            this.titlebutton.BackColor = System.Drawing.SystemColors.Info;
            this.titlebutton.Location = new System.Drawing.Point(310, 248);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(158, 67);
            this.titlebutton.TabIndex = 9;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Enabled = true;
            this.timeLabel.Tick += new System.EventHandler(this.timeLabel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titlebutton;
        private System.Windows.Forms.Timer timeLabel;
    }
}

