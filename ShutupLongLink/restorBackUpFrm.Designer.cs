
namespace ShutupLongLink
{
    partial class restorBackUpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restorBackUpFrm));
            this.lblBackUpPath = new System.Windows.Forms.Label();
            this.txtBxBackUpPath = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblChoosedFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBackUpPath
            // 
            this.lblBackUpPath.AutoSize = true;
            this.lblBackUpPath.Location = new System.Drawing.Point(12, 9);
            this.lblBackUpPath.Name = "lblBackUpPath";
            this.lblBackUpPath.Size = new System.Drawing.Size(163, 13);
            this.lblBackUpPath.TabIndex = 0;
            this.lblBackUpPath.Text = "Choose BackUp File To Restore :";
            // 
            // txtBxBackUpPath
            // 
            this.txtBxBackUpPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxBackUpPath.Location = new System.Drawing.Point(15, 25);
            this.txtBxBackUpPath.Name = "txtBxBackUpPath";
            this.txtBxBackUpPath.Size = new System.Drawing.Size(454, 22);
            this.txtBxBackUpPath.TabIndex = 1;
            this.txtBxBackUpPath.TextChanged += new System.EventHandler(this.txtBxBackUpPath_TextChanged);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(372, 65);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(97, 34);
            this.btnRestore.TabIndex = 36;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(475, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 34);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(475, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 34);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblChoosedFileName
            // 
            this.lblChoosedFileName.AutoSize = true;
            this.lblChoosedFileName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblChoosedFileName.Location = new System.Drawing.Point(12, 76);
            this.lblChoosedFileName.Name = "lblChoosedFileName";
            this.lblChoosedFileName.Size = new System.Drawing.Size(0, 13);
            this.lblChoosedFileName.TabIndex = 38;
            // 
            // restorBackUpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.lblChoosedFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBxBackUpPath);
            this.Controls.Add(this.lblBackUpPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "restorBackUpFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restor BackUp DataBase File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackUpPath;
        private System.Windows.Forms.TextBox txtBxBackUpPath;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblChoosedFileName;
    }
}