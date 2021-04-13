
namespace Game1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMoveVirus = new System.Windows.Forms.Timer(this.components);
            this.timerCreateVirus = new System.Windows.Forms.Timer(this.components);
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.timerMoveMetak = new System.Windows.Forms.Timer(this.components);
            this.textScoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMoveVirus
            // 
            this.timerMoveVirus.Enabled = true;
            this.timerMoveVirus.Interval = 50;
            // 
            // timerCreateVirus
            // 
            this.timerCreateVirus.Enabled = true;
            this.timerCreateVirus.Interval = 1000;
            // 
            // playerBox
            // 
            this.playerBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerBox.BackgroundImage")));
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox.Location = new System.Drawing.Point(325, 650);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(50, 50);
            this.playerBox.TabIndex = 1;
            this.playerBox.TabStop = false;
            // 
            // timerMoveMetak
            // 
            this.timerMoveMetak.Enabled = true;
            this.timerMoveMetak.Interval = 1;
            // 
            // textScoreLabel
            // 
            this.textScoreLabel.AutoSize = true;
            this.textScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScoreLabel.Location = new System.Drawing.Point(12, 12);
            this.textScoreLabel.Name = "textScoreLabel";
            this.textScoreLabel.Size = new System.Drawing.Size(103, 29);
            this.textScoreLabel.TabIndex = 2;
            this.textScoreLabel.Text = "Score : ";
            this.textScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(112, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(27, 29);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(588, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.Step = 5;
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.textScoreLabel);
            this.Controls.Add(this.playerBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(718, 747);
            this.MinimumSize = new System.Drawing.Size(718, 747);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMoveVirus;
        private System.Windows.Forms.Timer timerCreateVirus;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Timer timerMoveMetak;
        private System.Windows.Forms.Label textScoreLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

