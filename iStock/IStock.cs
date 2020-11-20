using CCWin;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using CsharpHttpHelper;
using System.Linq;

namespace iStock
{
    public struct Stock
    {
        public int index;
        public string code;
        public string name;
        public string jys;
    }
    public struct SinaStock
    {
        public string code;
        public string name;
        public string up;
        public double topen;
        public double yclose;
        public double now;
        public double high;
        public double low;
        public string date;
    }
    public partial class IStock : Skin_Metro
    {
        // 股票数据接口
        private readonly string hostSina = "http://hq.sinajs.cn/list={0}";
        // 一言接口
        private readonly string hostHitokoto = "https://v1.hitokoto.cn/?c=a&c=b&c=c&c=d&c=e&c=f&encode=text";
        // 配置文件路径 默认软件运行目录下
        private readonly string iniPath = Path.Combine(Application.StartupPath, "config.ini");
        // 单元格行高
        private readonly int rowHeight = 22;
        // 窗体高度
        private int orginHeiget;
        // 窗体状态 隐藏还是显示
        private bool isHide = false;
        // 用于休市时或者新增/移除股票时显示股票信息
        private bool runOnce = true;
        // 窗体显示的位置 用于隐藏窗体显示的依据
        private Point defaultPoint;
        // 股票信息集合
        public Dictionary<string, SinaStock> dictSina = new Dictionary<string, SinaStock> { };
        // 上交所股票代码开头
        private readonly List<string> shList = new List<string>{"600", "601", "603", "605", "688", "730", "900"};
        // 深交所股票代码开头
        private readonly List<string> szList = new List<string>{"000", "001", "002", "300", "200"};

        /*********************配置文件的变量***********************/
        //股票代码列表
        private string codeList = "";
        // 透明度
        private int opacity = 50;
        // 是否鼠标点击穿透
        private string penetrate = "false";
        /*********************配置文件的变量***********************/

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);

        private readonly string time1 = "093000";
        private readonly string time2 = "113000";
        private readonly string time4 = "130000";
        private readonly string time5 = "150000";

        // 初始化
        public IStock()
        {
            InitializeComponent();

            Menu_About.Text = "股票行情助手v1.1";
            Text = "股票行情助手v1.1 by北海小王子";

            Control.CheckForIllegalCrossThreadCalls = false;
            ListView_Stock.RowTemplate.Height = rowHeight;
        }
        // 隐藏窗体
        private void HideMe()
        {
            isHide = true;
            Location = new Point(0, 10000);
        }
        // 显示窗体
        private void ShowMe()
        {
            isHide = false;
            Location = defaultPoint;
        }
        // 窗体加载
        private void IStock_Load(object sender, EventArgs e)
        {
            defaultPoint = Location;
            orginHeiget = Height;
            Location = new Point(0, 0);
            //BackColor = Color.Black;
            //TransparencyKey = Color.Black;
            BorderColor = Color.Transparent;
            ListView_Stock.BackgroundColor = ListView_Stock.Parent.BackColor;
            TextBox_Add.SkinTxt.TextChanged += new EventHandler(TextBox_Add_TextChanged);

            ListView_Stock.Columns[0].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListView_Stock.Columns[1].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListView_Stock.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[4].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[5].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[6].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[7].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[8].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ListView_Stock.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListView_Stock.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListView_Stock.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListView_Stock.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            ListView_Stock.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            ReadConfig();
            UpdateStatus();
        }
        // 更新窗体状态
        private void UpdateStatus()
        {
            Opacity = opacity / 100.0;
            SkinOpacity = Opacity;
            skinTrackBar1.Value = opacity;

            if (penetrate == "true")
            {
                Menu_Ten.Checked = true;
                GetWindowLong(this.Handle, GWL_EXSTYLE);
                SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            }
            else
            {
                Menu_Ten.Checked = false;
                GetWindowLong(this.Handle, GWL_EXSTYLE);
                SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_LAYERED);
            }

            TextBox_Add.Visible = !Menu_Ten.Checked;
            skinTrackBar1.Visible = !Menu_Ten.Checked;
            label1.Visible = !Menu_Ten.Checked;
            label_Tips.Visible = !Menu_Ten.Checked;
            IniWriteValue("GENERAL", "penetrate", penetrate);
        }
        // 是否交易时间
        private bool IsTraceTime(DateTime date, out string msg)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                msg = "非交易日";
                return false;
            }

            string time = date.ToString("HHmmss");
            if (string.Compare(time, time1) < 0)
            {
                msg = "未开盘";
                return false;
            }
            if (string.Compare(time,time2) > 0 && string.Compare(time, time4) < 0)
            {
                msg = "休市中";
                return false;
            }
            if (string.Compare(time, time5) > 0)
            {
                msg = "已收盘";
                return false;
            }
            msg = "交易中";
            return true;
        }
        // 定时器超时
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Second % 5 == 0)
            {
                SetHitokoto();
            }
            string msg = "交易中";
            if (!runOnce && !IsTraceTime(now, out msg))
            {
                label_status.Text = $"{msg} {now:yyyy-MM-dd HH:mm:ss}";
                label_status.ForeColor = Color.Red;
                Opacity = 0.25;
                return;
            }
            Opacity = opacity / 100.0;
            label_status.ForeColor = Color.White;
            label_status.Text = $"{msg} {now:yyyy-MM-dd HH:mm:ss}";
            FromSina();
        }
        // 设置一言
        private void SetHitokoto()
        {
            string text = GetData(hostHitokoto);
            if (string.IsNullOrEmpty(text) || text.Length > 30)
                return;

            Text = text;
        }
        // 更新股票信息
        private void FromSina()
        {
            runOnce = false;
            
            try
            {
                dictSina.Clear();
                string url = string.Format(hostSina, codeList);
                string data = GetData(url);

                string[] vs = data.Split('\n');

                Height = orginHeiget + (rowHeight * (vs.Length - 2));
                Size = new Size(Width, Height);
                ListView_Stock.Height = Height - 77;
                foreach (var line in vs)
                {
                    string[] ss = line.Split('=');
                    if (ss.Length != 2)
                        continue;
                    string code = ss[0].Substring(ss[0].Length - 6);
                    string[] oo = ss[1].Split(',');
                    if (oo.Length < 32)
                    {
                        Console.WriteLine(line);
                        continue;
                    }

                    SinaStock sinaStock = new SinaStock
                    {
                        code = code,
                        name = oo[0].Substring(1),
                        topen = double.Parse(oo[1]),
                        yclose = double.Parse(oo[2]),
                        now = double.Parse(oo[3]),
                        high = double.Parse(oo[4]),
                        low = double.Parse(oo[5])
                    };
                    double d = (sinaStock.now - sinaStock.topen) * 100 / sinaStock.topen;
                    sinaStock.up = $"{d:F2}";
                    sinaStock.date = oo[30] + " " + oo[31];

                    dictSina[code] = sinaStock;
                }
                if (dictSina.Count > 0)
                {
                    ListView_Stock.DataSource = (from p in dictSina
                                                    select new
                                                    {
                                                        p.Value.code,
                                                        p.Value.name,
                                                        p.Value.up,
                                                        p.Value.now,
                                                        p.Value.high,
                                                        p.Value.low,
                                                        p.Value.topen,
                                                        p.Value.yclose,
                                                        p.Value.date
                                                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // 读ini文件 string值
        public string IniReadValue(string Section, string Key)
        {
            try
            {
                StringBuilder temp = new StringBuilder(500);
                _ = GetPrivateProfileString(Section, Key, "", temp, 500, iniPath);
                return temp.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        // 股票列表字符串化
        private string List2String(List<string> list, string seq)
        {
            string s = "";
            if (list.Count == 0)
                return s;
            foreach (var ss in list)
            {
                s += $"{ss}{seq}";
            }

            return s.Substring(0, s.Length - seq.Length); 
        }
        // 读ini文件
        private void ReadConfig()
        {
            if (!File.Exists(iniPath))
            {
                File.Create(iniPath);
            }
            string opacity1 = IniReadValue("GENERAL", "opacity");
            if (string.IsNullOrEmpty(opacity1))
            {
                opacity = 100;
            }
            else
            {
                try
                {
                    opacity = int.Parse(opacity1);
                }
                catch 
                {
                    opacity = 100;
                }
            }

            penetrate = IniReadValue("GENERAL", "penetrate");
            if (string.IsNullOrEmpty(penetrate))
            {
                penetrate = "false";
            }
            if (penetrate == "true")
            {
                GetWindowLong(this.Handle, GWL_EXSTYLE);
                SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
                Menu_Ten.Checked = true;
            }
            else
            {
                Menu_Ten.Checked = false;
                GetWindowLong(this.Handle, GWL_EXSTYLE);
                SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_LAYERED);
            }

            codeList = IniReadValue("GENERAL", "codelist");
            if (string.IsNullOrEmpty(codeList))
            {
                MessageBox.Show("股票代码列表为空，请添加股票代码。", "提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TextBox_Add.Visible = !Menu_Ten.Checked;
            skinTrackBar1.Visible = !Menu_Ten.Checked;
            label1.Visible = !Menu_Ten.Checked;
            label_Tips.Visible = !Menu_Ten.Checked;
            IniWriteValue("GENERAL", "codelist", codeList);
            IniWriteValue("GENERAL", "opacity", opacity.ToString());
            IniWriteValue("GENERAL", "penetrate", penetrate);
        }
        // 写ini文件
        public void IniWriteValue(string Section, string Key, string Value)
        {
            try
            {
                WritePrivateProfileString(Section, Key, Value, this.iniPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // 获取数据
        private string GetData(string url)
        {
            //创建Httphelper对象
            HttpHelper http = new HttpHelper();
            //创建Httphelper参数对象
            HttpItem item = new HttpItem()
            {
                URL = url,//URL     必需项    
                Method = "get",//URL     可选项 默认为Get   
                ContentType = "text/html",//返回类型    可选项有默认值   
                Referer = "https://www.baidu.com",
                UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36",
            };
            //请求的返回值对象
            HttpResult result = http.GetHtml(item);
            return result.Html;
        }
        // 改变窗体透明度
        private void SkinTrackBar1_Scroll(object sender, EventArgs e)
        {
            opacity = skinTrackBar1.Value;
            Opacity = opacity / 100.0;
            if (Opacity < 0.1)
            {
                Opacity = 0.1;
                opacity = 10;
            }

            IniWriteValue("GENERAL", "opacity", opacity.ToString());
        }
        // 添加股票代码
        private void AddStockCode(string code)
        {
            if (code.Length != 6)
                return;

            if (shList.Contains(code.Substring(0, 3)))
                code = "sh" + code;
            else if (szList.Contains(code.Substring(0, 3)))
                code = "sz" + code;
            else
            {
                MessageBox.Show($"不支持的股票代码类型 {code}", "错误", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> ss = new List<string>(codeList.Split(','));
            if (ss.Contains(code))
            {

                MessageBox.Show($"{code} 已经添加", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ss.Add(code);
            codeList = List2String(ss, ",");
            IniWriteValue("GENERAL", "codelist", List2String(ss, ","));
            MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            runOnce = true;
            TextBox_Add.Text = "";
        }
        // 关闭窗体
        private void IStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            isHide = true;
            Location = new Point(0, 10000);
        }
        // 点击鼠标穿透
        private void Menu_Ten_Click(object sender, EventArgs e)
        {
            if (!Menu_Ten.Checked)
                penetrate = "true";
            else
                penetrate = "false";
            UpdateStatus();
        }
        // 点击退出
        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        // 输入框内容改变
        private void TextBox_Add_TextChanged(object sender, EventArgs e)
        {
            string code = TextBox_Add.Text;

            AddStockCode(code);
        }
        // 双击图标
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (isHide)
            {
                ShowMe();
            }
            else
            {
                HideMe();
            }
        }
        // 窗体移动
        private void IStock_Move(object sender, EventArgs e)
        {
            if (Location.X < 0)
            {
                Location = new Point(0, Location.Y);
            }
            if (!isHide)
                defaultPoint = Location;
        }
        // 单元格格式
        private void ListView_Stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (row < 0 || col != 2 || e.Value == null)
                return;

            try
            {
                double price = double.Parse(e.Value.ToString());

                if (price > 0)
                    ListView_Stock.Rows[row].Cells[col].Style.ForeColor = Color.Red;
                else if (price == 0)
                    ListView_Stock.Rows[row].Cells[col].Style.ForeColor = Color.White;
                else
                    ListView_Stock.Rows[row].Cells[col].Style.ForeColor = Color.LightGreen;
            }
            catch
            {
                
            }
        }
        // 移除股票
        private void ListView_Stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
                return;

            string code = ListView_Stock.Rows[row].Cells[0].Value.ToString();
            string name = ListView_Stock.Rows[row].Cells[1].Value.ToString();

            DialogResult dr = MessageBox.Show($"确认移除 {code} {name}?", "移除股票", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return;

            if (shList.Contains(code.Substring(0, 3)))
                code = "sh" + code;
            else if (szList.Contains(code.Substring(0, 3)))
                code = "sz" + code;
            List<string> ss = new List<string>(codeList.Split(','));
            if (!ss.Contains(code))
            {
                return;
            }

            ss.Remove(code);
            codeList = List2String(ss, ",");
            IniWriteValue("GENERAL", "codelist", List2String(ss, ","));
            MessageBox.Show("移除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            runOnce = true;
        }
        // 双击隐藏窗体
        private void IStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HideMe();
        }
        // 双击透明度鼠标点击穿透
        private void Label_Tips_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            penetrate = "true";
            Menu_Ten.Checked = true;
            UpdateStatus();
        }
    }
}
