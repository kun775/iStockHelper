
namespace iStock
{
    partial class IStock
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IStock));
            this.skinTrackBar1 = new CCWin.SkinControl.SkinTrackBar();
            this.ListView_Stock = new CCWin.SkinControl.SkinDataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.now = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yclose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox_Add = new CCWin.SkinControl.SkinTextBox();
            this.notifyIcon_StatusBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip_StatusBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Ten = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Tips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListView_Stock)).BeginInit();
            this.MenuStrip_StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTrackBar1
            // 
            this.skinTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinTrackBar1.Bar = null;
            this.skinTrackBar1.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Saturation;
            this.skinTrackBar1.BaseColor = System.Drawing.Color.Blue;
            this.skinTrackBar1.LargeChange = 1;
            this.skinTrackBar1.Location = new System.Drawing.Point(281, 24);
            this.skinTrackBar1.Name = "skinTrackBar1";
            this.skinTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skinTrackBar1.Size = new System.Drawing.Size(278, 45);
            this.skinTrackBar1.SmallChange = 5;
            this.skinTrackBar1.TabIndex = 0;
            this.skinTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.skinTrackBar1.Track = null;
            this.skinTrackBar1.Value = 50;
            this.skinTrackBar1.Scroll += new System.EventHandler(this.SkinTrackBar1_Scroll);
            // 
            // ListView_Stock
            // 
            this.ListView_Stock.AlternatingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListView_Stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_Stock.ColumnFont = null;
            this.ListView_Stock.ColumnForeColor = System.Drawing.Color.White;
            this.ListView_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListView_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListView_Stock.ColumnHeadersHeight = 25;
            this.ListView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListView_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.up,
            this.now,
            this.high,
            this.low,
            this.topen,
            this.yclose,
            this.date});
            this.ListView_Stock.ColumnSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListView_Stock.DefaultCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListView_Stock.DefaultCellStyle = dataGridViewCellStyle10;
            this.ListView_Stock.EnableHeadersVisualStyles = false;
            this.ListView_Stock.GridColor = System.Drawing.Color.LightSlateGray;
            this.ListView_Stock.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView_Stock.HeadForeColor = System.Drawing.Color.White;
            this.ListView_Stock.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListView_Stock.LineNumberForeColor = System.Drawing.Color.White;
            this.ListView_Stock.Location = new System.Drawing.Point(11, 69);
            this.ListView_Stock.MouseCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.MultiSelect = false;
            this.ListView_Stock.Name = "ListView_Stock";
            this.ListView_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListView_Stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ListView_Stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListView_Stock.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ListView_Stock.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ListView_Stock.RowTemplate.ReadOnly = true;
            this.ListView_Stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ListView_Stock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListView_Stock.Size = new System.Drawing.Size(702, 50);
            this.ListView_Stock.SkinGridColor = System.Drawing.Color.LightSlateGray;
            this.ListView_Stock.TabIndex = 1;
            this.ListView_Stock.TitleBack = null;
            this.ListView_Stock.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ListView_Stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListView_Stock_CellDoubleClick);
            this.ListView_Stock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListView_Stock_CellFormatting);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.code.DefaultCellStyle = dataGridViewCellStyle3;
            this.code.HeaderText = "股票代码";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.code.Width = 75;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.name.DefaultCellStyle = dataGridViewCellStyle4;
            this.name.HeaderText = "股票名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 80;
            // 
            // up
            // 
            this.up.DataPropertyName = "up";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.up.DefaultCellStyle = dataGridViewCellStyle5;
            this.up.HeaderText = "涨跌幅%";
            this.up.Name = "up";
            this.up.ReadOnly = true;
            this.up.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.up.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.up.Width = 60;
            // 
            // now
            // 
            this.now.DataPropertyName = "now";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.now.DefaultCellStyle = dataGridViewCellStyle6;
            this.now.HeaderText = "当前价格";
            this.now.Name = "now";
            this.now.ReadOnly = true;
            this.now.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.now.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.now.Width = 60;
            // 
            // high
            // 
            this.high.DataPropertyName = "high";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.high.DefaultCellStyle = dataGridViewCellStyle7;
            this.high.HeaderText = "当日最高";
            this.high.Name = "high";
            this.high.ReadOnly = true;
            this.high.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.high.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.high.Width = 60;
            // 
            // low
            // 
            this.low.DataPropertyName = "low";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.low.DefaultCellStyle = dataGridViewCellStyle8;
            this.low.HeaderText = "当日最低";
            this.low.Name = "low";
            this.low.ReadOnly = true;
            this.low.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.low.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.low.Width = 60;
            // 
            // topen
            // 
            this.topen.DataPropertyName = "topen";
            this.topen.HeaderText = "今日开盘";
            this.topen.Name = "topen";
            this.topen.ReadOnly = true;
            this.topen.Width = 60;
            // 
            // yclose
            // 
            this.yclose.DataPropertyName = "yclose";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.yclose.DefaultCellStyle = dataGridViewCellStyle9;
            this.yclose.HeaderText = "昨日收盘";
            this.yclose.Name = "yclose";
            this.yclose.ReadOnly = true;
            this.yclose.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yclose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yclose.Width = 60;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "更新时间";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 140;
            // 
            // TextBox_Add
            // 
            this.TextBox_Add.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_Add.DownBack = null;
            this.TextBox_Add.Icon = null;
            this.TextBox_Add.IconIsButton = false;
            this.TextBox_Add.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBox_Add.IsPasswordChat = '\0';
            this.TextBox_Add.IsSystemPasswordChar = false;
            this.TextBox_Add.Lines = new string[0];
            this.TextBox_Add.Location = new System.Drawing.Point(609, 32);
            this.TextBox_Add.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox_Add.MaxLength = 6;
            this.TextBox_Add.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextBox_Add.MouseBack = null;
            this.TextBox_Add.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBox_Add.Multiline = false;
            this.TextBox_Add.Name = "TextBox_Add";
            this.TextBox_Add.NormlBack = null;
            this.TextBox_Add.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox_Add.ReadOnly = false;
            this.TextBox_Add.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Add.Size = new System.Drawing.Size(96, 28);
            // 
            // 
            // 
            this.TextBox_Add.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Add.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Add.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextBox_Add.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextBox_Add.SkinTxt.MaxLength = 6;
            this.TextBox_Add.SkinTxt.Name = "BaseText";
            this.TextBox_Add.SkinTxt.Size = new System.Drawing.Size(86, 18);
            this.TextBox_Add.SkinTxt.TabIndex = 0;
            this.TextBox_Add.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBox_Add.SkinTxt.WaterText = "6位股票代码";
            this.TextBox_Add.TabIndex = 3;
            this.TextBox_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Add.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBox_Add.WaterText = "6位股票代码";
            this.TextBox_Add.WordWrap = true;
            // 
            // notifyIcon_StatusBar
            // 
            this.notifyIcon_StatusBar.ContextMenuStrip = this.MenuStrip_StatusBar;
            this.notifyIcon_StatusBar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_StatusBar.Icon")));
            this.notifyIcon_StatusBar.Text = "股票行情助手";
            this.notifyIcon_StatusBar.Visible = true;
            this.notifyIcon_StatusBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // MenuStrip_StatusBar
            // 
            this.MenuStrip_StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_About,
            this.Menu_Ten,
            this.Menu_Exit});
            this.MenuStrip_StatusBar.Name = "contextMenuStrip1";
            this.MenuStrip_StatusBar.Size = new System.Drawing.Size(172, 70);
            // 
            // Menu_About
            // 
            this.Menu_About.Enabled = false;
            this.Menu_About.Name = "Menu_About";
            this.Menu_About.Size = new System.Drawing.Size(171, 22);
            this.Menu_About.Text = "股票行情助手v1.0";
            // 
            // Menu_Ten
            // 
            this.Menu_Ten.Name = "Menu_Ten";
            this.Menu_Ten.Size = new System.Drawing.Size(171, 22);
            this.Menu_Ten.Text = "点击穿透";
            this.Menu_Ten.Click += new System.EventHandler(this.Menu_Ten_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(171, 22);
            this.Menu_Exit.Text = "退出";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // label_Tips
            // 
            this.label_Tips.AutoSize = true;
            this.label_Tips.Location = new System.Drawing.Point(232, 40);
            this.label_Tips.Name = "label_Tips";
            this.label_Tips.Size = new System.Drawing.Size(41, 12);
            this.label_Tips.TabIndex = 5;
            this.label_Tips.Text = "透明度";
            this.label_Tips.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Label_Tips_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "添加";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(11, 40);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(65, 12);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "股市交易中";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // IStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.BorderColor = System.Drawing.Color.Transparent;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(716, 125);
            this.CloseBoxSize = new System.Drawing.Size(30, 20);
            this.CloseDownBack = null;
            this.CloseMouseBack = null;
            this.CloseNormlBack = null;
            this.ControlBox = false;
            this.ControlBoxOffset = new System.Drawing.Point(10, 1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Tips);
            this.Controls.Add(this.ListView_Stock);
            this.Controls.Add(this.TextBox_Add);
            this.Controls.Add(this.skinTrackBar1);
            this.EffectBack = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InheritBack = true;
            this.InheritTheme = true;
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.InternalBackColor = System.Drawing.Color.Transparent;
            this.InternalBorderColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MdiBackColor = System.Drawing.Color.Transparent;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "IStock";
            this.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShadowWidth = 1;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.ShowSystemMenu = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.TitleSuitColor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IStock_FormClosing);
            this.Load += new System.EventHandler(this.IStock_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IStock_MouseDoubleClick);
            this.Move += new System.EventHandler(this.IStock_Move);
            ((System.ComponentModel.ISupportInitialize)(this.skinTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListView_Stock)).EndInit();
            this.MenuStrip_StatusBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTrackBar skinTrackBar1;
        private CCWin.SkinControl.SkinTextBox TextBox_Add;
        private CCWin.SkinControl.SkinDataGridView ListView_Stock;
        private System.Windows.Forms.NotifyIcon notifyIcon_StatusBar;
        private System.Windows.Forms.ContextMenuStrip MenuStrip_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem Menu_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Ten;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.Label label_Tips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn up;
        private System.Windows.Forms.DataGridViewTextBoxColumn now;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn topen;
        private System.Windows.Forms.DataGridViewTextBoxColumn yclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

