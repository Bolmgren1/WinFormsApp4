namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Cyan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            int kvadrat = tal1 * tal2;
            string text = kvadrat.ToString();
            label1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            int kvadrat = tal1 - tal2;
            string text = kvadrat.ToString();
            label1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor= Color.Red;
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            int kvadrat = tal1 + tal2;
            string text = kvadrat.ToString();
            label1.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForeColor = Color.Purple;
            double tal1 = double.Parse(textBox1.Text);
            double tal2 = double.Parse(textBox2.Text);

            double kvadrat = tal1 / tal2;
            string text = kvadrat.ToString();
            label1.Text = text;
        }
    }
}