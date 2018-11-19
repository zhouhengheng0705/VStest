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
    public partial class 操作メニュー : Form
    {
        public 操作メニュー()
        {
            InitializeComponent();

        }
        //チケット管理(test)
        public チケット管理 g = null;
        private void btnチケット管理_Click(object sender, EventArgs e)
        {
            if (this.g == null || this.g.IsDisposed)
            {
                this.g = new チケット管理();
                g.Show(this);
                g.btn検索_Click(this, new EventArgs());
            }
            else
            {
                if (this.g.WindowState == FormWindowState.Minimized)
                {
                    this.g.WindowState = FormWindowState.Normal;
                }
            }


        }

        public fmカレンダー f = null;
        private void btn時間管理_Click(object sender, EventArgs e)
        {
            if (this.f == null || this.f.IsDisposed)
            {
                this.f = new fmカレンダー();
                f.Show(this);
            }
            else
            {
                if (this.f.WindowState == FormWindowState.Minimized)
                {
                    this.f.WindowState = FormWindowState.Normal;
                }
            }

        }

        public DataView d = null;
        private void btnDataView_Click(object sender, EventArgs e)
        {
            if (this.d == null || this.d.IsDisposed)
            {
                this.d = new DataView();
                d.Show(this);
            }
            else
            {
                if (this.d.WindowState == FormWindowState.Minimized)
                {
                    this.d.WindowState = FormWindowState.Normal;
                }
            }
        }

        public テスト t = null;
        private void btnテスト_Click_1(object sender, EventArgs e)
        {
            if (this.t == null || this.t.IsDisposed)
            {
                this.t = new テスト();
                t.Show(this);
            }
            else
            {
                if (this.t.WindowState == FormWindowState.Minimized)
                {
                    this.t.WindowState = FormWindowState.Normal;
                }
            }
        }
    }
}
