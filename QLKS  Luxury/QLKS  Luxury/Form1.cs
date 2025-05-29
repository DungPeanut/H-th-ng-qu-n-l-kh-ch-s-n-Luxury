using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS__Luxury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == " " ||
                 txtTenNV.Text == " " ||
                 txtMatKhau.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            // Kiểm tra thông tin (demo)
            if (txtMaNV.Text == "0004968" &&
                txtTenNV.Text == "Trần Tiến Dũng" &&
                txtMatKhau.Text == "TranTienDung")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
                // Chuyển sang Dashboard...
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai!", "Cảnh báo");
                txtMatKhau.Clear();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtMatKhau.Clear();

            // 2. Hiện thông báo
            MessageBox.Show(
                "Restart thành công",     // Nội dung
                "Thông báo",              // Tiêu đề
                MessageBoxButtons.OK,     // Nút bấm
                MessageBoxIcon.Information// Icon
            );

            // 3. Đặt con trỏ về txtMaNV
            txtMaNV.Focus();
        }
    }
}
