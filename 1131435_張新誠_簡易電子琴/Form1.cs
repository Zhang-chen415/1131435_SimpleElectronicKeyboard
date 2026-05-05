using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1131435_張新誠_簡易電子琴
{
    public partial class frmBeepPlayer: Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
        bool isRecording = false;                  // 用來記錄現在是否正在錄音
        List<int> recordedNotes = new List<int>(); // 宣告一個 List 來儲存按下的音符對應索引
        int initWidth = 0;
        int initHeight = 0;
        Dictionary<string, Rectangle> initControl = new Dictionary<string, Rectangle>();
        public frmBeepPlayer()
        {
            InitializeComponent();
            InitializeButton();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            if (isRecording)
            {
                // 將被按下的琴鍵 TabIndex (0~7) 存入 List 中
                recordedNotes.Add(btn.TabIndex);
            }
            Beep(freq[btn.TabIndex], 300);
            btn.Enabled = true;
        }
        private void InitializeButton()
        {
            // 讓btn1~btn8共用同一個事件處理函式
            btn2.Click += btn1_Click;
            btn3.Click += btn1_Click;
            btn4.Click += btn1_Click;
            btn5.Click += btn1_Click;
            btn6.Click += btn1_Click;
            btn7.Click += btn1_Click;
            btn8.Click += btn1_Click;
        }
        

        private void frmBeepPlayer_Load(object sender, EventArgs e)
        {
            this.initWidth = this.palMain.Width;
            this.initHeight = this.palMain.Height;
            foreach (Control ctl in this.palMain.Controls)
            {
                this.initControl.Add(ctl.Name, new Rectangle(ctl.Left, ctl.Top,
                ctl.Width, ctl.Height));
            }
        }

        private void frmBeepPlayer_SizeChanged(object sender, EventArgs e)
        {
            double width = this.palMain.Width;
            double height = this.palMain.Height;
            double iRatioWith = width / this.initWidth;
            double iRatioHeight = height / this.initHeight;
            foreach (Control ctl in this.palMain.Controls)
            {
                ctl.Left = (int)(initControl[ctl.Name].Left * iRatioWith);
                ctl.Top = (int)(initControl[ctl.Name].Top * iRatioHeight);
                ctl.Width = (int)(initControl[ctl.Name].Width * iRatioWith);
                ctl.Height = (int)(initControl[ctl.Name].Height *
                iRatioHeight);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                isRecording = true;
                recordedNotes.Clear();
                btnRecord.Text = "停止錄音";
                btnRecord.ForeColor = Color.Red;
            }
            else
            {
                isRecording = false;
                btnRecord.Text = "開始錄音";
                btnRecord.ForeColor = Color.Black;
            }
        }

        private void btnPlayRecord_Click(object sender, EventArgs e)
        {
            if (recordedNotes.Count == 0)
            {
                MessageBox.Show("目前沒有錄音紀錄喔！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 依序讀取 List 中的音符索引並播放
            foreach (int noteIndex in recordedNotes)
            {
                Beep(freq[noteIndex], 300);
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
