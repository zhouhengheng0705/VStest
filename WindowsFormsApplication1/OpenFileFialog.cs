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
    public partial class OpenFileFialog : Form
    {
        public OpenFileFialog()
        {
            InitializeComponent();
        }

        private void btn参照_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtファイル名.Text = openFileDialog1.FileName;
            }
        }
    }
}
