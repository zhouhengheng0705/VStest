namespace WindowsFormsApplication1
{
    partial class 操作メニュー
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
            this.gp項目 = new System.Windows.Forms.GroupBox();
            this.btnDataView = new System.Windows.Forms.Button();
            this.btn時間管理 = new System.Windows.Forms.Button();
            this.btnチケット管理 = new System.Windows.Forms.Button();
            this.btnテスト = new System.Windows.Forms.Button();
            this.gp項目.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp項目
            // 
            this.gp項目.Controls.Add(this.btnテスト);
            this.gp項目.Controls.Add(this.btnDataView);
            this.gp項目.Controls.Add(this.btn時間管理);
            this.gp項目.Controls.Add(this.btnチケット管理);
            this.gp項目.Location = new System.Drawing.Point(12, 12);
            this.gp項目.Name = "gp項目";
            this.gp項目.Size = new System.Drawing.Size(186, 83);
            this.gp項目.TabIndex = 0;
            this.gp項目.TabStop = false;
            // 
            // btnDataView
            // 
            this.btnDataView.Location = new System.Drawing.Point(6, 54);
            this.btnDataView.Name = "btnDataView";
            this.btnDataView.Size = new System.Drawing.Size(77, 23);
            this.btnDataView.TabIndex = 6;
            this.btnDataView.Text = "DataView";
            this.btnDataView.UseVisualStyleBackColor = true;
            this.btnDataView.Click += new System.EventHandler(this.btnDataView_Click);
            // 
            // btn時間管理
            // 
            this.btn時間管理.Location = new System.Drawing.Point(100, 18);
            this.btn時間管理.Name = "btn時間管理";
            this.btn時間管理.Size = new System.Drawing.Size(77, 23);
            this.btn時間管理.TabIndex = 5;
            this.btn時間管理.Text = "カレンダー";
            this.btn時間管理.UseVisualStyleBackColor = true;
            this.btn時間管理.Click += new System.EventHandler(this.btn時間管理_Click);
            // 
            // btnチケット管理
            // 
            this.btnチケット管理.Location = new System.Drawing.Point(6, 18);
            this.btnチケット管理.Name = "btnチケット管理";
            this.btnチケット管理.Size = new System.Drawing.Size(77, 23);
            this.btnチケット管理.TabIndex = 4;
            this.btnチケット管理.Text = "チケット管理";
            this.btnチケット管理.UseVisualStyleBackColor = true;
            this.btnチケット管理.Click += new System.EventHandler(this.btnチケット管理_Click);
            // 
            // btnテスト
            // 
            this.btnテスト.Location = new System.Drawing.Point(100, 54);
            this.btnテスト.Name = "btnテスト";
            this.btnテスト.Size = new System.Drawing.Size(77, 23);
            this.btnテスト.TabIndex = 7;
            this.btnテスト.Text = "テスト";
            this.btnテスト.UseVisualStyleBackColor = true;
            this.btnテスト.Click += new System.EventHandler(this.btnテスト_Click_1);
            // 
            // 操作メニュー
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 101);
            this.Controls.Add(this.gp項目);
            this.Name = "操作メニュー";
            this.Text = "操作メニュー";
            this.gp項目.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp項目;
        private System.Windows.Forms.Button btn時間管理;
        private System.Windows.Forms.Button btnチケット管理;
        private System.Windows.Forms.Button btnDataView;
        private System.Windows.Forms.Button btnテスト;
    }
}