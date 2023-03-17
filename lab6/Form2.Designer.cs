namespace lab6
{
    partial class Form2
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
            lblFrm2KetQua = new Label();
            SuspendLayout();
            // 
            // lblFrm2KetQua
            // 
            lblFrm2KetQua.BackColor = SystemColors.ActiveCaption;
            lblFrm2KetQua.Location = new Point(125, 147);
            lblFrm2KetQua.Name = "lblFrm2KetQua";
            lblFrm2KetQua.Size = new Size(415, 167);
            lblFrm2KetQua.TabIndex = 0;
            lblFrm2KetQua.TextAlign = ContentAlignment.MiddleCenter;
            lblFrm2KetQua.Click += lblFrm2KetQua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFrm2KetQua);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblFrm2KetQua;
    }
}