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

        //Add2로 쓰지 않고 Add로 씀. (매개변수가 다름 -> 오버로딩)
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        //함수의 오버로딩(overloading)
        //같은 함수를 여러번 선언할 수 있지만 매개변수가 달라야 함.
        //return형은 그 함수가 유니크한지 아닌지는 결정하지 않음. (의미가 없음)
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
