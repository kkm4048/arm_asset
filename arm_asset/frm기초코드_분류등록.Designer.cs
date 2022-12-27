namespace arm_asset
{
    partial class frm기초코드_분류등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초코드_분류등록));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan대분류 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.btn삭제2 = new System.Windows.Forms.Button();
            this.btn등록2 = new System.Windows.Forms.Button();
            this.btn수정2 = new System.Windows.Forms.Button();
            this.btn초기화2 = new System.Windows.Forms.Button();
            this.btn조회2 = new System.Windows.Forms.Button();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan대분류.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn삭제);
            this.panel1.Controls.Add(this.lblCnt);
            this.panel1.Controls.Add(this.btn등록);
            this.panel1.Controls.Add(this.btn수정);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn초기화);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.btn조회);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 148);
            this.panel1.TabIndex = 97;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 123);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(74, 34);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(204, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "대분류명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(74, 8);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(153, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "대분류코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 50);
            this.panel2.TabIndex = 96;
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(390, 100);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(75, 32);
            this.btn삭제.TabIndex = 43;
            this.btn삭제.Text = "    삭 제";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // btn등록
            // 
            this.btn등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록.Image = ((System.Drawing.Image)(resources.GetObject("btn등록.Image")));
            this.btn등록.Location = new System.Drawing.Point(228, 100);
            this.btn등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(75, 32);
            this.btn등록.TabIndex = 42;
            this.btn등록.Text = "    등 록";
            this.btn등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(309, 100);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(75, 32);
            this.btn수정.TabIndex = 41;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(51, 100);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(90, 32);
            this.btn초기화.TabIndex = 40;
            this.btn초기화.Text = "   초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(147, 100);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "    조 회";
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
            this.btn닫기.Size = new System.Drawing.Size(90, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "    닫 기";
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
            this.spr.Size = new System.Drawing.Size(487, 362);
            this.spr.TabIndex = 95;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
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
            // pan대분류
            // 
            this.pan대분류.Controls.Add(this.panel5);
            this.pan대분류.Controls.Add(this.panel1);
            this.pan대분류.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan대분류.Location = new System.Drawing.Point(0, 50);
            this.pan대분류.Name = "pan대분류";
            this.pan대분류.Size = new System.Drawing.Size(487, 510);
            this.pan대분류.TabIndex = 99;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.spr);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(487, 362);
            this.panel5.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(487, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 510);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.spr2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 362);
            this.panel4.TabIndex = 99;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 0);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(530, 362);
            this.spr2.TabIndex = 95;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txt24);
            this.panel6.Controls.Add(this.txt23);
            this.panel6.Controls.Add(this.btn삭제2);
            this.panel6.Controls.Add(this.btn등록2);
            this.panel6.Controls.Add(this.btn수정2);
            this.panel6.Controls.Add(this.btn초기화2);
            this.panel6.Controls.Add(this.btn조회2);
            this.panel6.Controls.Add(this.txt22);
            this.panel6.Controls.Add(this.txt21);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.lblCnt2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 148);
            this.panel6.TabIndex = 97;
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(16, 123);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 109;
            this.label4.Text = "소분류명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 108;
            this.label5.Text = "소분류코드";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 105;
            this.label12.Text = "대분류명";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 104;
            this.label13.Text = "대분류코드";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt21
            // 
            this.txt21.Enabled = false;
            this.txt21.Location = new System.Drawing.Point(105, 5);
            this.txt21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt21.MaxLength = 0;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(95, 21);
            this.txt21.TabIndex = 110;
            // 
            // txt22
            // 
            this.txt22.Enabled = false;
            this.txt22.Location = new System.Drawing.Point(265, 2);
            this.txt22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt22.MaxLength = 0;
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(197, 21);
            this.txt22.TabIndex = 111;
            // 
            // btn삭제2
            // 
            this.btn삭제2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제2.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제2.Image")));
            this.btn삭제2.Location = new System.Drawing.Point(408, 100);
            this.btn삭제2.Name = "btn삭제2";
            this.btn삭제2.Size = new System.Drawing.Size(75, 32);
            this.btn삭제2.TabIndex = 116;
            this.btn삭제2.Text = "    삭 제";
            this.btn삭제2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제2.UseVisualStyleBackColor = true;
            this.btn삭제2.Click += new System.EventHandler(this.btn삭제2_Click);
            // 
            // btn등록2
            // 
            this.btn등록2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록2.Image = ((System.Drawing.Image)(resources.GetObject("btn등록2.Image")));
            this.btn등록2.Location = new System.Drawing.Point(246, 100);
            this.btn등록2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록2.Name = "btn등록2";
            this.btn등록2.Size = new System.Drawing.Size(75, 32);
            this.btn등록2.TabIndex = 115;
            this.btn등록2.Text = "    등 록";
            this.btn등록2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록2.UseVisualStyleBackColor = true;
            this.btn등록2.Click += new System.EventHandler(this.btn등록2_Click);
            // 
            // btn수정2
            // 
            this.btn수정2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정2.Image = ((System.Drawing.Image)(resources.GetObject("btn수정2.Image")));
            this.btn수정2.Location = new System.Drawing.Point(327, 100);
            this.btn수정2.Name = "btn수정2";
            this.btn수정2.Size = new System.Drawing.Size(75, 32);
            this.btn수정2.TabIndex = 114;
            this.btn수정2.Text = "    수 정";
            this.btn수정2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정2.UseVisualStyleBackColor = true;
            this.btn수정2.Click += new System.EventHandler(this.btn수정2_Click);
            // 
            // btn초기화2
            // 
            this.btn초기화2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화2.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화2.Image")));
            this.btn초기화2.Location = new System.Drawing.Point(69, 100);
            this.btn초기화2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화2.Name = "btn초기화2";
            this.btn초기화2.Size = new System.Drawing.Size(90, 32);
            this.btn초기화2.TabIndex = 113;
            this.btn초기화2.Text = "   초기화";
            this.btn초기화2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화2.UseVisualStyleBackColor = true;
            this.btn초기화2.Click += new System.EventHandler(this.btn초기화2_Click);
            // 
            // btn조회2
            // 
            this.btn조회2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회2.Image = ((System.Drawing.Image)(resources.GetObject("btn조회2.Image")));
            this.btn조회2.Location = new System.Drawing.Point(165, 100);
            this.btn조회2.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회2.Name = "btn조회2";
            this.btn조회2.Size = new System.Drawing.Size(75, 32);
            this.btn조회2.TabIndex = 112;
            this.btn조회2.Text = "    조 회";
            this.btn조회2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회2.UseVisualStyleBackColor = true;
            this.btn조회2.Click += new System.EventHandler(this.btn조회2_Click);
            // 
            // txt23
            // 
            this.txt23.Location = new System.Drawing.Point(106, 34);
            this.txt23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt23.MaxLength = 0;
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(94, 21);
            this.txt23.TabIndex = 117;
            this.txt23.Enter += new System.EventHandler(this.txt_Enter);
            this.txt23.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt24
            // 
            this.txt24.Location = new System.Drawing.Point(106, 63);
            this.txt24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt24.MaxLength = 0;
            this.txt24.Name = "txt24";
            this.txt24.Size = new System.Drawing.Size(215, 21);
            this.txt24.TabIndex = 118;
            this.txt24.Enter += new System.EventHandler(this.txt_Enter);
            this.txt24.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // frm기초코드_분류등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pan대분류);
            this.Controls.Add(this.panel2);
            this.Name = "frm기초코드_분류등록";
            this.Text = "분류 등록";
            this.Load += new System.EventHandler(this.frm기초코드_분류등록_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan대분류.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan대분류;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.Button btn삭제2;
        private System.Windows.Forms.Button btn등록2;
        private System.Windows.Forms.Button btn수정2;
        private System.Windows.Forms.Button btn초기화2;
        private System.Windows.Forms.Button btn조회2;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt23;
    }
}