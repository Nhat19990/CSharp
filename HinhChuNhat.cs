namespace CSharp
{
    public partial class lakb1 : Form
    {
        public lakb1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double dai = Convert.ToDouble(textBox1.Text);
            double rong = Convert.ToDouble(textBox2.Text);
            label4.Text = "- Diện tích:" + (dai * rong) + Environment.NewLine + " Chu vi: " + (dai + rong) * 2;
        }
    }
}
