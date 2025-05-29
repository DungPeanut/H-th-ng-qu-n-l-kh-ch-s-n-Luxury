namespace QLKS__Luxury
{
    partial class Form3
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
            this.lblLoaiDV = new System.Windows.Forms.Label();
            this.cbbServiceType = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(175, 112);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(144, 38);
            this.lblMaPhong.TabIndex = 13;
            this.lblMaPhong.Text = "Mã Phòng";
            // 
            // txtRoomId
            // 
            this.txtRoomId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomId.Location = new System.Drawing.Point(182, 175);
            this.txtRoomId.Multiline = true;
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(879, 40);
            this.txtRoomId.TabIndex = 14;
            // 
            // lblLoaiDV
            // 
            this.lblLoaiDV.AutoSize = true;
            this.lblLoaiDV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiDV.Location = new System.Drawing.Point(175, 252);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new System.Drawing.Size(172, 38);
            this.lblLoaiDV.TabIndex = 15;
            this.lblLoaiDV.Text = "Loại Dịch Vụ";
            // 
            // cbbServiceType
            // 
            this.cbbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServiceType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbServiceType.FormattingEnabled = true;
            this.cbbServiceType.Items.AddRange(new object[] {
            "1. Giặt ủi",
            "2. Ăn uống",
            "3. Xe đưa đón",
            "4. Dịch vụ khác"});
            this.cbbServiceType.Location = new System.Drawing.Point(182, 312);
            this.cbbServiceType.Name = "cbbServiceType";
            this.cbbServiceType.Size = new System.Drawing.Size(879, 39);
            this.cbbServiceType.TabIndex = 16;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(175, 391);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(112, 38);
            this.lblGhiChu.TabIndex = 17;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(182, 456);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(879, 38);
            this.txtNotes.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(734, 539);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(327, 119);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLKS__Luxury.Properties.Resources.cancel_25px;
            this.button1.Location = new System.Drawing.Point(30, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Turquoise;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(182, 539);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(327, 119);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Gửi Yêu Cầu";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 693);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.cbbServiceType);
            this.Controls.Add(this.lblLoaiDV);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label lblLoaiDV;
        private System.Windows.Forms.ComboBox cbbServiceType;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSend;
    }
}