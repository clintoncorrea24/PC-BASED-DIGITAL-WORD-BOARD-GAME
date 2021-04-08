namespace Thesis_V2._0
{
    partial class WinnerIndicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerIndicator));
            this.WinnerBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backinstructionsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WinnerBox1
            // 
            this.WinnerBox1.Location = new System.Drawing.Point(0, 0);
            this.WinnerBox1.Name = "WinnerBox1";
            this.WinnerBox1.Size = new System.Drawing.Size(1920, 1080);
            this.WinnerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinnerBox1.TabIndex = 0;
            this.WinnerBox1.TabStop = false;
            this.WinnerBox1.Click += new System.EventHandler(this.WinnerBox1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1420, 789);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 80);
            this.label4.TabIndex = 24;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1420, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 80);
            this.label3.TabIndex = 23;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1420, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 80);
            this.label2.TabIndex = 22;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1420, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 80);
            this.label1.TabIndex = 21;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backinstructionsbtn
            // 
            this.backinstructionsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backinstructionsbtn.BackgroundImage")));
            this.backinstructionsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backinstructionsbtn.Location = new System.Drawing.Point(872, 932);
            this.backinstructionsbtn.Name = "backinstructionsbtn";
            this.backinstructionsbtn.Size = new System.Drawing.Size(182, 65);
            this.backinstructionsbtn.TabIndex = 125;
            this.backinstructionsbtn.UseVisualStyleBackColor = true;
            this.backinstructionsbtn.Click += new System.EventHandler(this.backinstructionsbtn_Click);
            // 
            // WinnerIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.backinstructionsbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WinnerBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinnerIndicator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WinnerIndicator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WinnerBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WinnerBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backinstructionsbtn;
    }
}