namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

            int number1 = 1;
            string operator1 = "+";
            bool isCorrect = false;
            int number2 = 2;

            int sum = number1 + number2;
            HelloLabel.Text = sum.ToString();

        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Sum1.Text);
            int number2 = Convert.ToInt32(Sum2.Text);

            int sum = number1 + number2;
            SumResult.Text = sum.ToString();

        }
    }
}
