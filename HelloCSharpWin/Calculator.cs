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
            int number2 = 2;

            int sum = number1 + number2;
            HelloLabel.Text = sum.ToString();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {

            int number1 = 0;
            int number2 = 0;
            // 밸리데이션, 익셉션, 디버깅에 개발자들은 시간을 굉장히 많이 쓸 수도 있다.

            // 밸리데이션: 입력값이 유효한지 체크하는 것
            // 익셉션: 프로그램이 실행되는 도중에 발생하는 에러
            // 디버깅: 프로그램이 실행되는 도중에 발생하는 에러를 찾아내는 것

            // Input에 대한 Validation 구현

            // if문으로 걸러내는 것 말고 아예 텍스트박스에 입력을 못하게 하는 방법도 있다. -> 라디오버튼이나 숫자 버튼만 주는 방법 등

            // null 이라는 건 보관함 자체가 없다는 것입니다.
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요."); // 메세지박스를 띄우고
                Sum1.Focus(); // Sum1에 포커스 주기
                return; // 함수 빠져나오기
            }
            // 함수 안에서 빠져나오기 위해서는 return을 사용. 반환값이 void이면 return만 사용 가능.

            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                Sum1.SelectAll(); // Sum1에 있는 모든 글자 선택하기
                Sum1.Focus(); // Sum1에 포커스 주기
                return;

                // SelectAll()과 Focus()를 이용해 사용자에게 편리한 기능을 구현할 수 있음.
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요."); // 메세지박스를 띄우고
                return; // 함수 빠져나오기
            }

            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                return;
            }

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
