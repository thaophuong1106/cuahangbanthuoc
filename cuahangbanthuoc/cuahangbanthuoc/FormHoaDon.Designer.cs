namespace cuahangbanthuoc
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cmbManv = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTaohoadon = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGioitinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMahang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluongcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.hanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIDNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIDNhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO HOÁ ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.cmbManv);
            this.groupBox1.Controls.Add(this.btnTaohoadon);
            this.groupBox1.Controls.Add(this.btnTinhtien);
            this.groupBox1.Controls.Add(this.dtpNgaylap);
            this.groupBox1.Controls.Add(this.txtMahd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1011, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(8, 202);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cmbManv
            // 
            this.cmbManv.DataSource = this.nhanVienBindingSource;
            this.cmbManv.FormattingEnabled = true;
            this.cmbManv.Location = new System.Drawing.Point(165, 105);
            this.cmbManv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbManv.Name = "cmbManv";
            this.cmbManv.Size = new System.Drawing.Size(160, 24);
            this.cmbManv.TabIndex = 8;
            this.cmbManv.SelectedIndexChanged += new System.EventHandler(this.cmbManv_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // btnTaohoadon
            // 
            this.btnTaohoadon.Location = new System.Drawing.Point(560, 175);
            this.btnTaohoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaohoadon.Name = "btnTaohoadon";
            this.btnTaohoadon.Size = new System.Drawing.Size(185, 46);
            this.btnTaohoadon.TabIndex = 7;
            this.btnTaohoadon.Text = "Tạo hóa đơn";
            this.btnTaohoadon.UseVisualStyleBackColor = true;
            this.btnTaohoadon.Click += new System.EventHandler(this.btnTaohoadon_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(201, 175);
            this.btnTinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(201, 46);
            this.btnTinhtien.TabIndex = 6;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(165, 64);
            this.dtpNgaylap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(237, 22);
            this.dtpNgaylap.TabIndex = 4;
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(165, 28);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(237, 22);
            this.txtMahd.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGioitinh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSdt);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.txtTenkh);
            this.groupBox2.Controls.Add(this.txtMakh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(437, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(556, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng:";
            // 
            // cmbGioitinh
            // 
            this.cmbGioitinh.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.cmbGioitinh.FormattingEnabled = true;
            this.cmbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioitinh.Location = new System.Drawing.Point(73, 112);
            this.cmbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGioitinh.Name = "cmbGioitinh";
            this.cmbGioitinh.Size = new System.Drawing.Size(160, 24);
            this.cmbGioitinh.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "SĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(348, 73);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(200, 22);
            this.txtSdt.TabIndex = 3;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(348, 36);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 22);
            this.txtDiachi.TabIndex = 3;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(73, 73);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(200, 22);
            this.txtTenkh.TabIndex = 3;
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(73, 36);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(200, 22);
            this.txtMakh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã KH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã người bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMahang,
            this.colTenhang,
            this.colSize,
            this.colSoluongcon,
            this.colSoluong,
            this.colDongia,
            this.colThanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(25, 320);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 331);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ColMahang
            // 
            this.ColMahang.HeaderText = "Mã hàng";
            this.ColMahang.MinimumWidth = 6;
            this.ColMahang.Name = "ColMahang";
            this.ColMahang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMahang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColMahang.Width = 125;
            // 
            // colTenhang
            // 
            this.colTenhang.HeaderText = "Tên hàng";
            this.colTenhang.MinimumWidth = 6;
            this.colTenhang.Name = "colTenhang";
            this.colTenhang.Width = 200;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size";
            this.colSize.MinimumWidth = 6;
            this.colSize.Name = "colSize";
            this.colSize.Width = 50;
            // 
            // colSoluongcon
            // 
            this.colSoluongcon.HeaderText = "Số lượng còn";
            this.colSoluongcon.MinimumWidth = 6;
            this.colSoluongcon.Name = "colSoluongcon";
            this.colSoluongcon.Width = 80;
            // 
            // colSoluong
            // 
            this.colSoluong.HeaderText = "Số lượng mua";
            this.colSoluong.MinimumWidth = 6;
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Width = 80;
            // 
            // colDongia
            // 
            this.colDongia.HeaderText = "Đơn giá";
            this.colDongia.MinimumWidth = 6;
            this.colDongia.Name = "colDongia";
            this.colDongia.Width = 125;
            // 
            // colThanhtien
            // 
            this.colThanhtien.HeaderText = "Thành tiền";
            this.colThanhtien.MinimumWidth = 6;
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(745, 634);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tổng tiền:";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(827, 634);
            this.lblTongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(16, 17);
            this.lblTongtien.TabIndex = 4;
            this.lblTongtien.Text = "0";
            // 
            // hanghoaBindingSource
            // 
            this.hanghoaBindingSource.DataMember = "Hanghoa";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHoaDon";
            this.Size = new System.Drawing.Size(1076, 673);
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIDNhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGioitinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
      //  private GetMaHang getMaHang;
    //    private GetMaHangTableAdapters.HanghoaTableAdapter hanghoaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTaohoadon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColMahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluongcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhtien;
        private System.Windows.Forms.ComboBox cmbManv;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource hanghoaBindingSource;
        private System.Windows.Forms.BindingSource getIDNhanvienBindingSource;
        private System.Windows.Forms.Button btnxoa;
        //  private QUANLYCUAHANG1DataSet1 QUANLYCUAHANG1DataSet1;
        // private QUANLYCUAHANG1DataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}
