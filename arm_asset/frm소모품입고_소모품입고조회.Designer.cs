namespace arm_asset
{
    partial class frm소모품입고_소모품입고조회
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm소모품입고_소모품입고조회));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn부대 = new System.Windows.Forms.Button();
            this.lblCnt0 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn출력_거래증 = new System.Windows.Forms.Button();
            this.btn출력 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spr0 = new FarPoint.Win.Spread.FpSpread();
            this.spr0_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.txt증빙번호 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt상태 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt부대2 = new System.Windows.Forms.TextBox();
            this.txt부대1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn엑셀저장 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn부대);
            this.panel1.Controls.Add(this.lblCnt0);
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.cmb소속부대);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 81);
            this.panel1.TabIndex = 100;
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(444, 39);
            this.btn부대.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn부대.Name = "btn부대";
            this.btn부대.Size = new System.Drawing.Size(24, 24);
            this.btn부대.TabIndex = 150;
            this.btn부대.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn부대.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn부대.UseVisualStyleBackColor = true;
            this.btn부대.Click += new System.EventHandler(this.btn부대_Click);
            // 
            // lblCnt0
            // 
            this.lblCnt0.AutoSize = true;
            this.lblCnt0.Location = new System.Drawing.Point(12, 66);
            this.lblCnt0.Name = "lblCnt0";
            this.lblCnt0.Size = new System.Drawing.Size(11, 12);
            this.lblCnt0.TabIndex = 105;
            this.lblCnt0.Text = "0";
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp2.Location = new System.Drawing.Point(382, 7);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(221, 26);
            this.dtp2.TabIndex = 102;
            this.dtp2.CloseUp += new System.EventHandler(this.dtp2_CloseUp);
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "일자";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp1.Location = new System.Drawing.Point(143, 7);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(221, 26);
            this.dtp1.TabIndex = 100;
            this.dtp1.CloseUp += new System.EventHandler(this.dtp1_CloseUp);
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // cmb소속부대
            // 
            this.cmb소속부대.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb소속부대.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb소속부대.FormattingEnabled = true;
            this.cmb소속부대.Location = new System.Drawing.Point(143, 39);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(292, 24);
            this.cmb소속부대.TabIndex = 10;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(95, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "부대";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 47);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn엑셀저장);
            this.panel2.Controls.Add(this.btn출력_거래증);
            this.panel2.Controls.Add(this.btn출력);
            this.panel2.Controls.Add(this.txt조회);
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
            // btn출력_거래증
            // 
            this.btn출력_거래증.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn출력_거래증.Image = ((System.Drawing.Image)(resources.GetObject("btn출력_거래증.Image")));
            this.btn출력_거래증.Location = new System.Drawing.Point(758, 10);
            this.btn출력_거래증.Name = "btn출력_거래증";
            this.btn출력_거래증.Size = new System.Drawing.Size(128, 32);
            this.btn출력_거래증.TabIndex = 149;
            this.btn출력_거래증.Text = "   거래증 출력";
            this.btn출력_거래증.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn출력_거래증.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn출력_거래증.UseVisualStyleBackColor = true;
            this.btn출력_거래증.Click += new System.EventHandler(this.btn출력_거래증_Click);
            // 
            // btn출력
            // 
            this.btn출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn출력.Image = ((System.Drawing.Image)(resources.GetObject("btn출력.Image")));
            this.btn출력.Location = new System.Drawing.Point(563, 9);
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
            this.txt조회.Location = new System.Drawing.Point(170, 15);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(178, 21);
            this.txt조회.TabIndex = 45;
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(358, 10);
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
            this.btn조회.Location = new System.Drawing.Point(87, 9);
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
            this.btn닫기.Location = new System.Drawing.Point(14, 9);
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
            this.spr.Location = new System.Drawing.Point(0, 70);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1007, 463);
            this.spr.TabIndex = 98;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1487, 533);
            this.panel3.TabIndex = 101;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spr0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spr);
            this.splitContainer1.Panel2.Controls.Add(this.pan데이타);
            this.splitContainer1.Size = new System.Drawing.Size(1487, 533);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 99;
            // 
            // spr0
            // 
            this.spr0.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr0.Location = new System.Drawing.Point(0, 0);
            this.spr0.Name = "spr0";
            this.spr0.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr0_Sheet1});
            this.spr0.Size = new System.Drawing.Size(476, 533);
            this.spr0.TabIndex = 99;
            this.spr0.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr0_ColumnWidthChanged);
            this.spr0.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr0_CellClick);
            // 
            // spr0_Sheet1
            // 
            this.spr0_Sheet1.Reset();
            spr0_Sheet1.SheetName = "Sheet0";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr0_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr0_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr0_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr0_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr0_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan데이타
            // 
            this.pan데이타.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan데이타.Controls.Add(this.txt증빙번호);
            this.pan데이타.Controls.Add(this.label8);
            this.pan데이타.Controls.Add(this.txt상태);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.txt부대2);
            this.pan데이타.Controls.Add(this.txt부대1);
            this.pan데이타.Controls.Add(this.label6);
            this.pan데이타.Controls.Add(this.label5);
            this.pan데이타.Controls.Add(this.dtp);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 0);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(1007, 70);
            this.pan데이타.TabIndex = 99;
            // 
            // txt증빙번호
            // 
            this.txt증빙번호.Enabled = false;
            this.txt증빙번호.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt증빙번호.Location = new System.Drawing.Point(562, 7);
            this.txt증빙번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt증빙번호.MaxLength = 0;
            this.txt증빙번호.Name = "txt증빙번호";
            this.txt증빙번호.Size = new System.Drawing.Size(137, 26);
            this.txt증빙번호.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(480, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = "증빙번호";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt상태
            // 
            this.txt상태.Enabled = false;
            this.txt상태.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt상태.Location = new System.Drawing.Point(366, 7);
            this.txt상태.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt상태.MaxLength = 0;
            this.txt상태.Name = "txt상태";
            this.txt상태.Size = new System.Drawing.Size(109, 26);
            this.txt상태.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(318, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "상태";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt부대2
            // 
            this.txt부대2.Enabled = false;
            this.txt부대2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt부대2.Location = new System.Drawing.Point(628, 35);
            this.txt부대2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt부대2.MaxLength = 0;
            this.txt부대2.Name = "txt부대2";
            this.txt부대2.Size = new System.Drawing.Size(238, 26);
            this.txt부대2.TabIndex = 107;
            this.txt부대2.TextChanged += new System.EventHandler(this.txt부대2_TextChanged);
            // 
            // txt부대1
            // 
            this.txt부대1.Enabled = false;
            this.txt부대1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt부대1.Location = new System.Drawing.Point(366, 35);
            this.txt부대1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt부대1.MaxLength = 0;
            this.txt부대1.Name = "txt부대1";
            this.txt부대1.Size = new System.Drawing.Size(238, 26);
            this.txt부대1.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(318, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "부대";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(35, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "일자";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp.Location = new System.Drawing.Point(83, 3);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(221, 26);
            this.dtp.TabIndex = 102;
            // 
            // btn엑셀저장
            // 
            this.btn엑셀저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀저장.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀저장.Image")));
            this.btn엑셀저장.Location = new System.Drawing.Point(898, 10);
            this.btn엑셀저장.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀저장.Name = "btn엑셀저장";
            this.btn엑셀저장.Size = new System.Drawing.Size(96, 31);
            this.btn엑셀저장.TabIndex = 156;
            this.btn엑셀저장.Text = " 엑셀 저장";
            this.btn엑셀저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀저장.UseVisualStyleBackColor = true;
            this.btn엑셀저장.Click += new System.EventHandler(this.btn엑셀저장_Click);
            // 
            // frm소모품입고_소모품입고조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm소모품입고_소모품입고조회";
            this.Text = "소모품 입고 조회";
            this.Activated += new System.EventHandler(this.frm소모품입고_소모품입고조회_Activated);
            this.Load += new System.EventHandler(this.frm소모품입고_소모품입고조회_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).EndInit();
            this.pan데이타.ResumeLayout(false);
            this.pan데이타.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb소속부대;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btn출력;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button btn출력_거래증;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FarPoint.Win.Spread.FpSpread spr0;
        private FarPoint.Win.Spread.SheetView spr0_Sheet1;
        private System.Windows.Forms.Panel pan데이타;
        private System.Windows.Forms.Label lblCnt0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txt상태;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt부대2;
        private System.Windows.Forms.TextBox txt부대1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn부대;
        private System.Windows.Forms.TextBox txt증빙번호;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn엑셀저장;
    }
}