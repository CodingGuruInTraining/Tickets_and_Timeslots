namespace TicketTime
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMinPerWin = new System.Windows.Forms.TextBox();
            this.txtBoxGuesterWin = new System.Windows.Forms.TextBox();
            this.txtBoxStartTime = new System.Windows.Forms.TextBox();
            this.txtBoxEndTime = new System.Windows.Forms.TextBox();
            this.txtBoxFirstTicket = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minutes per window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guests per window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start tme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First ticket number";
            // 
            // txtBoxMinPerWin
            // 
            this.txtBoxMinPerWin.Location = new System.Drawing.Point(141, 39);
            this.txtBoxMinPerWin.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMinPerWin.Name = "txtBoxMinPerWin";
            this.txtBoxMinPerWin.Size = new System.Drawing.Size(110, 20);
            this.txtBoxMinPerWin.TabIndex = 5;
            this.txtBoxMinPerWin.Text = "5";
            // 
            // txtBoxGuesterWin
            // 
            this.txtBoxGuesterWin.Location = new System.Drawing.Point(141, 90);
            this.txtBoxGuesterWin.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxGuesterWin.Name = "txtBoxGuesterWin";
            this.txtBoxGuesterWin.Size = new System.Drawing.Size(110, 20);
            this.txtBoxGuesterWin.TabIndex = 6;
            this.txtBoxGuesterWin.Text = "5";
            // 
            // txtBoxStartTime
            // 
            this.txtBoxStartTime.Location = new System.Drawing.Point(141, 139);
            this.txtBoxStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxStartTime.Name = "txtBoxStartTime";
            this.txtBoxStartTime.Size = new System.Drawing.Size(110, 20);
            this.txtBoxStartTime.TabIndex = 7;
            this.txtBoxStartTime.Text = "10:33:AM";
            // 
            // txtBoxEndTime
            // 
            this.txtBoxEndTime.Location = new System.Drawing.Point(141, 191);
            this.txtBoxEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxEndTime.Name = "txtBoxEndTime";
            this.txtBoxEndTime.Size = new System.Drawing.Size(110, 20);
            this.txtBoxEndTime.TabIndex = 8;
            this.txtBoxEndTime.Text = "2:33:PM";
            // 
            // txtBoxFirstTicket
            // 
            this.txtBoxFirstTicket.Location = new System.Drawing.Point(141, 240);
            this.txtBoxFirstTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxFirstTicket.Name = "txtBoxFirstTicket";
            this.txtBoxFirstTicket.Size = new System.Drawing.Size(110, 20);
            this.txtBoxFirstTicket.TabIndex = 9;
            this.txtBoxFirstTicket.Text = "1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(141, 283);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 21);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 314);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxFirstTicket);
            this.Controls.Add(this.txtBoxEndTime);
            this.Controls.Add(this.txtBoxStartTime);
            this.Controls.Add(this.txtBoxGuesterWin);
            this.Controls.Add(this.txtBoxMinPerWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMinPerWin;
        private System.Windows.Forms.TextBox txtBoxGuesterWin;
        private System.Windows.Forms.TextBox txtBoxStartTime;
        private System.Windows.Forms.TextBox txtBoxEndTime;
        private System.Windows.Forms.TextBox txtBoxFirstTicket;
        private System.Windows.Forms.Button btnOK;
    }
}