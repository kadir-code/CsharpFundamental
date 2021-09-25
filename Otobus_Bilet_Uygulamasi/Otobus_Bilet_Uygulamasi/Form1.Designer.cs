
namespace Otobus_Bilet_Uygulamasi
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
            this.grpPesonalInformation = new System.Windows.Forms.GroupBox();
            this.btnAvailableSeat = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpSeats = new System.Windows.Forms.GroupBox();
            this.btnSaveTicket = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblSeatNo = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.grpPesonalInformation.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPesonalInformation
            // 
            this.grpPesonalInformation.Controls.Add(this.btnAvailableSeat);
            this.grpPesonalInformation.Controls.Add(this.radioButton2);
            this.grpPesonalInformation.Controls.Add(this.radioButton1);
            this.grpPesonalInformation.Controls.Add(this.label4);
            this.grpPesonalInformation.Controls.Add(this.txtPhoneNumber);
            this.grpPesonalInformation.Controls.Add(this.label3);
            this.grpPesonalInformation.Controls.Add(this.txtFullName);
            this.grpPesonalInformation.Controls.Add(this.label2);
            this.grpPesonalInformation.Controls.Add(this.txtTC);
            this.grpPesonalInformation.Controls.Add(this.label1);
            this.grpPesonalInformation.Location = new System.Drawing.Point(12, 12);
            this.grpPesonalInformation.Name = "grpPesonalInformation";
            this.grpPesonalInformation.Size = new System.Drawing.Size(274, 309);
            this.grpPesonalInformation.TabIndex = 0;
            this.grpPesonalInformation.TabStop = false;
            this.grpPesonalInformation.Text = "Personal Information";
            // 
            // btnAvailableSeat
            // 
            this.btnAvailableSeat.Location = new System.Drawing.Point(118, 244);
            this.btnAvailableSeat.Name = "btnAvailableSeat";
            this.btnAvailableSeat.Size = new System.Drawing.Size(138, 33);
            this.btnAvailableSeat.TabIndex = 5;
            this.btnAvailableSeat.Text = "Find Seat";
            this.btnAvailableSeat.UseVisualStyleBackColor = true;
            this.btnAvailableSeat.Click += new System.EventHandler(this.btnAvailableSeat_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Man";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(118, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Woman";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(118, 96);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(138, 22);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(118, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(138, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name :";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(118, 21);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(138, 22);
            this.txtTC.TabIndex = 1;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // grpSeats
            // 
            this.grpSeats.Location = new System.Drawing.Point(474, 12);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(303, 641);
            this.grpSeats.TabIndex = 6;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Seats";
            this.grpSeats.Enter += new System.EventHandler(this.grpSeats_Enter);
            // 
            // btnSaveTicket
            // 
            this.btnSaveTicket.Location = new System.Drawing.Point(149, 192);
            this.btnSaveTicket.Name = "btnSaveTicket";
            this.btnSaveTicket.Size = new System.Drawing.Size(130, 40);
            this.btnSaveTicket.TabIndex = 0;
            this.btnSaveTicket.Text = "Save Ticket";
            this.btnSaveTicket.UseVisualStyleBackColor = true;
            this.btnSaveTicket.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblSeatNo);
            this.grpPayment.Controls.Add(this.lblPhoneNumber);
            this.grpPayment.Controls.Add(this.lblPerson);
            this.grpPayment.Controls.Add(this.label7);
            this.grpPayment.Controls.Add(this.label5);
            this.grpPayment.Controls.Add(this.label6);
            this.grpPayment.Controls.Add(this.btnSaveTicket);
            this.grpPayment.Location = new System.Drawing.Point(12, 358);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(285, 238);
            this.grpPayment.TabIndex = 7;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Person :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "P. Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seat No:";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(105, 35);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(22, 17);
            this.lblPerson.TabIndex = 10;
            this.lblPerson.Text = "- -";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(105, 71);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(22, 17);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "- -";
            // 
            // lblSeatNo
            // 
            this.lblSeatNo.AutoSize = true;
            this.lblSeatNo.Location = new System.Drawing.Point(105, 110);
            this.lblSeatNo.Name = "lblSeatNo";
            this.lblSeatNo.Size = new System.Drawing.Size(22, 17);
            this.lblSeatNo.TabIndex = 10;
            this.lblSeatNo.Text = "- -";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(803, 404);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(120, 42);
            this.btnCreateTicket.TabIndex = 6;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 659);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.grpPesonalInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPesonalInformation.ResumeLayout(false);
            this.grpPesonalInformation.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPesonalInformation;
        private System.Windows.Forms.Button btnAvailableSeat;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.Button btnSaveTicket;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblSeatNo;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateTicket;
    }
}

