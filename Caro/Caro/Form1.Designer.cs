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
            this.components = new System.ComponentModel.Container();
            this.pnlboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.pgrCountDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.tmCD = new System.Windows.Forms.Timer(this.components);
            this.lbMenu = new System.Windows.Forms.Label();
            this.btNewGame = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlboard
            // 
            this.pnlboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlboard.Location = new System.Drawing.Point(121, 12);
            this.pnlboard.Name = "pnlboard";
            this.pnlboard.Size = new System.Drawing.Size(761, 631);
            this.pnlboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(888, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 299);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btConnect);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.pgrCountDown);
            this.panel3.Controls.Add(this.txtPlayerName);
            this.panel3.Location = new System.Drawing.Point(892, 317);
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
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.GrayText;
            this.pctbMark.Location = new System.Drawing.Point(180, 7);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(210, 160);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // pgrCountDown
            // 
            this.pgrCountDown.Location = new System.Drawing.Point(0, 47);
            this.pgrCountDown.Maximum = 20000;
            this.pgrCountDown.Name = "pgrCountDown";
            this.pgrCountDown.Size = new System.Drawing.Size(174, 31);
            this.pgrCountDown.Step = 100;
            this.pgrCountDown.TabIndex = 1;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(3, 7);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(171, 34);
            this.txtPlayerName.TabIndex = 0;
            // 
            // tmCD
            // 
            this.tmCD.Enabled = true;
            this.tmCD.Tick += new System.EventHandler(this.tmCD_Tick);
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(12, 21);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(100, 23);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "Menu";
            // 
            // btNewGame
            // 
            this.btNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewGame.Location = new System.Drawing.Point(12, 63);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(100, 35);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "New game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // btUndo
            // 
            this.btUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.Location = new System.Drawing.Point(12, 104);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(83, 41);
            this.btUndo.TabIndex = 0;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar pgrCountDown;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Timer tmCD;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button button2;
    }
}

