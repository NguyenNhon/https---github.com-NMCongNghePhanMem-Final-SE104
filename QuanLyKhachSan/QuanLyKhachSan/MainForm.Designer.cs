﻿namespace QuanLyKhachSan
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msQuanLyKhachSan = new System.Windows.Forms.MenuStrip();
            this.msPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuanLyPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msTraCuuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msPhieuThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msTaoPTP = new System.Windows.Forms.ToolStripMenuItem();
            this.msXemPTP = new System.Windows.Forms.ToolStripMenuItem();
            this.msTaiChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.msHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBaoCaoTheoLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.msBaoCaoThang = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msThietLap = new System.Windows.Forms.ToolStripMenuItem();
            this.msPhanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.msTaoMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.msDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.msXoaQuyenTruyCap = new System.Windows.Forms.ToolStripMenuItem();
            this.msDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Hotel = new System.Windows.Forms.PictureBox();
            this.msQuanLyKhachSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // msQuanLyKhachSan
            // 
            this.msQuanLyKhachSan.BackColor = System.Drawing.Color.DodgerBlue;
            this.msQuanLyKhachSan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msQuanLyKhachSan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPhong,
            this.msPhieuThuePhong,
            this.msTaiChinh,
            this.msThietLap,
            this.msPhanQuyen,
            this.msDangXuat});
            this.msQuanLyKhachSan.Location = new System.Drawing.Point(0, 0);
            this.msQuanLyKhachSan.Name = "msQuanLyKhachSan";
            this.msQuanLyKhachSan.Size = new System.Drawing.Size(650, 29);
            this.msQuanLyKhachSan.TabIndex = 1;
            this.msQuanLyKhachSan.Text = "menuStrip1";
            // 
            // msPhong
            // 
            this.msPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQuanLyPhong,
            this.msTraCuuPhong});
            this.msPhong.Name = "msPhong";
            this.msPhong.Size = new System.Drawing.Size(67, 25);
            this.msPhong.Text = "Phòng";
            // 
            // msQuanLyPhong
            // 
            this.msQuanLyPhong.Name = "msQuanLyPhong";
            this.msQuanLyPhong.Size = new System.Drawing.Size(138, 26);
            this.msQuanLyPhong.Text = "Quản Lý";
            this.msQuanLyPhong.Click += new System.EventHandler(this.msQuanLyPhong_Click);
            // 
            // msTraCuuPhong
            // 
            this.msTraCuuPhong.Name = "msTraCuuPhong";
            this.msTraCuuPhong.Size = new System.Drawing.Size(138, 26);
            this.msTraCuuPhong.Text = "Tra Cứu";
            this.msTraCuuPhong.Click += new System.EventHandler(this.msTraCuuPhong_Click);
            // 
            // msPhieuThuePhong
            // 
            this.msPhieuThuePhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTaoPTP,
            this.msXemPTP});
            this.msPhieuThuePhong.Name = "msPhieuThuePhong";
            this.msPhieuThuePhong.Size = new System.Drawing.Size(148, 25);
            this.msPhieuThuePhong.Text = "Phiếu Thuê Phòng";
            // 
            // msTaoPTP
            // 
            this.msTaoPTP.Name = "msTaoPTP";
            this.msTaoPTP.Size = new System.Drawing.Size(192, 26);
            this.msTaoPTP.Text = "Tạo Mới";
            this.msTaoPTP.Click += new System.EventHandler(this.msTaoPTP_Click);
            // 
            // msXemPTP
            // 
            this.msXemPTP.Name = "msXemPTP";
            this.msXemPTP.Size = new System.Drawing.Size(192, 26);
            this.msXemPTP.Text = "Xem + Cập nhật";
            this.msXemPTP.Click += new System.EventHandler(this.msXemPTP_Click);
            // 
            // msTaiChinh
            // 
            this.msTaiChinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHoaDon,
            this.msBaoCaoTheoLoaiPhong});
            this.msTaiChinh.Name = "msTaiChinh";
            this.msTaiChinh.Size = new System.Drawing.Size(87, 25);
            this.msTaiChinh.Text = "Tài Chính";
            // 
            // msHoaDon
            // 
            this.msHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem});
            this.msHoaDon.Name = "msHoaDon";
            this.msHoaDon.Size = new System.Drawing.Size(142, 26);
            this.msHoaDon.Text = "Hóa Đơn";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.lToolStripMenuItem.Text = "Lập";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // msBaoCaoTheoLoaiPhong
            // 
            this.msBaoCaoTheoLoaiPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBaoCaoThang,
            this.traCứuToolStripMenuItem});
            this.msBaoCaoTheoLoaiPhong.Name = "msBaoCaoTheoLoaiPhong";
            this.msBaoCaoTheoLoaiPhong.Size = new System.Drawing.Size(142, 26);
            this.msBaoCaoTheoLoaiPhong.Text = "Báo Cáo ";
            // 
            // msBaoCaoThang
            // 
            this.msBaoCaoThang.Name = "msBaoCaoThang";
            this.msBaoCaoThang.Size = new System.Drawing.Size(205, 26);
            this.msBaoCaoThang.Text = "Lập cáo cáo tháng";
            this.msBaoCaoThang.Click += new System.EventHandler(this.msBaoCaoThang_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu";
            this.traCứuToolStripMenuItem.Click += new System.EventHandler(this.traCứuToolStripMenuItem_Click);
            // 
            // msThietLap
            // 
            this.msThietLap.Name = "msThietLap";
            this.msThietLap.Size = new System.Drawing.Size(85, 25);
            this.msThietLap.Text = "Thiết Lập";
            this.msThietLap.Click += new System.EventHandler(this.msThietLap_Click);
            // 
            // msPhanQuyen
            // 
            this.msPhanQuyen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTaoMoi,
            this.msDoiMatKhau,
            this.msXoaQuyenTruyCap});
            this.msPhanQuyen.Name = "msPhanQuyen";
            this.msPhanQuyen.Size = new System.Drawing.Size(107, 25);
            this.msPhanQuyen.Text = "Phân Quyền";
            // 
            // msTaoMoi
            // 
            this.msTaoMoi.Name = "msTaoMoi";
            this.msTaoMoi.Size = new System.Drawing.Size(222, 26);
            this.msTaoMoi.Text = "Tạo mới";
            this.msTaoMoi.Click += new System.EventHandler(this.msTaoMoi_Click);
            // 
            // msDoiMatKhau
            // 
            this.msDoiMatKhau.Name = "msDoiMatKhau";
            this.msDoiMatKhau.Size = new System.Drawing.Size(222, 26);
            this.msDoiMatKhau.Text = "Đổi mật khẩu";
            this.msDoiMatKhau.Click += new System.EventHandler(this.msDoiMatKhau_Click);
            // 
            // msXoaQuyenTruyCap
            // 
            this.msXoaQuyenTruyCap.Name = "msXoaQuyenTruyCap";
            this.msXoaQuyenTruyCap.Size = new System.Drawing.Size(222, 26);
            this.msXoaQuyenTruyCap.Text = "Xóa Quyền Truy Cập";
            this.msXoaQuyenTruyCap.Click += new System.EventHandler(this.msXoaQuyenTruyCap_Click);
            // 
            // msDangXuat
            // 
            this.msDangXuat.Name = "msDangXuat";
            this.msDangXuat.Size = new System.Drawing.Size(94, 25);
            this.msDangXuat.Text = "Đăng Xuất";
            this.msDangXuat.Click += new System.EventHandler(this.msDangXuat_Click);
            // 
            // pb_Hotel
            // 
            this.pb_Hotel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Hotel.BackgroundImage")));
            this.pb_Hotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Hotel.Location = new System.Drawing.Point(0, 27);
            this.pb_Hotel.Name = "pb_Hotel";
            this.pb_Hotel.Size = new System.Drawing.Size(650, 358);
            this.pb_Hotel.TabIndex = 2;
            this.pb_Hotel.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.Controls.Add(this.pb_Hotel);
            this.Controls.Add(this.msQuanLyKhachSan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH SẠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.msQuanLyKhachSan.ResumeLayout(false);
            this.msQuanLyKhachSan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msQuanLyKhachSan;
        private System.Windows.Forms.ToolStripMenuItem msPhong;
        private System.Windows.Forms.ToolStripMenuItem msQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem msPhieuThuePhong;
        private System.Windows.Forms.ToolStripMenuItem msTaoPTP;
        private System.Windows.Forms.ToolStripMenuItem msXemPTP;
        private System.Windows.Forms.ToolStripMenuItem msTaiChinh;
        private System.Windows.Forms.ToolStripMenuItem msTraCuuPhong;
        private System.Windows.Forms.ToolStripMenuItem msHoaDon;
        private System.Windows.Forms.ToolStripMenuItem msBaoCaoTheoLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem msThietLap;
        private System.Windows.Forms.ToolStripMenuItem msBaoCaoThang;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem msPhanQuyen;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Hotel;
        private System.Windows.Forms.ToolStripMenuItem msTaoMoi;
        private System.Windows.Forms.ToolStripMenuItem msDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem msDangXuat;
        private System.Windows.Forms.ToolStripMenuItem msXoaQuyenTruyCap;
    }
}

