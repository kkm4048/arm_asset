namespace arm_asset
{
    partial class frm자산관리_자산등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자산관리_자산등록));
            this.panTop = new System.Windows.Forms.Panel();
            this.btn자산다운로드 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt조회_사업명 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt조회_설치장소 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt조회_설치부대 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt조회_도입년도 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn부대 = new System.Windows.Forms.Button();
            this.lblCnt = new System.Windows.Forms.Label();
            this.cmb소속부대 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.btn데이타다운로드 = new System.Windows.Forms.Button();
            this.btn일괄삭제 = new System.Windows.Forms.Button();
            this.btn바코드출력2 = new System.Windows.Forms.Button();
            this.btn엑셀_불러오기 = new System.Windows.Forms.Button();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn조회 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt등록수량 = new System.Windows.Forms.TextBox();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panLeft = new System.Windows.Forms.Panel();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panRight = new System.Windows.Forms.Panel();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panRight.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panTop.Controls.Add(this.btn자산다운로드);
            this.panTop.Controls.Add(this.panel1);
            this.panTop.Controls.Add(this.btn부대);
            this.panTop.Controls.Add(this.lblCnt);
            this.panTop.Controls.Add(this.cmb소속부대);
            this.panTop.Controls.Add(this.label6);
            this.panTop.Controls.Add(this.label3);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 50);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1209, 54);
            this.panTop.TabIndex = 97;
            this.panTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panTop_Paint);
            // 
            // btn자산다운로드
            // 
            this.btn자산다운로드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn자산다운로드.Image = ((System.Drawing.Image)(resources.GetObject("btn자산다운로드.Image")));
            this.btn자산다운로드.Location = new System.Drawing.Point(1038, 10);
            this.btn자산다운로드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn자산다운로드.Name = "btn자산다운로드";
            this.btn자산다운로드.Size = new System.Drawing.Size(146, 32);
            this.btn자산다운로드.TabIndex = 154;
            this.btn자산다운로드.Text = "  자산 PDA 다운로드";
            this.btn자산다운로드.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn자산다운로드.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn자산다운로드.UseVisualStyleBackColor = true;
            this.btn자산다운로드.Click += new System.EventHandler(this.btn자산다운로드_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt조회_사업명);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt조회_설치장소);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt조회_설치부대);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt조회_도입년도);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(281, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 43);
            this.panel1.TabIndex = 149;
            // 
            // txt조회_사업명
            // 
            this.txt조회_사업명.Location = new System.Drawing.Point(554, 12);
            this.txt조회_사업명.Name = "txt조회_사업명";
            this.txt조회_사업명.Size = new System.Drawing.Size(179, 21);
            this.txt조회_사업명.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 67;
            this.label5.Text = "사업명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt조회_설치장소
            // 
            this.txt조회_설치장소.Location = new System.Drawing.Point(389, 12);
            this.txt조회_설치장소.Name = "txt조회_설치장소";
            this.txt조회_설치장소.Size = new System.Drawing.Size(96, 21);
            this.txt조회_설치장소.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "설치장소";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt조회_설치부대
            // 
            this.txt조회_설치부대.Location = new System.Drawing.Point(215, 12);
            this.txt조회_설치부대.Name = "txt조회_설치부대";
            this.txt조회_설치부대.Size = new System.Drawing.Size(96, 21);
            this.txt조회_설치부대.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "설치부대";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt조회_도입년도
            // 
            this.txt조회_도입년도.Location = new System.Drawing.Point(75, 11);
            this.txt조회_도입년도.Name = "txt조회_도입년도";
            this.txt조회_도입년도.Size = new System.Drawing.Size(77, 21);
            this.txt조회_도입년도.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "도입년도";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn부대
            // 
            this.btn부대.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn부대.Image = ((System.Drawing.Image)(resources.GetObject("btn부대.Image")));
            this.btn부대.Location = new System.Drawing.Point(247, 11);
            this.btn부대.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn부대.Name = "btn부대";
            this.btn부대.Size = new System.Drawing.Size(20, 20);
            this.btn부대.TabIndex = 148;
            this.btn부대.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn부대.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn부대.UseVisualStyleBackColor = true;
            this.btn부대.Click += new System.EventHandler(this.btn부대_Click);
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
            // cmb소속부대
            // 
            this.cmb소속부대.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb소속부대.FormattingEnabled = true;
            this.cmb소속부대.Location = new System.Drawing.Point(71, 12);
            this.cmb소속부대.Name = "cmb소속부대";
            this.cmb소속부대.Size = new System.Drawing.Size(173, 20);
            this.cmb소속부대.TabIndex = 100;
            this.cmb소속부대.SelectedIndexChanged += new System.EventHandler(this.cmb소속부대_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 60;
            this.label6.Text = "설치부대";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
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
            this.panTitle.Controls.Add(this.btn데이타다운로드);
            this.panTitle.Controls.Add(this.btn일괄삭제);
            this.panTitle.Controls.Add(this.btn바코드출력2);
            this.panTitle.Controls.Add(this.btn엑셀_불러오기);
            this.panTitle.Controls.Add(this.btn바코드출력);
            this.panTitle.Controls.Add(this.dtp);
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
            this.button2.Location = new System.Drawing.Point(755, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 153;
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
            // btn데이타다운로드
            // 
            this.btn데이타다운로드.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn데이타다운로드.Image = ((System.Drawing.Image)(resources.GetObject("btn데이타다운로드.Image")));
            this.btn데이타다운로드.Location = new System.Drawing.Point(855, 6);
            this.btn데이타다운로드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn데이타다운로드.Name = "btn데이타다운로드";
            this.btn데이타다운로드.Size = new System.Drawing.Size(144, 32);
            this.btn데이타다운로드.TabIndex = 152;
            this.btn데이타다운로드.Text = "   자산데이타 생성";
            this.btn데이타다운로드.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn데이타다운로드.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn데이타다운로드.UseVisualStyleBackColor = true;
            this.btn데이타다운로드.Visible = false;
            this.btn데이타다운로드.Click += new System.EventHandler(this.btn데이타다운로드_Click);
            // 
            // btn일괄삭제
            // 
            this.btn일괄삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn일괄삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn일괄삭제.Image")));
            this.btn일괄삭제.Location = new System.Drawing.Point(1306, 7);
            this.btn일괄삭제.Name = "btn일괄삭제";
            this.btn일괄삭제.Size = new System.Drawing.Size(114, 32);
            this.btn일괄삭제.TabIndex = 151;
            this.btn일괄삭제.Text = "    일괄삭제";
            this.btn일괄삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn일괄삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn일괄삭제.UseVisualStyleBackColor = true;
            this.btn일괄삭제.Click += new System.EventHandler(this.btn일괄삭제_Click);
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
            this.btn바코드출력2.Visible = false;
            this.btn바코드출력2.Click += new System.EventHandler(this.btn바코드출력2_Click);
            // 
            // btn엑셀_불러오기
            // 
            this.btn엑셀_불러오기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_불러오기.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_불러오기.Image")));
            this.btn엑셀_불러오기.Location = new System.Drawing.Point(634, 7);
            this.btn엑셀_불러오기.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_불러오기.Name = "btn엑셀_불러오기";
            this.btn엑셀_불러오기.Size = new System.Drawing.Size(115, 31);
            this.btn엑셀_불러오기.TabIndex = 147;
            this.btn엑셀_불러오기.Text = " 엑셀 불러오기";
            this.btn엑셀_불러오기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_불러오기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_불러오기.UseVisualStyleBackColor = true;
            this.btn엑셀_불러오기.Click += new System.EventHandler(this.btn엑셀_불러오기_Click);
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(1005, 7);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(136, 32);
            this.btn바코드출력.TabIndex = 147;
            this.btn바코드출력.Text = "  바코드출력";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 149;
            this.label11.Text = "등록수량";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt등록수량
            // 
            this.txt등록수량.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt등록수량.Location = new System.Drawing.Point(162, 16);
            this.txt등록수량.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt등록수량.MaxLength = 0;
            this.txt등록수량.Name = "txt등록수량";
            this.txt등록수량.Size = new System.Drawing.Size(53, 25);
            this.txt등록수량.TabIndex = 148;
            this.txt등록수량.Text = "1";
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(159, 48);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(56, 30);
            this.btn삭제.TabIndex = 43;
            this.btn삭제.Text = "삭제";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // btn등록
            // 
            this.btn등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록.Image = ((System.Drawing.Image)(resources.GetObject("btn등록.Image")));
            this.btn등록.Location = new System.Drawing.Point(13, 48);
            this.btn등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(60, 30);
            this.btn등록.TabIndex = 42;
            this.btn등록.Text = " 등록";
            this.btn등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(86, 48);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(60, 30);
            this.btn수정.TabIndex = 41;
            this.btn수정.Text = " 수정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(139, 86);
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
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
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
            this.panRight.Controls.Add(this.pan등록);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(1209, 50);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(290, 685);
            this.panRight.TabIndex = 99;
            // 
            // pan등록
            // 
            this.pan등록.Controls.Add(this.btn삭제);
            this.pan등록.Controls.Add(this.label11);
            this.pan등록.Controls.Add(this.btn수정);
            this.pan등록.Controls.Add(this.txt등록수량);
            this.pan등록.Controls.Add(this.btn등록);
            this.pan등록.Controls.Add(this.btn초기화);
            this.pan등록.Location = new System.Drawing.Point(42, 301);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(231, 130);
            this.pan등록.TabIndex = 150;
            // 
            // frm자산관리_자산등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 735);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panTitle);
            this.Name = "frm자산관리_자산등록";
            this.Text = "자산 등록";
            this.Load += new System.EventHandler(this.frm자산관리_자산등록_Load);
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
            this.panRight.ResumeLayout(false);
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.ComboBox cmb소속부대;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.Button btn엑셀_불러오기;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt등록수량;
        private System.Windows.Forms.Button btn바코드출력2;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Button btn일괄삭제;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Button btn데이타다운로드;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn부대;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt조회_설치장소;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt조회_설치부대;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt조회_도입년도;
        private System.Windows.Forms.TextBox txt조회_사업명;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn자산다운로드;
    }
}