namespace FightClub
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.progressBarHPPlayer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarHPPlayer2 = new System.Windows.Forms.ProgressBar();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblNumbRound = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lblHPPlayer1 = new System.Windows.Forms.Label();
            this.lblHPPlayer2 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnRound = new System.Windows.Forms.Button();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.rbBody = new System.Windows.Forms.RadioButton();
            this.rbLegs = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer1.Location = new System.Drawing.Point(145, 13);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(61, 18);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer2.Location = new System.Drawing.Point(667, 15);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(61, 18);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2";
            // 
            // progressBarHPPlayer1
            // 
            this.progressBarHPPlayer1.Location = new System.Drawing.Point(84, 55);
            this.progressBarHPPlayer1.Name = "progressBarHPPlayer1";
            this.progressBarHPPlayer1.Size = new System.Drawing.Size(199, 29);
            this.progressBarHPPlayer1.TabIndex = 2;
            // 
            // progressBarHPPlayer2
            // 
            this.progressBarHPPlayer2.Location = new System.Drawing.Point(602, 55);
            this.progressBarHPPlayer2.Name = "progressBarHPPlayer2";
            this.progressBarHPPlayer2.Size = new System.Drawing.Size(199, 29);
            this.progressBarHPPlayer2.TabIndex = 2;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRound.Location = new System.Drawing.Point(386, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(72, 24);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Round";
            // 
            // lblNumbRound
            // 
            this.lblNumbRound.AutoSize = true;
            this.lblNumbRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumbRound.Location = new System.Drawing.Point(464, 9);
            this.lblNumbRound.Name = "lblNumbRound";
            this.lblNumbRound.Size = new System.Drawing.Size(21, 24);
            this.lblNumbRound.TabIndex = 5;
            this.lblNumbRound.Text = "1";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(2, 365);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(865, 160);
            this.lbLog.TabIndex = 9;
            // 
            // lblHPPlayer1
            // 
            this.lblHPPlayer1.AutoSize = true;
            this.lblHPPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHPPlayer1.Location = new System.Drawing.Point(12, 62);
            this.lblHPPlayer1.Name = "lblHPPlayer1";
            this.lblHPPlayer1.Size = new System.Drawing.Size(32, 18);
            this.lblHPPlayer1.TabIndex = 10;
            this.lblHPPlayer1.Text = "100";
            // 
            // lblHPPlayer2
            // 
            this.lblHPPlayer2.AutoSize = true;
            this.lblHPPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHPPlayer2.Location = new System.Drawing.Point(807, 62);
            this.lblHPPlayer2.Name = "lblHPPlayer2";
            this.lblHPPlayer2.Size = new System.Drawing.Size(32, 18);
            this.lblHPPlayer2.TabIndex = 11;
            this.lblHPPlayer2.Text = "100";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAction.Location = new System.Drawing.Point(313, 55);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(233, 20);
            this.lblAction.TabIndex = 12;
            this.lblAction.Text = "Choose body part to protect";
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRound.Location = new System.Drawing.Point(359, 262);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(162, 69);
            this.btnRound.TabIndex = 13;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHead.Location = new System.Drawing.Point(397, 107);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(74, 28);
            this.rbHead.TabIndex = 14;
            this.rbHead.Text = "Head";
            this.rbHead.UseVisualStyleBackColor = true;
            // 
            // rbBody
            // 
            this.rbBody.AutoSize = true;
            this.rbBody.Checked = true;
            this.rbBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBody.Location = new System.Drawing.Point(397, 154);
            this.rbBody.Name = "rbBody";
            this.rbBody.Size = new System.Drawing.Size(71, 28);
            this.rbBody.TabIndex = 15;
            this.rbBody.TabStop = true;
            this.rbBody.Text = "Body";
            this.rbBody.UseVisualStyleBackColor = true;
            // 
            // rbLegs
            // 
            this.rbLegs.AutoSize = true;
            this.rbLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLegs.Location = new System.Drawing.Point(397, 201);
            this.rbLegs.Name = "rbLegs";
            this.rbLegs.Size = new System.Drawing.Size(69, 28);
            this.rbLegs.TabIndex = 16;
            this.rbLegs.Text = "Legs";
            this.rbLegs.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 209);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 200);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 524);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbLegs);
            this.Controls.Add(this.rbBody);
            this.Controls.Add(this.rbHead);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblHPPlayer2);
            this.Controls.Add(this.lblHPPlayer1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lblNumbRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.progressBarHPPlayer2);
            this.Controls.Add(this.progressBarHPPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.ProgressBar progressBarHPPlayer1;
        private System.Windows.Forms.ProgressBar progressBarHPPlayer2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblNumbRound;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label lblHPPlayer1;
        private System.Windows.Forms.Label lblHPPlayer2;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.RadioButton rbHead;
        private System.Windows.Forms.RadioButton rbBody;
        private System.Windows.Forms.RadioButton rbLegs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

