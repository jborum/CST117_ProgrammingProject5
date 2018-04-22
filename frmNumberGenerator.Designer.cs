namespace ProgrammingExercise5
{
    partial class frmNumberGenerator
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
            this.buttonLucky = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuckyNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLucky
            // 
            this.buttonLucky.Location = new System.Drawing.Point(12, 32);
            this.buttonLucky.Name = "buttonLucky";
            this.buttonLucky.Size = new System.Drawing.Size(285, 23);
            this.buttonLucky.TabIndex = 0;
            this.buttonLucky.Text = "Lucky Number Generator";
            this.buttonLucky.UseVisualStyleBackColor = true;
            this.buttonLucky.Click += new System.EventHandler(this.buttonLucky_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 61);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(285, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Lucky Number Between 1-10";
            // 
            // txtLuckyNumber
            // 
            this.txtLuckyNumber.Location = new System.Drawing.Point(191, 6);
            this.txtLuckyNumber.Name = "txtLuckyNumber";
            this.txtLuckyNumber.Size = new System.Drawing.Size(106, 20);
            this.txtLuckyNumber.TabIndex = 3;
            // 
            // frmNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 90);
            this.Controls.Add(this.txtLuckyNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLucky);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNumberGenerator";
            this.Text = "Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLucky;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLuckyNumber;
    }
}

