namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;

            // get the input
            // (P x rx(1 + r)n ) 7((1 + r)n - 1)
            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text) / 1200;
            n = decimal.ToInt32(termNumericUpDown.Value);

            //Processing
            emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            totalPayment = emi * n;

            // output result to label
            outputLabel.Text = "Payment/month is$:" + emi.ToString() +
                "\r\nTotal Payment is$: " + totalPayment.ToString();

        }

        private void termNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;

            // get the input
            // (P x r x (1 + r)n ) / ((1 + r)n - 1)
            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text) / 1200;
            n = decimal.ToInt32(termNumericUpDown.Value);

            //Processing
            emi = (p * r *(Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            totalPayment = emi * n;
            // output result to label
            outputLabel.Text = "Payment/month is$:" + emi.ToString() +
            "\r\nTotal Payment is$:" + totalPayment.ToString();
        }
    }
}