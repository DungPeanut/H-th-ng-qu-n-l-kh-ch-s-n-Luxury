namespace QLKS__Luxury
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.btnFetchInvoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServiceCharges = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblIDNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::QLKS__Luxury.Properties.Resources.cancel_25px;
            this.button1.Location = new System.Drawing.Point(29, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 53);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhong.Location = new System.Drawing.Point(144, 95);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(144, 38);
            this.lblMaPhong.TabIndex = 14;
            this.lblMaPhong.Text = "Mã Phòng";
            // 
            // txtRoomID
            // 
            this.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(303, 93);
            this.txtRoomID.Multiline = true;
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(695, 40);
            this.txtRoomID.TabIndex = 15;
            // 
            // btnFetchInvoice
            // 
            this.btnFetchInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFetchInvoice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchInvoice.Location = new System.Drawing.Point(462, 139);
            this.btnFetchInvoice.Name = "btnFetchInvoice";
            this.btnFetchInvoice.Size = new System.Drawing.Size(327, 61);
            this.btnFetchInvoice.TabIndex = 20;
            this.btnFetchInvoice.Text = "Lấy Hóa Đơn";
            this.btnFetchInvoice.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblIDNumber);
            this.panel1.Controls.Add(this.lblServiceCharges);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCMND);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Location = new System.Drawing.Point(171, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 281);
            this.panel1.TabIndex = 21;
            // 
            // lblServiceCharges
            // 
            this.lblServiceCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceCharges.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharges.Location = new System.Drawing.Point(463, 192);
            this.lblServiceCharges.Multiline = true;
            this.lblServiceCharges.Name = "lblServiceCharges";
            this.lblServiceCharges.Size = new System.Drawing.Size(385, 47);
            this.lblServiceCharges.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dịch Vụ Phát Sinh";
            // 
            // lblRoom
            // 
            this.lblRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(463, 69);
            this.lblRoom.Multiline = true;
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(385, 47);
            this.lblRoom.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phòng";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(13, 135);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(100, 38);
            this.lblCMND.TabIndex = 17;
            this.lblCMND.Text = "CMND";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(20, 69);
            this.lblCustomerName.Multiline = true;
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(360, 47);
            this.lblCustomerName.TabIndex = 16;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(13, 10);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(217, 38);
            this.lblTenKH.TabIndex = 15;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(462, 506);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(327, 61);
            this.btnPrintInvoice.TabIndex = 22;
            this.btnPrintInvoice.Text = "In Hóa Đơn";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(462, 588);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(327, 61);
            this.btnPayment.TabIndex = 23;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Trạng Thái";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(98, 670);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(360, 47);
            this.txtStatus.TabIndex = 25;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(738, 655);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(327, 61);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDNumber.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(20, 192);
            this.lblIDNumber.Multiline = true;
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(360, 47);
            this.lblIDNumber.TabIndex = 23;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 743);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFetchInvoice);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Button btnFetchInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox lblCustomerName;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox lblServiceCharges;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox lblIDNumber;
    }
}