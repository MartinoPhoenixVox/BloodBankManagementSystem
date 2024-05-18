namespace GUI_BBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabp_NHM = new TabPage();
            grb_nhmGioiTinh = new GroupBox();
            rd_nhmGioiTinhNam = new RadioButton();
            rd_nhmGioiTinhNu = new RadioButton();
            btExit_nhm = new Button();
            btDel_nhm = new Button();
            btMod_nhm = new Button();
            btAdd_nhm = new Button();
            dgv_nhm = new DataGridView();
            txt_nhmHoTen = new TextBox();
            txt_nhmSDT = new TextBox();
            txt_nhmEmail = new TextBox();
            txt_nhmDiaChi = new TextBox();
            dtp_nhmNgaySinh = new DateTimePicker();
            lb_nhmEmail = new Label();
            lb_nhmDiaChi = new Label();
            lb_nhmGioiTinh = new Label();
            lb_nhmSDT = new Label();
            lb_nhmNgaySinh = new Label();
            lb_nhm_HoTen = new Label();
            tabControl1 = new TabControl();
            tabp_NHM.SuspendLayout();
            grb_nhmGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhm).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabp_NHM
            // 
            tabp_NHM.Controls.Add(grb_nhmGioiTinh);
            tabp_NHM.Controls.Add(btExit_nhm);
            tabp_NHM.Controls.Add(btDel_nhm);
            tabp_NHM.Controls.Add(btMod_nhm);
            tabp_NHM.Controls.Add(btAdd_nhm);
            tabp_NHM.Controls.Add(dgv_nhm);
            tabp_NHM.Controls.Add(txt_nhmHoTen);
            tabp_NHM.Controls.Add(txt_nhmSDT);
            tabp_NHM.Controls.Add(txt_nhmEmail);
            tabp_NHM.Controls.Add(txt_nhmDiaChi);
            tabp_NHM.Controls.Add(dtp_nhmNgaySinh);
            tabp_NHM.Controls.Add(lb_nhmEmail);
            tabp_NHM.Controls.Add(lb_nhmDiaChi);
            tabp_NHM.Controls.Add(lb_nhmGioiTinh);
            tabp_NHM.Controls.Add(lb_nhmSDT);
            tabp_NHM.Controls.Add(lb_nhmNgaySinh);
            tabp_NHM.Controls.Add(lb_nhm_HoTen);
            tabp_NHM.Location = new Point(4, 29);
            tabp_NHM.Margin = new Padding(4);
            tabp_NHM.Name = "tabp_NHM";
            tabp_NHM.Padding = new Padding(4);
            tabp_NHM.Size = new Size(962, 717);
            tabp_NHM.TabIndex = 0;
            tabp_NHM.Text = "Người hiến máu";
            tabp_NHM.UseVisualStyleBackColor = true;
            // 
            // grb_nhmGioiTinh
            // 
            grb_nhmGioiTinh.Controls.Add(rd_nhmGioiTinhNam);
            grb_nhmGioiTinh.Controls.Add(rd_nhmGioiTinhNu);
            grb_nhmGioiTinh.Location = new Point(611, 79);
            grb_nhmGioiTinh.Margin = new Padding(4);
            grb_nhmGioiTinh.Name = "grb_nhmGioiTinh";
            grb_nhmGioiTinh.Padding = new Padding(4);
            grb_nhmGioiTinh.Size = new Size(160, 58);
            grb_nhmGioiTinh.TabIndex = 8;
            grb_nhmGioiTinh.TabStop = false;
            // 
            // rd_nhmGioiTinhNam
            // 
            rd_nhmGioiTinhNam.AutoSize = true;
            rd_nhmGioiTinhNam.Location = new Point(8, 15);
            rd_nhmGioiTinhNam.Margin = new Padding(4);
            rd_nhmGioiTinhNam.Name = "rd_nhmGioiTinhNam";
            rd_nhmGioiTinhNam.Size = new Size(75, 29);
            rd_nhmGioiTinhNam.TabIndex = 1;
            rd_nhmGioiTinhNam.TabStop = true;
            rd_nhmGioiTinhNam.Text = "Nam";
            rd_nhmGioiTinhNam.UseVisualStyleBackColor = true;
            // 
            // rd_nhmGioiTinhNu
            // 
            rd_nhmGioiTinhNu.AutoSize = true;
            rd_nhmGioiTinhNu.Location = new Point(92, 15);
            rd_nhmGioiTinhNu.Margin = new Padding(4);
            rd_nhmGioiTinhNu.Name = "rd_nhmGioiTinhNu";
            rd_nhmGioiTinhNu.Size = new Size(61, 29);
            rd_nhmGioiTinhNu.TabIndex = 1;
            rd_nhmGioiTinhNu.TabStop = true;
            rd_nhmGioiTinhNu.Text = "Nữ";
            rd_nhmGioiTinhNu.UseVisualStyleBackColor = true;
            // 
            // btExit_nhm
            // 
            btExit_nhm.Location = new Point(706, 282);
            btExit_nhm.Margin = new Padding(4);
            btExit_nhm.Name = "btExit_nhm";
            btExit_nhm.Size = new Size(118, 36);
            btExit_nhm.TabIndex = 7;
            btExit_nhm.Text = "Thoát";
            btExit_nhm.UseVisualStyleBackColor = true;
            btExit_nhm.Click += btExit_nhm_Click;
            // 
            // btDel_nhm
            // 
            btDel_nhm.Location = new Point(510, 282);
            btDel_nhm.Margin = new Padding(4);
            btDel_nhm.Name = "btDel_nhm";
            btDel_nhm.Size = new Size(118, 36);
            btDel_nhm.TabIndex = 7;
            btDel_nhm.Text = "Xóa";
            btDel_nhm.UseVisualStyleBackColor = true;
            btDel_nhm.Click += btDel_nhm_Click;
            // 
            // btMod_nhm
            // 
            btMod_nhm.Location = new Point(314, 282);
            btMod_nhm.Margin = new Padding(4);
            btMod_nhm.Name = "btMod_nhm";
            btMod_nhm.Size = new Size(118, 36);
            btMod_nhm.TabIndex = 7;
            btMod_nhm.Text = "Sửa";
            btMod_nhm.UseVisualStyleBackColor = true;
            btMod_nhm.Click += btMod_nhm_Click;
            // 
            // btAdd_nhm
            // 
            btAdd_nhm.Location = new Point(119, 282);
            btAdd_nhm.Margin = new Padding(4);
            btAdd_nhm.Name = "btAdd_nhm";
            btAdd_nhm.Size = new Size(118, 36);
            btAdd_nhm.TabIndex = 7;
            btAdd_nhm.Text = "Thêm";
            btAdd_nhm.UseVisualStyleBackColor = true;
            btAdd_nhm.Click += btAdd_nhm_Click;
            // 
            // dgv_nhm
            // 
            dgv_nhm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_nhm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhm.Location = new Point(42, 344);
            dgv_nhm.Margin = new Padding(4);
            dgv_nhm.Name = "dgv_nhm";
            dgv_nhm.RowHeadersWidth = 51;
            dgv_nhm.Size = new Size(864, 342);
            dgv_nhm.TabIndex = 6;
            dgv_nhm.Click += dgv_nhm_Click;
            // 
            // txt_nhmHoTen
            // 
            txt_nhmHoTen.Location = new Point(180, 40);
            txt_nhmHoTen.Margin = new Padding(4);
            txt_nhmHoTen.Name = "txt_nhmHoTen";
            txt_nhmHoTen.Size = new Size(284, 31);
            txt_nhmHoTen.TabIndex = 5;
            // 
            // txt_nhmSDT
            // 
            txt_nhmSDT.Location = new Point(180, 99);
            txt_nhmSDT.Margin = new Padding(4);
            txt_nhmSDT.Name = "txt_nhmSDT";
            txt_nhmSDT.Size = new Size(284, 31);
            txt_nhmSDT.TabIndex = 5;
            // 
            // txt_nhmEmail
            // 
            txt_nhmEmail.Location = new Point(180, 159);
            txt_nhmEmail.Margin = new Padding(4);
            txt_nhmEmail.Name = "txt_nhmEmail";
            txt_nhmEmail.Size = new Size(726, 31);
            txt_nhmEmail.TabIndex = 4;
            // 
            // txt_nhmDiaChi
            // 
            txt_nhmDiaChi.Location = new Point(180, 214);
            txt_nhmDiaChi.Margin = new Padding(4);
            txt_nhmDiaChi.Name = "txt_nhmDiaChi";
            txt_nhmDiaChi.Size = new Size(725, 31);
            txt_nhmDiaChi.TabIndex = 3;
            // 
            // dtp_nhmNgaySinh
            // 
            dtp_nhmNgaySinh.Location = new Point(594, 38);
            dtp_nhmNgaySinh.Margin = new Padding(4);
            dtp_nhmNgaySinh.Name = "dtp_nhmNgaySinh";
            dtp_nhmNgaySinh.Size = new Size(312, 31);
            dtp_nhmNgaySinh.TabIndex = 2;
            // 
            // lb_nhmEmail
            // 
            lb_nhmEmail.AutoSize = true;
            lb_nhmEmail.Location = new Point(42, 159);
            lb_nhmEmail.Margin = new Padding(4, 0, 4, 0);
            lb_nhmEmail.Name = "lb_nhmEmail";
            lb_nhmEmail.Size = new Size(58, 25);
            lb_nhmEmail.TabIndex = 0;
            lb_nhmEmail.Text = "Email:";
            // 
            // lb_nhmDiaChi
            // 
            lb_nhmDiaChi.AutoSize = true;
            lb_nhmDiaChi.Location = new Point(42, 218);
            lb_nhmDiaChi.Margin = new Padding(4, 0, 4, 0);
            lb_nhmDiaChi.Name = "lb_nhmDiaChi";
            lb_nhmDiaChi.Size = new Size(69, 25);
            lb_nhmDiaChi.TabIndex = 0;
            lb_nhmDiaChi.Text = "Địa chỉ:";
            // 
            // lb_nhmGioiTinh
            // 
            lb_nhmGioiTinh.AutoSize = true;
            lb_nhmGioiTinh.Location = new Point(490, 102);
            lb_nhmGioiTinh.Margin = new Padding(4, 0, 4, 0);
            lb_nhmGioiTinh.Name = "lb_nhmGioiTinh";
            lb_nhmGioiTinh.Size = new Size(82, 25);
            lb_nhmGioiTinh.TabIndex = 0;
            lb_nhmGioiTinh.Text = "Giới tính:";
            // 
            // lb_nhmSDT
            // 
            lb_nhmSDT.AutoSize = true;
            lb_nhmSDT.Location = new Point(42, 102);
            lb_nhmSDT.Margin = new Padding(4, 0, 4, 0);
            lb_nhmSDT.Name = "lb_nhmSDT";
            lb_nhmSDT.Size = new Size(121, 25);
            lb_nhmSDT.TabIndex = 0;
            lb_nhmSDT.Text = "Số điện thoại:";
            // 
            // lb_nhmNgaySinh
            // 
            lb_nhmNgaySinh.AutoSize = true;
            lb_nhmNgaySinh.Location = new Point(490, 44);
            lb_nhmNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lb_nhmNgaySinh.Name = "lb_nhmNgaySinh";
            lb_nhmNgaySinh.Size = new Size(95, 25);
            lb_nhmNgaySinh.TabIndex = 0;
            lb_nhmNgaySinh.Text = "Ngày sinh:";
            // 
            // lb_nhm_HoTen
            // 
            lb_nhm_HoTen.AutoSize = true;
            lb_nhm_HoTen.Location = new Point(42, 44);
            lb_nhm_HoTen.Margin = new Padding(4, 0, 4, 0);
            lb_nhm_HoTen.Name = "lb_nhm_HoTen";
            lb_nhm_HoTen.Size = new Size(93, 25);
            lb_nhm_HoTen.TabIndex = 0;
            lb_nhm_HoTen.Text = "Họ và tên:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabp_NHM);
            tabControl1.ItemSize = new Size(119, 25);
            tabControl1.Location = new Point(15, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 750);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 790);
            Controls.Add(tabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "BBMS";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            tabp_NHM.ResumeLayout(false);
            tabp_NHM.PerformLayout();
            grb_nhmGioiTinh.ResumeLayout(false);
            grb_nhmGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nhm).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabp_NHM;
        private GroupBox grb_nhmGioiTinh;
        private RadioButton rd_nhmGioiTinhNam;
        private RadioButton rd_nhmGioiTinhNu;
        private Button btExit_nhm;
        private Button btDel_nhm;
        private Button btMod_nhm;
        private Button btAdd_nhm;
        private DataGridView dgv_nhm;
        private TextBox txt_nhmHoTen;
        private TextBox txt_nhmSDT;
        private TextBox txt_nhmEmail;
        private TextBox txt_nhmDiaChi;
        private DateTimePicker dtp_nhmNgaySinh;
        private Label lb_nhmEmail;
        private Label lb_nhmDiaChi;
        private Label lb_nhmGioiTinh;
        private Label lb_nhmSDT;
        private Label lb_nhmNgaySinh;
        private Label lb_nhm_HoTen;
        private TabControl tabControl1;
    }
}
