using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using System.Runtime.InteropServices;




namespace WindowsFormsApplication1
{
    public partial class チケット管理 : Form
    {
        static int SystemYear = 2012;
        public DateTime dtNow = DateTime.Now;
        private string filename;


        public チケット管理()
        {
            InitializeComponent();
            lvチケット管理.View = View.Details;
            lvチケット管理.Columns.Add("トラッカー");
            lvチケット管理.Columns.Add("優先度");
            lvチケット管理.Columns.Add("プロジェク名",120);
            lvチケット管理.Columns.Add("チケット番号",70);
            lvチケット管理.Columns.Add("チケット名",240);
            lvチケット管理.Columns.Add("ステータス");
            lvチケット管理.Columns.Add("進捗率");
            lvチケット管理.Columns.Add("開始",80);
            lvチケット管理.Columns.Add("期日",80);
            lvチケット管理.Columns.Add("リリース予定日",80);
            lvチケット管理.Columns.Add("予定工数");
            lvチケット管理.Columns.Add("記録工数");
            lvチケット管理.Columns.Add("無効");
            lvチケット管理.Columns.Add("備考");

            // Initialize the search year 
            for (int i = SystemYear; i < dtNow.Year + 2; i++)
            {
                cmb年.Items.Add(i);  
            }
            cmb年.Text = (dtNow.Year - 1).ToString();
            //Initialize the search month
            for (int i = 1; i < 13; i++)
            {
                cmb月.Items.Add(i);   
            }
            cmb月.Text = (1).ToString();

            //開始年初期化
            for (int i = SystemYear; i < dtNow.Year + 2; i++)
            {
                cmb開始_年.Items.Add(i);
            }
            cmb開始_年.Items.Insert(0,"");
            cmb開始_年.Text = dtNow.Year.ToString();

            //開始月初期化
            for (int i = 1; i < 13; i++)
            {
                cmb開始_月.Items.Add(i);
            }
            cmb開始_月.Items.Insert(0, "");
            cmb開始_月.Text = dtNow.Month.ToString();

            //開始日初期化
            for (int i = 1; i <= 31; i++)
            {
                cmb開始_日.Items.Add(i);
            }
            cmb開始_日.Items.Insert(0, "");
            cmb開始_日.Text = dtNow.Day.ToString();

            //期日年初期化
            for (int i = SystemYear; i < dtNow.Year + 2; i++)
            {
                cmb期日_年.Items.Add(i);
            }
            cmb期日_年.Items.Insert(0, "");
            cmb期日_年.Text = dtNow.Year.ToString();

            //期日月初期化
            for (int i = 1; i < 13; i++)
            {
                cmb期日_月.Items.Add(i);
            }
            cmb期日_月.Items.Insert(0, "");
            cmb期日_月.Text = dtNow.Month.ToString();

            //期日日初期化
            for (int i = 1; i <= 31; i++)
            {
                cmb期日_日.Items.Add(i);
            }
            cmb期日_日.Items.Insert(0, "");
            cmb期日_日.Text = dtNow.Day.ToString();

            //リリース予定日年初期化
            for (int i = SystemYear; i < dtNow.Year + 2; i++)
            {
                cmbリリース予定日_年.Items.Add(i);
            }
            cmbリリース予定日_年.Items.Insert(0,"");
            cmbリリース予定日_年.Text = dtNow.Year.ToString();

            //リリース予定日月初期化
            for (int i = 1; i < 13; i++)
            {
                cmbリリース予定日_月.Items.Add(i);
            }
            cmbリリース予定日_月.Items.Insert(0, "");
            cmbリリース予定日_月.Text = dtNow.Month.ToString();

            //リリース予定日日初期化
            for (int i = 1; i <= 31; i++)
            {
                cmbリリース予定日_日.Items.Add(i);
            }
            cmbリリース予定日_日.Items.Insert(0, "");
            cmbリリース予定日_日.Text = dtNow.Day.ToString();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "進捗";
            dt.Columns.Add("進捗率");
            dt.Columns.Add("値");
            ds.Tables.Add(dt);

            //データを追加します。
            for (Double i = 0; i <= 1; i = i + 0.1)
            {
                DataRow row = ds.Tables[0].NewRow();
                row["進捗率"] = (i).ToString("P0");
                row["値"] = i;
                ds.Tables[0].Rows.Add(row);
            }
            cmb編集_進捗率.DataSource = ds.Tables[0];
            cmb編集_進捗率.DisplayMember = "進捗率";
            cmb編集_進捗率.ValueMember = "値";

            //connect the database
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");
            conn.Open();

            //set the sql
            String sql = "SELECT プロジェクト番号,プロジェクト名 FROM プロジェクト";

            //データセットにデータベースのデータを取得
            SqlDataAdapter daAuthors = new SqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet("Pubs");
            daAuthors.FillSchema(dataset, SchemaType.Source, "プロジェクト");
            daAuthors.Fill(dataset, "プロジェクト");

            //insert a blank row in the combobox
            DataRow InsertRow = dataset.Tables["プロジェクト"].NewRow();
            dataset.Tables["プロジェクト"].Rows.InsertAt(InsertRow,0);
            cmbプロジェクト.DataSource = dataset.Tables["プロジェクト"];
            cmbプロジェクト.DisplayMember = "プロジェクト名";
            cmbプロジェクト.ValueMember = "プロジェクト番号";
            conn.Close();
        }

        private void チケット管理_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'timeManagementDataSet6.プロジェクト' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.プロジェクトTableAdapter.Fill(this.timeManagementDataSet6.プロジェクト);
            // TODO: このコード行はデータを 'timeManagementDataSet5.V_ステータス' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.v_ステータスTableAdapter.Fill(this.timeManagementDataSet5.V_ステータス);
            // TODO: このコード行はデータを 'timeManagementDataSet4.V_トラッカー' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.v_トラッカーTableAdapter.Fill(this.timeManagementDataSet4.V_トラッカー);
            // TODO: このコード行はデータを 'timeManagementDataSet1.V_優先度' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.v_優先度TableAdapter.Fill(this.timeManagementDataSet1.V_優先度);

            //詳細表示にする
            lvチケット管理.View = View.Details;
            //ColumnClickイベントハンドラの追加
            lvチケット管理.ColumnClick += new ColumnClickEventHandler(lvチケット管理_ColumnClick);

            //ListViewItemComparerの作成と設定
            listViewItemSorter = new ListViewItemComparer();
            listViewItemSorter.ColumnModes = new ListViewItemComparer.ComparerMode[]
            {
                ListViewItemComparer.ComparerMode.String,
                ListViewItemComparer.ComparerMode.Integer
            };

            //ListViewItemSorterを指定する
            lvチケット管理.ListViewItemSorter = listViewItemSorter;
        }

        public string filtermake()
        {
            //フィルタ条件生成
            string 開始年月 = string.Empty;
            string filter =string.Empty;

            if (cmb年.Text != "" && cmb月.Text != "")
            {
                開始年月 = cmb年.Text + "/" + String.Format("{0:00}", Double.Parse(cmb月.Text)) + "/01";
                if (filter != "")
                {
                    filter = filter + " AND ";
                }
                filter = filter + "チケット管理.開始 >='" + 開始年月 + "'";
            }

            if (txt検索条件_チケット番号.Text != "")
            {
                if (!IsNumeric(txt検索条件_チケット番号.Text))
                {
                    MessageBox.Show("チケット番号は数字を入れてください。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt検索条件_チケット番号.Focus();
                }
                if (filter != "")
                {
                    filter = filter + " AND ";
                }
                filter = filter + "チケット管理.チケット番号='" + "#" + txt検索条件_チケット番号.Text + "'";
            }

            string プロジェクト番号 = string.Empty;
            if (cmbプロジェクト.Text != "")
            {
                プロジェクト番号 = cmbプロジェクト.SelectedValue.ToString();
                if (filter != "")
                {
                    filter = filter + " AND ";
                }
                filter = filter + "チケット管理.プロジェクト番号 ='" + プロジェクト番号 + "'";
            }

            string checkfilter = string.Empty;
            if (cbトラッカー1.Checked == true || 
                cbトラッカー2.Checked == true || 
                cbトラッカー3.Checked == true || 
                cbトラッカー4.Checked == true || 
                cbトラッカー5.Checked == true)
            {
                if (filter != "")
                {
                    filter = filter + " AND ";
                }
                
                if (cbトラッカー1.Checked == true)
                {
                    checkfilter = checkfilter + "チケット管理.トラッカー = 1";
                }
                if (cbトラッカー2.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.トラッカー = 2";
                }
                if (cbトラッカー3.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.トラッカー = 3";
                }
                if (cbトラッカー4.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.トラッカー = 4";
                }
                if (cbトラッカー5.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.トラッカー = 5";
                }
                filter = filter + "(" + checkfilter + ")";
            }

            if (cbステータス1.Checked == true ||
                cbステータス2.Checked == true ||
                cbステータス3.Checked == true ||
                cbステータス4.Checked == true )
            {
                if (filter != "")
                {
                    filter = filter + " AND ";
                }

                if (cbステータス1.Checked == true)
                {
                    checkfilter = checkfilter + "チケット管理.ステータス = 1";
                }
                if (cbステータス2.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.ステータス = 2";
                }
                if (cbステータス3.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.ステータス = 3";
                }
                if (cbステータス4.Checked == true)
                {
                    if (checkfilter != "")
                    {
                        checkfilter = checkfilter + " Or ";
                    }
                    checkfilter = checkfilter + "チケット管理.ステータス = 4";
                }
                filter = filter + "(" + checkfilter + ")";
            }

            if (filter != "")
            {
                filter = " WHERE " + filter;
            }

            return filter;
        }

        public bool IsNumeric(string stTarget)
        {
            double dNullable;

            return double.TryParse(
                stTarget,
                System.Globalization.NumberStyles.Any,
                null,
                out dNullable
            );
        }


        public void btn検索_Click(object sender, EventArgs e)
        {
            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");
            conn.Open();

            //sql文を設定します。
            String sql = "SELECT *"
                        + ",V_ステータス.項目名 AS ステータス_文字列"
                        + ",V_優先度.項目名 AS 優先度_文字列"
                        + ",V_トラッカー.項目名 AS トラッカー_文字列"
                        + ",プロジェクト.プロジェクト名 AS プロジェクト名_文字列"
                        + " FROM (((チケット管理"
                        + " LEFT JOIN V_ステータス ON CONVERT(int,V_ステータス.値) = チケット管理.ステータス)"
                        + " LEFT JOIN V_トラッカー ON CONVERT(int,V_トラッカー.値) = チケット管理.トラッカー)"
                        + " LEFT JOIN V_優先度 ON CONVERT(int,V_優先度.値) = チケット管理.優先度)"
                        + " LEFT JOIN プロジェクト ON プロジェクト.プロジェクト番号 = チケット管理.プロジェクト番号";

            //チケット管理件数取得
            String Countsql = "SELECT COUNT(*) FROM チケット管理";
            SqlCommand countcom = new SqlCommand(Countsql, conn);
            int Count = (int)countcom.ExecuteScalar();

            sql = sql + filtermake();

            try
            {
                //SqlDataAdapter設定
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet CustomersDataSet = new DataSet();

                //データ取得
                da.Fill(CustomersDataSet, "チケット管理");

                //SqlCommandBuilder設定
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                //テーブル取得
                DataTable dt = CustomersDataSet.Tables["チケット管理"];

                lvチケット管理.Items.Clear();
                foreach (DataRow dRow in dt.Rows)
                {
                    string[] item = {dRow["トラッカー_文字列"].ToString()
                                    ,dRow["優先度_文字列"].ToString()
                                    ,dRow["プロジェクト名_文字列"].ToString()
                                    ,dRow["チケット番号"].ToString()
                                    ,dRow["チケット名"].ToString()
                                    ,dRow["ステータス_文字列"].ToString()
                                    ,String.Format("{0:0%}",dRow["進捗率"])
                                    ,String.Format("{0:yyyy/MM/dd}",dRow["開始"])
                                    ,String.Format("{0:yyyy/MM/dd}",dRow["期日"])
                                    ,String.Format("{0:yyyy/MM/dd}",dRow["リリース予定日"])
                                    ,""
                                    ,""
                                    ,""
                                    ,dRow["備考"].ToString()
                                    };
                    lvチケット管理.Items.Add(new ListViewItem(item));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            ////sqlを実行する。
            //SqlCommand com = new SqlCommand(sql, conn);
            //SqlDataReader reader = com.ExecuteReader();
            //try
            //{
            //    lvチケット管理.Items.Clear();
            //    while (reader.Read())
            //    {
            //        string[] item = { reader["トラッカー_文字列"].ToString() 
            //                        , reader["優先度_文字列"].ToString()
            //                        , reader["プロジェクト名_文字列"].ToString()
            //                        , reader["チケット番号"].ToString()
            //                        , reader["チケット名"].ToString()
            //                        , reader["ステータス_文字列"].ToString()
            //                        , String.Format("{0:0%}",reader["進捗率"])
            //                        , String.Format("{0:yyyy/MM/dd}",reader["開始"])
            //                        , String.Format("{0:yyyy/MM/dd}",reader["期日"])
            //                        , String.Format("{0:yyyy/MM/dd}",reader["リリース予定日"])
            //                        , ""
            //                        , ""
            //                        , ""
            //                        , "" };
            //        lvチケット管理.Items.Add(new ListViewItem(item));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}

            lbl件数.Text = Count.ToString() + "件";
            conn.Close();
        }

        //ListViewItemSorterに指定するフィールド
        ListViewItemComparer listViewItemSorter;

        //列がクリックされた時
        private void lvチケット管理_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //クリックされた列を設定
            //lvチケット管理.ListViewItemSorter = new ListViewItemComparer(e.Column);

            listViewItemSorter.Column = e.Column;
            //並び替える
            lvチケット管理.Sort();
        }

        public class ListViewItemComparer : IComparer
        {
            /// <summary>
            /// 比較する方法
            /// </summary>
            public enum ComparerMode
            {
                /// <summary>
                /// 文字列として比較
                /// </summary>
                String,
                /// <summary>
                /// 数値（Int32型）として比較
                /// </summary>
                Integer,
                /// <summary>
                /// 日時（DataTime型）として比較
                /// </summary>
                DateTime
            };

            private int _column;
            private System.Windows.Forms.SortOrder _order;
            private ComparerMode _mode;
            private ComparerMode[] _columnModes;

            /// <summary>
            /// 並び替えるListView列の番号
            /// </summary>
            public int Column
            {
                set
                {
                    //現在と同じ列の時は、昇順降順を切り替える
                    //if (_column == value)
                    //{
                    if (_order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        _order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else if (_order == System.Windows.Forms.SortOrder.Descending)
                    {
                        _order = System.Windows.Forms.SortOrder.Ascending;
                    }
                    //}
                    _column = value;
                }
                get
                {
                    return _column;
                }
            }
            /// <summary>
            /// 昇順か降順か
            /// </summary>
            public System.Windows.Forms.SortOrder Order
            {
                set
                {
                    _order = value;
                }
                get
                {
                    return _order;
                }
            }
            /// <summary>
            /// 並び替えの方法
            /// </summary>
            public ComparerMode Mode
            {
                set
                {
                    _mode = value;
                }
                get
                {
                    return _mode;
                }
            }
            /// <summary>
            /// 列ごとの並び替えの方法
            /// </summary>
            public ComparerMode[] ColumnModes
            {
                set
                {
                    _columnModes = value;
                }
            }

            /// <summary>
            /// ListViewItemComparerクラスのコンストラクタ
            /// </summary>
            /// <param name="col">並び替える列の番号</param>
            /// <param name="ord">昇順か降順か</param>
            /// <param name="cmod">並び替えの方法</param>
            public ListViewItemComparer(
                int col, System.Windows.Forms.SortOrder ord, ComparerMode cmod)
            {
                _column = col;
                _order = ord;
                _mode = cmod;
            }
            public ListViewItemComparer()
            {
                _column = 0;
                _order = System.Windows.Forms.SortOrder.Ascending;
                _mode = ComparerMode.String;
            }

            //xがyより小さいときはマイナスの数、大きいときはプラスの数、
            //同じときは0を返す
            public int Compare(object x, object y)
            {
                if (_order == System.Windows.Forms.SortOrder.None)
                {
                    //並び替えない時
                    return 0;
                }

                int result = 0;
                //ListViewItemの取得
                ListViewItem itemx = (ListViewItem)x;
                ListViewItem itemy = (ListViewItem)y;

                //並べ替えの方法を決定
                if (_columnModes != null && _columnModes.Length > _column)
                {
                    _mode = _columnModes[_column];
                }

                //並び替えの方法別に、xとyを比較する
                switch (_mode)
                {
                    case ComparerMode.String:
                        //文字列をとして比較
                        result = string.Compare(itemx.SubItems[_column].Text,
                            itemy.SubItems[_column].Text);
                        break;
                    case ComparerMode.Integer:
                        //Int32に変換して比較
                        //.NET Framework 2.0からは、TryParseメソッドを使うこともできる
                        result = int.Parse(itemx.SubItems[_column].Text).CompareTo(
                            int.Parse(itemy.SubItems[_column].Text));
                        break;
                    case ComparerMode.DateTime:
                        //DateTimeに変換して比較
                        //.NET Framework 2.0からは、TryParseメソッドを使うこともできる
                        result = DateTime.Compare(
                            DateTime.Parse(itemx.SubItems[_column].Text),
                            DateTime.Parse(itemy.SubItems[_column].Text));
                        break;
                }

                //降順の時は結果を+-逆にする
                if (_order == System.Windows.Forms.SortOrder.Descending)
                {
                    result = -result;
                }

                //結果を返す
                return result;
            }
        }


        private void btn追加_Click(object sender, EventArgs e)
        {
            //プロジェクト入力チェック
            String プロジェクト;
            if (cmb編集_プロジェクト.Text == "")
            {
                プロジェクト = "";
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(cmb編集_プロジェクト.SelectedValue.ToString(), @"\d\d\d\d") == false)
                {
                    MessageBox.Show("プロジェクト入力が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbプロジェクト.Focus();
                    return;
                }
                プロジェクト = cmb編集_プロジェクト.SelectedValue.ToString();
            }

            //チケット番号入力チェック
            String チケット番号;
            if (txtチケット番号.Text != "")
            {
                チケット番号 = Strings.StrConv(txtチケット番号.Text, VbStrConv.Narrow);
                if (チケット番号.Substring(0,1) != "#")
                {
                    チケット番号 = "#" + チケット番号;
                    if (System.Text.RegularExpressions.Regex.IsMatch(チケット番号,@"#\d\d\d\d") == false)
                    {
                        MessageBox.Show("チケット番号が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtチケット番号.Focus();
                        return;
                    }
                }
            }
            else
            {
                チケット番号 = "";
            }

            //日付入力チェック
            String 開始;
            if (cmb開始_年.Text == "" && cmb開始_月.Text == "" && cmb開始_日.Text == "")
            {
                開始 = "";   
            }
            else if (cmb開始_年.Text == "" || cmb開始_月.Text == "" || cmb開始_日.Text == "")
            {
                MessageBox.Show("開始日付を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb開始_年.Focus();
                return;
            }
            else
	        {
                開始 = cmb開始_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmb開始_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmb開始_日.Text));
	        }
            
            String 期日;
            if (cmb期日_年.Text == "" && cmb期日_月.Text == "" && cmb期日_日.Text == "")
            {
                期日 = "";    
            }
            else if (cmb期日_年.Text == "" || cmb期日_月.Text == "" || cmb期日_日.Text == "")
            {
                MessageBox.Show("期日日付を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb期日_年.Focus();
                return;
            }
            else
	        {
                期日 = cmb開始_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmb開始_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmb開始_日.Text));
	        }

            String リリース予定日;
            if (cmbリリース予定日_年.Text == "" && cmbリリース予定日_月.Text == "" && cmbリリース予定日_日.Text == "")
	        {
		        リリース予定日 = "";
	        }
            else if(cmbリリース予定日_年.Text == "" || cmbリリース予定日_月.Text == "" || cmbリリース予定日_日.Text == "")
            {
                MessageBox.Show("リリース予定日を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb期日_年.Focus();
                return;
            }
            else
            {
                リリース予定日 = cmbリリース予定日_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmbリリース予定日_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmbリリース予定日_日.Text));
            }

            //予定工数入力チェック
            Double 予定工数;
            if (txt予定工数.Text != "")
            {
                予定工数 = Double.Parse(txt予定工数.Text);
            }

            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");
            
            try
            {
                //sql文を設定する
                String sql = "SELECT * FROM チケット管理";

                //SqlDataAdapter設定
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet CustomersDataSet = new DataSet();

                //データ取得
                da.Fill(CustomersDataSet, "チケット管理");

                //SqlCommandBuilder設定
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                //テーブル取得
                DataTable dt = CustomersDataSet.Tables["チケット管理"];

                //SqlCommand command = new SqlCommand(sql,conn);

                //チケット番号存在チェック
                foreach (DataRow dRows in dt.Rows)
                {
                    if (dRows["チケット番号"].ToString() == チケット番号)
                    {
                        MessageBox.Show("このチケット番号は既に登録済です。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtチケット番号.Focus();
                        return;
                    }
                }

                //レコード追加
                DataRow dRow = dt.NewRow();
                dRow["チケット番号"] = チケット番号;
                dRow["トラッカー"] = cmb編集_トラッカー.SelectedValue;
                dRow["チケット名"] = txtチケット名.Text;
                dRow["プロジェクト番号"] = プロジェクト;
                dRow["優先度"] = cmb編集_優先度.SelectedValue;
                dRow["ステータス"] = cmb編集_ステータス.SelectedValue;
                dRow["開始"] = DateTime.ParseExact(開始, @"yyyy/MM/dd", null);
                dRow["期日"] = DateTime.ParseExact(期日, @"yyyy/MM/dd", null);
                dRow["リリース予定日"] = DateTime.ParseExact(リリース予定日, @"yyyy/MM/dd", null);
                dRow["進捗率"] = cmb編集_進捗率.SelectedValue;
                dRow["備考"] = txt備考.Text;
                dRow["登録日時"] = DateTime.Now;
                dRow["登録者ID"] = "shuu";
                dt.Rows.Add(dRow);

                //データ更新
                da.Update(CustomersDataSet, "チケット管理");

                //SqlDataAdapterの解放
                da.Dispose();

                ////com.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                ////com.ExecuteNonQuery();
                ////String 新規採番されたID = com.Parameters["@ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            } 
            finally
            {
                //データベースの接続終了
                conn.Close();
            }
            //btn検索_Click();
            btn検索.PerformClick();
            MessageBox.Show("データの登録に成功しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn更新_Click(object sender, EventArgs e)
        {
            //プロジェクト入力チェック
            String プロジェクト;
            if (cmb編集_プロジェクト.Text == "")
            {
                プロジェクト = "";
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(cmb編集_プロジェクト.SelectedValue.ToString(), @"\d\d\d\d") == false)
                {
                    MessageBox.Show("プロジェクト入力が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbプロジェクト.Focus();
                    return;
                }
                プロジェクト = cmb編集_プロジェクト.SelectedValue.ToString();
            }

            //チケット番号入力チェック
            String チケット番号;
            if (txtチケット番号.Text != "")
            {
                チケット番号 = Strings.StrConv(txtチケット番号.Text, VbStrConv.Narrow);
                if (チケット番号.Substring(0, 1) != "#")
                {
                    チケット番号 = "#" + チケット番号;
                    if (System.Text.RegularExpressions.Regex.IsMatch(チケット番号, @"#\d\d\d\d") == false)
                    {
                        MessageBox.Show("チケット番号が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtチケット番号.Focus();
                        return;
                    }
                }
            }
            else
            {
                チケット番号 = "";
            }

            //日付入力チェック
            String 開始;
            if (cmb開始_年.Text == "" && cmb開始_月.Text == "" && cmb開始_日.Text == "")
            {
                開始 = "";
            }
            else if (cmb開始_年.Text == "" || cmb開始_月.Text == "" || cmb開始_日.Text == "")
            {
                MessageBox.Show("開始日付を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb開始_年.Focus();
                return;
            }
            else
            {
                開始 = cmb開始_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmb開始_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmb開始_日.Text));
            }

            String 期日;
            if (cmb期日_年.Text == "" && cmb期日_月.Text == "" && cmb期日_日.Text == "")
            {
                期日 = "";
            }
            else if (cmb期日_年.Text == "" || cmb期日_月.Text == "" || cmb期日_日.Text == "")
            {
                MessageBox.Show("期日日付を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb期日_年.Focus();
                return;
            }
            else
            {
                期日 = cmb開始_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmb開始_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmb開始_日.Text));
            }

            String リリース予定日;
            if (cmbリリース予定日_年.Text == "" && cmbリリース予定日_月.Text == "" && cmbリリース予定日_日.Text == "")
            {
                リリース予定日 = "";
            }
            else if (cmbリリース予定日_年.Text == "" || cmbリリース予定日_月.Text == "" || cmbリリース予定日_日.Text == "")
            {
                MessageBox.Show("リリース予定日を正しく入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb期日_年.Focus();
                return;
            }
            else
            {
                リリース予定日 = cmbリリース予定日_年.Text + "/" + String.Format("{0:00}", Double.Parse(cmbリリース予定日_月.Text)) + "/" + String.Format("{0:00}", Double.Parse(cmbリリース予定日_日.Text));
            }

            //予定工数入力チェック
            Double 予定工数;
            if (txt予定工数.Text != "")
            {
                予定工数 = Double.Parse(txt予定工数.Text);
            }

            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");

            try
            {
                //sql文を設定する
                String sql = "SELECT * FROM チケット管理 WHERE チケット番号='" + チケット番号 + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet CustomersDataSet = new DataSet();

                //データ取得
                da.Fill(CustomersDataSet, "チケット管理");

                //SqlCommandBuilder設定
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                //テーブル取得
                DataTable dt = CustomersDataSet.Tables["チケット管理"];

                int dt_counter = dt.Rows.Count;
                if (dt_counter == 0)
                {
                    MessageBox.Show("チケットが未登録です。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtチケット番号.Focus();
                    return;
                }

                //レコード変更
                dt.Rows[0]["チケット番号"] = チケット番号;
                dt.Rows[0]["トラッカー"] = cmb編集_トラッカー.SelectedValue;
                dt.Rows[0]["チケット名"] = txtチケット名.Text;
                dt.Rows[0]["プロジェクト番号"] = プロジェクト;
                dt.Rows[0]["優先度"] = cmb編集_優先度.SelectedValue;
                dt.Rows[0]["ステータス"] = cmb編集_ステータス.SelectedValue; ;
                dt.Rows[0]["開始"] = DateTime.ParseExact(開始, @"yyyy/MM/dd", null); ;
                dt.Rows[0]["期日"] = DateTime.ParseExact(期日, @"yyyy/MM/dd", null);
                dt.Rows[0]["リリース予定日"] = DateTime.ParseExact(リリース予定日, @"yyyy/MM/dd", null);
                dt.Rows[0]["進捗率"] = cmb編集_進捗率.SelectedValue;
                dt.Rows[0]["備考"] = txt備考.Text;
                dt.Rows[0]["更新日時"] = DateTime.Now;
                dt.Rows[0]["更新者ID"] = "shuu";
                da.Update(CustomersDataSet, "チケット管理");

                //SqlDataAdapterの解放
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                //データベースの接続終了
                conn.Close();
            }

            //btn検索_Click();
            btn検索_Click(this, new EventArgs());
            MessageBox.Show("データの更新に成功しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn削除_Click()
        {
            //チケット番号入力チェック
            String チケット番号;
            if (txtチケット番号.Text != "")
            {
                チケット番号 = Strings.StrConv(txtチケット番号.Text, VbStrConv.Narrow);
                if (チケット番号.Substring(0, 1) != "#")
                {
                    チケット番号 = "#" + チケット番号;
                    if (System.Text.RegularExpressions.Regex.IsMatch(チケット番号, @"#\d\d\d\d") == false)
                    {
                        MessageBox.Show("チケット番号が不正です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtチケット番号.Focus();
                        return;
                    }
                }
            }
            else
            {
                チケット番号 = "";
            }

            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");

            try
            {
                //sql文を設定する
                String sql = "SELECT * FROM チケット管理 WHERE チケット番号='" + チケット番号 + "'";

                //SqlDataAdapter設定
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet CustomersDataSet = new DataSet();

                //データ取得
                da.Fill(CustomersDataSet, "チケット管理");

                //SqlCommandBuilder設定
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                //テーブル取得
                DataTable dt = CustomersDataSet.Tables["チケット管理"];

                int dt_counter = dt.Rows.Count;
                if (dt_counter == 0)
                {
                    MessageBox.Show("チケット番号が未登録です。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtチケット番号.Focus();
                    return;
                }

                //レコード削除
                dt.Rows[0].Delete();

                //データ更新
                da.Update(CustomersDataSet, "チケット管理");

                //SqlDataAdapterの解放
                da.Dispose();

                //btn検索_Click();
                btn検索.PerformClick();
                MessageBox.Show("データの削除に成功しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                //データベースの接続終了
                conn.Close();
            }
        }

        static string MaxID()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");

            int maxID;
            String MaxID = String.Empty;

            // 接続文字列を設定します。
            conn.Open();

            //SELECT文を設定します。
            string sql = "SELECT Max(ID) As Max_ID FROM dbo.チケット管理";
            SqlCommand com = new SqlCommand(sql,conn);

            try
            {
                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    MaxID = reader["Max_ID"] as String;

                }
                //// SQLの実行
                //com.ExecuteNonQuery();
                //maxID = (int)com.ExecuteScalar();

                if (MaxID == null)
                {
                    maxID = 0;
                }
                else
                {
                    maxID = Int32.Parse(MaxID);
                }
                maxID = maxID + 1;
                MaxID = String.Format("{0:D5}", maxID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            conn.Close();
            return MaxID;  
        }

        private void lvチケット管理_ItemClick(object sender, EventArgs e)
        {

            if (lvチケット管理.SelectedItems.Count > 0)
            {
                ListViewItem item = lvチケット管理.SelectedItems[0];
                cmb編集_トラッカー.Text = item.SubItems[0].Text;
                cmb編集_優先度.Text = item.SubItems[1].Text;
                cmb編集_プロジェクト.Text = item.SubItems[2].Text;
                txtチケット番号.Text = item.SubItems[3].Text;
                txtチケット名.Text = item.SubItems[4].Text;
                cmb編集_ステータス.Text = item.SubItems[5].Text;
                cmb編集_進捗率.Text = item.SubItems[6].Text;
                cmb開始_年.Text = (item.SubItems[7].Text).Substring(0,4);
                cmb開始_月.Text = (item.SubItems[7].Text).Substring(5,2);
                cmb開始_日.Text = (item.SubItems[7].Text).Substring(8, 2);
                cmb期日_年.Text = (item.SubItems[8].Text).Substring(0, 4);
                cmb期日_月.Text = (item.SubItems[8].Text).Substring(5, 2);
                cmb期日_日.Text = (item.SubItems[8].Text).Substring(8, 2);
                cmbリリース予定日_年.Text = (item.SubItems[9].Text).Substring(0, 4);
                cmbリリース予定日_月.Text = (item.SubItems[9].Text).Substring(5, 2);
                cmbリリース予定日_日.Text = (item.SubItems[9].Text).Substring(8, 2);
                txt予定工数.Text = item.SubItems[10].Text;
                txt備考.Text = item.SubItems[13].Text;
            }
        }

        private void btnクリア_Click(object sender, EventArgs e)
        {
            cmb編集_トラッカー.SelectedIndex = 0;
            cmb編集_優先度.SelectedIndex = 0;
            cmb編集_プロジェクト.SelectedIndex = 0;
            txtチケット番号.Text = "";
            txtチケット名.Text = "";
            cmb編集_ステータス.SelectedIndex = 0;
            cmb編集_進捗率.SelectedIndex = 0;
            cmb開始_年.Text = "";
            cmb開始_月.Text = "";
            cmb開始_日.Text = "";
            cmb期日_年.Text = "";
            cmb期日_月.Text = "";
            cmb期日_日.Text = "";
            cmbリリース予定日_年.Text = "";
            cmbリリース予定日_月.Text = "";
            cmbリリース予定日_日.Text = "";
            txt予定工数.Text = "";
            txt備考.Text = "";
        }

        private void btn全選択_Click(object sender, EventArgs e)
        {
            int j = 0;
            if (lvチケット管理.Items.Count == 0)
            {
                MessageBox.Show("データなし、検索してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int i = 0; i < lvチケット管理.Items.Count; i++)
            {
                if (lvチケット管理.Items[i].Checked == false)
                {
                    break;
                }
                j++;
            }

            if (j == lvチケット管理.Items.Count)
            {
                for (int i = 0; i < lvチケット管理.Items.Count; i++)
                {
                    lvチケット管理.Items[i].Checked = false;
                }
            }
            else
            {
                for (int i = 0; i < lvチケット管理.Items.Count; i++)
                {
                    lvチケット管理.Items[i].Checked = true;
                }
            }

        }

        private void btnエクスポート_Click_1(object sender, EventArgs e)
        {
            //string csvPath; bool writeHeader;
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt.TableName = "進捗";
            //dt.Columns.Add("進捗率");
            //dt.Columns.Add("値");
            //ds.Tables.Add(dt);

            ////データを追加します。
            //for (Double i = 0; i <= 1; i = i + 0.1)
            //{
            //    DataRow row = ds.Tables[0].NewRow();
            //    row["進捗率"] = (i).ToString("P0");
            //    row["値"] = i;
            //    ds.Tables[0].Rows.Add(row);
            //}

            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");
            conn.Open();

            //sql文を設定します。
            String sql = " SELECT V_トラッカー.項目名 AS トラッカー,V_優先度.項目名 AS 優先度,プロジェクト.プロジェクト名 AS プロジェクト名,V_ステータス.項目名 AS ステータス,チケット番号,チケット名,FORMAT(進捗率,'0%') As 進捗率,FORMAT(開始,'yyyy/MM/dd') AS 開始,FORMAT(期日,'yyyy/MM/dd') As 期日,FORMAT(リリース予定日,'yyyy/MM/dd') AS リリース予定日,予定工数,記録工数,チケット管理.削除フラグ,備考"
                       + " FROM (((チケット管理"
                       + " LEFT JOIN V_ステータス ON CONVERT(int,V_ステータス.値) = チケット管理.ステータス)"
                       + " LEFT JOIN V_トラッカー ON CONVERT(int,V_トラッカー.値) = チケット管理.トラッカー)"
                       + " LEFT JOIN V_優先度 ON CONVERT(int,V_優先度.値) = チケット管理.優先度)"
                       + " LEFT JOIN プロジェクト ON プロジェクト.プロジェクト番号 = チケット管理.プロジェクト番号";

            //チケット管理件数取得
            String Countsql = "SELECT COUNT(*) FROM チケット管理";
            SqlCommand countcom = new SqlCommand(Countsql, conn);
            int Count = (int)countcom.ExecuteScalar();

            sql = sql + filtermake();


            //SqlDataAdapter設定
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataSet CustomersDataSet = new DataSet();

            //データ取得
            da.Fill(CustomersDataSet, "チケット管理");

            //SqlCommandBuilder設定
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

            //テーブル取得
            DataTable dt = CustomersDataSet.Tables["チケット管理"];

            エクスポート(dt);
            MessageBox.Show("データのエクスポートが完了しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //csvPath = @"C:\Users\shuu\Desktop\shuu\進捗.csv";
            //writeHeader = true;

            ////CSVファイルに書き込む時に使うEncoding
            //System.Text.Encoding enc = System.Text.Encoding.GetEncoding("Shift_JIS");

            //try
            //{
            //    //using (FileStream fs = new FileStream(csvPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            //    using ( //書き込むファイルを開く
            //            StreamWriter sr = new StreamWriter(csvPath, false, enc))
            //    {
            //        int colCount = dt.Columns.Count;
            //        int lastColIndex = colCount - 1;

            //        //ヘッダを書き込む
            //        if (writeHeader)
            //        {
            //            for (int i = 0; i < colCount; i++)
            //            {
            //                //ヘッダの取得
            //                string field = dt.Columns[i].Caption;
            //                //"で囲む
            //                field = EncloseDoubleQuotesIfNeed(field);
            //                //フィールドを書き込む
            //                sr.Write(field);
            //                //カンマを書き込む
            //                if (lastColIndex > i)
            //                {
            //                    sr.Write(',');
            //                }
            //            }
            //            //改行する
            //            sr.Write("\r\n");

            //            //レコードを書き込む
            //            foreach (DataRow row in dt.Rows)
            //            {
            //                for (int i = 0; i < colCount; i++)
            //                {
            //                    //フィールドの取得
            //                    string field = row[i].ToString();
            //                    //string field = dt.Rows[i]["トラッカー_文字列"].ToString();
            //                    //"で囲む
            //                    field = EncloseDoubleQuotesIfNeed(field);
            //                    //フィールドを書き込む
            //                    sr.Write(field);
            //                    //カンマを書き込む
            //                    if (lastColIndex > i)
            //                    {
            //                        sr.Write(',');
            //                    }
            //                }
            //                //改行する
            //                sr.Write("\r\n");
            //            }
            //            //閉じる
            //            sr.Close();
            //            MessageBox.Show("データのエクスポートが完了しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}           
        }

        /// <summary>
        /// 必要ならば、文字列をダブルクォートで囲む
        /// </summary>
        private string EncloseDoubleQuotesIfNeed(string field)
        {
            if (NeedEncloseDoubleQuotes(field))
            {
                return EncloseDoubleQuotes(field);
            }
            return field;
        }

        /// <summary>
        /// 文字列をダブルクォートで囲む
        /// </summary>
        private string EncloseDoubleQuotes(string field)
        {
            if (field.IndexOf('"') > -1)
            {
                //"を""とする
                field = field.Replace("\"", "\"\"");
            }
            return "\"" + field + "\"";
        }

        /// <summary>
        /// 文字列をダブルクォートで囲む必要があるか調べる
        /// </summary>
        private bool NeedEncloseDoubleQuotes(string field)
        {
            return field.IndexOf('"') > -1 ||
                field.IndexOf(',') > -1 ||
                field.IndexOf('\r') > -1 ||
                field.IndexOf('\n') > -1 ||
                field.StartsWith(" ") ||
                field.StartsWith("\t") ||
                field.EndsWith(" ") ||
                field.EndsWith("\t");
        }

        private void btnテスト_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Visible = false;

            //Open the Excel
            Excel.Workbook WorkBook = ExcelApp.Workbooks.Open(System.IO.Path.GetFullPath(@"C:\Users\shuu\Desktop\shuu\メモをしにくい知識.xlsx"));

            //select the first sheet 
            Excel.Worksheet sheet = WorkBook.Sheets[2];
            sheet.Select();

            //take the value of cellA1

            Excel.Range range = sheet.get_Range("A1");
            if (range != null)
            {
                MessageBox.Show(range.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            WorkBook.Close();
            ExcelApp.Quit();
        }

        private void エクスポート(DataTable dt)
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                //上書の確認ダイアログを非表示
                ExcelApp.DisplayAlerts = false;
                //ウィンドウは非表示
                ExcelApp.Visible = true;
                //ブックを新規作成
                Excel.Workbook WorkBook = ExcelApp.Workbooks.Add();
                //select the first sheet

                Excel.Worksheet sheet = WorkBook.Sheets[1];
                sheet.Select(Type.Missing);
                //データテーブルの列ごとでExcelに出力
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    //+1は項目名の行
                    object[,] obj = new object[dt.Rows.Count + 1, 1];

                    // 項目名出力
                    obj[0, 0] = dt.Columns[col].ColumnName;

                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        // データテーブルをobject配列に格納
                        obj[row + 1, 0] = dt.Rows[row][col].ToString();
                    }


                    Excel.Range rgn = sheet.Range[sheet.Cells[3, col + 2], sheet.Cells[dt.Rows.Count + 3, col + 2]]; //最初のセル(行,列)～最後のセル(行,列)
                    rgn.Font.Size = 10;
                    rgn.Font.Name = "メイリオ";

                    DataColumn dtcol = dt.Columns[col];
                    if (dtcol.DataType.ToString() == "System.String")
                    {
                        rgn.NumberFormatLocal = "@"; //表示形式を文字列にする
                        rgn.Value2 = obj;
                    }
                    else //System.Int32
                    {
                        rgn.Value2 = obj;
                    }
                }

                //ウィンドウ枠固定
                //sheet.Activate();
                Excel.Range startDataRow = (Excel.Range)sheet.Rows[4];

                startDataRow.Activate();
                startDataRow.Select();
                startDataRow.Application.ActiveWindow.FreezePanes = true;

                //最終行取得
                int EndRow = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                int EndColumn = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Column;

                //ヘッダ行背景色 
                Excel.Range headRow = sheet.Range[sheet.Cells[3, 2], sheet.Cells[3, EndColumn]];

                headRow.Interior.Color = Color.FromArgb(125, 255, 255);
                Excel.Range DataArea = sheet.Range[sheet.Cells[3, 2], sheet.Cells[EndRow, EndColumn]];
                //枠線付ける領域取得

                //枠線を付ける
                DataArea.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                //行自動調整
                sheet.Columns["B:N"].AutoFit();
                sheet.Columns[1].ColumnWidth = 2.25;

                //字体設定

                //Bookを保存
                WorkBook.SaveAs(@"C:\Users\shuu\Desktop\shuu\チケット一覧_" + dtNow.ToString("yyyyMMddHHmm") + ".xlsx");
                //Bookを閉じる
                WorkBook.Close(false);
                //Excelアプリケーションの終了
                ExcelApp.Quit();
                //COMの解放
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp);
                ExcelApp = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnインポート_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "ファイルを開く";
            op.Filter = "Excel ファイル|*.xls;*.xlsx;*.xlsm|全てのファイル|*.*";
            op.FilterIndex = 1;

            DialogResult dr = op.ShowDialog();
            String filepass = String.Empty;
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                filepass = op.FileName;
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }
            //ファイルオープン
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //上書の確認ダイアログを非表示
            ExcelApp.DisplayAlerts = false;
            //ウィンドウは非表示
            ExcelApp.Visible = true;
            Excel.Workbooks Workbooks = ExcelApp.Workbooks;
            Excel.Workbook Workbook = Workbooks.Open(filepass);

            Excel.Worksheet sheet = Workbook.Sheets[1];

            //最終行取得
            int EndRow = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            int EndColumn = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Column;


            //データベース接続
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7O181CF\SQLEXPRESS;Initial Catalog = TimeManagement;Integrated Security=True;");
            conn.Open();

            //トラッカーDic設定
            String sql = " SELECT 項目名,値 FROM V_トラッカー";
            SqlCommand com = new SqlCommand(sql,conn);

            Dictionary<string, string> トラッカーDic = new Dictionary<string, string>();
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                トラッカーDic.Add(reader["項目名"].ToString(),reader["値"].ToString());
            }
            reader.Close();
            com.Dispose();


            //優先度Dic設定
            String sql1 = "SELECT 項目名,値 FROM V_優先度";
            SqlCommand com1 = new SqlCommand(sql1,conn);

            Dictionary<string, string> 優先度Dic = new Dictionary<string, string>();
            var reader1 = com1.ExecuteReader();
            while (reader1.Read())
            {
                優先度Dic.Add(reader1["項目名"].ToString(),reader1["値"].ToString());
            }
            reader1.Close();
            com1.Dispose();


            //ステータスDic設定
            String sql2 = "SELECT 項目名,値 FROM V_ステータス";
            SqlCommand com2 = new SqlCommand(sql2,conn);

            Dictionary<string, string> ステータスDic = new Dictionary<string, string>();
            var reader2 = com2.ExecuteReader();
            while(reader2.Read())
            {
                ステータスDic.Add(reader2["項目名"].ToString(),reader2["値"].ToString());
            }
            reader2.Close();
            com2.Dispose();

            //プロジェクトDic設定
            String sql3 = "SELECT プロジェクト名,プロジェクト番号 FROM プロジェクト";
            SqlCommand com3 = new SqlCommand(sql3,conn);

            Dictionary<string,string> プロジェクトDic = new Dictionary<string,string>();
            var reader3 = com3.ExecuteReader();
            while(reader3.Read())
	        {
	            プロジェクトDic.Add(reader3["プロジェクト名"].ToString(),reader3["プロジェクト番号"].ToString());
	        }
            reader3.Close();
            com3.Dispose();

            //ヘッダ行Dic設定
            Dictionary<string,int> ヘッダ行Dic = new Dictionary<string,int>();
            ヘッダ行Dic.Add("トラッカー",2);
            ヘッダ行Dic.Add("優先度", 3);
            ヘッダ行Dic.Add("プロジェクト名", 4);
            ヘッダ行Dic.Add("ステータス", 5);
            ヘッダ行Dic.Add("チケット番号", 6);
            ヘッダ行Dic.Add("チケット名", 7);
            ヘッダ行Dic.Add("進捗率", 8);
            ヘッダ行Dic.Add("開始", 9);
            ヘッダ行Dic.Add("期日", 10);
            ヘッダ行Dic.Add("リリース予定日", 11);
            ヘッダ行Dic.Add("予定工数", 12);
            ヘッダ行Dic.Add("記録工数", 13);
            ヘッダ行Dic.Add("削除工数", 14);
            ヘッダ行Dic.Add("備考", 15);
            
            int errorN = 0;
            for (int i = 4; i <= EndRow; i++)
            {
                Dictionary<string, string> データ行Dic = new Dictionary<string, string>();
                foreach (KeyValuePair<string,int> 参照キー in ヘッダ行Dic)
                {
                    データ行Dic.Add(参照キー.Key,sheet.Cells[i,参照キー.Value].Value);
                }

                String トラッカー = string.Empty;
                if (データ行Dic["トラッカー"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:トラッカー未入力";
                    goto Continue;
                    errorN++;
                }
                if (!トラッカーDic.ContainsKey(データ行Dic["トラッカー"]))
                {
                    sheet.Cells[i,1].Value = "NG:トラッカー入力値不正";
                    goto Continue;
                    errorN++;
                }
                トラッカー = トラッカーDic[データ行Dic["トラッカー"]];

                String 優先度 = string.Empty;
                if (データ行Dic["優先度"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:優先度未入力";
                    goto Continue;
                    errorN++;
                }
                if (!優先度Dic.ContainsKey(データ行Dic["優先度"]))
                {
                    sheet.Cells[i, 1].Value = "NG:優先度入力値不正";
                    goto Continue;
                    errorN++;
                }
                優先度 = 優先度Dic[データ行Dic["優先度"]];

                String ステータス = string.Empty;
                if (データ行Dic["ステータス"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:ステータス未入力";
                    goto Continue;
                    errorN++;
                }
                if (!ステータスDic.ContainsKey(データ行Dic["ステータス"]))
                {
                    sheet.Cells[i, 1].Value = "NG:ステータス入力値不正";
                    goto Continue;
                    errorN++;
                }
                ステータス = ステータスDic[データ行Dic["ステータス"]];

                //プロジェクト名書式チェック
                String プロジェクト名 = string.Empty;
                if (データ行Dic["プロジェクト名"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:プロジェクト名未入力";
                    goto Continue;
                    errorN++;
                }
                if (!プロジェクトDic.ContainsKey(データ行Dic["プロジェクト名"]))
                {
                    sheet.Cells[i, 1].Value = "NG:プロジェクト名入力値不正";
                    goto Continue;
                    errorN++;
                }
                プロジェクト名 = プロジェクトDic[データ行Dic["プロジェクト名"]];

                //チケット番号書式チェック
                String チケット番号 = string.Empty;
                チケット番号 = データ行Dic["チケット番号"];
                if (チケット番号 != "")
                {
                    チケット番号 = Strings.StrConv(チケット番号, VbStrConv.Narrow);
                    if (チケット番号.Substring(0, 1) != "#")
                    {
                        チケット番号 = "#" + チケット番号;
                        if (System.Text.RegularExpressions.Regex.IsMatch(チケット番号, @"^#\d\d\d\d|\d|") == false)
                        {
                            sheet.Cells[i, 1].Value = "NG:チケット番号入力値不正";
                            goto Continue;
                            errorN++;
                        }
                    }
                }
                else
                {
                    チケット番号 = "";
                }

                //チケット名書式チェック
                string チケット名 = string.Empty;
                if (データ行Dic["チケット名"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:チケット名未入力";
                    goto Continue;
                    errorN++;
                }
                チケット名 = データ行Dic["チケット名"];

                //開始書式チェック
                string 開始 = string.Empty;
                if (データ行Dic["開始"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:開始未入力";
                    goto Continue;
                    errorN++;
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(データ行Dic["開始"], @"^\d\d\d\d/\d\d/\d\d$") == false)
                    {
                        sheet.Cells[i, 1].Value = "NG:開始入力値不正";
                        goto Continue;
                        errorN++;
                    }        
                }
                開始 = データ行Dic["開始"];

                //期日書式チェック
                string 期日 = string.Empty;
                if (データ行Dic["期日"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:期日未入力";
                    goto Continue;
                    errorN++;
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(データ行Dic["期日"], @"^\d\d\d\d/\d\d/\d\d$") == false)
                    {
                        sheet.Cells[i, 1].Value = "NG:期日入力値不正";
                        goto Continue;
                        errorN++;
                    }
                }
                期日 = データ行Dic["期日"];

                //リリース予定日書式チェック
                string リリース予定日 = string.Empty;
                if (System.Text.RegularExpressions.Regex.IsMatch(データ行Dic["リリース予定日"], @"^\d\d\d\d/\d\d/\d\d$") == false)
                {
                    sheet.Cells[i, 1].Value = "NG:リリース予定日入力値不正";
                    goto Continue;
                    errorN++;
                }
                リリース予定日 = データ行Dic["リリース予定日"];

                //進捗率書式チェック
                decimal 進捗率; 
                if (データ行Dic["進捗率"] == "")
                {
                    sheet.Cells[i, 1].Value = "NG:進捗率未入力";
                    goto Continue;
                    errorN++;
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(データ行Dic["進捗率"], @"^([1-9]0|100)%$") == false)
                    {
                        sheet.Cells[i, 1].Value = "NG:進捗率入力値不正";
                        goto Continue;
                        errorN++;
                    }
                }
                進捗率 = (Convert.ToDecimal(データ行Dic["進捗率"].Substring(0, データ行Dic["進捗率"].Length - 1)))/100;


                //備考書式チェック
                string 備考 = string.Empty;
                備考 = データ行Dic["備考"];


                //インポート開始
                if (チケット番号 != "")
                {
                    String sql5 = "SELECT * FROM チケット管理 WHERE チケット番号='" + チケット番号 + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql5, conn);

                    DataSet CustomersDataSet = new DataSet();

                    da.Fill(CustomersDataSet, "チケット管理");

                    //SqlCommandBuilder設定
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

                    DataTable dt = CustomersDataSet.Tables["チケット管理"];

                    int dt_counter = dt.Rows.Count;
                    if (dt_counter == 0)
                    {
                        //レコード追加
                        DataRow dRow = dt.NewRow();
                        dRow["チケット番号"] = チケット番号;
                        dRow["トラッカー"] = トラッカー;
                        dRow["チケット名"] = チケット名;
                        dRow["プロジェクト番号"] = プロジェクト名;
                        dRow["優先度"] = 優先度;
                        dRow["ステータス"] = ステータス;
                        dRow["開始"] = 開始;
                        dRow["期日"] = 期日;
                        dRow["リリース予定日"] = リリース予定日;
                        dRow["進捗率"] = 進捗率;
                        dRow["備考"] = 備考;
                        dRow["登録日時"] = DateTime.Now;
                        dRow["登録者ID"] = "shuu";
                        dt.Rows.Add(dRow);

                        //データ更新
                        da.Update(CustomersDataSet, "チケット管理");

                        //SqlDataAdapterの解放
                        da.Dispose();
                    }
                    else
                    {
                        //レコード変更
                        dt.Rows[0]["チケット番号"] = チケット番号;
                        dt.Rows[0]["トラッカー"] = トラッカー;
                        dt.Rows[0]["チケット名"] = チケット名;
                        dt.Rows[0]["プロジェクト番号"] = プロジェクト名;
                        dt.Rows[0]["優先度"] = 優先度;
                        dt.Rows[0]["ステータス"] = ステータス;
                        dt.Rows[0]["開始"] = 開始;
                        dt.Rows[0]["期日"] = 期日;
                        dt.Rows[0]["リリース予定日"] = リリース予定日;
                        dt.Rows[0]["進捗率"] = 進捗率;
                        dt.Rows[0]["備考"] = 備考;
                        dt.Rows[0]["更新日時"] = DateTime.Now;
                        dt.Rows[0]["更新者ID"] = "shuu";

                        //データ更新
                        da.Update(CustomersDataSet, "チケット管理");

                        //SqlDataAdapterの解放
                        da.Dispose();
                    }
                    //データベースの接続終了
                    conn.Close();
	            }
            Continue:
                System.Windows.Forms.Application.DoEvents();                               
            }
            MessageBox.Show("データのインポートに成功しました。","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}






