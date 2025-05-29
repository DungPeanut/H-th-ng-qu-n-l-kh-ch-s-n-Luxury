namespace QLKS__Luxury
{
    partial class Form4
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
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.cbbRating = new System.Windows.Forms.ComboBox();
            this.lblBinhLuan = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSendFb = new System.Windows.Forms.Button();
            this.btnResetFb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(186, 75);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(144, 38);
            this.lblMaPhong.TabIndex = 14;
            this.lblMaPhong.Text = "Mã Phòng";
            // 
            // txtRoomId
            // 
            this.txtRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomId.Location = new System.Drawing.Point(193, 156);
            this.txtRoomId.Multiline = true;
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(879, 40);
            this.txtRoomId.TabIndex = 15;
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.AutoSize = true;
            this.lblDanhGia.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.Location = new System.Drawing.Point(186, 232);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(131, 38);
            this.lblDanhGia.TabIndex = 16;
            this.lblDanhGia.Text = "Đánh Giá";
            // 
            // cbbRating
            // 
            this.cbbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRating.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRating.FormattingEnabled = true;
            this.cbbRating.Items.AddRange(new object[] {
            "1 sao",
            "2 sao",
            "3 sao",
            "4 sao",
            "5 sao"});
            this.cbbRating.Location = new System.Drawing.Point(193, 309);
            this.cbbRating.Name = "cbbRating";
            this.cbbRating.Size = new System.Drawing.Size(879, 39);
            this.cbbRating.TabIndex = 17;
            // 
            // lblBinhLuan
            // 
            this.lblBinhLuan.AutoSize = true;
            this.lblBinhLuan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinhLuan.Location = new System.Drawing.Point(186, 384);
            this.lblBinhLuan.Name = "lblBinhLuan";
            this.lblBinhLuan.Size = new System.Drawing.Size(139, 38);
            this.lblBinhLuan.TabIndex = 18;
            this.lblBinhLuan.Text = "Bình Luận";
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(193, 458);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(879, 38);
            this.txtComment.TabIndex = 19;
            // 
            // btnSendFb
            // 
            this.btnSendFb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSendFb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFb.Location = new System.Drawing.Point(193, 555);
            this.btnSendFb.Name = "btnSendFb";
            this.btnSendFb.Size = new System.Drawing.Size(327, 119);
            this.btnSendFb.TabIndex = 20;
            this.btnSendFb.Text = "Gửi Phản Hồi";
            this.btnSendFb.UseVisualStyleBackColor = false;
            this.btnSendFb.Click += new System.EventHandler(this.btnSendFb_Click);
            // 
            // btnResetFb
            // 
            this.btnResetFb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResetFb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFb.Location = new System.Drawing.Point(745, 555);
            this.btnResetFb.Name = "btnResetFb";
            this.btnResetFb.Size = new System.Drawing.Size(327, 119);
            this.btnResetFb.TabIndex = 21;
            this.btnResetFb.Text = "Nhập Lại";
            this.btnResetFb.UseVisualStyleBackColor = false;
            this.btnResetFb.Click += new System.EventHandler(this.btnResetFb_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLKS__Luxury.Properties.Resources.cancel_25px;
            this.button1.Location = new System.Drawing.Point(22, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 743);
            this.Controls.Add(this.btnResetFb);
            this.Controls.Add(this.btnSendFb);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblBinhLuan);
            this.Controls.Add(this.cbbRating);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.Label lblBinhLuan;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSendFb;
        private System.Windows.Forms.Button btnResetFb;
    }
}