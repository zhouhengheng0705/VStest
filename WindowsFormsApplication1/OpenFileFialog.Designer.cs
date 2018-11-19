namespace WindowsFormsApplication1
{
    partial class OpenFileFialog
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn参照 = new System.Windows.Forms.Button();
            this.txtファイル名 = new System.Windows.Forms.TextBox();
            this.lblファイル名 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn参照
            // 
            this.btn参照.Location = new System.Drawing.Point(297, 26);
            this.btn参照.Name = "btn参照";
            this.btn参照.Size = new System.Drawing.Size(57, 25);
            this.btn参照.TabIndex = 0;
            this.btn参照.Text = "参照";
            this.btn参照.UseVisualStyleBackColor = true;
            this.btn参照.Click += new System.EventHandler(this.btn参照_Click);
            // 
            // txtファイル名
            // 
            this.txtファイル名.Location = new System.Drawing.Point(61, 29);
            this.txtファイル名.Name = "txtファイル名";
            this.txtファイル名.Size = new System.Drawing.Size(236, 19);
            this.txtファイル名.TabIndex = 1;
            // 
            // lblファイル名
            // 
            this.lblファイル名.AutoSize = true;
            this.lblファイル名.Location = new System.Drawing.Point(4, 32);
            this.lblファイル名.Name = "lblファイル名";
            this.lblファイル名.Size = new System.Drawing.Size(51, 12);
            this.lblファイル名.TabIndex = 2;
            this.lblファイル名.Text = "ファイル名";
            // 
            // OpenFileFialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 85);
            this.Controls.Add(this.lblファイル名);
            this.Controls.Add(this.txtファイル名);
            this.Controls.Add(this.btn参照);
            this.Name = "OpenFileFialog";
            this.Text = "OpenFileFialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn参照;
        private System.Windows.Forms.TextBox txtファイル名;
        private System.Windows.Forms.Label lblファイル名;
    }
}