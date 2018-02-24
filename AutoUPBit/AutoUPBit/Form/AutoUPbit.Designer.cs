namespace AutoUPBit
{
    partial class AutoUPbit
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
            this.MinuteGrpBox = new System.Windows.Forms.GroupBox();
            this.MinuteComboBox = new System.Windows.Forms.ComboBox();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageMin1 = new System.Windows.Forms.TabPage();
            this.ListViewMin1 = new System.Windows.Forms.ListView();
            this.Min1ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min1ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min5ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min10ColumnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountGrpBox = new System.Windows.Forms.GroupBox();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            this.CoinNameGrpBox = new System.Windows.Forms.GroupBox();
            this.CoinNameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.BreakBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.MinuteGrpBox.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageMin1.SuspendLayout();
            this.CountGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            this.CoinNameGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinuteGrpBox
            // 
            this.MinuteGrpBox.Controls.Add(this.MinuteComboBox);
            this.MinuteGrpBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinuteGrpBox.Location = new System.Drawing.Point(203, 12);
            this.MinuteGrpBox.Name = "MinuteGrpBox";
            this.MinuteGrpBox.Size = new System.Drawing.Size(100, 50);
            this.MinuteGrpBox.TabIndex = 1;
            this.MinuteGrpBox.TabStop = false;
            this.MinuteGrpBox.Text = "Minutes";
            // 
            // MinuteComboBox
            // 
            this.MinuteComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinuteComboBox.FormattingEnabled = true;
            this.MinuteComboBox.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "30",
            "60",
            "240"});
            this.MinuteComboBox.Location = new System.Drawing.Point(3, 19);
            this.MinuteComboBox.Name = "MinuteComboBox";
            this.MinuteComboBox.Size = new System.Drawing.Size(94, 23);
            this.MinuteComboBox.TabIndex = 0;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainProgressBar,
            this.toolStripStatusLabel1});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 539);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(984, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Location = new System.Drawing.Point(660, 22);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 40);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "&Start";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserDateTimePicker);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minutes";
            // 
            // UserDateTimePicker
            // 
            this.UserDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDateTimePicker.Location = new System.Drawing.Point(3, 19);
            this.UserDateTimePicker.Name = "UserDateTimePicker";
            this.UserDateTimePicker.Size = new System.Drawing.Size(179, 23);
            this.UserDateTimePicker.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPageMin1);
            this.tabControl1.Location = new System.Drawing.Point(203, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 468);
            this.tabControl1.TabIndex = 22;
            // 
            // TabPageMin1
            // 
            this.TabPageMin1.Controls.Add(this.ListViewMin1);
            this.TabPageMin1.Location = new System.Drawing.Point(4, 24);
            this.TabPageMin1.Name = "TabPageMin1";
            this.TabPageMin1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageMin1.Size = new System.Drawing.Size(761, 440);
            this.TabPageMin1.TabIndex = 0;
            this.TabPageMin1.Text = "TabPageMin1";
            this.TabPageMin1.UseVisualStyleBackColor = true;
            // 
            // ListViewMin1
            // 
            this.ListViewMin1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Min1ColumnHeader0,
            this.Min1ColumnHeader1,
            this.Min1ColumnHeader2,
            this.Min1ColumnHeader3,
            this.Min1ColumnHeader4,
            this.Min1ColumnHeader5,
            this.Min1ColumnHeader6,
            this.Min1ColumnHeader7,
            this.Min1ColumnHeader8,
            this.Min1ColumnHeader9,
            this.Min1ColumnHeader10,
            this.Min1ColumnHeader11});
            this.ListViewMin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewMin1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListViewMin1.FullRowSelect = true;
            this.ListViewMin1.GridLines = true;
            this.ListViewMin1.Location = new System.Drawing.Point(3, 3);
            this.ListViewMin1.Name = "ListViewMin1";
            this.ListViewMin1.Size = new System.Drawing.Size(755, 434);
            this.ListViewMin1.TabIndex = 0;
            this.ListViewMin1.UseCompatibleStateImageBehavior = false;
            this.ListViewMin1.View = System.Windows.Forms.View.Details;
            // 
            // Min1ColumnHeader0
            // 
            this.Min1ColumnHeader0.Text = "Index";
            this.Min1ColumnHeader0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min1ColumnHeader0.Width = 50;
            // 
            // Min1ColumnHeader1
            // 
            this.Min1ColumnHeader1.Text = "Code";
            this.Min1ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min1ColumnHeader1.Width = 1;
            // 
            // Min1ColumnHeader2
            // 
            this.Min1ColumnHeader2.Text = "CandleDateTime";
            this.Min1ColumnHeader2.Width = 155;
            // 
            // Min1ColumnHeader3
            // 
            this.Min1ColumnHeader3.Text = "CandleDateTimeKst";
            this.Min1ColumnHeader3.Width = 155;
            // 
            // Min1ColumnHeader4
            // 
            this.Min1ColumnHeader4.Text = "OpeningPrice";
            this.Min1ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Min1ColumnHeader4.Width = 87;
            // 
            // Min1ColumnHeader5
            // 
            this.Min1ColumnHeader5.Text = "HighPrice";
            this.Min1ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Min1ColumnHeader5.Width = 87;
            // 
            // Min1ColumnHeader6
            // 
            this.Min1ColumnHeader6.Text = "LowPrice";
            this.Min1ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Min1ColumnHeader6.Width = 87;
            // 
            // Min1ColumnHeader7
            // 
            this.Min1ColumnHeader7.Text = "TradePrice";
            this.Min1ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Min1ColumnHeader7.Width = 87;
            // 
            // Min1ColumnHeader8
            // 
            this.Min1ColumnHeader8.Text = "CandleAccTradeVolume";
            this.Min1ColumnHeader8.Width = 3;
            // 
            // Min1ColumnHeader9
            // 
            this.Min1ColumnHeader9.Text = "CandleAccTradePrice";
            this.Min1ColumnHeader9.Width = 3;
            // 
            // Min1ColumnHeader10
            // 
            this.Min1ColumnHeader10.Text = "Timestamp";
            this.Min1ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Min1ColumnHeader10.Width = 125;
            // 
            // Min1ColumnHeader11
            // 
            this.Min1ColumnHeader11.Text = "Unit";
            this.Min1ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min1ColumnHeader11.Width = 50;
            // 
            // CountGrpBox
            // 
            this.CountGrpBox.Controls.Add(this.CountNumeric);
            this.CountGrpBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CountGrpBox.Location = new System.Drawing.Point(309, 12);
            this.CountGrpBox.Name = "CountGrpBox";
            this.CountGrpBox.Size = new System.Drawing.Size(100, 50);
            this.CountGrpBox.TabIndex = 3;
            this.CountGrpBox.TabStop = false;
            this.CountGrpBox.Text = "Count";
            // 
            // CountNumeric
            // 
            this.CountNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountNumeric.Location = new System.Drawing.Point(3, 19);
            this.CountNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(94, 23);
            this.CountNumeric.TabIndex = 0;
            this.CountNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CountNumeric.ThousandsSeparator = true;
            this.CountNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // CoinNameGrpBox
            // 
            this.CoinNameGrpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoinNameGrpBox.Controls.Add(this.CoinNameCheckedListBox);
            this.CoinNameGrpBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CoinNameGrpBox.Location = new System.Drawing.Point(12, 68);
            this.CoinNameGrpBox.Name = "CoinNameGrpBox";
            this.CoinNameGrpBox.Size = new System.Drawing.Size(185, 468);
            this.CoinNameGrpBox.TabIndex = 21;
            this.CoinNameGrpBox.TabStop = false;
            this.CoinNameGrpBox.Text = "Coin List";
            // 
            // CoinNameCheckedListBox
            // 
            this.CoinNameCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoinNameCheckedListBox.FormattingEnabled = true;
            this.CoinNameCheckedListBox.Location = new System.Drawing.Point(3, 19);
            this.CoinNameCheckedListBox.Name = "CoinNameCheckedListBox";
            this.CoinNameCheckedListBox.Size = new System.Drawing.Size(179, 446);
            this.CoinNameCheckedListBox.TabIndex = 0;
            // 
            // BreakBtn
            // 
            this.BreakBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BreakBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BreakBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BreakBtn.Location = new System.Drawing.Point(766, 22);
            this.BreakBtn.Name = "BreakBtn";
            this.BreakBtn.Size = new System.Drawing.Size(100, 40);
            this.BreakBtn.TabIndex = 12;
            this.BreakBtn.Text = "&Break";
            this.BreakBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BreakBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(554, 22);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 40);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(872, 22);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(100, 40);
            this.ReportBtn.TabIndex = 13;
            this.ReportBtn.Text = "&Report";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // AutoUPbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.BreakBtn);
            this.Controls.Add(this.CoinNameGrpBox);
            this.Controls.Add(this.CountGrpBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MinuteGrpBox);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AutoUPbit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoUPBit";
            this.Load += new System.EventHandler(this.AutoUPbit_Load);
            this.MinuteGrpBox.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabPageMin1.ResumeLayout(false);
            this.CountGrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            this.CoinNameGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MinuteGrpBox;
        private System.Windows.Forms.ComboBox MinuteComboBox;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker UserDateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageMin1;
        private System.Windows.Forms.ListView ListViewMin1;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader0;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader1;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader2;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader3;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader4;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader5;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader6;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader7;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader8;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader9;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader10;
        private System.Windows.Forms.ColumnHeader Min1ColumnHeader11;
        private System.Windows.Forms.ColumnHeader Min5ColumnHeader0;
        private System.Windows.Forms.ColumnHeader Min10ColumnHeader0;
        private System.Windows.Forms.GroupBox CountGrpBox;
        private System.Windows.Forms.NumericUpDown CountNumeric;
        private System.Windows.Forms.GroupBox CoinNameGrpBox;
        private System.Windows.Forms.CheckedListBox CoinNameCheckedListBox;
        private System.Windows.Forms.Button BreakBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ReportBtn;
    }
}

