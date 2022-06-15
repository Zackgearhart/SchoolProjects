
namespace Assignemnt6Gearhart
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstQuizzes = new System.Windows.Forms.ListBox();
            this.btnGetStudents = new System.Windows.Forms.Button();
            this.btnGetQuizzes = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.Enabled = false;
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 15;
            this.lstStudents.Location = new System.Drawing.Point(12, 29);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(331, 409);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.TabStop = false;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // lstQuizzes
            // 
            this.lstQuizzes.FormattingEnabled = true;
            this.lstQuizzes.ItemHeight = 15;
            this.lstQuizzes.Location = new System.Drawing.Point(458, 201);
            this.lstQuizzes.Name = "lstQuizzes";
            this.lstQuizzes.Size = new System.Drawing.Size(330, 199);
            this.lstQuizzes.TabIndex = 2;
            this.lstQuizzes.TabStop = false;
            // 
            // btnGetStudents
            // 
            this.btnGetStudents.Location = new System.Drawing.Point(458, 82);
            this.btnGetStudents.Name = "btnGetStudents";
            this.btnGetStudents.Size = new System.Drawing.Size(203, 23);
            this.btnGetStudents.TabIndex = 1;
            this.btnGetStudents.Text = "Get Students from Students.txt";
            this.btnGetStudents.UseVisualStyleBackColor = true;
            this.btnGetStudents.Click += new System.EventHandler(this.btnGetStudents_Click);
            // 
            // btnGetQuizzes
            // 
            this.btnGetQuizzes.Location = new System.Drawing.Point(458, 133);
            this.btnGetQuizzes.Name = "btnGetQuizzes";
            this.btnGetQuizzes.Size = new System.Drawing.Size(203, 23);
            this.btnGetQuizzes.TabIndex = 2;
            this.btnGetQuizzes.Text = "Load Quizzes From StuQuizzes.txt";
            this.btnGetQuizzes.UseVisualStyleBackColor = true;
            this.btnGetQuizzes.Click += new System.EventHandler(this.btnGetQuizzes_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(458, 415);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(203, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload Scores to SQL";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(416, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Grade Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnGetQuizzes);
            this.Controls.Add(this.btnGetStudents);
            this.Controls.Add(this.lstQuizzes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudents);
            this.Name = "Form1";
            this.Text = "Student Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstQuizzes;
        private System.Windows.Forms.Button btnGetStudents;
        private System.Windows.Forms.Button btnGetQuizzes;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
    }
}

