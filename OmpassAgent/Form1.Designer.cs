
namespace OmpassAgentDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.resultMessage = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_lang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_uaf = new System.Windows.Forms.RadioButton();
            this.rb_u2f = new System.Windows.Forms.RadioButton();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.BackColor = System.Drawing.SystemColors.Window;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webView.Location = new System.Drawing.Point(-1, 423);
            this.webView.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1095, 842);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // resultMessage
            // 
            this.resultMessage.Location = new System.Drawing.Point(143, 0);
            this.resultMessage.Name = "resultMessage";
            this.resultMessage.Size = new System.Drawing.Size(100, 23);
            this.resultMessage.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(774, 111);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(174, 38);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "LOGIN";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(497, 365);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 21);
            this.state.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "OMPASS Windows Demo";
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(285, 114);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(444, 32);
            this.tb_url.TabIndex = 0;
            // 
            // tb_lang
            // 
            this.tb_lang.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lang.Location = new System.Drawing.Point(288, 178);
            this.tb_lang.Name = "tb_lang";
            this.tb_lang.Size = new System.Drawing.Size(441, 32);
            this.tb_lang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "DOMAIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "LANG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(147, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_uaf);
            this.groupBox1.Controls.Add(this.rb_u2f);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(774, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 174);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auth Type";
            // 
            // rb_uaf
            // 
            this.rb_uaf.AutoSize = true;
            this.rb_uaf.Location = new System.Drawing.Point(47, 106);
            this.rb_uaf.Name = "rb_uaf";
            this.rb_uaf.Size = new System.Drawing.Size(77, 34);
            this.rb_uaf.TabIndex = 5;
            this.rb_uaf.TabStop = true;
            this.rb_uaf.Text = "UAF";
            this.rb_uaf.UseVisualStyleBackColor = true;
            this.rb_uaf.CheckedChanged += new System.EventHandler(this.rb_uaf_CheckedChanged);
            // 
            // rb_u2f
            // 
            this.rb_u2f.AutoSize = true;
            this.rb_u2f.Location = new System.Drawing.Point(47, 47);
            this.rb_u2f.Name = "rb_u2f";
            this.rb_u2f.Size = new System.Drawing.Size(75, 34);
            this.rb_u2f.TabIndex = 4;
            this.rb_u2f.TabStop = true;
            this.rb_u2f.Text = "U2F";
            this.rb_u2f.UseVisualStyleBackColor = true;
            this.rb_u2f.CheckedChanged += new System.EventHandler(this.rb_u2f_CheckedChanged);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(176, 311);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(58, 24);
            this.label_pass.TabIndex = 23;
            this.label_pass.Text = "PASS";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(176, 250);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(34, 24);
            this.label_id.TabIndex = 22;
            this.label_id.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(288, 244);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(441, 32);
            this.tb_id.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(288, 306);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(441, 32);
            this.tb_pass.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1099, 1266);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_lang);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.resultMessage);
            this.Controls.Add(this.webView);
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Form1";
            this.Text = "OMPASS Demo for Widnows";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Label resultMessage;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_lang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.RadioButton rb_u2f;
        private System.Windows.Forms.RadioButton rb_uaf;
    }
}

