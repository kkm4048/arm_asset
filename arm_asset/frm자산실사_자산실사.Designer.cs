namespace arm_asset
{
    partial class frm자산실사_자산실사
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산실사_자산실사));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn부대 = new System.Windows.Forms.Button();
            this.chk자동저장 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.chk취소 = new System.Windows.Forms.CheckBox();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDRIMS생성 = new System.Windows.Forms.Button();
            this.btn실사데이타다운로드 = new System.Windows.Forms.Button();
            this.btn데이타다운로드 = new System.Windows.Forms.Button();
            this.btn출력 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn실사반영 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn부대);
            this.panel1.Controls.Add(this.chk자동저장);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.chk취소);
            this.panel1.Controls.Add(this.cmb소속부대);
            this.panel1.Controls.Add(this.lblCnt);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 81);
            this.panel1.TabIndex = 100;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(804, 6);
            this.btn부대.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn부대.Name = "btn부대";
            this.btn부대.Size = new System.Drawing.Size(24, 24);
            this.btn부대.TabIndex = 151;
            this.btn부대.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn부대.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn부대.UseVisualStyleBackColor = true;
            this.btn부대.Click += new System.EventHandler(this.btn부대_Click);
            // 
            // chk자동저장
            // 
            this.chk자동저장.AutoSize = true;
            this.chk자동저장.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk자동저장.Location = new System.Drawing.Point(580, 45);
            this.chk자동저장.Name = "chk자동저장";
            this.chk자동저장.Size = new System.Drawing.Size(95, 20);
            this.chk자동저장.TabIndex = 107;
            this.chk자동저장.Text = "자동저장";
            this.chk자동저장.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(72, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "실사일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp.Location = new System.Drawing.Point(144, 7);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(221, 26);
            this.dtp.TabIndex = 100;
            this.dtp.CloseUp += new System.EventHandler(this.dtp_CloseUp);
            // 
            // chk취소
            // 
            this.chk취소.AutoSize = true;
            this.chk취소.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk취소.Location = new System.Drawing.Point(479, 46);
            this.chk취소.Name = "chk취소";
            this.chk취소.Size = new System.Drawing.Size(67, 20);
            this.chk취소.TabIndex = 99;
            this.chk취소.Text = "취 소";
            this.chk취소.UseVisualStyleBackColor = true;
            this.chk취소.CheckedChanged += new System.EventHandler(this.chk취소_CheckedChanged);
            // 
            // cmb소속부대
            // 
            this.cmb소속부대.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb소속부대.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb소속부대.FormattingEnabled = true;
            this.cmb소속부대.Location = new System.Drawing.Point(510, 6);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(292, 24);
            this.cmb소속부대.TabIndex = 10;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속_SelectedIndexChanged);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 54);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt1.Location = new System.Drawing.Point(144, 43);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(292, 26);
            this.txt1.TabIndex = 96;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyDown);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "자산번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "소속부대";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDRIMS생성);
            this.panel2.Controls.Add(this.btn실사데이타다운로드);
            this.panel2.Controls.Add(this.btn데이타다운로드);
            this.panel2.Controls.Add(this.btn출력);
            this.panel2.Controls.Add(this.txt조회);
            this.panel2.Controls.Add(this.btn삭제);
            this.panel2.Controls.Add(this.btn실사반영);
            this.panel2.Controls.Add(this.btn초기화);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1487, 50);
            this.panel2.TabIndex = 99;
            // 
            // btnDRIMS생성
            // 
            this.btnDRIMS생성.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDRIMS생성.Image = ((System.Drawing.Image)(resources.GetObject("btnDRIMS생성.Image")));
            this.btnDRIMS생성.Location = new System.Drawing.Point(1048, 10);
            this.btnDRIMS생성.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDRIMS생성.Name = "btnDRIMS생성";
            this.btnDRIMS생성.Size = new System.Drawing.Size(190, 32);
            this.btnDRIMS생성.TabIndex = 155;
            this.btnDRIMS생성.Text = "   DRIMS 업로드 생성";
            this.btnDRIMS생성.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDRIMS생성.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDRIMS생성.UseVisualStyleBackColor = true;
            // 
            // btn실사데이타다운로드
            // 
            this.btn실사데이타다운로드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn실사데이타다운로드.Image = ((System.Drawing.Image)(resources.GetObject("btn실사데이타다운로드.Image")));
            this.btn실사데이타다운로드.Location = new System.Drawing.Point(685, 10);
            this.btn실사데이타다운로드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn실사데이타다운로드.Name = "btn실사데이타다운로드";
            this.btn실사데이타다운로드.Size = new System.Drawing.Size(190, 32);
            this.btn실사데이타다운로드.TabIndex = 154;
            this.btn실사데이타다운로드.Text = "   실사데이타 가져오기";
            this.btn실사데이타다운로드.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn실사데이타다운로드.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn실사데이타다운로드.UseVisualStyleBackColor = true;
            this.btn실사데이타다운로드.Click += new System.EventHandler(this.btn실사데이타다운로드_Click);
            // 
            // btn데이타다운로드
            // 
            this.btn데이타다운로드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn데이타다운로드.Image = ((System.Drawing.Image)(resources.GetObject("btn데이타다운로드.Image")));
            this.btn데이타다운로드.Location = new System.Drawing.Point(468, 10);
            this.btn데이타다운로드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn데이타다운로드.Name = "btn데이타다운로드";
            this.btn데이타다운로드.Size = new System.Drawing.Size(211, 32);
            this.btn데이타다운로드.TabIndex = 153;
            this.btn데이타다운로드.Text = "   사용자/부대/자산 다운로드";
            this.btn데이타다운로드.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn데이타다운로드.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn데이타다운로드.UseVisualStyleBackColor = true;
            this.btn데이타다운로드.Click += new System.EventHandler(this.btn데이타다운로드_Click);
            // 
            // btn출력
            // 
            this.btn출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn출력.Image = ((System.Drawing.Image)(resources.GetObject("btn출력.Image")));
            this.btn출력.Location = new System.Drawing.Point(1256, 10);
            this.btn출력.Name = "btn출력";
            this.btn출력.Size = new System.Drawing.Size(114, 32);
            this.btn출력.TabIndex = 148;
            this.btn출력.Text = "  출 력";
            this.btn출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn출력.UseVisualStyleBackColor = true;
            this.btn출력.Click += new System.EventHandler(this.btn출력_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(167, 16);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(178, 21);
            this.txt조회.TabIndex = 45;
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(1398, 7);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(76, 30);
            this.btn삭제.TabIndex = 43;
            this.btn삭제.Text = "    삭 제";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Visible = false;
            // 
            // btn실사반영
            // 
            this.btn실사반영.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn실사반영.Image = ((System.Drawing.Image)(resources.GetObject("btn실사반영.Image")));
            this.btn실사반영.Location = new System.Drawing.Point(896, 11);
            this.btn실사반영.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn실사반영.Name = "btn실사반영";
            this.btn실사반영.Size = new System.Drawing.Size(131, 30);
            this.btn실사반영.TabIndex = 42;
            this.btn실사반영.Text = "    실사반영";
            this.btn실사반영.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn실사반영.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn실사반영.UseVisualStyleBackColor = true;
            this.btn실사반영.Click += new System.EventHandler(this.btn실사반영_Click);
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(355, 11);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(76, 30);
            this.btn초기화.TabIndex = 40;
            this.btn초기화.Text = "  초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(84, 9);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(70, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "   조회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(11, 9);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(69, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "   닫기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 0);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1487, 533);
            this.spr.TabIndex = 98;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.spr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1487, 533);
            this.panel3.TabIndex = 101;
            // 
            // frm자산실사_자산실사
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm자산실사_자산실사";
            this.Text = "자산실사";
            this.Activated += new System.EventHandler(this.frm자산실사_자산실사_Activated);
            this.Load += new System.EventHandler(this.frm자산실사_자산실사_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb소속부대;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn실사반영;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chk취소;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn출력;
        private System.Windows.Forms.CheckBox chk자동저장;
        private System.Windows.Forms.Button btn데이타다운로드;
        private System.Windows.Forms.Button btn실사데이타다운로드;
        private System.Windows.Forms.Button btnDRIMS생성;
        private System.Windows.Forms.Button btn부대;
    }
}