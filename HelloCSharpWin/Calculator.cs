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

            int sum = Add(number1, number2);
            SumResult.Text = sum.ToString();

        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        //Add2�� ���� �ʰ� Add�� ��. (�Ű������� �ٸ� -> �����ε�)
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        //�Լ��� �����ε�(overloading)
        //���� �Լ��� ������ ������ �� ������ �Ű������� �޶�� ��.
        //return���� �� �Լ��� ����ũ���� �ƴ����� �������� ����. (�ǹ̰� ����)
        //public void Flush(Number1) { };
        //public void Flush(Number2) { };
        //public void Flush(Number1, Number2) { };
        //public void Flush() { };

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
    }
}
