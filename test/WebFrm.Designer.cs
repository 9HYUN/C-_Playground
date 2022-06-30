namespace test
{
    partial class WebFrm
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(98, 15);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(996, 23);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://www.naver.com";
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1100, 15);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(72, 26);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(12, 15);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(38, 26);
            this.btnBefore.TabIndex = 2;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(56, 15);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(38, 26);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // wbMain
            // 
            this.wbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMain.Location = new System.Drawing.Point(12, 49);
            this.wbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 25);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(1160, 547);
            this.wbMain.TabIndex = 4;
            this.wbMain.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // WebFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.wbMain);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WebFrm";
            this.Text = "yongTech";
            this.Load += new System.EventHandler(this.WebFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.WebBrowser wbMain;
    }
}

