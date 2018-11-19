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
    public partial class DataView : Form
    {
        private DataTable dt;

        public DataView()
        {
            InitializeComponent();
            // 3列定義します。
        }

        private System.Windows.Forms.Button Button1;

        
       //フォームのLoadイベントハンドラ
        private void DataView_Load_1(object sender, EventArgs e)
        {
            //Buttonクラスのインスタンスを作成する
            this.Button1 = new System.Windows.Forms.Button();

            //Buttonコントロールのプロパティを設定する
            this.Button1.Name = "Button1";
            this.Button1.Text = "押してね";
            //サイズと位置を設定する
            this.Button1.Location = new Point(10, 10);
            this.Button1.Size = new System.Drawing.Size(80, 20);

            //フォームに追加する
            this.Controls.Add(this.Button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //クリックされたボタンのNameを表示する
            MessageBox.Show(((System.Windows.Forms.Button)sender).Name);
        }

    }
}
