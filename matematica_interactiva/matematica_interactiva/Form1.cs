namespace matematica_interactiva
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            Random r = new Random();
            int x = r.Next(1, 10);
            int y = r.Next(1, 10);
            //InitializeComponent();
            label1.Text = x.ToString();
            label2.Text = y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int produs = int.Parse(label1.Text) * int.Parse(label2.Text);
            if (produs == int.Parse(textBox1.Text))
                MessageBox.Show("Ai raspuns corect!");
            else
                MessageBox.Show("Mai ai de invatat!");
        }
    }
}
