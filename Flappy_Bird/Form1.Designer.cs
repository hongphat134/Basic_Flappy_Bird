namespace Flappy_Bird
{
    partial class frmFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.ptrIcon = new System.Windows.Forms.PictureBox();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlUnderGround = new System.Windows.Forms.Panel();
            this.timerBirdMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptrIcon)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptrIcon
            // 
            this.ptrIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptrIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptrIcon.BackgroundImage")));
            this.ptrIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrIcon.Location = new System.Drawing.Point(10, 260);
            this.ptrIcon.Name = "ptrIcon";
            this.ptrIcon.Size = new System.Drawing.Size(60, 60);
            this.ptrIcon.TabIndex = 0;
            this.ptrIcon.TabStop = false;
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 20;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // timerIcon
            // 
            this.timerIcon.Tick += new System.EventHandler(this.timerIcon_Tick);
            // 
            // pnlGame
            // 
            this.pnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGame.BackgroundImage")));
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGame.Controls.Add(this.lblTitle);
            this.pnlGame.Controls.Add(this.lblScore);
            this.pnlGame.Controls.Add(this.ptrIcon);
            this.pnlGame.Location = new System.Drawing.Point(12, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(942, 523);
            this.pnlGame.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(398, 224);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 72);
            this.lblTitle.TabIndex = 999;
            this.lblTitle.Text = "Press Enter To Play";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(500, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(90, 40);
            this.lblScore.TabIndex = 3;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUnderGround
            // 
            this.pnlUnderGround.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUnderGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUnderGround.BackgroundImage")));
            this.pnlUnderGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUnderGround.Location = new System.Drawing.Point(539, 563);
            this.pnlUnderGround.Name = "pnlUnderGround";
            this.pnlUnderGround.Size = new System.Drawing.Size(200, 100);
            this.pnlUnderGround.TabIndex = 0;
            // 
            // timerBirdMove
            // 
            this.timerBirdMove.Tick += new System.EventHandler(this.timerBirdMove_Tick);
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlUnderGround);
            this.Controls.Add(this.pnlGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFlappyBird";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY BIRD";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFlappyBird_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ptrIcon)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrIcon;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlUnderGround;
        private System.Windows.Forms.Label lblScore;
        internal System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerBirdMove;
    }
}

