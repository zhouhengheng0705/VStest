using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class テスト : Form
    {
        public テスト()
        {
            InitializeComponent();
        }

        //private System.Windows.Forms.Label[] labels;
        //private void テスト_Load(object sender, EventArgs e)
        //{
        //    this.labels = new System.Windows.Forms.Label[42];
        //    this.SuspendLayout();
        //    //カレンダーフォーム初期化
        //    for (int i = 0; i < 42; i++)
        //    {
        //        //Control c = this.Controls["label" + i];
        //        //((Label)c).BorderStyle = BorderStyle.Fixed3D;
        //        //this.Controls["label" + i].BorderStyle = BorderStyle.Fixed3D;
        //        //インスタンス作成
        //        this.labels[i] = new System.Windows.Forms.Label();
        //        //プロパティ設定
        //        this.labels[i].Name = "label" + i.ToString();
        //        this.labels[i].Text = "31";
        //        this.labels[i].Size = new Size(30, 30);
        //        this.labels[i].Location = new Point(i * 30, 10);
           
        //        //イベントハンドラに関連付け
        //        this.labels[i].Click += new EventHandler(this.labels_Click);

        //        //フォームにコントロールを追加
        //        this.Controls.AddRange(this.labels);
        //        this.ResumeLayout(false);
        //    }
        //}

        ////labelのクリックイベントハンドラ
        //private void labels_Click(object sender, EventArgs e)
        //{
        //    //クリックされたボタンのNameを表示する
        //    MessageBox.Show(((System.Windows.Forms.Label)sender).Name);
        //}

        private System.Windows.Forms.Button[] buttons;
        private void テスト_Load(object sender, EventArgs e)
        {
            this.buttons = new System.Windows.Forms.Button[42];
            this.SuspendLayout();
            //カレンダーフォーム初期化
            for (int i = 0; i < 42; i++)
            {
                
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("",11,FontStyle.Bold);

        }
    }
}
