namespace Ping_Pong
{
    partial class MainForm
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
            this.Ground = new System.Windows.Forms.PictureBox();
            this.btnBall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lMyScore = new System.Windows.Forms.Label();
            this.lEnemyScore = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lNewRound = new System.Windows.Forms.Label();
            this.nLevels = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Green;
            this.Ground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ground.Location = new System.Drawing.Point(50, 50);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(900, 400);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // btnBall
            // 
            this.btnBall.BackColor = System.Drawing.Color.Green;
            this.btnBall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBall.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBall.Location = new System.Drawing.Point(185, 12);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(65, 32);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "Ball";
            this.btnBall.UseVisualStyleBackColor = false;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change color:";
            // 
            // lMyScore
            // 
            this.lMyScore.AutoSize = true;
            this.lMyScore.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMyScore.ForeColor = System.Drawing.Color.White;
            this.lMyScore.Location = new System.Drawing.Point(409, 67);
            this.lMyScore.Name = "lMyScore";
            this.lMyScore.Size = new System.Drawing.Size(82, 23);
            this.lMyScore.TabIndex = 4;
            this.lMyScore.Text = "Score: 0";
            // 
            // lEnemyScore
            // 
            this.lEnemyScore.AutoSize = true;
            this.lEnemyScore.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEnemyScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lEnemyScore.Location = new System.Drawing.Point(509, 67);
            this.lEnemyScore.Name = "lEnemyScore";
            this.lEnemyScore.Size = new System.Drawing.Size(82, 23);
            this.lEnemyScore.TabIndex = 5;
            this.lEnemyScore.Text = "Score: 0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(905, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Х";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(458, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 32);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lNewRound
            // 
            this.lNewRound.AutoSize = true;
            this.lNewRound.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNewRound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lNewRound.Location = new System.Drawing.Point(452, 141);
            this.lNewRound.Name = "lNewRound";
            this.lNewRound.Size = new System.Drawing.Size(186, 94);
            this.lNewRound.TabIndex = 10;
            this.lNewRound.Text = "One";
            this.lNewRound.Visible = false;
            // 
            // nLevels
            // 
            this.nLevels.BackColor = System.Drawing.Color.DarkGreen;
            this.nLevels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nLevels.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nLevels.Location = new System.Drawing.Point(809, 19);
            this.nLevels.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLevels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLevels.Name = "nLevels";
            this.nLevels.Size = new System.Drawing.Size(60, 25);
            this.nLevels.TabIndex = 11;
            this.nLevels.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLevels.ValueChanged += new System.EventHandler(this.nLevels_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(691, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chose level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(377, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Press SPACE to pause";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nLevels);
            this.Controls.Add(this.lNewRound);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lEnemyScore);
            this.Controls.Add(this.lMyScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.Ground);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMyScore;
        private System.Windows.Forms.Label lEnemyScore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lNewRound;
        private System.Windows.Forms.NumericUpDown nLevels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

