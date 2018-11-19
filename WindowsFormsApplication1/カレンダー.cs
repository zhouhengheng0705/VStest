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
    public partial class fmカレンダー : Form

    {
        static int システム開始年 = 2012;
        public DateTime dtNow = DateTime.Now;


        public fmカレンダー()
        {
            InitializeComponent();
            string 当日日付 = dtNow.ToShortDateString();
            //年初期化
            for (int i = システム開始年 ; i < システム開始年 + 10; i++)
            {
                cmb年.Items.Add(i);
            }
            int iYear = dtNow.Year;
            cmb年.Text = iYear.ToString();

            //月初期化
            for (int i = 1; i < 13; i++)
            {
                cmb月.Items.Add(i);
            }
            int iMonth = dtNow.Month;
            cmb月.Text = iMonth.ToString();
            //MessageBox.Show(当月初日曜日.ToString(),"曜日");
        }

        private void fm時間管理_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                this.cmb月.Items.Add("2017年");  
            }
            this.cmb月.Items.Add("2017年");
            this.Controls.Add(cmb月);         
        }

        public static Control FindControl(Control ufmカレンダー, string stName)
        {
            // hParent 内のすべてのコントロールを列挙する
            foreach (Control c in ufmカレンダー.Controls)
            {
                Control cFindControl = FindControl(c, stName);

                // 再帰呼び出し先でコントロールが見つかった場合はそのまま返す
                if (cFindControl != null)
                {
                    return cFindControl;
                }
            }

            return null;
        }

        private System.Windows.Forms.Label label;
        private void カレンダーフォーム初期化()
        {
            //カレンダーフォーム初期化
            for (int i = 1; i <= 43; i++)
            {
                Control c = FindControl(this, "label42");
                MessageBox.Show(c.Name);
                //((Label)c).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void 初期化()
        {
            DateTime 月初日 = new DateTime(Int32.Parse(cmb年.Text),Int32.Parse(cmb月.Text),1);
            int 前月日数 = 月初日.AddDays(-1).Day;
            int 当月日数 = (月初日.AddMonths(1)).AddDays(-1).Day;
            int 月初日曜日 = (int)月初日.DayOfWeek;
            //当月初日から末日まで格納
            int n = 1;
            for (int i = 月初日曜日; i <= (月初日曜日 + 当月日数 - 1); i++)
            {
                this.Controls["label" + i].Text = n.ToString();
                DateTime 日付 = new DateTime(月初日.Year,月初日.Month,n);
                this.Controls["label" + i].Tag = 日付;
                this.Controls["label" + i].BackColor = Color.PaleGreen;
                //当日日付取得
                string 当日日付 = dtNow.ToShortDateString();
                if (this.Controls["label" + i].Tag == 当日日付)
                {
                    this.Controls["label" + i].BackColor = Color.Yellow;
                }
                n++;
            }

            //翌月日付格納
            n = 1;
            for (int i = (月初日曜日 + 当月日数); i <= 42; i++)
            {
                this.Controls["label" + i].Text = n.ToString();
                DateTime 翌月日付 = new DateTime(月初日.AddMonths(1).Year,月初日.AddMonths(1).Month,n);
                this.Controls["label" + i].BackColor = Color.Silver;
                n++;
            }

            //前月日付格納
            n = 前月日数;
            for (int i = (月初日曜日 - 1); i <= 1; i--)
            {
                this.Controls["label" + i].Text = n.ToString();
                DateTime 前月日付 = new DateTime(月初日.AddMonths(-1).Year,月初日.AddMonths(-1).Month,n);
                this.Controls["label" + i].BackColor = Color.Silver;
                n--;
            }

            for (int i = 7; i <= 42; i+= 7)
            {
                this.Controls["label" + i].ForeColor = Color.Blue;
            }

            for (int i = 1; i <= 36; i+= 7)
            {
                this.Controls["label" + i].ForeColor = Color.Red;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            カレンダーフォーム初期化();

            //クリック時書式変化
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font(label1.Font,FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ////カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font(label2.Font, FontStyle.Bold);            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font(label6.Font, FontStyle.Bold);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font(label7.Font, FontStyle.Bold);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font(label8.Font, FontStyle.Bold);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font(label9.Font, FontStyle.Bold);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font(label11.Font, FontStyle.Bold);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font(label12.Font, FontStyle.Bold);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font(label13.Font, FontStyle.Bold);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font(label14.Font, FontStyle.Bold);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Font = new Font(label15.Font, FontStyle.Bold);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Font = new Font(label16.Font, FontStyle.Bold);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Font = new Font(label17.Font, FontStyle.Bold);
        }

        private void label18_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font(label18.Font, FontStyle.Bold);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font(label19.Font, FontStyle.Bold);
        }

        private void label20_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Font = new Font(label20.Font, FontStyle.Bold);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Font = new Font(label21.Font, FontStyle.Bold);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Font = new Font(label22.Font, FontStyle.Bold);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label23.BorderStyle = BorderStyle.Fixed3D;
            label23.Font = new Font(label23.Font, FontStyle.Bold);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label24.BorderStyle = BorderStyle.Fixed3D;
            label24.Font = new Font(label24.Font, FontStyle.Bold);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Font = new Font(label25.Font, FontStyle.Bold);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label26.BorderStyle = BorderStyle.Fixed3D;
            label26.Font = new Font(label26.Font, FontStyle.Bold);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label27.BorderStyle = BorderStyle.Fixed3D;
            label27.Font = new Font(label27.Font, FontStyle.Bold);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label28.BorderStyle = BorderStyle.Fixed3D;
            label28.Font = new Font(label28.Font, FontStyle.Bold);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label29.BorderStyle = BorderStyle.Fixed3D;
            label29.Font = new Font(label29.Font, FontStyle.Bold);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label30.BorderStyle = BorderStyle.Fixed3D;
            label30.Font = new Font(label30.Font, FontStyle.Bold);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label31.BorderStyle = BorderStyle.Fixed3D;
            label31.Font = new Font(label31.Font, FontStyle.Bold);
        }

        private void label32_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label32.BorderStyle = BorderStyle.Fixed3D;
            label32.Font = new Font(label32.Font, FontStyle.Bold);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label33.BorderStyle = BorderStyle.Fixed3D;
            label33.Font = new Font(label33.Font, FontStyle.Bold);
        }

        private void label34_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label34.BorderStyle = BorderStyle.Fixed3D;
            label34.Font = new Font(label34.Font, FontStyle.Bold);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label35.BorderStyle = BorderStyle.Fixed3D;
            label35.Font = new Font(label35.Font, FontStyle.Bold);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label36.BorderStyle = BorderStyle.Fixed3D;
            label36.Font = new Font(label36.Font, FontStyle.Bold);
        }

        private void label37_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label37.BorderStyle = BorderStyle.Fixed3D;
            label37.Font = new Font(label37.Font, FontStyle.Bold);
        }

        private void label38_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label38.BorderStyle = BorderStyle.Fixed3D;
            label38.Font = new Font(label38.Font, FontStyle.Bold);
        }

        private void label39_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label39.BorderStyle = BorderStyle.Fixed3D;
            label39.Font = new Font(label39.Font, FontStyle.Bold);
        }

        private void label40_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label40.BorderStyle = BorderStyle.Fixed3D;
            label40.Font = new Font(label40.Font, FontStyle.Bold);
        }

        private void label41_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label41.BorderStyle = BorderStyle.Fixed3D;
            label41.Font = new Font(label41.Font, FontStyle.Bold);
        }

        private void label42_Click(object sender, EventArgs e)
        {
            //カレンダーフォーム初期化
            //カレンダーフォーム初期化();

            //クリック時書式変化
            label42.BorderStyle = BorderStyle.Fixed3D;
            label42.Font = new Font(label42.Font, FontStyle.Bold);
        }

    }
}
