namespace assets
{
    partial class frm자산등록_자산조회
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산등록_자산조회));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb위치 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmb부서 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb품목분류 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb자산구분 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb사업장 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn조회_리스트2 = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btn바코드출력2 = new System.Windows.Forms.Button();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회_리스트 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmb위치);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.cmb부서);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmb품목분류);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmb자산구분);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmb사업장);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 55);
            this.panel1.TabIndex = 97;
            // 
            // cmb위치
            // 
            this.cmb위치.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb위치.FormattingEnabled = true;
            this.cmb위치.Location = new System.Drawing.Point(554, 12);
            this.cmb위치.Name = "cmb위치";
            this.cmb위치.Size = new System.Drawing.Size(210, 20);
            this.cmb위치.TabIndex = 101;
            this.cmb위치.SelectedIndexChanged += new System.EventHandler(this.cmb위치_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(519, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 146;
            this.label25.Text = "위치";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb부서
            // 
            this.cmb부서.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb부서.FormattingEnabled = true;
            this.cmb부서.Location = new System.Drawing.Point(324, 12);
            this.cmb부서.Name = "cmb부서";
            this.cmb부서.Size = new System.Drawing.Size(186, 20);
            this.cmb부서.TabIndex = 102;
            this.cmb부서.SelectedIndexChanged += new System.EventHandler(this.cmb부서_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 142;
            this.label12.Text = "부서";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb품목분류
            // 
            this.cmb품목분류.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb품목분류.FormattingEnabled = true;
            this.cmb품목분류.Location = new System.Drawing.Point(1055, 12);
            this.cmb품목분류.Name = "cmb품목분류";
            this.cmb품목분류.Size = new System.Drawing.Size(191, 20);
            this.cmb품목분류.TabIndex = 104;
            this.cmb품목분류.SelectedIndexChanged += new System.EventHandler(this.cmb품목분류_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(996, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 111;
            this.label10.Text = "품목분류";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb자산구분
            // 
            this.cmb자산구분.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb자산구분.FormattingEnabled = true;
            this.cmb자산구분.Location = new System.Drawing.Point(829, 12);
            this.cmb자산구분.Name = "cmb자산구분";
            this.cmb자산구분.Size = new System.Drawing.Size(161, 20);
            this.cmb자산구분.TabIndex = 103;
            this.cmb자산구분.SelectedIndexChanged += new System.EventHandler(this.cmb자산구분_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(770, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 109;
            this.label9.Text = "자산구분";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb사업장
            // 
            this.cmb사업장.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb사업장.FormattingEnabled = true;
            this.cmb사업장.Location = new System.Drawing.Point(71, 12);
            this.cmb사업장.Name = "cmb사업장";
            this.cmb사업장.Size = new System.Drawing.Size(210, 20);
            this.cmb사업장.TabIndex = 100;
            this.cmb사업장.SelectedIndexChanged += new System.EventHandler(this.cmb사업장_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "사업장";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn바코드출력2);
            this.panel2.Controls.Add(this.btn바코드출력);
            this.panel2.Controls.Add(this.txt조회);
            this.panel2.Controls.Add(this.btn초기화);
            this.panel2.Controls.Add(this.btn조회_리스트);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1499, 50);
            this.panel2.TabIndex = 96;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtp);
            this.panel4.Controls.Add(this.btn조회_리스트2);
            this.panel4.Controls.Add(this.dtp2);
            this.panel4.Location = new System.Drawing.Point(419, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 42);
            this.panel4.TabIndex = 156;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(16, 10);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(159, 21);
            this.dtp.TabIndex = 154;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btn조회_리스트2
            // 
            this.btn조회_리스트2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회_리스트2.Image = ((System.Drawing.Image)(resources.GetObject("btn조회_리스트2.Image")));
            this.btn조회_리스트2.Location = new System.Drawing.Point(383, 4);
            this.btn조회_리스트2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회_리스트2.Name = "btn조회_리스트2";
            this.btn조회_리스트2.Size = new System.Drawing.Size(102, 32);
            this.btn조회_리스트2.TabIndex = 153;
            this.btn조회_리스트2.Text = "조회 등록일";
            this.btn조회_리스트2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회_리스트2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회_리스트2.UseVisualStyleBackColor = true;
            this.btn조회_리스트2.Click += new System.EventHandler(this.btn조회_리스트2_Click);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(185, 10);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(159, 21);
            this.dtp2.TabIndex = 155;
            // 
            // btn바코드출력2
            // 
            this.btn바코드출력2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력2.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력2.Image")));
            this.btn바코드출력2.Location = new System.Drawing.Point(1161, 8);
            this.btn바코드출력2.Name = "btn바코드출력2";
            this.btn바코드출력2.Size = new System.Drawing.Size(130, 32);
            this.btn바코드출력2.TabIndex = 152;
            this.btn바코드출력2.Text = "  바코드출력(대)";
            this.btn바코드출력2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력2.UseVisualStyleBackColor = true;
            this.btn바코드출력2.Click += new System.EventHandler(this.btn바코드출력2_Click);
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(1019, 8);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(136, 32);
            this.btn바코드출력.TabIndex = 151;
            this.btn바코드출력.Text = "  바코드출력(소)";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(11, 12);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(190, 21);
            this.txt조회.TabIndex = 45;
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt조회_KeyDown);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(303, 7);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(76, 30);
            this.btn초기화.TabIndex = 40;
            this.btn초기화.Text = " 초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn조회_리스트
            // 
            this.btn조회_리스트.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회_리스트.Image = ((System.Drawing.Image)(resources.GetObject("btn조회_리스트.Image")));
            this.btn조회_리스트.Location = new System.Drawing.Point(214, 6);
            this.btn조회_리스트.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회_리스트.Name = "btn조회_리스트";
            this.btn조회_리스트.Size = new System.Drawing.Size(76, 32);
            this.btn조회_리스트.TabIndex = 39;
            this.btn조회_리스트.Text = " 조회";
            this.btn조회_리스트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회_리스트.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회_리스트.UseVisualStyleBackColor = true;
            this.btn조회_리스트.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(1397, 6);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(72, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "  닫기";
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
            this.spr.Size = new System.Drawing.Size(1499, 558);
            this.spr.TabIndex = 95;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.LeaveCell += new FarPoint.Win.Spread.LeaveCellEventHandler(this.spr_LeaveCell);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            this.spr.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellDoubleClick);
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
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).Height = 34F;
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
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1499, 558);
            this.panel3.TabIndex = 98;
            // 
            // frm자산등록_자산조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm자산등록_자산조회";
            this.Text = "자산 조회";
            this.Load += new System.EventHandler(this.frm자산등록_자산조회_Load);
            this.Resize += new System.EventHandler(this.frm자산등록_자산조회_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회_리스트;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb사업장;
        private System.Windows.Forms.ComboBox cmb자산구분;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb품목분류;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.ComboBox cmb부서;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb위치;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn바코드출력2;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn조회_리스트2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp2;
    }
}