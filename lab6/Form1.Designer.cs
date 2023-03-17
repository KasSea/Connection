namespace lab6
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
            txtSoThuNhat = new TextBox();
            txtSoThuHai = new TextBox();
            lblSoThuNhat = new Label();
            label2 = new Label();
            btTong = new Button();
            Oprater = new Label();
            txtTuso = new TextBox();
            txtMauso = new TextBox();
            lblTuso = new Label();
            lblMauSo = new Label();
            label1 = new Label();
            label3 = new Label();
            btHieu = new Button();
            btTich = new Button();
            btThuong = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.Location = new Point(210, 128);
            txtSoThuNhat.Margin = new Padding(3, 2, 3, 2);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(110, 23);
            txtSoThuNhat.TabIndex = 3;
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.Location = new Point(210, 172);
            txtSoThuHai.Margin = new Padding(3, 2, 3, 2);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(110, 23);
            txtSoThuHai.TabIndex = 5;
            // 
            // lblSoThuNhat
            // 
            lblSoThuNhat.AutoSize = true;
            lblSoThuNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoThuNhat.Location = new Point(102, 128);
            lblSoThuNhat.Name = "lblSoThuNhat";
            lblSoThuNhat.Size = new Size(82, 15);
            lblSoThuNhat.TabIndex = 1;
            lblSoThuNhat.Text = "Số Thứ Nhất :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(376, 128);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Số Thứ Hai :";
            // 
            // btTong
            // 
            btTong.Location = new Point(164, 240);
            btTong.Margin = new Padding(3, 2, 3, 2);
            btTong.Name = "btTong";
            btTong.Size = new Size(82, 22);
            btTong.TabIndex = 11;
            btTong.Text = "Tổng";
            btTong.UseVisualStyleBackColor = true;
            btTong.Click += btTong_Click;
            // 
            // Oprater
            // 
            Oprater.BackColor = Color.FromArgb(255, 224, 192);
            Oprater.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Oprater.Location = new Point(248, 39);
            Oprater.Name = "Oprater";
            Oprater.Size = new Size(209, 46);
            Oprater.TabIndex = 0;
            Oprater.Text = "Tính 2 Phân Số";
            Oprater.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTuso
            // 
            txtTuso.Location = new Point(472, 129);
            txtTuso.Margin = new Padding(3, 2, 3, 2);
            txtTuso.Name = "txtTuso";
            txtTuso.Size = new Size(110, 23);
            txtTuso.TabIndex = 8;
            // 
            // txtMauso
            // 
            txtMauso.Location = new Point(472, 172);
            txtMauso.Margin = new Padding(3, 2, 3, 2);
            txtMauso.Name = "txtMauso";
            txtMauso.Size = new Size(110, 23);
            txtMauso.TabIndex = 10;
            // 
            // lblTuso
            // 
            lblTuso.AutoSize = true;
            lblTuso.Location = new Point(210, 110);
            lblTuso.Name = "lblTuso";
            lblTuso.Size = new Size(36, 15);
            lblTuso.TabIndex = 2;
            lblTuso.Text = "Tử Số";
            // 
            // lblMauSo
            // 
            lblMauSo.AutoSize = true;
            lblMauSo.Location = new Point(210, 156);
            lblMauSo.Name = "lblMauSo";
            lblMauSo.Size = new Size(47, 15);
            lblMauSo.TabIndex = 4;
            lblMauSo.Text = "Mẫu Số";
            lblMauSo.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 110);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Tử Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 156);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Mẫu Số";
            label3.Click += label3_Click;
            // 
            // btHieu
            // 
            btHieu.Location = new Point(282, 240);
            btHieu.Name = "btHieu";
            btHieu.Size = new Size(82, 22);
            btHieu.TabIndex = 12;
            btHieu.Text = "Hiệu";
            btHieu.UseVisualStyleBackColor = true;
            btHieu.Click += btHieu_Click;
            // 
            // btTich
            // 
            btTich.Location = new Point(400, 240);
            btTich.Name = "btTich";
            btTich.Size = new Size(82, 22);
            btTich.TabIndex = 13;
            btTich.Text = "Tích";
            btTich.UseVisualStyleBackColor = true;
            btTich.Click += btTich_Click;
            // 
            // btThuong
            // 
            btThuong.Location = new Point(507, 240);
            btThuong.Name = "btThuong";
            btThuong.Size = new Size(82, 22);
            btThuong.TabIndex = 14;
            btThuong.Text = "Thương";
            btThuong.UseVisualStyleBackColor = true;
            btThuong.Click += btThuong_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(334, 288);
            btExit.Name = "btExit";
            btExit.Size = new Size(105, 38);
            btExit.TabIndex = 15;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btExit;
            ClientSize = new Size(700, 338);
            Controls.Add(btExit);
            Controls.Add(btThuong);
            Controls.Add(btTich);
            Controls.Add(btHieu);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblMauSo);
            Controls.Add(lblTuso);
            Controls.Add(txtMauso);
            Controls.Add(txtTuso);
            Controls.Add(Oprater);
            Controls.Add(btTong);
            Controls.Add(label2);
            Controls.Add(lblSoThuNhat);
            Controls.Add(txtSoThuHai);
            Controls.Add(txtSoThuNhat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoThuNhat;
        private TextBox txtSoThuHai;
        private Label lblSoThuNhat;
        private Label label2;
        private Button btTong;
        private Label Oprater;
        private TextBox txtTuso;
        private TextBox txtMauso;
        private Label lblTuso;
        private Label lblMauSo;
        private Label label1;
        private Label label3;
        private Button btHieu;
        private Button btTich;
        private Button btThuong;
        private Button btExit;
    }
}