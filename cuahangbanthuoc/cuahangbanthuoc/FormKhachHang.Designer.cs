namespace cuahangbanthuoc
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.clmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.lblmakh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvkhachhang);
            this.groupBox4.Location = new System.Drawing.Point(448, 143);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(641, 425);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khách Hàng";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmakh,
            this.cltenkh,
            this.clsdt,
            this.clgioitinh,
            this.cldiachi});
            this.dgvkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhachhang.Location = new System.Drawing.Point(4, 19);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.Size = new System.Drawing.Size(633, 402);
            this.dgvkhachhang.TabIndex = 0;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // clmakh
            // 
            this.clmakh.DataPropertyName = "Makh";
            this.clmakh.HeaderText = "Mã KH";
            this.clmakh.MinimumWidth = 6;
            this.clmakh.Name = "clmakh";
            this.clmakh.Width = 70;
            // 
            // cltenkh
            // 
            this.cltenkh.DataPropertyName = "Tenkh";
            this.cltenkh.HeaderText = "Tên KH";
            this.cltenkh.MinimumWidth = 6;
            this.cltenkh.Name = "cltenkh";
            this.cltenkh.Width = 125;
            // 
            // clsdt
            // 
            this.clsdt.DataPropertyName = "Sdt";
            this.clsdt.HeaderText = "SĐT";
            this.clsdt.MinimumWidth = 6;
            this.clsdt.Name = "clsdt";
            this.clsdt.Width = 80;
            // 
            // clgioitinh
            // 
            this.clgioitinh.DataPropertyName = "Gioitinh";
            this.clgioitinh.HeaderText = "Giới Tính";
            this.clgioitinh.MinimumWidth = 6;
            this.clgioitinh.Name = "clgioitinh";
            this.clgioitinh.Width = 80;
            // 
            // cldiachi
            // 
            this.cldiachi.DataPropertyName = "Diachi";
            this.cldiachi.HeaderText = "Địa Chỉ";
            this.cldiachi.MinimumWidth = 6;
            this.cldiachi.Name = "cldiachi";
            this.cldiachi.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Location = new System.Drawing.Point(0, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1089, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lựa Chọn Công Việc";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(815, 42);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            //this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(507, 42);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(177, 42);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.lbltenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.lblmakh);
            this.groupBox1.Location = new System.Drawing.Point(0, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(440, 425);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radnu);
            this.groupBox2.Controls.Add(this.radnam);
            this.groupBox2.Location = new System.Drawing.Point(32, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(295, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới Tính";
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(167, 23);
            this.radnu.Margin = new System.Windows.Forms.Padding(4);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(47, 21);
            this.radnu.TabIndex = 1;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(25, 23);
            this.radnam.Margin = new System.Windows.Forms.Padding(4);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(58, 21);
            this.radnam.TabIndex = 0;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(140, 308);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(165, 22);
            this.txtdiachi.TabIndex = 7;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(32, 316);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(53, 17);
            this.lbldiachi.TabIndex = 6;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(140, 244);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(165, 22);
            this.txtsdt.TabIndex = 5;
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Location = new System.Drawing.Point(28, 252);
            this.sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(36, 17);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "SĐT";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(140, 106);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(165, 22);
            this.txttenkh.TabIndex = 3;
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Location = new System.Drawing.Point(28, 106);
            this.lbltenkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(56, 17);
            this.lbltenkh.TabIndex = 2;
            this.lbltenkh.Text = "Tên KH";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(140, 44);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(165, 22);
            this.txtmakh.TabIndex = 1;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(28, 48);
            this.lblmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(50, 17);
            this.lblmakh.TabIndex = 0;
            this.lblmakh.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Size = new System.Drawing.Size(1093, 569);
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.Button btnxoa;
    }
}
