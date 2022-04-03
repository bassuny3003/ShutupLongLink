
namespace ShutupLongLink
{
    partial class MainFrm
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
            this.mnuStrp = new System.Windows.Forms.MenuStrip();
            this.mnuItm01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm02 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrp = new System.Windows.Forms.StatusStrip();
            this.statusLbl01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mnuStrp.SuspendLayout();
            this.statusStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrp
            // 
            this.mnuStrp.BackColor = System.Drawing.SystemColors.Control;
            this.mnuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm01,
            this.mnuItm02});
            this.mnuStrp.Location = new System.Drawing.Point(0, 0);
            this.mnuStrp.Name = "mnuStrp";
            this.mnuStrp.Size = new System.Drawing.Size(484, 24);
            this.mnuStrp.TabIndex = 0;
            this.mnuStrp.Text = "mnuStp";
            // 
            // mnuItm01
            // 
            this.mnuItm01.Name = "mnuItm01";
            this.mnuItm01.Size = new System.Drawing.Size(37, 20);
            this.mnuItm01.Text = "&File";
            // 
            // mnuItm02
            // 
            this.mnuItm02.Name = "mnuItm02";
            this.mnuItm02.Size = new System.Drawing.Size(44, 20);
            this.mnuItm02.Text = "&Help";
            // 
            // statusStrp
            // 
            this.statusStrp.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl01});
            this.statusStrp.Location = new System.Drawing.Point(0, 739);
            this.statusStrp.Name = "statusStrp";
            this.statusStrp.Size = new System.Drawing.Size(484, 22);
            this.statusStrp.SizingGrip = false;
            this.statusStrp.TabIndex = 1;
            this.statusStrp.Text = "statusStrp";
            // 
            // statusLbl01
            // 
            this.statusLbl01.Name = "statusLbl01";
            this.statusLbl01.Size = new System.Drawing.Size(0, 17);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 156);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 218);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 156);
            this.textBox2.TabIndex = 4;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrp);
            this.Controls.Add(this.mnuStrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuStrp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutup Long Link ( Shortner Tool Manger )";
            this.mnuStrp.ResumeLayout(false);
            this.mnuStrp.PerformLayout();
            this.statusStrp.ResumeLayout(false);
            this.statusStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrp;
        private System.Windows.Forms.ToolStripMenuItem mnuItm01;
        private System.Windows.Forms.ToolStripMenuItem mnuItm02;
        private System.Windows.Forms.StatusStrip statusStrp;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

