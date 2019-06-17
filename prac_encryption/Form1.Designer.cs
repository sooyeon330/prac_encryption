namespace prac_encryption
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
            this.lb_key = new System.Windows.Forms.Label();
            this.lb_str = new System.Windows.Forms.Label();
            this.tbx_key = new System.Windows.Forms.TextBox();
            this.tbx_str = new System.Windows.Forms.TextBox();
            this.btn_en = new System.Windows.Forms.Button();
            this.label_en = new System.Windows.Forms.Label();
            this.lb_enstr = new System.Windows.Forms.Label();
            this.btn_de = new System.Windows.Forms.Button();
            this.lb_destr = new System.Windows.Forms.Label();
            this.label_de = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_key
            // 
            this.lb_key.AutoSize = true;
            this.lb_key.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.lb_key.Location = new System.Drawing.Point(42, 50);
            this.lb_key.Name = "lb_key";
            this.lb_key.Size = new System.Drawing.Size(29, 23);
            this.lb_key.TabIndex = 0;
            this.lb_key.Text = "키";
            // 
            // lb_str
            // 
            this.lb_str.AutoSize = true;
            this.lb_str.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.lb_str.Location = new System.Drawing.Point(42, 100);
            this.lb_str.Name = "lb_str";
            this.lb_str.Size = new System.Drawing.Size(48, 23);
            this.lb_str.TabIndex = 0;
            this.lb_str.Text = "평문";
            this.lb_str.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tbx_key
            // 
            this.tbx_key.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx_key.Location = new System.Drawing.Point(110, 50);
            this.tbx_key.Name = "tbx_key";
            this.tbx_key.Size = new System.Drawing.Size(374, 30);
            this.tbx_key.TabIndex = 1;
            // 
            // tbx_str
            // 
            this.tbx_str.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx_str.Location = new System.Drawing.Point(110, 93);
            this.tbx_str.Name = "tbx_str";
            this.tbx_str.Size = new System.Drawing.Size(374, 30);
            this.tbx_str.TabIndex = 1;
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(525, 50);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(119, 73);
            this.btn_en.TabIndex = 2;
            this.btn_en.Text = "암호화";
            this.btn_en.UseVisualStyleBackColor = true;
            // 
            // label_en
            // 
            this.label_en.AutoSize = true;
            this.label_en.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.label_en.Location = new System.Drawing.Point(43, 305);
            this.label_en.Name = "label_en";
            this.label_en.Size = new System.Drawing.Size(64, 17);
            this.label_en.TabIndex = 3;
            this.label_en.Text = "《암호문》";
            // 
            // lb_enstr
            // 
            this.lb_enstr.AutoSize = true;
            this.lb_enstr.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.lb_enstr.Location = new System.Drawing.Point(59, 332);
            this.lb_enstr.Name = "lb_enstr";
            this.lb_enstr.Size = new System.Drawing.Size(44, 23);
            this.lb_enstr.TabIndex = 0;
            this.lb_enstr.Text = "null";
            this.lb_enstr.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(525, 282);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(119, 73);
            this.btn_de.TabIndex = 2;
            this.btn_de.Text = "복호화";
            this.btn_de.UseVisualStyleBackColor = true;
            // 
            // lb_destr
            // 
            this.lb_destr.AutoSize = true;
            this.lb_destr.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.lb_destr.Location = new System.Drawing.Point(59, 424);
            this.lb_destr.Name = "lb_destr";
            this.lb_destr.Size = new System.Drawing.Size(44, 23);
            this.lb_destr.TabIndex = 0;
            this.lb_destr.Text = "null";
            this.lb_destr.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_de
            // 
            this.label_de.AutoSize = true;
            this.label_de.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.label_de.Location = new System.Drawing.Point(43, 397);
            this.label_de.Name = "label_de";
            this.label_de.Size = new System.Drawing.Size(64, 17);
            this.label_de.TabIndex = 3;
            this.label_de.Text = "《복호문》";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 515);
            this.Controls.Add(this.label_de);
            this.Controls.Add(this.label_en);
            this.Controls.Add(this.btn_de);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.tbx_str);
            this.Controls.Add(this.lb_destr);
            this.Controls.Add(this.tbx_key);
            this.Controls.Add(this.lb_enstr);
            this.Controls.Add(this.lb_str);
            this.Controls.Add(this.lb_key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "암호화/복호화 쌍자치환";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_key;
        private System.Windows.Forms.Label lb_str;
        private System.Windows.Forms.TextBox tbx_key;
        private System.Windows.Forms.TextBox tbx_str;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.Label lb_enstr;
        private System.Windows.Forms.Button btn_de;
        private System.Windows.Forms.Label lb_destr;
        private System.Windows.Forms.Label label_de;
    }
}

