namespace Kalkulator
{
    public partial class formKalkulator : Form
    {
        double num;
        double first_num;
        string operasi = "";

        public formKalkulator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSatu_Click(object sender, EventArgs e)
        {
            num = 1;
            textBoxView.Text += num.ToString();
        }

        private void buttonDua_Click(object sender, EventArgs e)
        {
            num = 2;
            textBoxView.Text += num.ToString();
        }

        private void buttonTiga_Click(object sender, EventArgs e)
        {
            num = 3;
            textBoxView.Text += num.ToString();
        }

        private void buttonEmpat_Click(object sender, EventArgs e)
        {
            num = 4;
            textBoxView.Text += num.ToString();
        }

        private void buttonLima_Click(object sender, EventArgs e)
        {
            num = 5;
            textBoxView.Text += num.ToString();
        }

        private void buttonEnam_Click(object sender, EventArgs e)
        {
            num = 6;
            textBoxView.Text += num.ToString();
        }

        private void buttonTujuh_Click(object sender, EventArgs e)
        {
            num = 7;
            textBoxView.Text += num.ToString();
        }

        private void buttonDelapan_Click(object sender, EventArgs e)
        {
            num = 8;
            textBoxView.Text += num.ToString();
        }

        private void buttonSembilan_Click(object sender, EventArgs e)
        {
            num = 9;
            textBoxView.Text += num.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            first_num = double.Parse(textBoxView.Text);
            operasi = "+";
            textBoxView.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double second_num = double.Parse(textBoxView.Text);
            double hasil = 0;
            if (operasi == "+") {
                hasil = first_num + second_num;
            }
            textBoxView.Text = hasil.ToString();
        }

    }
}
