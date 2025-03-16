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

        private void buttonNol_Click(object sender, EventArgs e)
        {
            num = 0;
            textBoxView.Text += num.ToString();
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
        private void buttonKoma_Click(object sender, EventArgs e)
        {
            if (!textBoxView.Text.Contains(","))
            {
                textBoxView.Text += ",";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxView.Text, out first_num))
            {
                operasi = "+";
                textBoxView.Clear();
            }
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxView.Text, out first_num))
            {
                operasi = "-";
                textBoxView.Clear();
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxView.Text, out first_num))
            {
                operasi = "*";
                textBoxView.Clear();
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxView.Text, out first_num))
            {
                operasi = "/";
                textBoxView.Clear();
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double second_num = double.Parse(textBoxView.Text);
            double hasil = 0;
            switch (operasi)
            {
                case "+":
                    hasil = first_num + second_num;
                    break;
                case "-":
                    hasil = first_num - second_num;
                    break;
                case "*":
                    hasil = first_num * second_num;
                    break;
                case "/":
                    if (second_num != 0)
                    {
                        hasil = first_num / second_num;
                    }
                    else
                    {
                        textBoxView.Text = "Error";
                        return;
                    }
                    break;
            }
            textBoxView.Text = hasil.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            first_num = 0;
            textBoxView.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxView.Text.Length > 0)
            {
                textBoxView.Text = textBoxView.Text.Remove(textBoxView.Text.Length - 1);
            }
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            bool isEnabled = buttonNol.Enabled;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn != buttonOnOff) // Kecuali On/Off button 
                {
                    btn.Enabled = !isEnabled;
                }
            }

            textBoxView.Clear();
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxView.Text) && double.TryParse(textBoxView.Text, out double num))
            {
                num = -num;
                textBoxView.Text = num.ToString();
            }
        }

    }
}
