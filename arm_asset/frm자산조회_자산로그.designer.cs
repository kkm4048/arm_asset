namespace arm_asset
{
    partial class frm자산조회_자산로그
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산조회_자산로그));
            this.panTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.chk도입년도 = new System.Windows.Forms.CheckBox();
            this.cmb자원구분 = new System.Windows.Forms.ComboBox();
            this.txt사업명 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btn부대 = new System.Windows.Forms.Button();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
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
            this.t맨위로 = new System.Windows.Forms.Timer(this.components);
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panTop.Controls.Add(this.panel1);
            this.panTop.Controls.Add(this.lblCnt);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 50);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1209, 54);
            this.panTop.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.chk도입년도);
            this.panel1.Controls.Add(this.cmb자원구분);
            this.panel1.Controls.Add(this.txt사업명);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 43);
            this.panel1.TabIndex = 149;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(272, 10);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(176, 21);
            this.dtp2.TabIndex = 72;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(91, 10);
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
            this.cmb자원구분.Location = new System.Drawing.Point(529, 11);
            this.cmb자원구분.Name = "cmb자원구분";
            this.cmb자원구분.Size = new System.Drawing.Size(138, 20);
            this.cmb자원구분.TabIndex = 69;
            this.cmb자원구분.SelectedIndexChanged += new System.EventHandler(this.cmb자원구분_SelectedIndexChanged);
            // 
            // txt사업명
            // 
            this.txt사업명.Location = new System.Drawing.Point(732, 11);
            this.txt사업명.Name = "txt사업명";
            this.txt사업명.Size = new System.Drawing.Size(231, 21);
            this.txt사업명.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 67;
            this.label5.Text = "사업명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "자원구분";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(10, 39);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 147;
            this.lblCnt.Text = "0";
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(859, 13);
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
            this.cmb소속부대.Location = new System.Drawing.Point(683, 14);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(173, 20);
            this.cmb소속부대.TabIndex = 100;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속부대_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 18);
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
            this.panTitle.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(894, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 154;
            this.button2.Text = " 엑셀 저장";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btn바코드출력2.Location = new System.Drawing.Point(1147, 7);
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
            this.btn바코드출력.Location = new System.Drawing.Point(1005, 7);
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
            this.spr.Size = new System.Drawing.Size(1209, 631);
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
            this.panLeft.Controls.Add(this.spr);
            this.panLeft.Controls.Add(this.spr2);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLeft.Location = new System.Drawing.Point(0, 104);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(1209, 631);
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
            this.panRight.Location = new System.Drawing.Point(1209, 50);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(290, 685);
            this.panRight.TabIndex = 99;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t맨위로
            // 
            this.t맨위로.Enabled = true;
            this.t맨위로.Interval = 500;
            this.t맨위로.Tick += new System.EventHandler(this.t맨위로_Tick);
            // 
            // frm자산조회_자산로그
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 735);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panTitle);
            this.Name = "frm자산조회_자산로그";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자산 로그";
            this.Load += new System.EventHandler(this.frm자산조회_자산로그_Load);
            this.Resize += new System.EventHandler(this.frm자산등록_자산등록_Resize);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
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
        private System.Windows.Forms.Timer t맨위로;
        private System.Windows.Forms.Button button2;
    }
}