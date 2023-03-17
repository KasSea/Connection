namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstDanhSachSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstHienthidanhsach.Items.Add(txtNhapTenSv.Text);
                lstHienthidanhsach.Items.Add(txtQueQuan.Text);
                if (picAnh1.Visible == false)
                {
                    picAnh1.Visible = true;
                    picAnh2.Visible = false;
                }
                else
                {
                    picAnh1.Visible = false;
                    picAnh2.Visible = true;
                }
            }

        }

        private void lstHienthi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picAnh2.Visible = false;
            picAnh1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstHienthidanhsach.Items.RemoveAt(0);
        }

        private void lstHienthidanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}