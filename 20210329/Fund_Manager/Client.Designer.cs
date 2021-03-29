namespace Fund_Manager
{
    partial class Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label1 = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb이름 = new System.Windows.Forms.Label();
            this.lb아이디 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Accountbutton = new MetroFramework.Controls.MetroButton();
            this.lb수익률 = new System.Windows.Forms.Label();
            this.lb매입금액 = new System.Windows.Forms.Label();
            this.lb총금액 = new System.Windows.Forms.Label();
            this.lb손익금액 = new System.Windows.Forms.Label();
            this.realTimeAccountGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.realTimeAccountOnlabel = new System.Windows.Forms.RadioButton();
            this.realTimeAccountOfflabel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbinvestment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.itemcountnumeric2 = new System.Windows.Forms.NumericUpDown();
            this.investmentnumeric1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buyingOrderComboBox = new System.Windows.Forms.ComboBox();
            this.lable11 = new System.Windows.Forms.RadioButton();
            this.marketPriceRadio = new System.Windows.Forms.RadioButton();
            this.lbbuycondition = new System.Windows.Forms.Label();
            this.buycondition_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.createStrategyButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tradingStrategyGridView = new System.Windows.Forms.DataGridView();
            this.매매전략_계좌번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_매수가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_총투자금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_매수종목수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_종목당투자금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.sellOrderCount = new System.Windows.Forms.TextBox();
            this.sellOrderCode = new System.Windows.Forms.TextBox();
            this.sellOrderButton = new MetroFramework.Controls.MetroButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Tightening_ok_datagrid = new System.Windows.Forms.DataGridView();
            this._주문번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._주문상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._주문수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._누계금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._주문구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._체결가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._체결수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.Tightening_no_datagrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findTighteningButton = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.itemDeleteListBox = new System.Windows.Forms.ListBox();
            this.itemInsertListBox = new System.Windows.Forms.ListBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.realTimeConditionOffLabel = new System.Windows.Forms.RadioButton();
            this.realTimeConditionGridView = new System.Windows.Forms.DataGridView();
            this.종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일대비 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등락율 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.시가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.저가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realTimeConditionOnLabel = new System.Windows.Forms.RadioButton();
            this.startBuy = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.stopBuyRadio = new MetroFramework.Controls.MetroRadioButton();
            this.startBuyRadio = new MetroFramework.Controls.MetroRadioButton();
            this.autoSettingButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.autoFundStartButton = new MetroFramework.Controls.MetroButton();
            this.자동매매lb = new MetroFramework.Controls.MetroLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.realTimeConditionCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.order_price = new System.Windows.Forms.Label();
            this.order_count = new System.Windows.Forms.Label();
            this.order_code = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.manualTradingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realTimeAccountGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemcountnumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentnumeric1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tradingStrategyGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tightening_ok_datagrid)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tightening_no_datagrid)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realTimeConditionGridView)).BeginInit();
            this.startBuy.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualTradingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(40, 706);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(181, 68);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "계좌목록 : ";
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(177, 26);
            this.accountComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(138, 23);
            this.accountComboBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb이름);
            this.groupBox1.Controls.Add(this.lb아이디);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.accountComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1063, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(395, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // lb이름
            // 
            this.lb이름.AutoSize = true;
            this.lb이름.Location = new System.Drawing.Point(202, 108);
            this.lb이름.Name = "lb이름";
            this.lb이름.Size = new System.Drawing.Size(0, 15);
            this.lb이름.TabIndex = 6;
            // 
            // lb아이디
            // 
            this.lb아이디.AutoSize = true;
            this.lb아이디.Location = new System.Drawing.Point(202, 71);
            this.lb아이디.Name = "lb아이디";
            this.lb아이디.Size = new System.Drawing.Size(0, 15);
            this.lb아이디.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "User_ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "수익률";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "매입금액";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "총금액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "손익금액";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Accountbutton);
            this.groupBox2.Controls.Add(this.lb수익률);
            this.groupBox2.Controls.Add(this.lb매입금액);
            this.groupBox2.Controls.Add(this.lb총금액);
            this.groupBox2.Controls.Add(this.lb손익금액);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1063, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(395, 212);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // Accountbutton
            // 
            this.Accountbutton.Location = new System.Drawing.Point(275, 91);
            this.Accountbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accountbutton.Name = "Accountbutton";
            this.Accountbutton.Size = new System.Drawing.Size(94, 52);
            this.Accountbutton.TabIndex = 11;
            this.Accountbutton.Text = "확인";
            // 
            // lb수익률
            // 
            this.lb수익률.AutoSize = true;
            this.lb수익률.Location = new System.Drawing.Point(130, 172);
            this.lb수익률.Name = "lb수익률";
            this.lb수익률.Size = new System.Drawing.Size(0, 15);
            this.lb수익률.TabIndex = 10;
            // 
            // lb매입금액
            // 
            this.lb매입금액.AutoSize = true;
            this.lb매입금액.Location = new System.Drawing.Point(130, 124);
            this.lb매입금액.Name = "lb매입금액";
            this.lb매입금액.Size = new System.Drawing.Size(0, 15);
            this.lb매입금액.TabIndex = 10;
            // 
            // lb총금액
            // 
            this.lb총금액.AutoSize = true;
            this.lb총금액.Location = new System.Drawing.Point(130, 42);
            this.lb총금액.Name = "lb총금액";
            this.lb총금액.Size = new System.Drawing.Size(0, 15);
            this.lb총금액.TabIndex = 10;
            // 
            // lb손익금액
            // 
            this.lb손익금액.AutoSize = true;
            this.lb손익금액.Location = new System.Drawing.Point(130, 85);
            this.lb손익금액.Name = "lb손익금액";
            this.lb손익금액.Size = new System.Drawing.Size(0, 15);
            this.lb손익금액.TabIndex = 9;
            // 
            // realTimeAccountGridView
            // 
            this.realTimeAccountGridView.AllowUserToAddRows = false;
            this.realTimeAccountGridView.AllowUserToDeleteRows = false;
            this.realTimeAccountGridView.AllowUserToResizeColumns = false;
            this.realTimeAccountGridView.AllowUserToResizeRows = false;
            this.realTimeAccountGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.realTimeAccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realTimeAccountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.realTimeAccountGridView.Location = new System.Drawing.Point(63, 76);
            this.realTimeAccountGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeAccountGridView.Name = "realTimeAccountGridView";
            this.realTimeAccountGridView.RowHeadersVisible = false;
            this.realTimeAccountGridView.RowHeadersWidth = 51;
            this.realTimeAccountGridView.RowTemplate.Height = 27;
            this.realTimeAccountGridView.Size = new System.Drawing.Size(871, 222);
            this.realTimeAccountGridView.TabIndex = 10;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "종목코드";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "종목명";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "현재가";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "매입가";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "보유수량";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "수익률";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // timer1
            // 
            this.timer1.Interval = 1300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // realTimeAccountOnlabel
            // 
            this.realTimeAccountOnlabel.AutoSize = true;
            this.realTimeAccountOnlabel.Location = new System.Drawing.Point(69, 41);
            this.realTimeAccountOnlabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeAccountOnlabel.Name = "realTimeAccountOnlabel";
            this.realTimeAccountOnlabel.Size = new System.Drawing.Size(49, 19);
            this.realTimeAccountOnlabel.TabIndex = 11;
            this.realTimeAccountOnlabel.Text = "ON";
            this.realTimeAccountOnlabel.UseVisualStyleBackColor = true;
            this.realTimeAccountOnlabel.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged_1);
            // 
            // realTimeAccountOfflabel
            // 
            this.realTimeAccountOfflabel.AutoSize = true;
            this.realTimeAccountOfflabel.Checked = true;
            this.realTimeAccountOfflabel.Location = new System.Drawing.Point(158, 39);
            this.realTimeAccountOfflabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeAccountOfflabel.Name = "realTimeAccountOfflabel";
            this.realTimeAccountOfflabel.Size = new System.Drawing.Size(56, 19);
            this.realTimeAccountOfflabel.TabIndex = 12;
            this.realTimeAccountOfflabel.TabStop = true;
            this.realTimeAccountOfflabel.Text = "OFF";
            this.realTimeAccountOfflabel.UseVisualStyleBackColor = true;
            this.realTimeAccountOfflabel.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.realTimeAccountOfflabel);
            this.groupBox3.Controls.Add(this.realTimeAccountGridView);
            this.groupBox3.Controls.Add(this.realTimeAccountOnlabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1013, 389);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 638);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(3, 321);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 315);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "매도";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbinvestment);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.itemcountnumeric2);
            this.panel1.Controls.Add(this.investmentnumeric1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.buyingOrderComboBox);
            this.panel1.Controls.Add(this.lable11);
            this.panel1.Controls.Add(this.marketPriceRadio);
            this.panel1.Controls.Add(this.lbbuycondition);
            this.panel1.Controls.Add(this.buycondition_combo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 315);
            this.panel1.TabIndex = 0;
            // 
            // lbinvestment
            // 
            this.lbinvestment.AutoSize = true;
            this.lbinvestment.Location = new System.Drawing.Point(168, 282);
            this.lbinvestment.Name = "lbinvestment";
            this.lbinvestment.Size = new System.Drawing.Size(15, 15);
            this.lbinvestment.TabIndex = 11;
            this.lbinvestment.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "종목당 투자금 : ";
            // 
            // itemcountnumeric2
            // 
            this.itemcountnumeric2.Location = new System.Drawing.Point(155, 232);
            this.itemcountnumeric2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemcountnumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemcountnumeric2.Name = "itemcountnumeric2";
            this.itemcountnumeric2.Size = new System.Drawing.Size(120, 25);
            this.itemcountnumeric2.TabIndex = 9;
            this.itemcountnumeric2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // investmentnumeric1
            // 
            this.investmentnumeric1.Location = new System.Drawing.Point(155, 185);
            this.investmentnumeric1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.investmentnumeric1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.investmentnumeric1.Name = "investmentnumeric1";
            this.investmentnumeric1.Size = new System.Drawing.Size(120, 25);
            this.investmentnumeric1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "매수 종목수 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "총 투자금 : ";
            // 
            // buyingOrderComboBox
            // 
            this.buyingOrderComboBox.FormattingEnabled = true;
            this.buyingOrderComboBox.Items.AddRange(new object[] {
            "현재가",
            "시장가",
            "조건부지정가",
            "최유리지정가",
            "최우선지정가",
            "지정가IOC",
            "시장가IOC",
            "최유리IOC",
            "지정가FOK",
            "시장가FOK",
            "최유리FOK",
            "장전시간외종가",
            "시간외단일가매매",
            "장후시간외종가"});
            this.buyingOrderComboBox.Location = new System.Drawing.Point(115, 142);
            this.buyingOrderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyingOrderComboBox.Name = "buyingOrderComboBox";
            this.buyingOrderComboBox.Size = new System.Drawing.Size(225, 23);
            this.buyingOrderComboBox.TabIndex = 5;
            this.buyingOrderComboBox.Text = "현재가";
            // 
            // lable11
            // 
            this.lable11.AutoSize = true;
            this.lable11.Checked = true;
            this.lable11.Location = new System.Drawing.Point(142, 104);
            this.lable11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lable11.Name = "lable11";
            this.lable11.Size = new System.Drawing.Size(73, 19);
            this.lable11.TabIndex = 4;
            this.lable11.TabStop = true;
            this.lable11.Text = "지정가";
            this.lable11.UseVisualStyleBackColor = true;
            // 
            // marketPriceRadio
            // 
            this.marketPriceRadio.AutoSize = true;
            this.marketPriceRadio.Location = new System.Drawing.Point(34, 104);
            this.marketPriceRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marketPriceRadio.Name = "marketPriceRadio";
            this.marketPriceRadio.Size = new System.Drawing.Size(73, 19);
            this.marketPriceRadio.TabIndex = 3;
            this.marketPriceRadio.Text = "시장가";
            this.marketPriceRadio.UseVisualStyleBackColor = true;
            // 
            // lbbuycondition
            // 
            this.lbbuycondition.AutoSize = true;
            this.lbbuycondition.Location = new System.Drawing.Point(30, 54);
            this.lbbuycondition.Name = "lbbuycondition";
            this.lbbuycondition.Size = new System.Drawing.Size(62, 15);
            this.lbbuycondition.TabIndex = 2;
            this.lbbuycondition.Text = "조건식 :";
            // 
            // buycondition_combo
            // 
            this.buycondition_combo.FormattingEnabled = true;
            this.buycondition_combo.Location = new System.Drawing.Point(111, 50);
            this.buycondition_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buycondition_combo.Name = "buycondition_combo";
            this.buycondition_combo.Size = new System.Drawing.Size(225, 23);
            this.buycondition_combo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "매수";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.createStrategyButton);
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Controls.Add(this.axKHOpenAPI1);
            this.groupBox4.Location = new System.Drawing.Point(1061, 21);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(416, 750);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "전략";
            // 
            // createStrategyButton
            // 
            this.createStrategyButton.Location = new System.Drawing.Point(177, 706);
            this.createStrategyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createStrategyButton.Name = "createStrategyButton";
            this.createStrategyButton.Size = new System.Drawing.Size(85, 28);
            this.createStrategyButton.TabIndex = 15;
            this.createStrategyButton.Text = "등록";
            this.createStrategyButton.UseVisualStyleBackColor = true;
            this.createStrategyButton.Click += new System.EventHandler(this.CreateStrategyButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tradingStrategyGridView);
            this.groupBox5.Location = new System.Drawing.Point(21, 65);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1015, 248);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "매매전략";
            // 
            // tradingStrategyGridView
            // 
            this.tradingStrategyGridView.AllowUserToAddRows = false;
            this.tradingStrategyGridView.AllowUserToDeleteRows = false;
            this.tradingStrategyGridView.AllowUserToResizeColumns = false;
            this.tradingStrategyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tradingStrategyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradingStrategyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.매매전략_계좌번호,
            this.매매전략_매수가격,
            this.매매전략_총투자금,
            this.매매전략_매수종목수,
            this.매매전략_종목당투자금});
            this.tradingStrategyGridView.Location = new System.Drawing.Point(18, 35);
            this.tradingStrategyGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tradingStrategyGridView.Name = "tradingStrategyGridView";
            this.tradingStrategyGridView.RowHeadersVisible = false;
            this.tradingStrategyGridView.RowHeadersWidth = 51;
            this.tradingStrategyGridView.RowTemplate.Height = 27;
            this.tradingStrategyGridView.Size = new System.Drawing.Size(875, 196);
            this.tradingStrategyGridView.TabIndex = 0;
            // 
            // 매매전략_계좌번호
            // 
            this.매매전략_계좌번호.HeaderText = "계좌번호";
            this.매매전략_계좌번호.MinimumWidth = 6;
            this.매매전략_계좌번호.Name = "매매전략_계좌번호";
            this.매매전략_계좌번호.ReadOnly = true;
            // 
            // 매매전략_매수가격
            // 
            this.매매전략_매수가격.HeaderText = "매수가격";
            this.매매전략_매수가격.MinimumWidth = 6;
            this.매매전략_매수가격.Name = "매매전략_매수가격";
            this.매매전략_매수가격.ReadOnly = true;
            // 
            // 매매전략_총투자금
            // 
            this.매매전략_총투자금.HeaderText = "총투자금";
            this.매매전략_총투자금.MinimumWidth = 6;
            this.매매전략_총투자금.Name = "매매전략_총투자금";
            this.매매전략_총투자금.ReadOnly = true;
            // 
            // 매매전략_매수종목수
            // 
            this.매매전략_매수종목수.HeaderText = "매수종목수";
            this.매매전략_매수종목수.MinimumWidth = 6;
            this.매매전략_매수종목수.Name = "매매전략_매수종목수";
            this.매매전략_매수종목수.ReadOnly = true;
            // 
            // 매매전략_종목당투자금
            // 
            this.매매전략_종목당투자금.HeaderText = "종목당투자금";
            this.매매전략_종목당투자금.MinimumWidth = 6;
            this.매매전략_종목당투자금.Name = "매매전략_종목당투자금";
            this.매매전략_종목당투자금.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 88);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1486, 1029);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.metroTabControl1);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.startBuy);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1478, 1000);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "메인";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.sellOrderCount);
            this.groupBox11.Controls.Add(this.sellOrderCode);
            this.groupBox11.Controls.Add(this.sellOrderButton);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Location = new System.Drawing.Point(1063, 431);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox11.Size = new System.Drawing.Size(395, 152);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "판매";
            // 
            // sellOrderCount
            // 
            this.sellOrderCount.Location = new System.Drawing.Point(102, 84);
            this.sellOrderCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellOrderCount.Name = "sellOrderCount";
            this.sellOrderCount.Size = new System.Drawing.Size(114, 25);
            this.sellOrderCount.TabIndex = 11;
            // 
            // sellOrderCode
            // 
            this.sellOrderCode.Location = new System.Drawing.Point(102, 45);
            this.sellOrderCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellOrderCode.Name = "sellOrderCode";
            this.sellOrderCode.Size = new System.Drawing.Size(114, 25);
            this.sellOrderCode.TabIndex = 10;
            // 
            // sellOrderButton
            // 
            this.sellOrderButton.Location = new System.Drawing.Point(283, 45);
            this.sellOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellOrderButton.Name = "sellOrderButton";
            this.sellOrderButton.Size = new System.Drawing.Size(86, 61);
            this.sellOrderButton.TabIndex = 9;
            this.sellOrderButton.Text = "매도";
            this.sellOrderButton.Click += new System.EventHandler(this.sellOrderButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(202, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 15);
            this.label17.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(119, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 15);
            this.label19.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "수량 :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "종목코드 :";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 465);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1011, 352);
            this.metroTabControl1.TabIndex = 17;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tabControl3);
            this.metroTabPage1.Controls.Add(this.findTighteningButton);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 40);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1003, 308);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "체결내역";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Location = new System.Drawing.Point(6, 9);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(882, 290);
            this.tabControl3.TabIndex = 18;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Tightening_ok_datagrid);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Size = new System.Drawing.Size(874, 261);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "체결";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Tightening_ok_datagrid
            // 
            this.Tightening_ok_datagrid.AllowUserToAddRows = false;
            this.Tightening_ok_datagrid.AllowUserToDeleteRows = false;
            this.Tightening_ok_datagrid.AllowUserToResizeColumns = false;
            this.Tightening_ok_datagrid.AllowUserToResizeRows = false;
            this.Tightening_ok_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tightening_ok_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tightening_ok_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._주문번호,
            this._종목코드,
            this._주문상태,
            this._종목명,
            this._주문수량,
            this._누계금액,
            this._주문구분,
            this._체결가,
            this._체결수량});
            this.Tightening_ok_datagrid.Location = new System.Drawing.Point(6, 2);
            this.Tightening_ok_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tightening_ok_datagrid.Name = "Tightening_ok_datagrid";
            this.Tightening_ok_datagrid.RowHeadersVisible = false;
            this.Tightening_ok_datagrid.RowHeadersWidth = 51;
            this.Tightening_ok_datagrid.RowTemplate.Height = 27;
            this.Tightening_ok_datagrid.Size = new System.Drawing.Size(866, 252);
            this.Tightening_ok_datagrid.TabIndex = 12;
            // 
            // _주문번호
            // 
            this._주문번호.HeaderText = "주문번호";
            this._주문번호.MinimumWidth = 6;
            this._주문번호.Name = "_주문번호";
            this._주문번호.ReadOnly = true;
            // 
            // _종목코드
            // 
            this._종목코드.HeaderText = "종목코드";
            this._종목코드.MinimumWidth = 6;
            this._종목코드.Name = "_종목코드";
            this._종목코드.ReadOnly = true;
            // 
            // _주문상태
            // 
            this._주문상태.HeaderText = "주문상태";
            this._주문상태.MinimumWidth = 6;
            this._주문상태.Name = "_주문상태";
            this._주문상태.ReadOnly = true;
            // 
            // _종목명
            // 
            this._종목명.HeaderText = "종목명";
            this._종목명.MinimumWidth = 6;
            this._종목명.Name = "_종목명";
            this._종목명.ReadOnly = true;
            // 
            // _주문수량
            // 
            this._주문수량.HeaderText = "주문수량";
            this._주문수량.MinimumWidth = 6;
            this._주문수량.Name = "_주문수량";
            this._주문수량.ReadOnly = true;
            // 
            // _누계금액
            // 
            this._누계금액.HeaderText = "누계금액";
            this._누계금액.MinimumWidth = 6;
            this._누계금액.Name = "_누계금액";
            this._누계금액.ReadOnly = true;
            // 
            // _주문구분
            // 
            this._주문구분.HeaderText = "주문구분";
            this._주문구분.MinimumWidth = 6;
            this._주문구분.Name = "_주문구분";
            this._주문구분.ReadOnly = true;
            // 
            // _체결가
            // 
            this._체결가.HeaderText = "체결가";
            this._체결가.MinimumWidth = 6;
            this._체결가.Name = "_체결가";
            this._체결가.ReadOnly = true;
            // 
            // _체결수량
            // 
            this._체결수량.HeaderText = "체결수량";
            this._체결수량.MinimumWidth = 6;
            this._체결수량.Name = "_체결수량";
            this._체결수량.ReadOnly = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Tightening_no_datagrid);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Size = new System.Drawing.Size(874, 261);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "미체결";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Tightening_no_datagrid
            // 
            this.Tightening_no_datagrid.AllowUserToAddRows = false;
            this.Tightening_no_datagrid.AllowUserToDeleteRows = false;
            this.Tightening_no_datagrid.AllowUserToResizeColumns = false;
            this.Tightening_no_datagrid.AllowUserToResizeRows = false;
            this.Tightening_no_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tightening_no_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tightening_no_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn18});
            this.Tightening_no_datagrid.Location = new System.Drawing.Point(6, 2);
            this.Tightening_no_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tightening_no_datagrid.Name = "Tightening_no_datagrid";
            this.Tightening_no_datagrid.RowHeadersVisible = false;
            this.Tightening_no_datagrid.RowHeadersWidth = 51;
            this.Tightening_no_datagrid.RowTemplate.Height = 27;
            this.Tightening_no_datagrid.Size = new System.Drawing.Size(867, 252);
            this.Tightening_no_datagrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "주문번호";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "종목코드";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "주문상태";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "종목명";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "주문수량";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "누계금액";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "주문구분";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "체결가";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "체결수량";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // findTighteningButton
            // 
            this.findTighteningButton.Location = new System.Drawing.Point(905, 135);
            this.findTighteningButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findTighteningButton.Name = "findTighteningButton";
            this.findTighteningButton.Size = new System.Drawing.Size(67, 49);
            this.findTighteningButton.TabIndex = 10;
            this.findTighteningButton.Text = "조회";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.itemDeleteListBox);
            this.metroTabPage2.Controls.Add(this.itemInsertListBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 40);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1003, 308);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "조건편입";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(501, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "종목이탈";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "종목편입";
            // 
            // itemDeleteListBox
            // 
            this.itemDeleteListBox.FormattingEnabled = true;
            this.itemDeleteListBox.ItemHeight = 15;
            this.itemDeleteListBox.Location = new System.Drawing.Point(501, 44);
            this.itemDeleteListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemDeleteListBox.Name = "itemDeleteListBox";
            this.itemDeleteListBox.Size = new System.Drawing.Size(419, 259);
            this.itemDeleteListBox.TabIndex = 3;
            // 
            // itemInsertListBox
            // 
            this.itemInsertListBox.FormattingEnabled = true;
            this.itemInsertListBox.ItemHeight = 15;
            this.itemInsertListBox.Location = new System.Drawing.Point(17, 44);
            this.itemInsertListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemInsertListBox.Name = "itemInsertListBox";
            this.itemInsertListBox.Size = new System.Drawing.Size(419, 259);
            this.itemInsertListBox.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(19, 20);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1015, 392);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1007, 363);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "보유주식";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(1007, 363);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "조건검색";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.realTimeConditionOffLabel);
            this.groupBox6.Controls.Add(this.realTimeConditionGridView);
            this.groupBox6.Controls.Add(this.realTimeConditionOnLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(1001, 368);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // realTimeConditionOffLabel
            // 
            this.realTimeConditionOffLabel.AutoSize = true;
            this.realTimeConditionOffLabel.Location = new System.Drawing.Point(158, 41);
            this.realTimeConditionOffLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeConditionOffLabel.Name = "realTimeConditionOffLabel";
            this.realTimeConditionOffLabel.Size = new System.Drawing.Size(56, 19);
            this.realTimeConditionOffLabel.TabIndex = 12;
            this.realTimeConditionOffLabel.Text = "OFF";
            this.realTimeConditionOffLabel.UseVisualStyleBackColor = true;
            // 
            // realTimeConditionGridView
            // 
            this.realTimeConditionGridView.AllowUserToAddRows = false;
            this.realTimeConditionGridView.AllowUserToDeleteRows = false;
            this.realTimeConditionGridView.AllowUserToResizeColumns = false;
            this.realTimeConditionGridView.AllowUserToResizeRows = false;
            this.realTimeConditionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.realTimeConditionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realTimeConditionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목코드,
            this.종목명,
            this.현재가,
            this.전일대비,
            this.등락율,
            this.거래량,
            this.시가,
            this.고가,
            this.저가});
            this.realTimeConditionGridView.Location = new System.Drawing.Point(63, 78);
            this.realTimeConditionGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeConditionGridView.Name = "realTimeConditionGridView";
            this.realTimeConditionGridView.RowHeadersVisible = false;
            this.realTimeConditionGridView.RowHeadersWidth = 51;
            this.realTimeConditionGridView.RowTemplate.Height = 27;
            this.realTimeConditionGridView.Size = new System.Drawing.Size(871, 222);
            this.realTimeConditionGridView.TabIndex = 10;
            // 
            // 종목코드
            // 
            this.종목코드.HeaderText = "종목코드";
            this.종목코드.MinimumWidth = 6;
            this.종목코드.Name = "종목코드";
            this.종목코드.ReadOnly = true;
            // 
            // 종목명
            // 
            this.종목명.HeaderText = "종목명";
            this.종목명.MinimumWidth = 6;
            this.종목명.Name = "종목명";
            this.종목명.ReadOnly = true;
            // 
            // 현재가
            // 
            this.현재가.HeaderText = "현재가";
            this.현재가.MinimumWidth = 6;
            this.현재가.Name = "현재가";
            this.현재가.ReadOnly = true;
            // 
            // 전일대비
            // 
            this.전일대비.HeaderText = "전일대비";
            this.전일대비.MinimumWidth = 6;
            this.전일대비.Name = "전일대비";
            this.전일대비.ReadOnly = true;
            // 
            // 등락율
            // 
            this.등락율.HeaderText = "등락율";
            this.등락율.MinimumWidth = 6;
            this.등락율.Name = "등락율";
            this.등락율.ReadOnly = true;
            // 
            // 거래량
            // 
            this.거래량.HeaderText = "거래량";
            this.거래량.MinimumWidth = 6;
            this.거래량.Name = "거래량";
            this.거래량.ReadOnly = true;
            // 
            // 시가
            // 
            this.시가.HeaderText = "시가";
            this.시가.MinimumWidth = 6;
            this.시가.Name = "시가";
            this.시가.ReadOnly = true;
            // 
            // 고가
            // 
            this.고가.HeaderText = "고가";
            this.고가.MinimumWidth = 6;
            this.고가.Name = "고가";
            this.고가.ReadOnly = true;
            // 
            // 저가
            // 
            this.저가.HeaderText = "저가";
            this.저가.MinimumWidth = 6;
            this.저가.Name = "저가";
            this.저가.ReadOnly = true;
            // 
            // realTimeConditionOnLabel
            // 
            this.realTimeConditionOnLabel.AutoSize = true;
            this.realTimeConditionOnLabel.Location = new System.Drawing.Point(69, 42);
            this.realTimeConditionOnLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeConditionOnLabel.Name = "realTimeConditionOnLabel";
            this.realTimeConditionOnLabel.Size = new System.Drawing.Size(49, 19);
            this.realTimeConditionOnLabel.TabIndex = 11;
            this.realTimeConditionOnLabel.Text = "ON";
            this.realTimeConditionOnLabel.UseVisualStyleBackColor = true;
            this.realTimeConditionOnLabel.CheckedChanged += new System.EventHandler(this.RealTimeStrategyOnLabel_CheckedChanged);
            // 
            // startBuy
            // 
            this.startBuy.Controls.Add(this.groupBox12);
            this.startBuy.Controls.Add(this.autoSettingButton);
            this.startBuy.Controls.Add(this.metroLabel3);
            this.startBuy.Controls.Add(this.autoFundStartButton);
            this.startBuy.Controls.Add(this.자동매매lb);
            this.startBuy.Location = new System.Drawing.Point(1063, 601);
            this.startBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBuy.Name = "startBuy";
            this.startBuy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBuy.Size = new System.Drawing.Size(395, 186);
            this.startBuy.TabIndex = 15;
            this.startBuy.TabStop = false;
            this.startBuy.Text = "start";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.stopBuyRadio);
            this.groupBox12.Controls.Add(this.startBuyRadio);
            this.groupBox12.Location = new System.Drawing.Point(13, 44);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Size = new System.Drawing.Size(101, 78);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "매수 활성화";
            // 
            // stopBuyRadio
            // 
            this.stopBuyRadio.AutoSize = true;
            this.stopBuyRadio.Checked = true;
            this.stopBuyRadio.Location = new System.Drawing.Point(26, 51);
            this.stopBuyRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopBuyRadio.Name = "stopBuyRadio";
            this.stopBuyRadio.Size = new System.Drawing.Size(46, 17);
            this.stopBuyRadio.TabIndex = 3;
            this.stopBuyRadio.TabStop = true;
            this.stopBuyRadio.Text = "OFF";
            this.stopBuyRadio.UseVisualStyleBackColor = true;
            // 
            // startBuyRadio
            // 
            this.startBuyRadio.AutoSize = true;
            this.startBuyRadio.Location = new System.Drawing.Point(26, 25);
            this.startBuyRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBuyRadio.Name = "startBuyRadio";
            this.startBuyRadio.Size = new System.Drawing.Size(44, 17);
            this.startBuyRadio.TabIndex = 2;
            this.startBuyRadio.Text = "ON";
            this.startBuyRadio.UseVisualStyleBackColor = true;
            // 
            // autoSettingButton
            // 
            this.autoSettingButton.Location = new System.Drawing.Point(287, 110);
            this.autoSettingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSettingButton.Name = "autoSettingButton";
            this.autoSettingButton.Size = new System.Drawing.Size(89, 42);
            this.autoSettingButton.TabIndex = 3;
            this.autoSettingButton.Text = "시작";
            this.autoSettingButton.Click += new System.EventHandler(this.AutoSettingButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(169, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "자동설정 : ";
            // 
            // autoFundStartButton
            // 
            this.autoFundStartButton.Location = new System.Drawing.Point(287, 39);
            this.autoFundStartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoFundStartButton.Name = "autoFundStartButton";
            this.autoFundStartButton.Size = new System.Drawing.Size(89, 42);
            this.autoFundStartButton.TabIndex = 1;
            this.autoFundStartButton.Text = "시작";
            // 
            // 자동매매lb
            // 
            this.자동매매lb.AutoSize = true;
            this.자동매매lb.Location = new System.Drawing.Point(143, 44);
            this.자동매매lb.Name = "자동매매lb";
            this.자동매매lb.Size = new System.Drawing.Size(110, 20);
            this.자동매매lb.TabIndex = 0;
            this.자동매매lb.Text = "자동매매 시작 :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.realTimeConditionCombo);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Location = new System.Drawing.Point(1063, 808);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(395, 125);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "검색조건";
            // 
            // realTimeConditionCombo
            // 
            this.realTimeConditionCombo.FormattingEnabled = true;
            this.realTimeConditionCombo.Location = new System.Drawing.Point(133, 56);
            this.realTimeConditionCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realTimeConditionCombo.Name = "realTimeConditionCombo";
            this.realTimeConditionCombo.Size = new System.Drawing.Size(197, 23);
            this.realTimeConditionCombo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(130, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 15);
            this.label15.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 15);
            this.label16.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "조건이름 : ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1478, 1000);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "전략";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1478, 1000);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "주문";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.metroButton1);
            this.groupBox9.Controls.Add(this.numericUpDown2);
            this.groupBox9.Controls.Add(this.numericUpDown1);
            this.groupBox9.Controls.Add(this.metroTextBox1);
            this.groupBox9.Controls.Add(this.order_price);
            this.groupBox9.Controls.Add(this.order_count);
            this.groupBox9.Controls.Add(this.order_code);
            this.groupBox9.Location = new System.Drawing.Point(1111, 99);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(281, 241);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(69, 174);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 34);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "주문";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(115, 118);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(128, 25);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 80);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(128, 25);
            this.numericUpDown1.TabIndex = 4;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(115, 42);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(128, 22);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // order_price
            // 
            this.order_price.AutoSize = true;
            this.order_price.Location = new System.Drawing.Point(22, 120);
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(67, 15);
            this.order_price.TabIndex = 2;
            this.order_price.Text = "주문가격";
            // 
            // order_count
            // 
            this.order_count.AutoSize = true;
            this.order_count.Location = new System.Drawing.Point(22, 82);
            this.order_count.Name = "order_count";
            this.order_count.Size = new System.Drawing.Size(67, 15);
            this.order_count.TabIndex = 1;
            this.order_count.Text = "주문수량";
            // 
            // order_code
            // 
            this.order_code.AutoSize = true;
            this.order_code.Location = new System.Drawing.Point(22, 48);
            this.order_code.Name = "order_code";
            this.order_code.Size = new System.Drawing.Size(67, 15);
            this.order_code.TabIndex = 0;
            this.order_code.Text = "종목코드";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.manualTradingDataGridView);
            this.groupBox8.Location = new System.Drawing.Point(57, 78);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(917, 276);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "실시간조건검색";
            // 
            // manualTradingDataGridView
            // 
            this.manualTradingDataGridView.AllowUserToAddRows = false;
            this.manualTradingDataGridView.AllowUserToDeleteRows = false;
            this.manualTradingDataGridView.AllowUserToResizeColumns = false;
            this.manualTradingDataGridView.AllowUserToResizeRows = false;
            this.manualTradingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manualTradingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manualTradingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.manualTradingDataGridView.Location = new System.Drawing.Point(22, 34);
            this.manualTradingDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualTradingDataGridView.Name = "manualTradingDataGridView";
            this.manualTradingDataGridView.RowHeadersVisible = false;
            this.manualTradingDataGridView.RowHeadersWidth = 51;
            this.manualTradingDataGridView.RowTemplate.Height = 27;
            this.manualTradingDataGridView.Size = new System.Drawing.Size(871, 222);
            this.manualTradingDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "종목코드";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "종목명";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "현재가";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "전일대비";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "등락율";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "거래량";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "시가";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "고가";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "저가";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 1082);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "Fund_Manager";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realTimeAccountGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemcountnumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentnumeric1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tradingStrategyGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tightening_ok_datagrid)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tightening_no_datagrid)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realTimeConditionGridView)).EndInit();
            this.startBuy.ResumeLayout(false);
            this.startBuy.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manualTradingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lb이름;
        public System.Windows.Forms.Label lb아이디;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb수익률;
        private System.Windows.Forms.Label lb매입금액;
        private System.Windows.Forms.Label lb총금액;
        private System.Windows.Forms.Label lb손익금액;
        private System.Windows.Forms.DataGridView realTimeAccountGridView;
        private System.Windows.Forms.RadioButton realTimeAccountOnlabel;
        private System.Windows.Forms.RadioButton realTimeAccountOfflabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbbuycondition;
        private System.Windows.Forms.ComboBox buycondition_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbinvestment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown itemcountnumeric2;
        private System.Windows.Forms.NumericUpDown investmentnumeric1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox buyingOrderComboBox;
        private System.Windows.Forms.RadioButton lable11;
        private System.Windows.Forms.RadioButton marketPriceRadio;
        private System.Windows.Forms.Button createStrategyButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView tradingStrategyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_계좌번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_매수가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_총투자금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_매수종목수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_종목당투자금;
        private MetroFramework.Controls.MetroButton Accountbutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox realTimeConditionCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label order_price;
        private System.Windows.Forms.Label order_count;
        private System.Windows.Forms.Label order_code;
        private System.Windows.Forms.DataGridView manualTradingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.GroupBox startBuy;
        private MetroFramework.Controls.MetroButton autoFundStartButton;
        private MetroFramework.Controls.MetroLabel 자동매매lb;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton realTimeConditionOffLabel;
        private System.Windows.Forms.DataGridView realTimeConditionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일대비;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등락율;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 저가;
        private System.Windows.Forms.RadioButton realTimeConditionOnLabel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox itemDeleteListBox;
        private System.Windows.Forms.ListBox itemInsertListBox;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton findTighteningButton;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView Tightening_ok_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _주문번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn _종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn _주문상태;
        private System.Windows.Forms.DataGridViewTextBoxColumn _종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn _주문수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn _누계금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn _주문구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn _체결가;
        private System.Windows.Forms.DataGridViewTextBoxColumn _체결수량;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView Tightening_no_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private MetroFramework.Controls.MetroButton autoSettingButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox sellOrderCount;
        private System.Windows.Forms.TextBox sellOrderCode;
        private MetroFramework.Controls.MetroButton sellOrderButton;
        private System.Windows.Forms.GroupBox groupBox12;
        private MetroFramework.Controls.MetroRadioButton stopBuyRadio;
        private MetroFramework.Controls.MetroRadioButton startBuyRadio;
    }
}

