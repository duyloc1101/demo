namespace Caro
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
            this.pnlboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.picOX = new System.Windows.Forms.PictureBox();
            this.pgrCountDown = new System.Windows.Forms.ProgressBar();
            this.txtLuotChoi = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlboard
            // 
            this.pnlboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlboard.Location = new System.Drawing.Point(12, 12);
            this.pnlboard.Name = "pnlboard";
            this.pnlboard.Size = new System.Drawing.Size(761, 631);
            this.pnlboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(776, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 299);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btConnect);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.picOX);
            this.panel3.Controls.Add(this.pgrCountDown);
            this.panel3.Controls.Add(this.txtLuotChoi);
            this.panel3.Location = new System.Drawing.Point(776, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 272);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(3, 132);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(171, 35);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Kết Nối";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(0, 84);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(174, 34);
            this.txtIP.TabIndex = 3;
            // 
            // picOX
            // 
            this.picOX.BackColor = System.Drawing.SystemColors.GrayText;
            this.picOX.Location = new System.Drawing.Point(193, 19);
            this.picOX.Name = "picOX";
            this.picOX.Size = new System.Drawing.Size(181, 130);
            this.picOX.TabIndex = 2;
            this.picOX.TabStop = false;
            // 
            // pgrCountDown
            // 
            this.pgrCountDown.Location = new System.Drawing.Point(0, 47);
            this.pgrCountDown.Name = "pgrCountDown";
            this.pgrCountDown.Size = new System.Drawing.Size(174, 31);
            this.pgrCountDown.TabIndex = 1;
            // 
            // txtLuotChoi
            // 
            this.txtLuotChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuotChoi.Location = new System.Drawing.Point(3, 7);
            this.txtLuotChoi.Name = "txtLuotChoi";
            this.txtLuotChoi.Size = new System.Drawing.Size(171, 34);
            this.txtLuotChoi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox picOX;
        private System.Windows.Forms.ProgressBar pgrCountDown;
        private System.Windows.Forms.TextBox txtLuotChoi;
    }
}

