namespace arm_asset
{
    partial class frm자산조회_자산상세조회
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산조회_자산상세조회));
            this.panTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblCnt = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.chk도입년도 = new System.Windows.Forms.CheckBox();
            this.cmb자원구분 = new System.Windows.Forms.ComboBox();
            this.txt사업명 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn부대 = new System.Windows.Forms.Button();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.btn바코드출력2 = new System.Windows.Forms.Button();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn조회 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panLeft = new System.Windows.Forms.Panel();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panRight = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pan상세조회 = new System.Windows.Forms.Panel();
            this.spr0 = new FarPoint.Win.Spread.FpSpread();
            this.spr0_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan상세조회_top = new System.Windows.Forms.Panel();
            this.lblCnt0 = new System.Windows.Forms.Label();
            this.txt자산번호 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan자산 = new System.Windows.Forms.Panel();
            this.btn엑셀저장 = new System.Windows.Forms.Button();
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.pan상세조회.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).BeginInit();
            this.pan상세조회_top.SuspendLayout();
            this.pan자산.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTop.Controls.Add(this.panel1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(554, 54);
            this.panTop.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Controls.Add(this.lblCnt);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.chk도입년도);
            this.panel1.Controls.Add(this.cmb자원구분);
            this.panel1.Controls.Add(this.txt사업명);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 52);
            this.panel1.TabIndex = 149;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(90, 26);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(176, 21);
            this.dtp2.TabIndex = 72;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(11, 38);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 147;
            this.lblCnt.Text = "0";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(90, 5);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(176, 21);
            this.dtp1.TabIndex = 71;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // chk도입년도
            // 
            this.chk도입년도.AutoSize = true;
            this.chk도입년도.Location = new System.Drawing.Point(13, 12);
            this.chk도입년도.Name = "chk도입년도";
            this.chk도입년도.Size = new System.Drawing.Size(72, 16);
            this.chk도입년도.TabIndex = 70;
            this.chk도입년도.Text = "도입년도";
            this.chk도입년도.UseVisualStyleBackColor = true;
            this.chk도입년도.CheckedChanged += new System.EventHandler(this.chk도입년도_CheckedChanged);
            // 
            // cmb자원구분
            // 
            this.cmb자원구분.FormattingEnabled = true;
            this.cmb자원구분.Location = new System.Drawing.Point(340, 5);
            this.cmb자원구분.Name = "cmb자원구분";
            this.cmb자원구분.Size = new System.Drawing.Size(138, 20);
            this.cmb자원구분.TabIndex = 69;
            this.cmb자원구분.SelectedIndexChanged += new System.EventHandler(this.cmb자원구분_SelectedIndexChanged);
            // 
            // txt사업명
            // 
            this.txt사업명.Location = new System.Drawing.Point(543, 5);
            this.txt사업명.Name = "txt사업명";
            this.txt사업명.Size = new System.Drawing.Size(216, 21);
            this.txt사업명.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 67;
            this.label5.Text = "사업명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "자원구분";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(862, 13);
            this.btn부대.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn부대.Name = "btn부대";
            this.btn부대.Size = new System.Drawing.Size(20, 20);
            this.btn부대.TabIndex = 148;
            this.btn부대.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn부대.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn부대.UseVisualStyleBackColor = true;
            this.btn부대.Click += new System.EventHandler(this.btn부대_Click);
            // 
            // cmb소속부대
            // 
            this.cmb소속부대.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb소속부대.FormattingEnabled = true;
            this.cmb소속부대.Location = new System.Drawing.Point(686, 14);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(173, 20);
            this.cmb소속부대.TabIndex = 100;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속부대_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "설치부대";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.White;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTitle.Controls.Add(this.btn닫기);
            this.panTitle.Controls.Add(this.btn부대);
            this.panTitle.Controls.Add(this.btn바코드출력2);
            this.panTitle.Controls.Add(this.btn바코드출력);
            this.panTitle.Controls.Add(this.cmb소속부대);
            this.panTitle.Controls.Add(this.dtp);
            this.panTitle.Controls.Add(this.label3);
            this.panTitle.Controls.Add(this.button1);
            this.panTitle.Controls.Add(this.txt조회);
            this.panTitle.Controls.Add(this.btn조회);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1499, 50);
            this.panTitle.TabIndex = 96;
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(3, 7);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(93, 33);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "  닫기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // btn바코드출력2
            // 
            this.btn바코드출력2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력2.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력2.Image")));
            this.btn바코드출력2.Location = new System.Drawing.Point(1199, 7);
            this.btn바코드출력2.Name = "btn바코드출력2";
            this.btn바코드출력2.Size = new System.Drawing.Size(130, 32);
            this.btn바코드출력2.TabIndex = 150;
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
            this.btn바코드출력.Location = new System.Drawing.Point(1057, 7);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(136, 32);
            this.btn바코드출력.TabIndex = 147;
            this.btn바코드출력.Text = "  바코드출력(소)";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(341, 13);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(159, 21);
            this.dtp.TabIndex = 47;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(513, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "조회 등록일";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(116, 13);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(136, 21);
            this.txt조회.TabIndex = 45;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt조회_KeyDown);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(265, 7);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(63, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = " 조회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 0);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(552, 629);
            this.spr.TabIndex = 95;
            this.spr.EditModeOff += new System.EventHandler(this.spr_EditModeOff);
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
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
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
            this.spr_Sheet1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panLeft
            // 
            this.panLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLeft.Controls.Add(this.spr);
            this.panLeft.Controls.Add(this.spr2);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLeft.Location = new System.Drawing.Point(0, 54);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(554, 631);
            this.panLeft.TabIndex = 98;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Location = new System.Drawing.Point(397, 70);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(487, 325);
            this.spr2.TabIndex = 96;
            this.spr2.Visible = false;
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.Rows.Get(0).Height = 34F;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.White;
            this.panRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(554, 0);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(290, 685);
            this.panRight.TabIndex = 99;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pan상세조회
            // 
            this.pan상세조회.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan상세조회.Controls.Add(this.spr0);
            this.pan상세조회.Controls.Add(this.pan상세조회_top);
            this.pan상세조회.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan상세조회.Location = new System.Drawing.Point(0, 50);
            this.pan상세조회.Name = "pan상세조회";
            this.pan상세조회.Size = new System.Drawing.Size(655, 685);
            this.pan상세조회.TabIndex = 100;
            // 
            // spr0
            // 
            this.spr0.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr0.Location = new System.Drawing.Point(0, 56);
            this.spr0.Name = "spr0";
            this.spr0.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr0_Sheet1});
            this.spr0.Size = new System.Drawing.Size(653, 627);
            this.spr0.TabIndex = 96;
            this.spr0.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr0_ColumnWidthChanged);
            // 
            // spr0_Sheet1
            // 
            this.spr0_Sheet1.Reset();
            spr0_Sheet1.SheetName = "Sheet0";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr0_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr0_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr0_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.ColumnHeader.Rows.Get(0).Height = 34F;
            this.spr0_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr0_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr0_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr0_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr0_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan상세조회_top
            // 
            this.pan상세조회_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan상세조회_top.Controls.Add(this.btn엑셀저장);
            this.pan상세조회_top.Controls.Add(this.lblCnt0);
            this.pan상세조회_top.Controls.Add(this.txt자산번호);
            this.pan상세조회_top.Controls.Add(this.label1);
            this.pan상세조회_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan상세조회_top.Location = new System.Drawing.Point(0, 0);
            this.pan상세조회_top.Name = "pan상세조회_top";
            this.pan상세조회_top.Size = new System.Drawing.Size(653, 56);
            this.pan상세조회_top.TabIndex = 0;
            // 
            // lblCnt0
            // 
            this.lblCnt0.AutoSize = true;
            this.lblCnt0.Location = new System.Drawing.Point(10, 38);
            this.lblCnt0.Name = "lblCnt0";
            this.lblCnt0.Size = new System.Drawing.Size(11, 12);
            this.lblCnt0.TabIndex = 148;
            this.lblCnt0.Text = "0";
            // 
            // txt자산번호
            // 
            this.txt자산번호.Location = new System.Drawing.Point(69, 16);
            this.txt자산번호.Name = "txt자산번호";
            this.txt자산번호.Size = new System.Drawing.Size(149, 21);
            this.txt자산번호.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "자산번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pan자산
            // 
            this.pan자산.Controls.Add(this.panLeft);
            this.pan자산.Controls.Add(this.panTop);
            this.pan자산.Controls.Add(this.panRight);
            this.pan자산.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan자산.Location = new System.Drawing.Point(655, 50);
            this.pan자산.Name = "pan자산";
            this.pan자산.Size = new System.Drawing.Size(844, 685);
            this.pan자산.TabIndex = 101;
            // 
            // btn엑셀저장
            // 
            this.btn엑셀저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀저장.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀저장.Image")));
            this.btn엑셀저장.Location = new System.Drawing.Point(295, 13);
            this.btn엑셀저장.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀저장.Name = "btn엑셀저장";
            this.btn엑셀저장.Size = new System.Drawing.Size(96, 31);
            this.btn엑셀저장.TabIndex = 155;
            this.btn엑셀저장.Text = " 엑셀 저장";
            this.btn엑셀저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀저장.UseVisualStyleBackColor = true;
            this.btn엑셀저장.Click += new System.EventHandler(this.btn엑셀저장_Click);
            // 
            // frm자산조회_자산상세조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 735);
            this.Controls.Add(this.pan자산);
            this.Controls.Add(this.pan상세조회);
            this.Controls.Add(this.panTitle);
            this.Name = "frm자산조회_자산상세조회";
            this.Text = "자산 상세 조회";
            this.Load += new System.EventHandler(this.frm자산조회_자산상세조회_Load);
            this.Resize += new System.EventHandler(this.frm자산등록_자산등록_Resize);
            this.panTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.pan상세조회.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).EndInit();
            this.pan상세조회_top.ResumeLayout(false);
            this.pan상세조회_top.PerformLayout();
            this.pan자산.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.ComboBox cmb소속부대;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.Button btn바코드출력2;
        private System.Windows.Forms.Panel panRight;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn부대;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt사업명;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb자원구분;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.CheckBox chk도입년도;
        private System.Windows.Forms.Panel pan상세조회;
        private FarPoint.Win.Spread.FpSpread spr0;
        private FarPoint.Win.Spread.SheetView spr0_Sheet1;
        private System.Windows.Forms.Panel pan상세조회_top;
        private System.Windows.Forms.Panel pan자산;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt자산번호;
        private System.Windows.Forms.Label lblCnt0;
        private System.Windows.Forms.Button btn엑셀저장;
    }
}