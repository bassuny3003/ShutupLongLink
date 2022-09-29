
namespace ShutupLongLink
{
    partial class changLogFrm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBxChangLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(490, 475);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 34);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtBxChangLog
            // 
            this.txtBxChangLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxChangLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxChangLog.Location = new System.Drawing.Point(12, 12);
            this.txtBxChangLog.Multiline = true;
            this.txtBxChangLog.Name = "txtBxChangLog";
            this.txtBxChangLog.ReadOnly = true;
            this.txtBxChangLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxChangLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxChangLog.Size = new System.Drawing.Size(575, 457);
            this.txtBxChangLog.TabIndex = 12;
            // 
            // changLogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 521);
            this.Controls.Add(this.txtBxChangLog);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changLogFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chang Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBxChangLog;
    }
}