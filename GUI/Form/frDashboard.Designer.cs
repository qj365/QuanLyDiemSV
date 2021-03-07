namespace QuanLyDiemSV
{
    partial class frDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDashboard));
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnlControl = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLopHP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSinhVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGiaoVien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHocPhan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLopCN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKhoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(215, 127);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(985, 593);
            this.pnlControl.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.label3);
            this.bunifuGradientPanel3.Controls.Add(this.lblDate);
            this.bunifuGradientPanel3.Controls.Add(this.lblTime);
            this.bunifuGradientPanel3.Controls.Add(this.label2);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.MediumSeaGreen;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(215, 38);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(985, 89);
            this.bunifuGradientPanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giáo viên môn ABC";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(769, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 22);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "DD/MM/YYYY";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(780, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(92, 22);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xin Chào, Nguyễn Văn A";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnThoat);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(215, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(985, 38);
            this.bunifuGradientPanel2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(946, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(39, 38);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học viện Kỹ thuật Quân sự";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.btnDangXuat);
            this.bunifuGradientPanel1.Controls.Add(this.btnLopHP);
            this.bunifuGradientPanel1.Controls.Add(this.btnDiem);
            this.bunifuGradientPanel1.Controls.Add(this.btnSinhVien);
            this.bunifuGradientPanel1.Controls.Add(this.btnGiaoVien);
            this.bunifuGradientPanel1.Controls.Add(this.btnHocPhan);
            this.bunifuGradientPanel1.Controls.Add(this.btnLopCN);
            this.bunifuGradientPanel1.Controls.Add(this.btnKhoa);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(239)))), ((int)(((byte)(125)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(215, 720);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 154);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Active = false;
            this.btnDangXuat.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.ButtonText = "     Đăng xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangXuat.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Iconimage")));
            this.btnDangXuat.Iconimage_right = null;
            this.btnDangXuat.Iconimage_right_Selected = null;
            this.btnDangXuat.Iconimage_Selected = null;
            this.btnDangXuat.IconMarginLeft = 0;
            this.btnDangXuat.IconMarginRight = 0;
            this.btnDangXuat.IconRightVisible = true;
            this.btnDangXuat.IconRightZoom = 0D;
            this.btnDangXuat.IconVisible = true;
            this.btnDangXuat.IconZoom = 75D;
            this.btnDangXuat.IsTab = true;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 547);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDangXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDangXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangXuat.selected = false;
            this.btnDangXuat.Size = new System.Drawing.Size(215, 56);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "     Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Textcolor = System.Drawing.Color.White;
            this.btnDangXuat.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnLopHP
            // 
            this.btnLopHP.Active = false;
            this.btnLopHP.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnLopHP.BackColor = System.Drawing.Color.Transparent;
            this.btnLopHP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLopHP.BorderRadius = 0;
            this.btnLopHP.ButtonText = "    Lớp học phần";
            this.btnLopHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLopHP.DisabledColor = System.Drawing.Color.Gray;
            this.btnLopHP.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHP.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLopHP.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLopHP.Iconimage")));
            this.btnLopHP.Iconimage_right = null;
            this.btnLopHP.Iconimage_right_Selected = null;
            this.btnLopHP.Iconimage_Selected = null;
            this.btnLopHP.IconMarginLeft = 0;
            this.btnLopHP.IconMarginRight = 0;
            this.btnLopHP.IconRightVisible = true;
            this.btnLopHP.IconRightZoom = 0D;
            this.btnLopHP.IconVisible = true;
            this.btnLopHP.IconZoom = 75D;
            this.btnLopHP.IsTab = true;
            this.btnLopHP.Location = new System.Drawing.Point(0, 322);
            this.btnLopHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLopHP.Name = "btnLopHP";
            this.btnLopHP.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLopHP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLopHP.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLopHP.selected = false;
            this.btnLopHP.Size = new System.Drawing.Size(215, 56);
            this.btnLopHP.TabIndex = 1;
            this.btnLopHP.Text = "    Lớp học phần";
            this.btnLopHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHP.Textcolor = System.Drawing.Color.White;
            this.btnLopHP.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHP.Click += new System.EventHandler(this.btnLopHP_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Active = false;
            this.btnDiem.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnDiem.BackColor = System.Drawing.Color.Transparent;
            this.btnDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiem.BorderRadius = 0;
            this.btnDiem.ButtonText = "   Điểm sinh viên";
            this.btnDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiem.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiem.Iconimage")));
            this.btnDiem.Iconimage_right = null;
            this.btnDiem.Iconimage_right_Selected = null;
            this.btnDiem.Iconimage_Selected = null;
            this.btnDiem.IconMarginLeft = 0;
            this.btnDiem.IconMarginRight = 0;
            this.btnDiem.IconRightVisible = true;
            this.btnDiem.IconRightZoom = 0D;
            this.btnDiem.IconVisible = true;
            this.btnDiem.IconZoom = 75D;
            this.btnDiem.IsTab = true;
            this.btnDiem.Location = new System.Drawing.Point(0, 491);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiem.selected = false;
            this.btnDiem.Size = new System.Drawing.Size(215, 56);
            this.btnDiem.TabIndex = 1;
            this.btnDiem.Text = "   Điểm sinh viên";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.Textcolor = System.Drawing.Color.White;
            this.btnDiem.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Active = false;
            this.btnSinhVien.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.btnSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinhVien.BorderRadius = 0;
            this.btnSinhVien.ButtonText = "     Sinh viên";
            this.btnSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinhVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnSinhVien.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSinhVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Iconimage")));
            this.btnSinhVien.Iconimage_right = null;
            this.btnSinhVien.Iconimage_right_Selected = null;
            this.btnSinhVien.Iconimage_Selected = null;
            this.btnSinhVien.IconMarginLeft = 0;
            this.btnSinhVien.IconMarginRight = 0;
            this.btnSinhVien.IconRightVisible = true;
            this.btnSinhVien.IconRightZoom = 0D;
            this.btnSinhVien.IconVisible = true;
            this.btnSinhVien.IconZoom = 75D;
            this.btnSinhVien.IsTab = true;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 435);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSinhVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSinhVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSinhVien.selected = false;
            this.btnSinhVien.Size = new System.Drawing.Size(215, 56);
            this.btnSinhVien.TabIndex = 1;
            this.btnSinhVien.Text = "     Sinh viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Textcolor = System.Drawing.Color.White;
            this.btnSinhVien.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Active = false;
            this.btnGiaoVien.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.btnGiaoVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiaoVien.BorderRadius = 0;
            this.btnGiaoVien.ButtonText = "     Giáo viên";
            this.btnGiaoVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaoVien.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiaoVien.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiaoVien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Iconimage")));
            this.btnGiaoVien.Iconimage_right = null;
            this.btnGiaoVien.Iconimage_right_Selected = null;
            this.btnGiaoVien.Iconimage_Selected = null;
            this.btnGiaoVien.IconMarginLeft = 0;
            this.btnGiaoVien.IconMarginRight = 0;
            this.btnGiaoVien.IconRightVisible = true;
            this.btnGiaoVien.IconRightZoom = 0D;
            this.btnGiaoVien.IconVisible = true;
            this.btnGiaoVien.IconZoom = 75D;
            this.btnGiaoVien.IsTab = true;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 379);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGiaoVien.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiaoVien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiaoVien.selected = false;
            this.btnGiaoVien.Size = new System.Drawing.Size(215, 56);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "     Giáo viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoVien.Textcolor = System.Drawing.Color.White;
            this.btnGiaoVien.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHocPhan
            // 
            this.btnHocPhan.Active = false;
            this.btnHocPhan.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.btnHocPhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHocPhan.BorderRadius = 0;
            this.btnHocPhan.ButtonText = "      Học phần";
            this.btnHocPhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHocPhan.DisabledColor = System.Drawing.Color.Gray;
            this.btnHocPhan.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHocPhan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHocPhan.Iconimage")));
            this.btnHocPhan.Iconimage_right = null;
            this.btnHocPhan.Iconimage_right_Selected = null;
            this.btnHocPhan.Iconimage_Selected = null;
            this.btnHocPhan.IconMarginLeft = 0;
            this.btnHocPhan.IconMarginRight = 0;
            this.btnHocPhan.IconRightVisible = true;
            this.btnHocPhan.IconRightZoom = 0D;
            this.btnHocPhan.IconVisible = true;
            this.btnHocPhan.IconZoom = 75D;
            this.btnHocPhan.IsTab = true;
            this.btnHocPhan.Location = new System.Drawing.Point(-4, 265);
            this.btnHocPhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHocPhan.Name = "btnHocPhan";
            this.btnHocPhan.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHocPhan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHocPhan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHocPhan.selected = false;
            this.btnHocPhan.Size = new System.Drawing.Size(215, 56);
            this.btnHocPhan.TabIndex = 1;
            this.btnHocPhan.Text = "      Học phần";
            this.btnHocPhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocPhan.Textcolor = System.Drawing.Color.White;
            this.btnHocPhan.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhan.Click += new System.EventHandler(this.btnHocPhan_Click);
            // 
            // btnLopCN
            // 
            this.btnLopCN.Active = false;
            this.btnLopCN.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnLopCN.BackColor = System.Drawing.Color.Transparent;
            this.btnLopCN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLopCN.BorderRadius = 0;
            this.btnLopCN.ButtonText = " Lớp chuyên ngành";
            this.btnLopCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLopCN.DisabledColor = System.Drawing.Color.Gray;
            this.btnLopCN.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopCN.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLopCN.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLopCN.Iconimage")));
            this.btnLopCN.Iconimage_right = null;
            this.btnLopCN.Iconimage_right_Selected = null;
            this.btnLopCN.Iconimage_Selected = null;
            this.btnLopCN.IconMarginLeft = 0;
            this.btnLopCN.IconMarginRight = 0;
            this.btnLopCN.IconRightVisible = true;
            this.btnLopCN.IconRightZoom = 0D;
            this.btnLopCN.IconVisible = true;
            this.btnLopCN.IconZoom = 75D;
            this.btnLopCN.IsTab = true;
            this.btnLopCN.Location = new System.Drawing.Point(0, 209);
            this.btnLopCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLopCN.Name = "btnLopCN";
            this.btnLopCN.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLopCN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLopCN.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLopCN.selected = false;
            this.btnLopCN.Size = new System.Drawing.Size(215, 56);
            this.btnLopCN.TabIndex = 1;
            this.btnLopCN.Text = " Lớp chuyên ngành";
            this.btnLopCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopCN.Textcolor = System.Drawing.Color.White;
            this.btnLopCN.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopCN.Click += new System.EventHandler(this.btnLopCN_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Active = true;
            this.btnKhoa.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnKhoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhoa.BorderRadius = 0;
            this.btnKhoa.ButtonText = "       Khoa";
            this.btnKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnKhoa.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKhoa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Iconimage")));
            this.btnKhoa.Iconimage_right = null;
            this.btnKhoa.Iconimage_right_Selected = null;
            this.btnKhoa.Iconimage_Selected = null;
            this.btnKhoa.IconMarginLeft = 0;
            this.btnKhoa.IconMarginRight = 0;
            this.btnKhoa.IconRightVisible = true;
            this.btnKhoa.IconRightZoom = 0D;
            this.btnKhoa.IconVisible = true;
            this.btnKhoa.IconZoom = 75D;
            this.btnKhoa.IsTab = true;
            this.btnKhoa.Location = new System.Drawing.Point(0, 153);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Normalcolor = System.Drawing.Color.Transparent;
            this.btnKhoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKhoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKhoa.selected = true;
            this.btnKhoa.Size = new System.Drawing.Size(215, 56);
            this.btnKhoa.TabIndex = 1;
            this.btnKhoa.Text = "       Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Textcolor = System.Drawing.Color.White;
            this.btnKhoa.TextFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // frDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDangXuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiem;
        private Bunifu.Framework.UI.BunifuFlatButton btnSinhVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiaoVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnHocPhan;
        private Bunifu.Framework.UI.BunifuFlatButton btnLopCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnKhoa;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel pnlControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnThoat;
        private Bunifu.Framework.UI.BunifuFlatButton btnLopHP;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}