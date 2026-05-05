namespace _1131435_張新誠_簡易電子琴
{
    partial class frmBeepPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlayRecord = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(21, 31);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 93);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Do";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(110, 31);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 93);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Re";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(196, 31);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 93);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Mi";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(282, 31);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 93);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Fa";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(376, 31);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 93);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Sol";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(473, 31);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 93);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "La";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(568, 31);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 93);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Si";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.Color.Red;
            this.btn8.Location = new System.Drawing.Point(660, 31);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 93);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Do";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.btnPlayRecord);
            this.palMain.Controls.Add(this.btnRecord);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Location = new System.Drawing.Point(0, 2);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(876, 157);
            this.palMain.TabIndex = 8;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(751, 22);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(110, 46);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "開始錄音";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPlayRecord
            // 
            this.btnPlayRecord.Location = new System.Drawing.Point(751, 87);
            this.btnPlayRecord.Name = "btnPlayRecord";
            this.btnPlayRecord.Size = new System.Drawing.Size(110, 46);
            this.btnPlayRecord.TabIndex = 9;
            this.btnPlayRecord.Text = "播放錄音";
            this.btnPlayRecord.UseVisualStyleBackColor = true;
            this.btnPlayRecord.Click += new System.EventHandler(this.btnPlayRecord_Click);
            // 
            // frmBeepPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 161);
            this.Controls.Add(this.palMain);
            this.Name = "frmBeepPlayer";
            this.Text = "簡易電子琴";
            this.Load += new System.EventHandler(this.frmBeepPlayer_Load);
            this.SizeChanged += new System.EventHandler(this.frmBeepPlayer_SizeChanged);
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btnPlayRecord;
        private System.Windows.Forms.Button btnRecord;
    }
}

