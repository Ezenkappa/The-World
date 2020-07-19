namespace BorrowAndRepay
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MyNameIP = new System.Windows.Forms.TextBox();
            this.FriendNameIP = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MynameLable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MyMoney = new System.Windows.Forms.Label();
            this.FriendMoney = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FriendnameLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.repayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入我的名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(75, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入朋友的名字:";
            // 
            // MyNameIP
            // 
            this.MyNameIP.Location = new System.Drawing.Point(228, 57);
            this.MyNameIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyNameIP.Name = "MyNameIP";
            this.MyNameIP.Size = new System.Drawing.Size(132, 27);
            this.MyNameIP.TabIndex = 2;
            // 
            // FriendNameIP
            // 
            this.FriendNameIP.Location = new System.Drawing.Point(228, 122);
            this.FriendNameIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FriendNameIP.Name = "FriendNameIP";
            this.FriendNameIP.Size = new System.Drawing.Size(132, 27);
            this.FriendNameIP.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submitButton.Location = new System.Drawing.Point(380, 57);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(140, 92);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "確認";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "我的名字:";
            // 
            // MynameLable
            // 
            this.MynameLable.AutoSize = true;
            this.MynameLable.Location = new System.Drawing.Point(163, 190);
            this.MynameLable.Name = "MynameLable";
            this.MynameLable.Size = new System.Drawing.Size(56, 16);
            this.MynameLable.TabIndex = 6;
            this.MynameLable.Text = "無名氏";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "我的$$:";
            // 
            // MyMoney
            // 
            this.MyMoney.AutoSize = true;
            this.MyMoney.Location = new System.Drawing.Point(163, 251);
            this.MyMoney.Name = "MyMoney";
            this.MyMoney.Size = new System.Drawing.Size(16, 16);
            this.MyMoney.TabIndex = 8;
            this.MyMoney.Text = "0";
            // 
            // FriendMoney
            // 
            this.FriendMoney.AutoSize = true;
            this.FriendMoney.Location = new System.Drawing.Point(387, 251);
            this.FriendMoney.Name = "FriendMoney";
            this.FriendMoney.Size = new System.Drawing.Size(56, 16);
            this.FriendMoney.TabIndex = 12;
            this.FriendMoney.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "朋友的$$:";
            // 
            // FriendnameLable
            // 
            this.FriendnameLable.AutoSize = true;
            this.FriendnameLable.Location = new System.Drawing.Point(387, 190);
            this.FriendnameLable.Name = "FriendnameLable";
            this.FriendnameLable.Size = new System.Drawing.Size(56, 16);
            this.FriendnameLable.TabIndex = 10;
            this.FriendnameLable.Text = "無名氏";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "朋友的名字:";
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowButton.Location = new System.Drawing.Point(80, 303);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(4);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(440, 46);
            this.borrowButton.TabIndex = 13;
            this.borrowButton.Text = "跟XXX借1000元";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // repayButton
            // 
            this.repayButton.Enabled = false;
            this.repayButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.repayButton.Location = new System.Drawing.Point(80, 370);
            this.repayButton.Margin = new System.Windows.Forms.Padding(4);
            this.repayButton.Name = "repayButton";
            this.repayButton.Size = new System.Drawing.Size(440, 45);
            this.repayButton.TabIndex = 14;
            this.repayButton.Text = "還XXX1000元";
            this.repayButton.UseVisualStyleBackColor = true;
            this.repayButton.Click += new System.EventHandler(this.repayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 504);
            this.Controls.Add(this.repayButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.FriendMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FriendnameLable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MyMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MynameLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.FriendNameIP);
            this.Controls.Add(this.MyNameIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "借還錢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MyNameIP;
        private System.Windows.Forms.TextBox FriendNameIP;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MynameLable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MyMoney;
        private System.Windows.Forms.Label FriendMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FriendnameLable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button repayButton;
    }
}

