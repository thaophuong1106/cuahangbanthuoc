namespace cuahangbanthuoc
{
    partial class FormHangHoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtrangthai = new System.Windows.Forms.ComboBox();
            this.cmbsize = new System.Windows.Forms.ComboBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.cmbmancc = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnngungkinhdoanh = new System.Windows.Forms.Button();
            this.btnkinhdoanhlai = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Hàng Hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbtrangthai);
            this.groupBox1.Controls.Add(this.cmbsize);
            this.groupBox1.Controls.Add(this.txtmau);
            this.groupBox1.Controls.Add(this.cmbmancc);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txttenhang);
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.txtmahang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa:";
            // 
            // cmbtrangthai
            // 
            this.cmbtrangthai.FormattingEnabled = true;
            this.cmbtrangthai.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng kinh doanh"});
            this.cmbtrangthai.Location = new System.Drawing.Point(573, 83);
            this.cmbtrangthai.Name = "cmbtrangthai";
            this.cmbtrangthai.Size = new System.Drawing.Size(121, 21);
            this.cmbtrangthai.TabIndex = 5;
            // 
            // cmbsize
            // 
            this.cmbsize.FormattingEnabled = true;
            this.cmbsize.Items.AddRange(new object[] {
            "To",
            "Vừa",
            "Nhỏ"});
            this.cmbsize.Location = new System.Drawing.Point(330, 86);
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(100, 21);
            this.cmbsize.TabIndex = 4;
            this.cmbsize.SelectedIndexChanged += new System.EventHandler(this.cmbsize_SelectedIndexChanged);
            // 
            // txtmau
            // 
            this.txtmau.Location = new System.Drawing.Point(331, 55);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(99, 20);
            this.txtmau.TabIndex = 1;
            // 
            // cmbmancc
            // 
            this.cmbmancc.DataSource = this.nhaCungCapBindingSource;
            this.cmbmancc.DisplayMember = "Mancc";
            this.cmbmancc.FormattingEnabled = true;
            this.cmbmancc.Location = new System.Drawing.Point(79, 83);
            this.cmbmancc.Name = "cmbmancc";
            this.cmbmancc.Size = new System.Drawing.Size(142, 21);
            this.cmbmancc.TabIndex = 3;
            this.cmbmancc.ValueMember = "Mancc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnu);
            this.groupBox2.Controls.Add(this.rbnam);
            this.groupBox2.Location = new System.Drawing.Point(112, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 38);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại hàng:";
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(290, 15);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(112, 17);
            this.rbnu.TabIndex = 0;
            this.rbnu.Text = "Thuốc Phổ Thông";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Checked = true;
            this.rbnam.Location = new System.Drawing.Point(66, 15);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(183, 17);
            this.rbnam.TabIndex = 0;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Thuốc Chỉ Định B.S ( Nguy Hiểm)";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(572, 51);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(144, 20);
            this.txtgiaban.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(330, 23);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 1;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(77, 51);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(144, 20);
            this.txttenhang.TabIndex = 1;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(573, 23);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(143, 20);
            this.txtgianhap.TabIndex = 1;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(78, 23);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(143, 20);
            this.txtmahang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NCC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "HSD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hàng:";
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvhanghoa.Location = new System.Drawing.Point(21, 239);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.Size = new System.Drawing.Size(790, 259);
            this.dgvhanghoa.TabIndex = 2;
            this.dgvhanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhanghoa_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mahang";
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenhang";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mancc";
            this.Column3.HeaderText = "Mã NCC";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Loaihang";
            this.Column4.HeaderText = "Loại hàng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Size";
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Mau";
            this.Column6.HeaderText = "HSD ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Soluong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Gianhap";
            this.Column8.HeaderText = "Giá nhập";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Giaban";
            this.Column9.HeaderText = "Giá bán";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Trangthai";
            this.Column10.HeaderText = "Trạng thái";
            this.Column10.Name = "Column10";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(101, 194);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(139, 40);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(264, 194);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(139, 40);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnngungkinhdoanh
            // 
            this.btnngungkinhdoanh.Location = new System.Drawing.Point(430, 194);
            this.btnngungkinhdoanh.Name = "btnngungkinhdoanh";
            this.btnngungkinhdoanh.Size = new System.Drawing.Size(139, 40);
            this.btnngungkinhdoanh.TabIndex = 3;
            this.btnngungkinhdoanh.Text = "Ngừng kinh doanh";
            this.btnngungkinhdoanh.UseVisualStyleBackColor = true;
            this.btnngungkinhdoanh.Click += new System.EventHandler(this.btnngungkinhdoanh_Click);
            // 
            // btnkinhdoanhlai
            // 
            this.btnkinhdoanhlai.Location = new System.Drawing.Point(596, 193);
            this.btnkinhdoanhlai.Name = "btnkinhdoanhlai";
            this.btnkinhdoanhlai.Size = new System.Drawing.Size(139, 40);
            this.btnkinhdoanhlai.TabIndex = 3;
            this.btnkinhdoanhlai.Text = "Kinh doanh lại";
            this.btnkinhdoanhlai.UseVisualStyleBackColor = true;
            this.btnkinhdoanhlai.Click += new System.EventHandler(this.btnkinhdoanhlai_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnkinhdoanhlai);
            this.Controls.Add(this.btnngungkinhdoanh);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormHangHoa";
            this.Size = new System.Drawing.Size(844, 501);
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnngungkinhdoanh;
        private System.Windows.Forms.Button btnkinhdoanhlai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ComboBox cmbtrangthai;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.ComboBox cmbsize;
        private System.Windows.Forms.ComboBox cmbmancc;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmau;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        // private QUANLYCUAHANG1DataSet1TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
    }
}
