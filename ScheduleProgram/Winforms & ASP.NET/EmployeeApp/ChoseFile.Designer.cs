namespace EmployeeApp
{
    partial class ChoseFile
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
            this.fileNameTxb = new System.Windows.Forms.TextBox();
            this.choseFileBnt = new System.Windows.Forms.Button();
            this.saveBnt = new System.Windows.Forms.Button();
            this.closeBnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNameTxb
            // 
            this.fileNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTxb.Location = new System.Drawing.Point(71, 139);
            this.fileNameTxb.Name = "fileNameTxb";
            this.fileNameTxb.Size = new System.Drawing.Size(224, 20);
            this.fileNameTxb.TabIndex = 0;
            this.fileNameTxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // choseFileBnt
            // 
            this.choseFileBnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choseFileBnt.BackColor = System.Drawing.SystemColors.Window;
            this.choseFileBnt.Location = new System.Drawing.Point(301, 136);
            this.choseFileBnt.Name = "choseFileBnt";
            this.choseFileBnt.Size = new System.Drawing.Size(75, 23);
            this.choseFileBnt.TabIndex = 1;
            this.choseFileBnt.Text = "Chose file";
            this.choseFileBnt.UseVisualStyleBackColor = false;
            this.choseFileBnt.Click += new System.EventHandler(this.choseFileBnt_Click);
            // 
            // saveBnt
            // 
            this.saveBnt.BackColor = System.Drawing.SystemColors.Window;
            this.saveBnt.Location = new System.Drawing.Point(300, 225);
            this.saveBnt.Name = "saveBnt";
            this.saveBnt.Size = new System.Drawing.Size(75, 23);
            this.saveBnt.TabIndex = 2;
            this.saveBnt.Text = "Save";
            this.saveBnt.UseVisualStyleBackColor = false;
            this.saveBnt.Click += new System.EventHandler(this.saveBnt_Click);
            // 
            // closeBnt
            // 
            this.closeBnt.BackColor = System.Drawing.SystemColors.Window;
            this.closeBnt.Location = new System.Drawing.Point(382, 224);
            this.closeBnt.Name = "closeBnt";
            this.closeBnt.Size = new System.Drawing.Size(75, 23);
            this.closeBnt.TabIndex = 3;
            this.closeBnt.Text = "Close";
            this.closeBnt.UseVisualStyleBackColor = false;
            this.closeBnt.Click += new System.EventHandler(this.closeBnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chose a file";
            // 
            // ChoseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBnt);
            this.Controls.Add(this.saveBnt);
            this.Controls.Add(this.choseFileBnt);
            this.Controls.Add(this.fileNameTxb);
            this.Name = "ChoseFile";
            this.Text = "ChoseFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTxb;
        private System.Windows.Forms.Button choseFileBnt;
        private System.Windows.Forms.Button saveBnt;
        private System.Windows.Forms.Button closeBnt;
        private System.Windows.Forms.Label label1;
    }
}