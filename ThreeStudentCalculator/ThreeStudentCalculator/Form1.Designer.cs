
namespace ThreeStudentCalculator
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblScoreNumber = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstStuOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(349, 187);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 23);
            this.txtScore.TabIndex = 0;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(349, 107);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 23);
            this.txtStuName.TabIndex = 1;
            // 
            // lblScoreNumber
            // 
            this.lblScoreNumber.AutoSize = true;
            this.lblScoreNumber.Location = new System.Drawing.Point(349, 169);
            this.lblScoreNumber.Name = "lblScoreNumber";
            this.lblScoreNumber.Size = new System.Drawing.Size(0, 15);
            this.lblScoreNumber.TabIndex = 2;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(349, 89);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(0, 15);
            this.lblStudentNumber.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(349, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Score";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstStuOutput
            // 
            this.lstStuOutput.FormattingEnabled = true;
            this.lstStuOutput.ItemHeight = 15;
            this.lstStuOutput.Location = new System.Drawing.Point(12, 81);
            this.lstStuOutput.Name = "lstStuOutput";
            this.lstStuOutput.Size = new System.Drawing.Size(249, 169);
            this.lstStuOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.lstStuOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblScoreNumber);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Student Score Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblScoreNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstStuOutput;
    }
}

