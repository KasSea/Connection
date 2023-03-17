using System;
using System.Numerics;
namespace lab6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        public void Print()
        {
            Console.WriteLine("/");
        }
        // abss
        public void btTong_Click(object sender, EventArgs e)
        {

            Console.WriteLine(txtSoThuNhat.Text);
            Console.WriteLine(txtSoThuHai.Text);
            Console.WriteLine(txtTuso.Text);
            Console.WriteLine(txtMauso.Text);

            int tuSoMoi = int.Parse(txtSoThuNhat.Text) * int.Parse(txtMauso.Text) + int.Parse(txtSoThuHai.Text) * int.Parse(txtTuso.Text);
            int mauSoMoi = int.Parse(txtSoThuHai.Text) * int.Parse(txtMauso.Text);



            Form2 form2 = new Form2("Tinh Tong\n" + txtSoThuNhat.Text + "/" + txtSoThuHai.Text + " + " + txtTuso.Text + "/" + txtMauso.Text + " = " + tuSoMoi.ToString() + "/" + mauSoMoi.ToString());

            form2.Show();
        }

        private void btFritwo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btHieu_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtSoThuNhat.Text);
            Console.WriteLine(txtSoThuHai.Text);
            Console.WriteLine(txtTuso.Text);
            Console.WriteLine(txtMauso.Text);

            int tuSoMoi = int.Parse(txtSoThuNhat.Text) * int.Parse(txtMauso.Text) - int.Parse(txtSoThuHai.Text) * int.Parse(txtTuso.Text);
            int mauSoMoi = int.Parse(txtSoThuHai.Text) * int.Parse(txtMauso.Text);

            Form2 form2 = new Form2("Tinh Hieu\n" + txtSoThuNhat.Text + "/" + txtSoThuHai.Text + " - " + txtTuso.Text + "/" + txtMauso.Text + " = " + tuSoMoi.ToString() + "/" + mauSoMoi.ToString());

            form2.Show();
        }

        private void btTich_Click(object sender, EventArgs e)
        {

            Console.WriteLine(txtSoThuNhat.Text);
            Console.WriteLine(txtSoThuHai.Text);
            Console.WriteLine(txtTuso.Text);
            Console.WriteLine(txtMauso.Text);

            int tuSoMoi = int.Parse(txtSoThuNhat.Text) * int.Parse(txtTuso.Text);
            int mauSoMoi = int.Parse(txtSoThuHai.Text) * int.Parse(txtMauso.Text);

            Form2 form2 = new Form2("Tinh Tich\n" + txtSoThuNhat.Text + "/" + txtSoThuHai.Text + " * " + txtTuso.Text + "/" + txtMauso.Text + " = " + tuSoMoi.ToString() + "/" + mauSoMoi.ToString());

            form2.Show();
        }

        private void btThuong_Click(object sender, EventArgs e)
        {

            Console.WriteLine(txtSoThuNhat.Text);
            Console.WriteLine(txtSoThuHai.Text);
            Console.WriteLine(txtTuso.Text);
            Console.WriteLine(txtMauso.Text);

            int tuSoMoi = int.Parse(txtSoThuNhat.Text) * int.Parse(txtMauso.Text);
            int mauSoMoi = int.Parse(txtSoThuHai.Text) * int.Parse(txtTuso.Text);

            Form2 form2 = new Form2("Tinh Thuong\n" + txtSoThuNhat.Text + "/" + txtSoThuHai.Text + " : " + txtTuso.Text + "/" + txtMauso.Text + " = " + tuSoMoi.ToString() + "/" + mauSoMoi.ToString());

            form2.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}