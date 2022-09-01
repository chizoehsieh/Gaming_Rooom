namespace HW8
{
    partial class mform1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.選擇遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lottery = new System.Windows.Forms.ToolStripMenuItem();
            this.poker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選擇遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 選擇遊戲ToolStripMenuItem
            // 
            this.選擇遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lottery,
            this.poker,
            this.toolStripMenuItem1,
            this.exit});
            this.選擇遊戲ToolStripMenuItem.Name = "選擇遊戲ToolStripMenuItem";
            this.選擇遊戲ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.選擇遊戲ToolStripMenuItem.Text = "選擇遊戲";
            // 
            // lottery
            // 
            this.lottery.Name = "lottery";
            this.lottery.Size = new System.Drawing.Size(270, 34);
            this.lottery.Text = "大樂透遊戲";
            this.lottery.Click += new System.EventHandler(this.lottery_Click);
            // 
            // poker
            // 
            this.poker.Name = "poker";
            this.poker.Size = new System.Drawing.Size(270, 34);
            this.poker.Text = "撲克牌遊戲";
            this.poker.Click += new System.EventHandler(this.poker_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(270, 34);
            this.exit.Text = "離開";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 1050);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mform1";
            this.Text = "遊樂場";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mform1_FormClosing);
            this.Load += new System.EventHandler(this.mform1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 選擇遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lottery;
        private System.Windows.Forms.ToolStripMenuItem poker;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

