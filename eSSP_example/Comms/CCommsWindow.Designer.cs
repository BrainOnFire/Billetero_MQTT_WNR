namespace eSSP_example
{
    partial class CCommsWindow
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logWindowText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 497);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(198, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Record Encrypted Packets";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logWindowText
            // 
            this.logWindowText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logWindowText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logWindowText.Location = new System.Drawing.Point(17, 16);
            this.logWindowText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logWindowText.Multiline = true;
            this.logWindowText.Name = "logWindowText";
            this.logWindowText.ReadOnly = true;
            this.logWindowText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logWindowText.Size = new System.Drawing.Size(607, 473);
            this.logWindowText.TabIndex = 2;
            // 
            // CCommsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 533);
            this.Controls.Add(this.logWindowText);
            this.Controls.Add(this.checkBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CCommsWindow";
            this.ShowInTaskbar = false;
            this.Text = "CommsWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommsWindow_FormClosing);
            this.Load += new System.EventHandler(this.CommsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox logWindowText;
    }
}