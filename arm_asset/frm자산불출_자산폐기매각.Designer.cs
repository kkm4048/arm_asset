namespace arm_asset
{
    partial class frm자산불출_자산폐기매각
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산불출_자산폐기매각));
            this.pan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb상태 = new System.Windows.Forms.ComboBox();
            this.btn선택폐기취소 = new System.Windows.Forms.Button();
            this.btn선택폐기 = new System.Windows.Forms.Button();
            this.txt반납관 = new System.Windows.Forms.TextBox();
            this.txt출납관 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl선택수량 = new System.Windows.Forms.Label();
            this.btn부대 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.chk취소 = new System.Windows.Forms.CheckBox();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn출력_거래증 = new System.Windows.Forms.Button();
            this.btn출력 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.spr0 = new FarPoint.Win.Spread.FpSpread();
            this.spr0_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan0 = new System.Windows.Forms.Panel();
            this.lblCnt0 = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t초기화 = new System.Windows.Forms.Timer(this.components);
            this.pan.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).BeginInit();
            this.pan0.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan.Controls.Add(this.label7);
            this.pan.Controls.Add(this.cmb상태);
            this.pan.Controls.Add(this.btn선택폐기취소);
            this.pan.Controls.Add(this.btn선택폐기);
            this.pan.Controls.Add(this.txt반납관);
            this.pan.Controls.Add(this.txt출납관);
            this.pan.Controls.Add(this.label5);
            this.pan.Controls.Add(this.label4);
            this.pan.Controls.Add(this.lbl선택수량);
            this.pan.Controls.Add(this.btn부대);
            this.pan.Controls.Add(this.label2);
            this.pan.Controls.Add(this.dtp);
            this.pan.Controls.Add(this.chk취소);
            this.pan.Controls.Add(this.cmb소속부대);
            this.pan.Controls.Add(this.lblCnt);
            this.pan.Controls.Add(this.txt1);
            this.pan.Controls.Add(this.label1);
            this.pan.Controls.Add(this.label3);
            this.pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(986, 99);
            this.pan.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(704, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 160;
            this.label7.Text = "상태";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb상태
            // 
            this.cmb상태.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb상태.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb상태.FormattingEnabled = true;
            this.cmb상태.Location = new System.Drawing.Point(704, 69);
            this.cmb상태.Name = "cmb상태";
            this.cmb상태.Size = new System.Drawing.Size(125, 24);
            this.cmb상태.TabIndex = 159;
            this.cmb상태.SelectedIndexChanged += new System.EventHandler(this.cmb상태_SelectedIndexChanged);
            // 
            // btn선택폐기취소
            // 
            this.btn선택폐기취소.BackColor = System.Drawing.Color.MistyRose;
            this.btn선택폐기취소.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn선택폐기취소.Image = ((System.Drawing.Image)(resources.GetObject("btn선택폐기취소.Image")));
            this.btn선택폐기취소.Location = new System.Drawing.Point(835, 53);
            this.btn선택폐기취소.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn선택폐기취소.Name = "btn선택폐기취소";
            this.btn선택폐기취소.Size = new System.Drawing.Size(148, 37);
            this.btn선택폐기취소.TabIndex = 158;
            this.btn선택폐기취소.Text = "선택 폐기/매각 취소";
            this.btn선택폐기취소.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn선택폐기취소.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn선택폐기취소.UseVisualStyleBackColor = false;
            this.btn선택폐기취소.Click += new System.EventHandler(this.btn선택폐기취소_Click);
            // 
            // btn선택폐기
            // 
            this.btn선택폐기.BackColor = System.Drawing.Color.Linen;
            this.btn선택폐기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn선택폐기.Image = ((System.Drawing.Image)(resources.GetObject("btn선택폐기.Image")));
            this.btn선택폐기.Location = new System.Drawing.Point(835, 4);
            this.btn선택폐기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn선택폐기.Name = "btn선택폐기";
            this.btn선택폐기.Size = new System.Drawing.Size(148, 37);
            this.btn선택폐기.TabIndex = 157;
            this.btn선택폐기.Text = "   선택 폐기/매각";
            this.btn선택폐기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn선택폐기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn선택폐기.UseVisualStyleBackColor = false;
            this.btn선택폐기.Click += new System.EventHandler(this.btn선택폐기_Click);
            // 
            // txt반납관
            // 
            this.txt반납관.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt반납관.Location = new System.Drawing.Point(406, 68);
            this.txt반납관.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt반납관.MaxLength = 0;
            this.txt반납관.Name = "txt반납관";
            this.txt반납관.Size = new System.Drawing.Size(292, 26);
            this.txt반납관.TabIndex = 156;
            // 
            // txt출납관
            // 
            this.txt출납관.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt출납관.Location = new System.Drawing.Point(406, 38);
            this.txt출납관.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt출납관.MaxLength = 0;
            this.txt출납관.Name = "txt출납관";
            this.txt출납관.Size = new System.Drawing.Size(292, 26);
            this.txt출납관.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(296, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 154;
            this.label5.Text = "수령및반납관";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(347, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 153;
            this.label4.Text = "출납관";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl선택수량
            // 
            this.lbl선택수량.AutoSize = true;
            this.lbl선택수량.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl선택수량.ForeColor = System.Drawing.Color.Red;
            this.lbl선택수량.Location = new System.Drawing.Point(159, 80);
            this.lbl선택수량.Name = "lbl선택수량";
            this.lbl선택수량.Size = new System.Drawing.Size(15, 13);
            this.lbl선택수량.TabIndex = 152;
            this.lbl선택수량.Text = "0";
            this.lbl선택수량.Click += new System.EventHandler(this.lbl선택수량_Click);
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(699, 8);
            this.btn부대.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn부대.Name = "btn부대";
            this.btn부대.Size = new System.Drawing.Size(24, 24);
            this.btn부대.TabIndex = 149;
            this.btn부대.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn부대.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn부대.UseVisualStyleBackColor = true;
            this.btn부대.Visible = false;
            this.btn부대.Click += new System.EventHandler(this.btn부대_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "불출일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp.Location = new System.Drawing.Point(93, 7);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(221, 26);
            this.dtp.TabIndex = 100;
            this.dtp.CloseUp += new System.EventHandler(this.dtp_CloseUp);
            // 
            // chk취소
            // 
            this.chk취소.AutoSize = true;
            this.chk취소.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk취소.Location = new System.Drawing.Point(281, 45);
            this.chk취소.Name = "chk취소";
            this.chk취소.Size = new System.Drawing.Size(61, 20);
            this.chk취소.TabIndex = 99;
            this.chk취소.Text = "취소";
            this.chk취소.UseVisualStyleBackColor = true;
            this.chk취소.CheckedChanged += new System.EventHandler(this.chk취소_CheckedChanged);
            // 
            // cmb소속부대
            // 
            this.cmb소속부대.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb소속부대.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb소속부대.FormattingEnabled = true;
            this.cmb소속부대.Location = new System.Drawing.Point(406, 7);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(292, 24);
            this.cmb소속부대.TabIndex = 10;
            this.cmb소속부대.Visible = false;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속_SelectedIndexChanged);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 73);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt1.Location = new System.Drawing.Point(93, 43);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(182, 26);
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
            this.label1.Location = new System.Drawing.Point(11, 46);
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
            this.label3.Location = new System.Drawing.Point(324, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "불출 부대";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn출력_거래증);
            this.panel2.Controls.Add(this.btn출력);
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
            this.btn출력_거래증.Location = new System.Drawing.Point(760, 10);
            this.btn출력_거래증.Name = "btn출력_거래증";
            this.btn출력_거래증.Size = new System.Drawing.Size(128, 32);
            this.btn출력_거래증.TabIndex = 150;
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
            this.btn출력.Location = new System.Drawing.Point(560, 11);
            this.btn출력.Name = "btn출력";
            this.btn출력.Size = new System.Drawing.Size(114, 32);
            this.btn출력.TabIndex = 148;
            this.btn출력.Text = "  출 력";
            this.btn출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn출력.UseVisualStyleBackColor = true;
            this.btn출력.Click += new System.EventHandler(this.btn출력_Click);
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
            this.spr.Location = new System.Drawing.Point(0, 99);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(986, 515);
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
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.spr0);
            this.sc.Panel1.Controls.Add(this.pan0);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.spr);
            this.sc.Panel2.Controls.Add(this.pan);
            this.sc.Size = new System.Drawing.Size(1487, 614);
            this.sc.SplitterDistance = 497;
            this.sc.TabIndex = 102;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // spr0
            // 
            this.spr0.AccessibleDescription = "spr0, Sheet0, Row 0, Column 0, ";
            this.spr0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr0.Location = new System.Drawing.Point(0, 81);
            this.spr0.Name = "spr0";
            this.spr0.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr0_Sheet1});
            this.spr0.Size = new System.Drawing.Size(497, 533);
            this.spr0.TabIndex = 102;
            this.spr0.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr0_ColumnWidthChanged);
            this.spr0.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spr0_ButtonClicked);
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
            // pan0
            // 
            this.pan0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan0.Controls.Add(this.lblCnt0);
            this.pan0.Controls.Add(this.txt조회);
            this.pan0.Controls.Add(this.label6);
            this.pan0.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan0.Location = new System.Drawing.Point(0, 0);
            this.pan0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan0.Name = "pan0";
            this.pan0.Size = new System.Drawing.Size(497, 81);
            this.pan0.TabIndex = 101;
            // 
            // lblCnt0
            // 
            this.lblCnt0.AutoSize = true;
            this.lblCnt0.Location = new System.Drawing.Point(3, 66);
            this.lblCnt0.Name = "lblCnt0";
            this.lblCnt0.Size = new System.Drawing.Size(11, 12);
            this.lblCnt0.TabIndex = 98;
            this.lblCnt0.Text = "0";
            // 
            // txt조회
            // 
            this.txt조회.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt조회.Location = new System.Drawing.Point(110, 40);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(292, 26);
            this.txt조회.TabIndex = 96;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(55, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 70;
            this.label6.Text = "조회";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // t초기화
            // 
            this.t초기화.Enabled = true;
            this.t초기화.Interval = 1000;
            this.t초기화.Tick += new System.EventHandler(this.t초기화_Tick);
            // 
            // frm자산불출_자산폐기매각
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 664);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.panel2);
            this.Name = "frm자산불출_자산폐기매각";
            this.Text = "자산 폐기/매각";
            this.Activated += new System.EventHandler(this.frm자산불출_자산불출_Activated);
            this.Load += new System.EventHandler(this.frm자산불출_자산폐기매각_Load);
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr0_Sheet1)).EndInit();
            this.pan0.ResumeLayout(false);
            this.pan0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.ComboBox cmb소속부대;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.CheckBox chk취소;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn출력;
        private System.Windows.Forms.Button btn부대;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Panel pan0;
        private System.Windows.Forms.Label lblCnt0;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Label label6;
        private FarPoint.Win.Spread.FpSpread spr0;
        private FarPoint.Win.Spread.SheetView spr0_Sheet1;
        private System.Windows.Forms.Label lbl선택수량;
        private System.Windows.Forms.TextBox txt반납관;
        private System.Windows.Forms.TextBox txt출납관;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer t초기화;
        private System.Windows.Forms.Button btn출력_거래증;
        private System.Windows.Forms.Button btn선택폐기;
        private System.Windows.Forms.Button btn선택폐기취소;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb상태;
    }
}