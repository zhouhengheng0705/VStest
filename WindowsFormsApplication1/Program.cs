using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 操作メニュー());
        }
    }

    public class ADO
    {
        public void Test()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = PC\SQL Server Management Studio;Initial Catalog = TimeManagement;User Id = shuu;";
            conn.Open();
            conn.Close();
        }
    }

    public class Utils
    {
        public bool Check(string project)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(project,@"\d\d\d\d$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
