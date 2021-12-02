namespace GUI
{
    partial class QLNV
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
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnamsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsocmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grthongtin = new System.Windows.Forms.GroupBox();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.lblsocmt = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.grthongtin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clhoten,
            this.clgioitinh,
            this.clnamsinh,
            this.clsocmt,
            this.clsdt,
            this.cldiachi,
            this.clchucvu,
            this.cltrangthai});
            this.dgvnhanvien.Location = new System.Drawing.Point(335, 118);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhanvien.Size = new System.Drawing.Size(506, 418);
            this.dgvnhanvien.TabIndex = 9;
            this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
            // 
            // clid
            // 
            this.clid.DataPropertyName = "ID";
            this.clid.HeaderText = "Mã NV";
            this.clid.Name = "clid";
            // 
            // clhoten
            // 
            this.clhoten.DataPropertyName = "Hoten";
            this.clhoten.HeaderText = "Họ Tên";
            this.clhoten.Name = "clhoten";
            // 
            // clgioitinh
            // 
            this.clgioitinh.DataPropertyName = "Gioitinh";
            this.clgioitinh.HeaderText = "Giới tính";
            this.clgioitinh.Name = "clgioitinh";
            // 
            // clnamsinh
            // 
            this.clnamsinh.DataPropertyName = "Namsinh";
            this.clnamsinh.HeaderText = "Năm sinh";
            this.clnamsinh.Name = "clnamsinh";
            // 
            // clsocmt
            // 
            this.clsocmt.DataPropertyName = "Socmt";
            this.clsocmt.HeaderText = "Số CMND";
            this.clsocmt.Name = "clsocmt";
            // 
            // clsdt
            // 
            this.clsdt.DataPropertyName = "Sdt";
            this.clsdt.HeaderText = "Số ĐT";
            this.clsdt.Name = "clsdt";
            // 
            // cldiachi
            // 
            this.cldiachi.DataPropertyName = "Diachi";
            this.cldiachi.HeaderText = "Địa Chỉ";
            this.cldiachi.Name = "cldiachi";
            // 
            // clchucvu
            // 
            this.clchucvu.DataPropertyName = "Chucvu";
            this.clchucvu.HeaderText = "Chức vụ";
            this.clchucvu.Name = "clchucvu";
            // 
            // cltrangthai
            // 
            this.cltrangthai.DataPropertyName = "Trangthai";
            this.cltrangthai.HeaderText = "Trạng thái";
            this.cltrangthai.Name = "cltrangthai";
            // 
            // grthongtin
            // 
            this.grthongtin.Controls.Add(this.cbotrangthai);
            this.grthongtin.Controls.Add(this.lbltrangthai);
            this.grthongtin.Controls.Add(this.txtchucvu);
            this.grthongtin.Controls.Add(this.lblchucvu);
            this.grthongtin.Controls.Add(this.txtdiachi);
            this.grthongtin.Controls.Add(this.lbldiachi);
            this.grthongtin.Controls.Add(this.txtsdt);
            this.grthongtin.Controls.Add(this.lblsdt);
            this.grthongtin.Controls.Add(this.txtcmnd);
            this.grthongtin.Controls.Add(this.lblsocmt);
            this.grthongtin.Controls.Add(this.dtpngaysinh);
            this.grthongtin.Controls.Add(this.lblngaysinh);
            this.grthongtin.Controls.Add(this.groupBox3);
            this.grthongtin.Controls.Add(this.txthoten);
            this.grthongtin.Controls.Add(this.lblhoten);
            this.grthongtin.Controls.Add(this.txtmanv);
            this.grthongtin.Controls.Add(this.lblid);
            this.grthongtin.Location = new System.Drawing.Point(14, 118);
            this.grthongtin.Name = "grthongtin";
            this.grthongtin.Size = new System.Drawing.Size(315, 478);
            this.grthongtin.TabIndex = 8;
            this.grthongtin.TabStop = false;
            this.grthongtin.Text = "Thông tin nhân viên";
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Items.AddRange(new object[] {
            "Đang làm việc",
            "Không làm việc"});
            this.cbotrangthai.Location = new System.Drawing.Point(100, 373);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(132, 21);
            this.cbotrangthai.TabIndex = 16;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Location = new System.Drawing.Point(16, 373);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(55, 13);
            this.lbltrangthai.TabIndex = 15;
            this.lbltrangthai.Text = "Trạng thái";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(100, 336);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(132, 20);
            this.txtchucvu.TabIndex = 14;
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(16, 339);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(47, 13);
            this.lblchucvu.TabIndex = 13;
            this.lblchucvu.Text = "Chức vụ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(100, 305);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(132, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(22, 305);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(40, 13);
            this.lbldiachi.TabIndex = 11;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(100, 275);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(132, 20);
            this.txtsdt.TabIndex = 10;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(16, 278);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(29, 13);
            this.lblsdt.TabIndex = 9;
            this.lblsdt.Text = "SĐT";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(100, 242);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(132, 20);
            this.txtcmnd.TabIndex = 8;
            // 
            // lblsocmt
            // 
            this.lblsocmt.AutoSize = true;
            this.lblsocmt.Location = new System.Drawing.Point(16, 245);
            this.lblsocmt.Name = "lblsocmt";
            this.lblsocmt.Size = new System.Drawing.Size(55, 13);
            this.lblsocmt.TabIndex = 7;
            this.lblsocmt.Text = "Số CMND";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(100, 208);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(132, 20);
            this.dtpngaysinh.TabIndex = 6;
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(15, 208);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblngaysinh.TabIndex = 5;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radnu);
            this.groupBox3.Controls.Add(this.radnam);
            this.groupBox3.Location = new System.Drawing.Point(6, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giới tính";
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(175, 27);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(39, 17);
            this.radnu.TabIndex = 1;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(19, 27);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(47, 17);
            this.radnam.TabIndex = 0;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(100, 89);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(132, 20);
            this.txthoten.TabIndex = 3;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(6, 89);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(39, 13);
            this.lblhoten.TabIndex = 2;
            this.lblhoten.Text = "Họ tên";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(100, 49);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(132, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 49);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(40, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btndong);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(14, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 77);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn công việc";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(446, 40);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(631, 36);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(240, 36);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(32, 36);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 609);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.grthongtin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "QLNV";
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.grthongtin.ResumeLayout(false);
            this.grthongtin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnamsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsocmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltrangthai;
        private System.Windows.Forms.GroupBox grthongtin;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label lblsocmt;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}