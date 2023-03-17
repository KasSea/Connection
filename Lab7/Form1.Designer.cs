namespace Lab7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNhapTenSv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnadd = new Button();
            lstHienthidanhsach = new ListView();
            label3 = new Label();
            txtQueQuan = new TextBox();
            picAnh1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            picAnh2 = new PictureBox();
            btnExit = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)picAnh1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh2).BeginInit();
            SuspendLayout();
            // 
            // txtNhapTenSv
            // 
            txtNhapTenSv.Location = new Point(203, 91);
            txtNhapTenSv.Name = "txtNhapTenSv";
            txtNhapTenSv.Size = new Size(269, 27);
            txtNhapTenSv.TabIndex = 0;
            txtNhapTenSv.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 94);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập Tên Sinh Viên :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 192);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 3;
            label2.Text = "Danh sách Sinh Viên";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(588, 94);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 4;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // lstHienthidanhsach
            // 
            lstHienthidanhsach.BackColor = SystemColors.Info;
            lstHienthidanhsach.Location = new Point(32, 215);
            lstHienthidanhsach.Name = "lstHienthidanhsach";
            lstHienthidanhsach.RightToLeft = RightToLeft.Yes;
            lstHienthidanhsach.Size = new Size(269, 157);
            lstHienthidanhsach.TabIndex = 6;
            lstHienthidanhsach.UseCompatibleStateImageBehavior = false;
            lstHienthidanhsach.SelectedIndexChanged += lstHienthidanhsach_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 130);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 7;
            label3.Text = "Nhập Quê Quán :";
            // 
            // txtQueQuan
            // 
            txtQueQuan.Location = new Point(203, 127);
            txtQueQuan.Name = "txtQueQuan";
            txtQueQuan.Size = new Size(269, 27);
            txtQueQuan.TabIndex = 8;
            // 
            // picAnh1
            // 
            picAnh1.Image = (Image)resources.GetObject("picAnh1.Image");
            picAnh1.Location = new Point(413, 215);
            picAnh1.Name = "picAnh1";
            picAnh1.Size = new Size(269, 157);
            picAnh1.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh1.TabIndex = 9;
            picAnh1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(413, 192);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Ảnh Sinh Viên";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(155, 9);
            label5.Name = "label5";
            label5.Size = new Size(435, 47);
            label5.TabIndex = 11;
            label5.Text = "Form Danh Sách Sinh Viên ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picAnh2
            // 
            picAnh2.Image = (Image)resources.GetObject("picAnh2.Image");
            picAnh2.Location = new Point(413, 215);
            picAnh2.Name = "picAnh2";
            picAnh2.Size = new Size(269, 157);
            picAnh2.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh2.TabIndex = 12;
            picAnh2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(307, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(588, 130);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(btnRemove);
            Controls.Add(btnExit);
            Controls.Add(picAnh2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(picAnh1);
            Controls.Add(txtQueQuan);
            Controls.Add(label3);
            Controls.Add(lstHienthidanhsach);
            Controls.Add(btnadd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNhapTenSv);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Sinh Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAnh1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapTenSv;
        private Label label1;
        private Label label2;
        private Button btnadd;
        private ListView lstHienthidanhsach;
        private Label label3;
        private TextBox txtQueQuan;
        private PictureBox picAnh1;
        private Label label4;
        private Label label5;
        private PictureBox picAnh2;
        private Button btnExit;
        private Button btnRemove;
    }
}