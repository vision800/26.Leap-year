namespace _26.Leap_year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Year = int.Parse(txtYear.Text);
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                MessageBox.Show($"{Year} is a Leap Year.");
            }else
            {
                MessageBox.Show($"{Year} is not a Leap Year.");
            }
        }
    }
}