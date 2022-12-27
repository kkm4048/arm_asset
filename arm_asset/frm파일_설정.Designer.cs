namespace arm_asset
{
    partial class frm파일_설정
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn저장 = new System.Windows.Forms.Button();
            this.cmb프린터 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb드라이브 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt저장폴더 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn저장
            // 
            this.btn저장.Location = new System.Drawing.Point(79, 95);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(75, 39);
            this.btn저장.TabIndex = 72;
            this.btn저장.Text = "저 장";
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // cmb프린터
            // 
            this.cmb프린터.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb프린터.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb프린터.FormattingEnabled = true;
            this.cmb프린터.Location = new System.Drawing.Point(79, 31);
            this.cmb프린터.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb프린터.Name = "cmb프린터";
            this.cmb프린터.Size = new System.Drawing.Size(401, 20);
            this.cmb프린터.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 70;
            this.label11.Text = "프린터";
            // 
            // cmb드라이브
            // 
            this.cmb드라이브.FormattingEnabled = true;
            this.cmb드라이브.Location = new System.Drawing.Point(79, 58);
            this.cmb드라이브.Name = "cmb드라이브";
            this.cmb드라이브.Size = new System.Drawing.Size(182, 20);
            this.cmb드라이브.TabIndex = 73;
            this.cmb드라이브.SelectedIndexChanged += new System.EventHandler(this.cmb드라이브_SelectedIndexChanged);
            this.cmb드라이브.Click += new System.EventHandler(this.cmb드라이브_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "저장폴더";
            // 
            // txt저장폴더
            // 
            this.txt저장폴더.Location = new System.Drawing.Point(274, 57);
            this.txt저장폴더.Name = "txt저장폴더";
            this.txt저장폴더.Size = new System.Drawing.Size(206, 21);
            this.txt저장폴더.TabIndex = 75;
            // 
            // frm파일_설정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(this.txt저장폴더);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb드라이브);
            this.Controls.Add(this.btn저장);
            this.Controls.Add(this.cmb프린터);
            this.Controls.Add(this.label11);
            this.Name = "frm파일_설정";
            this.Text = "설 정";
            this.Load += new System.EventHandler(this.frm파일_설정_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.ComboBox cmb프린터;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb드라이브;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt저장폴더;
    }
}