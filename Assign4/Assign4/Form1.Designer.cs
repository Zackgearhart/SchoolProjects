
namespace Assign4
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
            this.rdoCessna = new System.Windows.Forms.RadioButton();
            this.rdoPiper = new System.Windows.Forms.RadioButton();
            this.lstPassengerList = new System.Windows.Forms.ListBox();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoCessna
            // 
            this.rdoCessna.AutoSize = true;
            this.rdoCessna.Location = new System.Drawing.Point(5, 117);
            this.rdoCessna.Name = "rdoCessna";
            this.rdoCessna.Size = new System.Drawing.Size(117, 19);
            this.rdoCessna.TabIndex = 1;
            this.rdoCessna.Text = "&Cessna Citation X";
            this.rdoCessna.UseVisualStyleBackColor = true;
            this.rdoCessna.CheckedChanged += new System.EventHandler(this.FlightChange);
            // 
            // rdoPiper
            // 
            this.rdoPiper.AutoSize = true;
            this.rdoPiper.Location = new System.Drawing.Point(5, 151);
            this.rdoPiper.Name = "rdoPiper";
            this.rdoPiper.Size = new System.Drawing.Size(92, 19);
            this.rdoPiper.TabIndex = 2;
            this.rdoPiper.Text = "&Piper Mirage";
            this.rdoPiper.UseVisualStyleBackColor = true;
            this.rdoPiper.CheckedChanged += new System.EventHandler(this.FlightChange);
            // 
            // lstPassengerList
            // 
            this.lstPassengerList.FormattingEnabled = true;
            this.lstPassengerList.ItemHeight = 15;
            this.lstPassengerList.Location = new System.Drawing.Point(426, 77);
            this.lstPassengerList.Name = "lstPassengerList";
            this.lstPassengerList.Size = new System.Drawing.Size(174, 319);
            this.lstPassengerList.TabIndex = 3;
            this.lstPassengerList.TabStop = false;
            // 
            // lblAirlineName
            // 
            this.lblAirlineName.AutoSize = true;
            this.lblAirlineName.Location = new System.Drawing.Point(5, 77);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(127, 15);
            this.lblAirlineName.TabIndex = 4;
            this.lblAirlineName.Text = "Please Select an Airline";
            // 
            // txtPassenger
            // 
            this.txtPassenger.Location = new System.Drawing.Point(270, 115);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.ReadOnly = true;
            this.txtPassenger.Size = new System.Drawing.Size(100, 23);
            this.txtPassenger.TabIndex = 3;
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(270, 151);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.ReadOnly = true;
            this.txtSeatNumber.Size = new System.Drawing.Size(100, 23);
            this.txtSeatNumber.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(270, 211);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name of Passenger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seat Number";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(188, 186);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(0, 15);
            this.lblSeatNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "SCC Airlines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Avaible Airlines";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(270, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.txtPassenger);
            this.Controls.Add(this.lblAirlineName);
            this.Controls.Add(this.lstPassengerList);
            this.Controls.Add(this.rdoPiper);
            this.Controls.Add(this.rdoCessna);
            this.Name = "Form1";
            this.Text = "SCC Airlines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoCessna;
        private System.Windows.Forms.RadioButton rdoPiper;
        private System.Windows.Forms.ListBox lstPassengerList;
        private System.Windows.Forms.Label lblAirlineName;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

