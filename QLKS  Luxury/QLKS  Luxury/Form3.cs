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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
                     "Xác nhận gửi?",       // Nội dung
                     "Confirm",             // Tiêu đề
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            // 2. Nếu chọn Yes thì báo thành công
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Gửi yêu cầu thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
            

        private void btnReset_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Xác nhận nhập lại?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            // Clear các ô và đặt focus về txtRoomId
            txtRoomId.Clear();
            cbbServiceType.SelectedIndex = -1;
            txtNotes.Clear();
            txtRoomId.Focus();
        }
    }
}
