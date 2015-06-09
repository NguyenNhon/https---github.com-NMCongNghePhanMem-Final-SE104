﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicTier;

namespace QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        PhanQuyenBUS m_PhanQuyen;
        static DangNhap staticForm;
        private DangNhap()
        {
            InitializeComponent();
            m_PhanQuyen = new PhanQuyenBUS();
        }

        public static DangNhap getInstance()
        {
            if (staticForm == null)
            {
                staticForm = new DangNhap();
            }
            return staticForm;
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "admin" && mtb_Password.Text == "admin")
            {
                FormPhanQuyen m_PQ = new FormPhanQuyen();
                m_PQ.ShowDialog();
                return;
            }
            if (tb_UserName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (mtb_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            PhanQuyenDTO phanQuyen = new PhanQuyenDTO(tb_UserName.Text, mtb_Password.Text, "");

            if (m_PhanQuyen.KiemTraMatKhau(phanQuyen).Rows.Count <= 0 || m_PhanQuyen.KiemTraMatKhau(phanQuyen).Rows.Count > 1)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (m_PhanQuyen.KiemTraMatKhau(phanQuyen).Rows[0][2].ToString().Contains("Quản Lý"))
            {
                MainForm.role = ERole.QuanLy;
                MainForm.username = tb_UserName.Text;
                MainForm mf = new MainForm();
                tb_UserName.Text = "";
                mtb_Password.Text = "";
                this.Hide();
                mf.Show();
                
            }
            else if (m_PhanQuyen.KiemTraMatKhau(phanQuyen).Rows[0][2].ToString().Contains("Nhân Viên"))
            {
                MainForm.role = ERole.NhanVien;
                MainForm.username = tb_UserName.Text;
                tb_UserName.Text = "";
                mtb_Password.Text = "";
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }

        

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(1);
        }

        private void bt_Dang_Nhap_Lai_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = "";
            mtb_Password.Text = "";
        }
    }
}
