
namespace Assign5Gearhart
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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtMessagebox = new System.Windows.Forms.TextBox();
            this.pnlButtonBoard = new System.Windows.Forms.Panel();
            this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
            this.txtPlayerOneName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Location = new System.Drawing.Point(187, 67);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(601, 480);
            this.pnlGameBoard.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(52, 242);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "&Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtMessagebox
            // 
            this.txtMessagebox.Location = new System.Drawing.Point(8, 329);
            this.txtMessagebox.Name = "txtMessagebox";
            this.txtMessagebox.ReadOnly = true;
            this.txtMessagebox.Size = new System.Drawing.Size(168, 23);
            this.txtMessagebox.TabIndex = 2;
            this.txtMessagebox.TabStop = false;
            // 
            // pnlButtonBoard
            // 
            this.pnlButtonBoard.Location = new System.Drawing.Point(187, 30);
            this.pnlButtonBoard.Name = "pnlButtonBoard";
            this.pnlButtonBoard.Size = new System.Drawing.Size(601, 31);
            this.pnlButtonBoard.TabIndex = 0;
            // 
            // txtPlayerTwoName
            // 
            this.txtPlayerTwoName.Location = new System.Drawing.Point(43, 201);
            this.txtPlayerTwoName.Name = "txtPlayerTwoName";
            this.txtPlayerTwoName.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerTwoName.TabIndex = 2;
            // 
            // txtPlayerOneName
            // 
            this.txtPlayerOneName.Location = new System.Drawing.Point(43, 135);
            this.txtPlayerOneName.Name = "txtPlayerOneName";
            this.txtPlayerOneName.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerOneName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Player One Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Player Two Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 478);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(52, 288);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Connect 4!";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStartGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerOneName);
            this.Controls.Add(this.txtPlayerTwoName);
            this.Controls.Add(this.pnlButtonBoard);
            this.Controls.Add(this.txtMessagebox);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pnlGameBoard);
            this.Name = "Form1";
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtMessagebox;
        private System.Windows.Forms.Panel pnlButtonBoard;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label3;
    }
}

