namespace WindowsFormsApplication1
{
    partial class チケット管理
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
            this.components = new System.ComponentModel.Container();
            this.gp検索 = new System.Windows.Forms.GroupBox();
            this.cb無効 = new System.Windows.Forms.CheckBox();
            this.cbトラッカー4 = new System.Windows.Forms.CheckBox();
            this.gpステータス = new System.Windows.Forms.GroupBox();
            this.cbステータス4 = new System.Windows.Forms.CheckBox();
            this.cbステータス3 = new System.Windows.Forms.CheckBox();
            this.cbステータス2 = new System.Windows.Forms.CheckBox();
            this.cbステータス1 = new System.Windows.Forms.CheckBox();
            this.gpトラッカー = new System.Windows.Forms.GroupBox();
            this.cbトラッカー5 = new System.Windows.Forms.CheckBox();
            this.cbトラッカー3 = new System.Windows.Forms.CheckBox();
            this.cbトラッカー2 = new System.Windows.Forms.CheckBox();
            this.cbトラッカー1 = new System.Windows.Forms.CheckBox();
            this.txt検索条件_チケット番号 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblプロジェクト = new System.Windows.Forms.Label();
            this.cmbプロジェクト = new System.Windows.Forms.ComboBox();
            this.lbl月 = new System.Windows.Forms.Label();
            this.cmb月 = new System.Windows.Forms.ComboBox();
            this.lbl年 = new System.Windows.Forms.Label();
            this.cmb年 = new System.Windows.Forms.ComboBox();
            this.lbl検索範囲 = new System.Windows.Forms.Label();
            this.lvチケット管理 = new System.Windows.Forms.ListView();
            this.gp編集 = new System.Windows.Forms.GroupBox();
            this.btnテスト = new System.Windows.Forms.Button();
            this.btn削除 = new System.Windows.Forms.Button();
            this.btn更新 = new System.Windows.Forms.Button();
            this.btn追加 = new System.Windows.Forms.Button();
            this.lbl備考 = new System.Windows.Forms.Label();
            this.txt備考 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbリリース予定日_日 = new System.Windows.Forms.ComboBox();
            this.lblリリース予定日 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbリリース予定日_月 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbリリース予定日_年 = new System.Windows.Forms.ComboBox();
            this.lbl期日_日 = new System.Windows.Forms.Label();
            this.cmb期日_日 = new System.Windows.Forms.ComboBox();
            this.lbl編集_期日 = new System.Windows.Forms.Label();
            this.lbl期日_月 = new System.Windows.Forms.Label();
            this.cmb期日_月 = new System.Windows.Forms.ComboBox();
            this.lbl期日_年 = new System.Windows.Forms.Label();
            this.cmb期日_年 = new System.Windows.Forms.ComboBox();
            this.lbl開始_日 = new System.Windows.Forms.Label();
            this.cmb開始_日 = new System.Windows.Forms.ComboBox();
            this.lbl編集_開始 = new System.Windows.Forms.Label();
            this.lbl開始_月 = new System.Windows.Forms.Label();
            this.cmb開始_月 = new System.Windows.Forms.ComboBox();
            this.lbl開始_年 = new System.Windows.Forms.Label();
            this.cmb開始_年 = new System.Windows.Forms.ComboBox();
            this.lbl編集_時 = new System.Windows.Forms.Label();
            this.txt予定工数 = new System.Windows.Forms.TextBox();
            this.lbl編集_予定工数 = new System.Windows.Forms.Label();
            this.cmb編集_進捗率 = new System.Windows.Forms.ComboBox();
            this.lbl編集_進捗率 = new System.Windows.Forms.Label();
            this.cmb編集_優先度 = new System.Windows.Forms.ComboBox();
            this.v優先度BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagementDataSet1 = new WindowsFormsApplication1.TimeManagementDataSet1();
            this.lbl編集_優先度 = new System.Windows.Forms.Label();
            this.cb編集_無効 = new System.Windows.Forms.CheckBox();
            this.txtチケット名 = new System.Windows.Forms.TextBox();
            this.lbl編集_チケット名 = new System.Windows.Forms.Label();
            this.txtチケット番号 = new System.Windows.Forms.TextBox();
            this.lbl編集_チケット番号 = new System.Windows.Forms.Label();
            this.cmb編集_ステータス = new System.Windows.Forms.ComboBox();
            this.vステータスBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagementDataSet5 = new WindowsFormsApplication1.TimeManagementDataSet5();
            this.lbl編集_ステータス = new System.Windows.Forms.Label();
            this.cmb編集_トラッカー = new System.Windows.Forms.ComboBox();
            this.vトラッカーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagementDataSet4 = new WindowsFormsApplication1.TimeManagementDataSet4();
            this.lbl編集_トラッカー = new System.Windows.Forms.Label();
            this.cmb編集_プロジェクト = new System.Windows.Forms.ComboBox();
            this.プロジェクトBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagementDataSet6 = new WindowsFormsApplication1.TimeManagementDataSet6();
            this.lbl編集_プロジェクト = new System.Windows.Forms.Label();
            this.btnクリア = new System.Windows.Forms.Button();
            this.btn検索 = new System.Windows.Forms.Button();
            this.timeManagementDataSet = new WindowsFormsApplication1.TimeManagementDataSet();
            this.timeManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.チケット管理BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.チケット管理TableAdapter = new WindowsFormsApplication1.TimeManagementDataSetTableAdapters.チケット管理TableAdapter();
            this.チケット管理BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.チケット管理BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.v_優先度TableAdapter = new WindowsFormsApplication1.TimeManagementDataSet1TableAdapters.V_優先度TableAdapter();
            this.v_トラッカーTableAdapter = new WindowsFormsApplication1.TimeManagementDataSet4TableAdapters.V_トラッカーTableAdapter();
            this.v_ステータスTableAdapter = new WindowsFormsApplication1.TimeManagementDataSet5TableAdapters.V_ステータスTableAdapter();
            this.プロジェクトTableAdapter = new WindowsFormsApplication1.TimeManagementDataSet6TableAdapters.プロジェクトTableAdapter();
            this.txtチケット管理番号 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl件数 = new System.Windows.Forms.Label();
            this.btn全選択 = new System.Windows.Forms.Button();
            this.btnエクスポート = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.gp検索.SuspendLayout();
            this.gpステータス.SuspendLayout();
            this.gpトラッカー.SuspendLayout();
            this.gp編集.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v優先度BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vステータスBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vトラッカーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.プロジェクトBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gp検索
            // 
            this.gp検索.Controls.Add(this.cb無効);
            this.gp検索.Controls.Add(this.gpステータス);
            this.gp検索.Controls.Add(this.gpトラッカー);
            this.gp検索.Controls.Add(this.txt検索条件_チケット番号);
            this.gp検索.Controls.Add(this.label1);
            this.gp検索.Controls.Add(this.lblプロジェクト);
            this.gp検索.Controls.Add(this.cmbプロジェクト);
            this.gp検索.Controls.Add(this.lbl月);
            this.gp検索.Controls.Add(this.cmb月);
            this.gp検索.Controls.Add(this.lbl年);
            this.gp検索.Controls.Add(this.cmb年);
            this.gp検索.Controls.Add(this.lbl検索範囲);
            this.gp検索.Location = new System.Drawing.Point(12, 12);
            this.gp検索.Name = "gp検索";
            this.gp検索.Size = new System.Drawing.Size(587, 115);
            this.gp検索.TabIndex = 0;
            this.gp検索.TabStop = false;
            this.gp検索.Text = "検索";
            // 
            // cb無効
            // 
            this.cb無効.AutoSize = true;
            this.cb無効.Location = new System.Drawing.Point(386, 58);
            this.cb無効.Name = "cb無効";
            this.cb無効.Size = new System.Drawing.Size(48, 16);
            this.cb無効.TabIndex = 7;
            this.cb無効.Text = "無効";
            this.cb無効.UseVisualStyleBackColor = true;
            // 
            // cbトラッカー4
            // 
            this.cbトラッカー4.AutoSize = true;
            this.cbトラッカー4.Location = new System.Drawing.Point(12, 39);
            this.cbトラッカー4.Name = "cbトラッカー4";
            this.cbトラッカー4.Size = new System.Drawing.Size(48, 16);
            this.cbトラッカー4.TabIndex = 3;
            this.cbトラッカー4.Text = "要望";
            this.cbトラッカー4.UseVisualStyleBackColor = true;
            // 
            // gpステータス
            // 
            this.gpステータス.Controls.Add(this.cbステータス4);
            this.gpステータス.Controls.Add(this.cbステータス3);
            this.gpステータス.Controls.Add(this.cbステータス2);
            this.gpステータス.Controls.Add(this.cbステータス1);
            this.gpステータス.Location = new System.Drawing.Point(203, 43);
            this.gpステータス.Name = "gpステータス";
            this.gpステータス.Size = new System.Drawing.Size(170, 61);
            this.gpステータス.TabIndex = 6;
            this.gpステータス.TabStop = false;
            this.gpステータス.Text = "ステータス";
            // 
            // cbステータス4
            // 
            this.cbステータス4.AutoSize = true;
            this.cbステータス4.Location = new System.Drawing.Point(99, 39);
            this.cbステータス4.Name = "cbステータス4";
            this.cbステータス4.Size = new System.Drawing.Size(48, 16);
            this.cbステータス4.TabIndex = 3;
            this.cbステータス4.Text = "終了";
            this.cbステータス4.UseVisualStyleBackColor = true;
            // 
            // cbステータス3
            // 
            this.cbステータス3.AutoSize = true;
            this.cbステータス3.Location = new System.Drawing.Point(15, 39);
            this.cbステータス3.Name = "cbステータス3";
            this.cbステータス3.Size = new System.Drawing.Size(78, 16);
            this.cbステータス3.TabIndex = 2;
            this.cbステータス3.Text = "リリース待ち";
            this.cbステータス3.UseVisualStyleBackColor = true;
            // 
            // cbステータス2
            // 
            this.cbステータス2.AutoSize = true;
            this.cbステータス2.Location = new System.Drawing.Point(99, 15);
            this.cbステータス2.Name = "cbステータス2";
            this.cbステータス2.Size = new System.Drawing.Size(60, 16);
            this.cbステータス2.TabIndex = 1;
            this.cbステータス2.Text = "進行中";
            this.cbステータス2.UseVisualStyleBackColor = true;
            // 
            // cbステータス1
            // 
            this.cbステータス1.AutoSize = true;
            this.cbステータス1.Location = new System.Drawing.Point(15, 15);
            this.cbステータス1.Name = "cbステータス1";
            this.cbステータス1.Size = new System.Drawing.Size(48, 16);
            this.cbステータス1.TabIndex = 0;
            this.cbステータス1.Text = "新規";
            this.cbステータス1.UseVisualStyleBackColor = true;
            // 
            // gpトラッカー
            // 
            this.gpトラッカー.Controls.Add(this.cbトラッカー5);
            this.gpトラッカー.Controls.Add(this.cbトラッカー4);
            this.gpトラッカー.Controls.Add(this.cbトラッカー3);
            this.gpトラッカー.Controls.Add(this.cbトラッカー2);
            this.gpトラッカー.Controls.Add(this.cbトラッカー1);
            this.gpトラッカー.Location = new System.Drawing.Point(16, 43);
            this.gpトラッカー.Name = "gpトラッカー";
            this.gpトラッカー.Size = new System.Drawing.Size(178, 61);
            this.gpトラッカー.TabIndex = 5;
            this.gpトラッカー.TabStop = false;
            this.gpトラッカー.Text = "トラッカー";
            // 
            // cbトラッカー5
            // 
            this.cbトラッカー5.AutoSize = true;
            this.cbトラッカー5.Location = new System.Drawing.Point(61, 39);
            this.cbトラッカー5.Name = "cbトラッカー5";
            this.cbトラッカー5.Size = new System.Drawing.Size(60, 16);
            this.cbトラッカー5.TabIndex = 4;
            this.cbトラッカー5.Text = "イベント";
            this.cbトラッカー5.UseVisualStyleBackColor = true;
            // 
            // cbトラッカー3
            // 
            this.cbトラッカー3.AutoSize = true;
            this.cbトラッカー3.Location = new System.Drawing.Point(113, 15);
            this.cbトラッカー3.Name = "cbトラッカー3";
            this.cbトラッカー3.Size = new System.Drawing.Size(62, 16);
            this.cbトラッカー3.TabIndex = 2;
            this.cbトラッカー3.Text = "サポート";
            this.cbトラッカー3.UseVisualStyleBackColor = true;
            // 
            // cbトラッカー2
            // 
            this.cbトラッカー2.AutoSize = true;
            this.cbトラッカー2.Location = new System.Drawing.Point(61, 15);
            this.cbトラッカー2.Name = "cbトラッカー2";
            this.cbトラッカー2.Size = new System.Drawing.Size(48, 16);
            this.cbトラッカー2.TabIndex = 1;
            this.cbトラッカー2.Text = "機能";
            this.cbトラッカー2.UseVisualStyleBackColor = true;
            // 
            // cbトラッカー1
            // 
            this.cbトラッカー1.AutoSize = true;
            this.cbトラッカー1.Location = new System.Drawing.Point(12, 15);
            this.cbトラッカー1.Name = "cbトラッカー1";
            this.cbトラッカー1.Size = new System.Drawing.Size(43, 16);
            this.cbトラッカー1.TabIndex = 0;
            this.cbトラッカー1.Text = "バグ";
            this.cbトラッカー1.UseVisualStyleBackColor = true;
            // 
            // txt検索条件_チケット番号
            // 
            this.txt検索条件_チケット番号.Location = new System.Drawing.Point(485, 14);
            this.txt検索条件_チケット番号.Name = "txt検索条件_チケット番号";
            this.txt検索条件_チケット番号.Size = new System.Drawing.Size(87, 19);
            this.txt検索条件_チケット番号.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "チケット番号";
            // 
            // lblプロジェクト
            // 
            this.lblプロジェクト.AutoSize = true;
            this.lblプロジェクト.Location = new System.Drawing.Point(231, 20);
            this.lblプロジェクト.Name = "lblプロジェクト";
            this.lblプロジェクト.Size = new System.Drawing.Size(56, 12);
            this.lblプロジェクト.TabIndex = 7;
            this.lblプロジェクト.Text = "プロジェクト";
            // 
            // cmbプロジェクト
            // 
            this.cmbプロジェクト.FormattingEnabled = true;
            this.cmbプロジェクト.Location = new System.Drawing.Point(290, 14);
            this.cmbプロジェクト.Name = "cmbプロジェクト";
            this.cmbプロジェクト.Size = new System.Drawing.Size(125, 20);
            this.cmbプロジェクト.TabIndex = 3;
            // 
            // lbl月
            // 
            this.lbl月.AutoSize = true;
            this.lbl月.Location = new System.Drawing.Point(190, 20);
            this.lbl月.Name = "lbl月";
            this.lbl月.Size = new System.Drawing.Size(35, 12);
            this.lbl月.TabIndex = 4;
            this.lbl月.Text = "月から";
            // 
            // cmb月
            // 
            this.cmb月.FormattingEnabled = true;
            this.cmb月.Location = new System.Drawing.Point(143, 14);
            this.cmb月.Name = "cmb月";
            this.cmb月.Size = new System.Drawing.Size(47, 20);
            this.cmb月.TabIndex = 2;
            // 
            // lbl年
            // 
            this.lbl年.AutoSize = true;
            this.lbl年.Location = new System.Drawing.Point(127, 20);
            this.lbl年.Name = "lbl年";
            this.lbl年.Size = new System.Drawing.Size(17, 12);
            this.lbl年.TabIndex = 2;
            this.lbl年.Text = "年";
            // 
            // cmb年
            // 
            this.cmb年.FormattingEnabled = true;
            this.cmb年.Location = new System.Drawing.Point(67, 14);
            this.cmb年.Name = "cmb年";
            this.cmb年.Size = new System.Drawing.Size(59, 20);
            this.cmb年.TabIndex = 1;
            // 
            // lbl検索範囲
            // 
            this.lbl検索範囲.AutoSize = true;
            this.lbl検索範囲.Location = new System.Drawing.Point(14, 20);
            this.lbl検索範囲.Name = "lbl検索範囲";
            this.lbl検索範囲.Size = new System.Drawing.Size(53, 12);
            this.lbl検索範囲.TabIndex = 0;
            this.lbl検索範囲.Text = "検索範囲";
            // 
            // lvチケット管理
            // 
            this.lvチケット管理.CheckBoxes = true;
            this.lvチケット管理.FullRowSelect = true;
            this.lvチケット管理.GridLines = true;
            this.lvチケット管理.Location = new System.Drawing.Point(12, 150);
            this.lvチケット管理.MultiSelect = false;
            this.lvチケット管理.Name = "lvチケット管理";
            this.lvチケット管理.Size = new System.Drawing.Size(656, 287);
            this.lvチケット管理.TabIndex = 1;
            this.lvチケット管理.UseCompatibleStateImageBehavior = false;
            this.lvチケット管理.View = System.Windows.Forms.View.List;
            this.lvチケット管理.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvチケット管理_ColumnClick);
            this.lvチケット管理.SelectedIndexChanged += new System.EventHandler(this.lvチケット管理_ItemClick);
            // 
            // gp編集
            // 
            this.gp編集.Controls.Add(this.btnテスト);
            this.gp編集.Controls.Add(this.btn削除);
            this.gp編集.Controls.Add(this.btn更新);
            this.gp編集.Controls.Add(this.btn追加);
            this.gp編集.Controls.Add(this.lbl備考);
            this.gp編集.Controls.Add(this.txt備考);
            this.gp編集.Controls.Add(this.label3);
            this.gp編集.Controls.Add(this.cmbリリース予定日_日);
            this.gp編集.Controls.Add(this.lblリリース予定日);
            this.gp編集.Controls.Add(this.label5);
            this.gp編集.Controls.Add(this.cmbリリース予定日_月);
            this.gp編集.Controls.Add(this.label6);
            this.gp編集.Controls.Add(this.cmbリリース予定日_年);
            this.gp編集.Controls.Add(this.lbl期日_日);
            this.gp編集.Controls.Add(this.cmb期日_日);
            this.gp編集.Controls.Add(this.lbl編集_期日);
            this.gp編集.Controls.Add(this.lbl期日_月);
            this.gp編集.Controls.Add(this.cmb期日_月);
            this.gp編集.Controls.Add(this.lbl期日_年);
            this.gp編集.Controls.Add(this.cmb期日_年);
            this.gp編集.Controls.Add(this.lbl開始_日);
            this.gp編集.Controls.Add(this.cmb開始_日);
            this.gp編集.Controls.Add(this.lbl編集_開始);
            this.gp編集.Controls.Add(this.lbl開始_月);
            this.gp編集.Controls.Add(this.cmb開始_月);
            this.gp編集.Controls.Add(this.lbl開始_年);
            this.gp編集.Controls.Add(this.cmb開始_年);
            this.gp編集.Controls.Add(this.lbl編集_時);
            this.gp編集.Controls.Add(this.txt予定工数);
            this.gp編集.Controls.Add(this.lbl編集_予定工数);
            this.gp編集.Controls.Add(this.cmb編集_進捗率);
            this.gp編集.Controls.Add(this.lbl編集_進捗率);
            this.gp編集.Controls.Add(this.cmb編集_優先度);
            this.gp編集.Controls.Add(this.lbl編集_優先度);
            this.gp編集.Controls.Add(this.cb編集_無効);
            this.gp編集.Controls.Add(this.txtチケット名);
            this.gp編集.Controls.Add(this.lbl編集_チケット名);
            this.gp編集.Controls.Add(this.txtチケット番号);
            this.gp編集.Controls.Add(this.lbl編集_チケット番号);
            this.gp編集.Controls.Add(this.cmb編集_ステータス);
            this.gp編集.Controls.Add(this.lbl編集_ステータス);
            this.gp編集.Controls.Add(this.cmb編集_トラッカー);
            this.gp編集.Controls.Add(this.lbl編集_トラッカー);
            this.gp編集.Controls.Add(this.cmb編集_プロジェクト);
            this.gp編集.Controls.Add(this.lbl編集_プロジェクト);
            this.gp編集.Controls.Add(this.btnクリア);
            this.gp編集.Location = new System.Drawing.Point(12, 443);
            this.gp編集.Name = "gp編集";
            this.gp編集.Size = new System.Drawing.Size(656, 252);
            this.gp編集.TabIndex = 2;
            this.gp編集.TabStop = false;
            this.gp編集.Text = "編集";
            // 
            // btnテスト
            // 
            this.btnテスト.Location = new System.Drawing.Point(586, 193);
            this.btnテスト.Name = "btnテスト";
            this.btnテスト.Size = new System.Drawing.Size(48, 23);
            this.btnテスト.TabIndex = 48;
            this.btnテスト.Text = "テスト";
            this.btnテスト.UseVisualStyleBackColor = true;
            this.btnテスト.Click += new System.EventHandler(this.btnテスト_Click);
            // 
            // btn削除
            // 
            this.btn削除.Location = new System.Drawing.Point(586, 108);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(48, 23);
            this.btn削除.TabIndex = 47;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = true;
            // 
            // btn更新
            // 
            this.btn更新.Location = new System.Drawing.Point(586, 71);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(48, 23);
            this.btn更新.TabIndex = 45;
            this.btn更新.Text = "更新";
            this.btn更新.UseVisualStyleBackColor = true;
            this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
            // 
            // btn追加
            // 
            this.btn追加.Location = new System.Drawing.Point(586, 32);
            this.btn追加.Name = "btn追加";
            this.btn追加.Size = new System.Drawing.Size(48, 23);
            this.btn追加.TabIndex = 44;
            this.btn追加.Text = "追加";
            this.btn追加.UseVisualStyleBackColor = true;
            this.btn追加.Click += new System.EventHandler(this.btn追加_Click);
            // 
            // lbl備考
            // 
            this.lbl備考.AutoSize = true;
            this.lbl備考.Location = new System.Drawing.Point(32, 196);
            this.lbl備考.Name = "lbl備考";
            this.lbl備考.Size = new System.Drawing.Size(29, 12);
            this.lbl備考.TabIndex = 43;
            this.lbl備考.Text = "備考";
            // 
            // txt備考
            // 
            this.txt備考.Location = new System.Drawing.Point(64, 193);
            this.txt備考.Multiline = true;
            this.txt備考.Name = "txt備考";
            this.txt備考.Size = new System.Drawing.Size(443, 50);
            this.txt備考.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "日";
            // 
            // cmbリリース予定日_日
            // 
            this.cmbリリース予定日_日.FormattingEnabled = true;
            this.cmbリリース予定日_日.Location = new System.Drawing.Point(203, 158);
            this.cmbリリース予定日_日.Name = "cmbリリース予定日_日";
            this.cmbリリース予定日_日.Size = new System.Drawing.Size(47, 20);
            this.cmbリリース予定日_日.TabIndex = 40;
            // 
            // lblリリース予定日
            // 
            this.lblリリース予定日.AutoSize = true;
            this.lblリリース予定日.Location = new System.Drawing.Point(21, 156);
            this.lblリリース予定日.Name = "lblリリース予定日";
            this.lblリリース予定日.Size = new System.Drawing.Size(41, 24);
            this.lblリリース予定日.TabIndex = 39;
            this.lblリリース予定日.Text = "リリース\r\n予定日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "月";
            // 
            // cmbリリース予定日_月
            // 
            this.cmbリリース予定日_月.FormattingEnabled = true;
            this.cmbリリース予定日_月.Location = new System.Drawing.Point(140, 158);
            this.cmbリリース予定日_月.Name = "cmbリリース予定日_月";
            this.cmbリリース予定日_月.Size = new System.Drawing.Size(47, 20);
            this.cmbリリース予定日_月.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "年";
            // 
            // cmbリリース予定日_年
            // 
            this.cmbリリース予定日_年.FormattingEnabled = true;
            this.cmbリリース予定日_年.Location = new System.Drawing.Point(64, 158);
            this.cmbリリース予定日_年.Name = "cmbリリース予定日_年";
            this.cmbリリース予定日_年.Size = new System.Drawing.Size(59, 20);
            this.cmbリリース予定日_年.TabIndex = 35;
            // 
            // lbl期日_日
            // 
            this.lbl期日_日.AutoSize = true;
            this.lbl期日_日.Location = new System.Drawing.Point(508, 127);
            this.lbl期日_日.Name = "lbl期日_日";
            this.lbl期日_日.Size = new System.Drawing.Size(17, 12);
            this.lbl期日_日.TabIndex = 34;
            this.lbl期日_日.Text = "日";
            // 
            // cmb期日_日
            // 
            this.cmb期日_日.FormattingEnabled = true;
            this.cmb期日_日.Location = new System.Drawing.Point(460, 123);
            this.cmb期日_日.Name = "cmb期日_日";
            this.cmb期日_日.Size = new System.Drawing.Size(47, 20);
            this.cmb期日_日.TabIndex = 33;
            // 
            // lbl編集_期日
            // 
            this.lbl編集_期日.AutoSize = true;
            this.lbl編集_期日.Location = new System.Drawing.Point(288, 127);
            this.lbl編集_期日.Name = "lbl編集_期日";
            this.lbl編集_期日.Size = new System.Drawing.Size(29, 12);
            this.lbl編集_期日.TabIndex = 32;
            this.lbl編集_期日.Text = "期日";
            // 
            // lbl期日_月
            // 
            this.lbl期日_月.AutoSize = true;
            this.lbl期日_月.Location = new System.Drawing.Point(444, 127);
            this.lbl期日_月.Name = "lbl期日_月";
            this.lbl期日_月.Size = new System.Drawing.Size(17, 12);
            this.lbl期日_月.TabIndex = 31;
            this.lbl期日_月.Text = "月";
            // 
            // cmb期日_月
            // 
            this.cmb期日_月.FormattingEnabled = true;
            this.cmb期日_月.Location = new System.Drawing.Point(397, 123);
            this.cmb期日_月.Name = "cmb期日_月";
            this.cmb期日_月.Size = new System.Drawing.Size(47, 20);
            this.cmb期日_月.TabIndex = 30;
            // 
            // lbl期日_年
            // 
            this.lbl期日_年.AutoSize = true;
            this.lbl期日_年.Location = new System.Drawing.Point(381, 127);
            this.lbl期日_年.Name = "lbl期日_年";
            this.lbl期日_年.Size = new System.Drawing.Size(17, 12);
            this.lbl期日_年.TabIndex = 29;
            this.lbl期日_年.Text = "年";
            // 
            // cmb期日_年
            // 
            this.cmb期日_年.FormattingEnabled = true;
            this.cmb期日_年.Location = new System.Drawing.Point(321, 123);
            this.cmb期日_年.Name = "cmb期日_年";
            this.cmb期日_年.Size = new System.Drawing.Size(59, 20);
            this.cmb期日_年.TabIndex = 28;
            // 
            // lbl開始_日
            // 
            this.lbl開始_日.AutoSize = true;
            this.lbl開始_日.Location = new System.Drawing.Point(251, 127);
            this.lbl開始_日.Name = "lbl開始_日";
            this.lbl開始_日.Size = new System.Drawing.Size(17, 12);
            this.lbl開始_日.TabIndex = 27;
            this.lbl開始_日.Text = "日";
            // 
            // cmb開始_日
            // 
            this.cmb開始_日.FormattingEnabled = true;
            this.cmb開始_日.Location = new System.Drawing.Point(203, 123);
            this.cmb開始_日.Name = "cmb開始_日";
            this.cmb開始_日.Size = new System.Drawing.Size(47, 20);
            this.cmb開始_日.TabIndex = 26;
            // 
            // lbl編集_開始
            // 
            this.lbl編集_開始.AutoSize = true;
            this.lbl編集_開始.Location = new System.Drawing.Point(32, 127);
            this.lbl編集_開始.Name = "lbl編集_開始";
            this.lbl編集_開始.Size = new System.Drawing.Size(29, 12);
            this.lbl編集_開始.TabIndex = 25;
            this.lbl編集_開始.Text = "開始";
            // 
            // lbl開始_月
            // 
            this.lbl開始_月.AutoSize = true;
            this.lbl開始_月.Location = new System.Drawing.Point(187, 127);
            this.lbl開始_月.Name = "lbl開始_月";
            this.lbl開始_月.Size = new System.Drawing.Size(17, 12);
            this.lbl開始_月.TabIndex = 24;
            this.lbl開始_月.Text = "月";
            // 
            // cmb開始_月
            // 
            this.cmb開始_月.FormattingEnabled = true;
            this.cmb開始_月.Location = new System.Drawing.Point(140, 123);
            this.cmb開始_月.Name = "cmb開始_月";
            this.cmb開始_月.Size = new System.Drawing.Size(47, 20);
            this.cmb開始_月.TabIndex = 23;
            // 
            // lbl開始_年
            // 
            this.lbl開始_年.AutoSize = true;
            this.lbl開始_年.Location = new System.Drawing.Point(124, 127);
            this.lbl開始_年.Name = "lbl開始_年";
            this.lbl開始_年.Size = new System.Drawing.Size(17, 12);
            this.lbl開始_年.TabIndex = 22;
            this.lbl開始_年.Text = "年";
            // 
            // cmb開始_年
            // 
            this.cmb開始_年.FormattingEnabled = true;
            this.cmb開始_年.Location = new System.Drawing.Point(64, 123);
            this.cmb開始_年.Name = "cmb開始_年";
            this.cmb開始_年.Size = new System.Drawing.Size(59, 20);
            this.cmb開始_年.TabIndex = 21;
            // 
            // lbl編集_時
            // 
            this.lbl編集_時.AutoSize = true;
            this.lbl編集_時.Location = new System.Drawing.Point(444, 91);
            this.lbl編集_時.Name = "lbl編集_時";
            this.lbl編集_時.Size = new System.Drawing.Size(17, 12);
            this.lbl編集_時.TabIndex = 20;
            this.lbl編集_時.Text = "時";
            this.lbl編集_時.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt予定工数
            // 
            this.txt予定工数.Location = new System.Drawing.Point(386, 87);
            this.txt予定工数.Name = "txt予定工数";
            this.txt予定工数.Size = new System.Drawing.Size(58, 19);
            this.txt予定工数.TabIndex = 19;
            // 
            // lbl編集_予定工数
            // 
            this.lbl編集_予定工数.AutoSize = true;
            this.lbl編集_予定工数.Location = new System.Drawing.Point(333, 91);
            this.lbl編集_予定工数.Name = "lbl編集_予定工数";
            this.lbl編集_予定工数.Size = new System.Drawing.Size(53, 12);
            this.lbl編集_予定工数.TabIndex = 18;
            this.lbl編集_予定工数.Text = "予定工数";
            // 
            // cmb編集_進捗率
            // 
            this.cmb編集_進捗率.FormattingEnabled = true;
            this.cmb編集_進捗率.Location = new System.Drawing.Point(220, 86);
            this.cmb編集_進捗率.Name = "cmb編集_進捗率";
            this.cmb編集_進捗率.Size = new System.Drawing.Size(86, 20);
            this.cmb編集_進捗率.TabIndex = 17;
            // 
            // lbl編集_進捗率
            // 
            this.lbl編集_進捗率.AutoSize = true;
            this.lbl編集_進捗率.Location = new System.Drawing.Point(174, 91);
            this.lbl編集_進捗率.Name = "lbl編集_進捗率";
            this.lbl編集_進捗率.Size = new System.Drawing.Size(41, 12);
            this.lbl編集_進捗率.TabIndex = 16;
            this.lbl編集_進捗率.Text = "進捗率";
            // 
            // cmb編集_優先度
            // 
            this.cmb編集_優先度.DataSource = this.v優先度BindingSource;
            this.cmb編集_優先度.DisplayMember = "項目名";
            this.cmb編集_優先度.FormattingEnabled = true;
            this.cmb編集_優先度.Location = new System.Drawing.Point(64, 86);
            this.cmb編集_優先度.Name = "cmb編集_優先度";
            this.cmb編集_優先度.Size = new System.Drawing.Size(86, 20);
            this.cmb編集_優先度.TabIndex = 15;
            this.cmb編集_優先度.ValueMember = "値";
            // 
            // v優先度BindingSource
            // 
            this.v優先度BindingSource.DataMember = "V_優先度";
            this.v優先度BindingSource.DataSource = this.timeManagementDataSet1;
            // 
            // timeManagementDataSet1
            // 
            this.timeManagementDataSet1.DataSetName = "TimeManagementDataSet1";
            this.timeManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl編集_優先度
            // 
            this.lbl編集_優先度.AutoSize = true;
            this.lbl編集_優先度.Location = new System.Drawing.Point(20, 91);
            this.lbl編集_優先度.Name = "lbl編集_優先度";
            this.lbl編集_優先度.Size = new System.Drawing.Size(41, 12);
            this.lbl編集_優先度.TabIndex = 14;
            this.lbl編集_優先度.Text = "優先度";
            // 
            // cb編集_無効
            // 
            this.cb編集_無効.AutoSize = true;
            this.cb編集_無効.Location = new System.Drawing.Point(485, 53);
            this.cb編集_無効.Name = "cb編集_無効";
            this.cb編集_無効.Size = new System.Drawing.Size(48, 16);
            this.cb編集_無効.TabIndex = 13;
            this.cb編集_無効.Text = "無効";
            this.cb編集_無効.UseVisualStyleBackColor = true;
            // 
            // txtチケット名
            // 
            this.txtチケット名.Location = new System.Drawing.Point(220, 51);
            this.txtチケット名.Name = "txtチケット名";
            this.txtチケット名.Size = new System.Drawing.Size(252, 19);
            this.txtチケット名.TabIndex = 12;
            // 
            // lbl編集_チケット名
            // 
            this.lbl編集_チケット名.AutoSize = true;
            this.lbl編集_チケット名.Location = new System.Drawing.Point(166, 54);
            this.lbl編集_チケット名.Name = "lbl編集_チケット名";
            this.lbl編集_チケット名.Size = new System.Drawing.Size(50, 12);
            this.lbl編集_チケット名.TabIndex = 11;
            this.lbl編集_チケット名.Text = "チケット名";
            // 
            // txtチケット番号
            // 
            this.txtチケット番号.Location = new System.Drawing.Point(64, 51);
            this.txtチケット番号.Name = "txtチケット番号";
            this.txtチケット番号.Size = new System.Drawing.Size(87, 19);
            this.txtチケット番号.TabIndex = 10;
            // 
            // lbl編集_チケット番号
            // 
            this.lbl編集_チケット番号.AutoSize = true;
            this.lbl編集_チケット番号.Location = new System.Drawing.Point(23, 49);
            this.lbl編集_チケット番号.Name = "lbl編集_チケット番号";
            this.lbl編集_チケット番号.Size = new System.Drawing.Size(38, 24);
            this.lbl編集_チケット番号.TabIndex = 7;
            this.lbl編集_チケット番号.Text = "チケット\r\n番号";
            // 
            // cmb編集_ステータス
            // 
            this.cmb編集_ステータス.DataSource = this.vステータスBindingSource;
            this.cmb編集_ステータス.DisplayMember = "項目名";
            this.cmb編集_ステータス.FormattingEnabled = true;
            this.cmb編集_ステータス.Location = new System.Drawing.Point(386, 15);
            this.cmb編集_ステータス.Name = "cmb編集_ステータス";
            this.cmb編集_ステータス.Size = new System.Drawing.Size(86, 20);
            this.cmb編集_ステータス.TabIndex = 6;
            this.cmb編集_ステータス.ValueMember = "値";
            // 
            // vステータスBindingSource
            // 
            this.vステータスBindingSource.DataMember = "V_ステータス";
            this.vステータスBindingSource.DataSource = this.timeManagementDataSet5;
            // 
            // timeManagementDataSet5
            // 
            this.timeManagementDataSet5.DataSetName = "TimeManagementDataSet5";
            this.timeManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl編集_ステータス
            // 
            this.lbl編集_ステータス.AutoSize = true;
            this.lbl編集_ステータス.Location = new System.Drawing.Point(333, 20);
            this.lbl編集_ステータス.Name = "lbl編集_ステータス";
            this.lbl編集_ステータス.Size = new System.Drawing.Size(50, 12);
            this.lbl編集_ステータス.TabIndex = 5;
            this.lbl編集_ステータス.Text = "ステータス";
            // 
            // cmb編集_トラッカー
            // 
            this.cmb編集_トラッカー.DataSource = this.vトラッカーBindingSource;
            this.cmb編集_トラッカー.DisplayMember = "項目名";
            this.cmb編集_トラッカー.FormattingEnabled = true;
            this.cmb編集_トラッカー.Location = new System.Drawing.Point(220, 15);
            this.cmb編集_トラッカー.Name = "cmb編集_トラッカー";
            this.cmb編集_トラッカー.Size = new System.Drawing.Size(86, 20);
            this.cmb編集_トラッカー.TabIndex = 4;
            this.cmb編集_トラッカー.ValueMember = "値";
            // 
            // vトラッカーBindingSource
            // 
            this.vトラッカーBindingSource.DataMember = "V_トラッカー";
            this.vトラッカーBindingSource.DataSource = this.timeManagementDataSet4;
            // 
            // timeManagementDataSet4
            // 
            this.timeManagementDataSet4.DataSetName = "TimeManagementDataSet4";
            this.timeManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl編集_トラッカー
            // 
            this.lbl編集_トラッカー.AutoSize = true;
            this.lbl編集_トラッカー.Location = new System.Drawing.Point(170, 20);
            this.lbl編集_トラッカー.Name = "lbl編集_トラッカー";
            this.lbl編集_トラッカー.Size = new System.Drawing.Size(47, 12);
            this.lbl編集_トラッカー.TabIndex = 3;
            this.lbl編集_トラッカー.Text = "トラッカー";
            // 
            // cmb編集_プロジェクト
            // 
            this.cmb編集_プロジェクト.DataSource = this.プロジェクトBindingSource;
            this.cmb編集_プロジェクト.DisplayMember = "プロジェクト名";
            this.cmb編集_プロジェクト.FormattingEnabled = true;
            this.cmb編集_プロジェクト.Location = new System.Drawing.Point(64, 15);
            this.cmb編集_プロジェクト.Name = "cmb編集_プロジェクト";
            this.cmb編集_プロジェクト.Size = new System.Drawing.Size(100, 20);
            this.cmb編集_プロジェクト.TabIndex = 2;
            this.cmb編集_プロジェクト.ValueMember = "プロジェクト番号";
            // 
            // プロジェクトBindingSource
            // 
            this.プロジェクトBindingSource.DataMember = "プロジェクト";
            this.プロジェクトBindingSource.DataSource = this.timeManagementDataSet6;
            // 
            // timeManagementDataSet6
            // 
            this.timeManagementDataSet6.DataSetName = "TimeManagementDataSet6";
            this.timeManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl編集_プロジェクト
            // 
            this.lbl編集_プロジェクト.AutoSize = true;
            this.lbl編集_プロジェクト.Location = new System.Drawing.Point(6, 20);
            this.lbl編集_プロジェクト.Name = "lbl編集_プロジェクト";
            this.lbl編集_プロジェクト.Size = new System.Drawing.Size(56, 12);
            this.lbl編集_プロジェクト.TabIndex = 0;
            this.lbl編集_プロジェクト.Text = "プロジェクト";
            // 
            // btnクリア
            // 
            this.btnクリア.Location = new System.Drawing.Point(586, 151);
            this.btnクリア.Name = "btnクリア";
            this.btnクリア.Size = new System.Drawing.Size(48, 23);
            this.btnクリア.TabIndex = 46;
            this.btnクリア.Text = "クリア";
            this.btnクリア.UseVisualStyleBackColor = true;
            this.btnクリア.Click += new System.EventHandler(this.btnクリア_Click);
            // 
            // btn検索
            // 
            this.btn検索.Location = new System.Drawing.Point(620, 23);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(48, 23);
            this.btn検索.TabIndex = 3;
            this.btn検索.Text = "検索";
            this.btn検索.UseVisualStyleBackColor = true;
            this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
            // 
            // timeManagementDataSet
            // 
            this.timeManagementDataSet.DataSetName = "TimeManagementDataSet";
            this.timeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeManagementDataSetBindingSource
            // 
            this.timeManagementDataSetBindingSource.DataSource = this.timeManagementDataSet;
            this.timeManagementDataSetBindingSource.Position = 0;
            // 
            // チケット管理BindingSource
            // 
            this.チケット管理BindingSource.DataMember = "チケット管理";
            this.チケット管理BindingSource.DataSource = this.timeManagementDataSetBindingSource;
            // 
            // チケット管理TableAdapter
            // 
            this.チケット管理TableAdapter.ClearBeforeFill = true;
            // 
            // チケット管理BindingSource1
            // 
            this.チケット管理BindingSource1.DataMember = "チケット管理";
            this.チケット管理BindingSource1.DataSource = this.timeManagementDataSetBindingSource;
            // 
            // timeManagementDataSetBindingSource1
            // 
            this.timeManagementDataSetBindingSource1.DataSource = this.timeManagementDataSet;
            this.timeManagementDataSetBindingSource1.Position = 0;
            // 
            // チケット管理BindingSource2
            // 
            this.チケット管理BindingSource2.DataMember = "チケット管理";
            this.チケット管理BindingSource2.DataSource = this.timeManagementDataSetBindingSource1;
            // 
            // v_優先度TableAdapter
            // 
            this.v_優先度TableAdapter.ClearBeforeFill = true;
            // 
            // v_トラッカーTableAdapter
            // 
            this.v_トラッカーTableAdapter.ClearBeforeFill = true;
            // 
            // v_ステータスTableAdapter
            // 
            this.v_ステータスTableAdapter.ClearBeforeFill = true;
            // 
            // プロジェクトTableAdapter
            // 
            this.プロジェクトTableAdapter.ClearBeforeFill = true;
            // 
            // txtチケット管理番号
            // 
            this.txtチケット管理番号.Location = new System.Drawing.Point(760, 633);
            this.txtチケット管理番号.Name = "txtチケット管理番号";
            this.txtチケット管理番号.Size = new System.Drawing.Size(87, 19);
            this.txtチケット管理番号.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "チケット管理番号\r\n";
            // 
            // lbl件数
            // 
            this.lbl件数.AutoSize = true;
            this.lbl件数.Location = new System.Drawing.Point(650, 117);
            this.lbl件数.Name = "lbl件数";
            this.lbl件数.Size = new System.Drawing.Size(0, 12);
            this.lbl件数.TabIndex = 13;
            // 
            // btn全選択
            // 
            this.btn全選択.Location = new System.Drawing.Point(12, 127);
            this.btn全選択.Name = "btn全選択";
            this.btn全選択.Size = new System.Drawing.Size(61, 23);
            this.btn全選択.TabIndex = 45;
            this.btn全選択.Text = "全選択";
            this.btn全選択.UseVisualStyleBackColor = true;
            this.btn全選択.Click += new System.EventHandler(this.btn全選択_Click);
            // 
            // btnエクスポート
            // 
            this.btnエクスポート.Location = new System.Drawing.Point(76, 127);
            this.btnエクスポート.Name = "btnエクスポート";
            this.btnエクスポート.Size = new System.Drawing.Size(71, 23);
            this.btnエクスポート.TabIndex = 46;
            this.btnエクスポート.Text = "エクスポート";
            this.btnエクスポート.UseVisualStyleBackColor = true;
            this.btnエクスポート.Click += new System.EventHandler(this.btnエクスポート_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "インポート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnインポート_Click);
            // 
            // チケット管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnエクスポート);
            this.Controls.Add(this.btn全選択);
            this.Controls.Add(this.lbl件数);
            this.Controls.Add(this.txtチケット管理番号);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn検索);
            this.Controls.Add(this.gp編集);
            this.Controls.Add(this.lvチケット管理);
            this.Controls.Add(this.gp検索);
            this.Name = "チケット管理";
            this.Text = "チケット管理";
            this.Load += new System.EventHandler(this.チケット管理_Load);
            this.gp検索.ResumeLayout(false);
            this.gp検索.PerformLayout();
            this.gpステータス.ResumeLayout(false);
            this.gpステータス.PerformLayout();
            this.gpトラッカー.ResumeLayout(false);
            this.gpトラッカー.PerformLayout();
            this.gp編集.ResumeLayout(false);
            this.gp編集.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v優先度BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vステータスBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vトラッカーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.プロジェクトBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeManagementDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.チケット管理BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.GroupBox gp検索;
        private System.Windows.Forms.Label lbl検索範囲;
        private System.Windows.Forms.ListView lvチケット管理;
        private System.Windows.Forms.GroupBox gp編集;
        private System.Windows.Forms.Button btn検索;
        private System.Windows.Forms.ComboBox cmb年;
        private System.Windows.Forms.ComboBox cmb月;
        private System.Windows.Forms.Label lbl年;
        private System.Windows.Forms.GroupBox gpステータス;
        private System.Windows.Forms.CheckBox cbステータス4;
        private System.Windows.Forms.CheckBox cbステータス3;
        private System.Windows.Forms.CheckBox cbステータス2;
        private System.Windows.Forms.CheckBox cbステータス1;
        private System.Windows.Forms.GroupBox gpトラッカー;
        private System.Windows.Forms.CheckBox cbトラッカー5;
        private System.Windows.Forms.CheckBox cbトラッカー4;
        private System.Windows.Forms.CheckBox cbトラッカー3;
        private System.Windows.Forms.CheckBox cbトラッカー2;
        private System.Windows.Forms.CheckBox cbトラッカー1;
        private System.Windows.Forms.TextBox txt検索条件_チケット番号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblプロジェクト;
        private System.Windows.Forms.ComboBox cmbプロジェクト;
        private System.Windows.Forms.Label lbl月;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbリリース予定日_日;
        private System.Windows.Forms.Label lblリリース予定日;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbリリース予定日_月;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbリリース予定日_年;
        private System.Windows.Forms.Label lbl期日_日;
        private System.Windows.Forms.ComboBox cmb期日_日;
        private System.Windows.Forms.Label lbl編集_期日;
        private System.Windows.Forms.Label lbl期日_月;
        private System.Windows.Forms.ComboBox cmb期日_月;
        private System.Windows.Forms.Label lbl期日_年;
        private System.Windows.Forms.ComboBox cmb期日_年;
        private System.Windows.Forms.Label lbl開始_日;
        private System.Windows.Forms.ComboBox cmb開始_日;
        private System.Windows.Forms.Label lbl編集_開始;
        private System.Windows.Forms.Label lbl開始_月;
        private System.Windows.Forms.ComboBox cmb開始_月;
        private System.Windows.Forms.Label lbl開始_年;
        private System.Windows.Forms.ComboBox cmb開始_年;
        private System.Windows.Forms.Label lbl編集_時;
        private System.Windows.Forms.TextBox txt予定工数;
        private System.Windows.Forms.Label lbl編集_予定工数;
        private System.Windows.Forms.ComboBox cmb編集_進捗率;
        private System.Windows.Forms.Label lbl編集_進捗率;
        private System.Windows.Forms.ComboBox cmb編集_優先度;
        private System.Windows.Forms.Label lbl編集_優先度;
        private System.Windows.Forms.CheckBox cb編集_無効;
        private System.Windows.Forms.TextBox txtチケット名;
        private System.Windows.Forms.Label lbl編集_チケット名;
        private System.Windows.Forms.TextBox txtチケット番号;
        private System.Windows.Forms.Label lbl編集_チケット番号;
        private System.Windows.Forms.ComboBox cmb編集_ステータス;
        private System.Windows.Forms.Label lbl編集_ステータス;
        private System.Windows.Forms.ComboBox cmb編集_トラッカー;
        private System.Windows.Forms.Label lbl編集_トラッカー;
        private System.Windows.Forms.ComboBox cmb編集_プロジェクト;
        private System.Windows.Forms.Label lbl編集_プロジェクト;
        private System.Windows.Forms.Label lbl備考;
        private System.Windows.Forms.TextBox txt備考;
        private System.Windows.Forms.CheckBox cb無効;
        private System.Windows.Forms.BindingSource timeManagementDataSetBindingSource;
        private TimeManagementDataSet timeManagementDataSet;
        private System.Windows.Forms.BindingSource チケット管理BindingSource;
        private TimeManagementDataSetTableAdapters.チケット管理TableAdapter チケット管理TableAdapter;
        private System.Windows.Forms.BindingSource チケット管理BindingSource1;
        private System.Windows.Forms.BindingSource timeManagementDataSetBindingSource1;
        private System.Windows.Forms.BindingSource チケット管理BindingSource2;
        private TimeManagementDataSet1 timeManagementDataSet1;
        private System.Windows.Forms.BindingSource v優先度BindingSource;
        private TimeManagementDataSet1TableAdapters.V_優先度TableAdapter v_優先度TableAdapter;
        private TimeManagementDataSet4 timeManagementDataSet4;
        private System.Windows.Forms.BindingSource vトラッカーBindingSource;
        private TimeManagementDataSet4TableAdapters.V_トラッカーTableAdapter v_トラッカーTableAdapter;
        private TimeManagementDataSet5 timeManagementDataSet5;
        private System.Windows.Forms.BindingSource vステータスBindingSource;
        private TimeManagementDataSet5TableAdapters.V_ステータスTableAdapter v_ステータスTableAdapter;
        private System.Windows.Forms.Button btn更新;
        private System.Windows.Forms.Button btn追加;
        private System.Windows.Forms.Button btnクリア;
        private TimeManagementDataSet6 timeManagementDataSet6;
        private System.Windows.Forms.BindingSource プロジェクトBindingSource;
        private TimeManagementDataSet6TableAdapters.プロジェクトTableAdapter プロジェクトTableAdapter;
        private System.Windows.Forms.TextBox txtチケット管理番号;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl件数;
        private System.Windows.Forms.Button btn全選択;
        private System.Windows.Forms.Button btnエクスポート;
        private System.Windows.Forms.Button btn削除;
        private System.Windows.Forms.Button btnテスト;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;

    }
}