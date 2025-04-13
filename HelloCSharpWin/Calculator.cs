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
            // �븮���̼�, �ͼ���, ����뿡 �����ڵ��� �ð��� ������ ���� �� ���� �ִ�.

            // �븮���̼�: �Է°��� ��ȿ���� üũ�ϴ� ��
            // �ͼ���: ���α׷��� ����Ǵ� ���߿� �߻��ϴ� ����
            // �����: ���α׷��� ����Ǵ� ���߿� �߻��ϴ� ������ ã�Ƴ��� ��

            // Input�� ���� Validation ����

            // if������ �ɷ����� �� ���� �ƿ� �ؽ�Ʈ�ڽ��� �Է��� ���ϰ� �ϴ� ����� �ִ�. -> ������ư�̳� ���� ��ư�� �ִ� ��� ��

            // null �̶�� �� ������ ��ü�� ���ٴ� ���Դϴ�.
            if (String.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("Sum1�� ���ڸ� �Է����ּ���."); // �޼����ڽ��� ����
                Sum1.Focus(); // Sum1�� ��Ŀ�� �ֱ�
                return; // �Լ� ����������
            }
            // �Լ� �ȿ��� ���������� ���ؼ��� return�� ���. ��ȯ���� void�̸� return�� ��� ����.

            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
                Sum1.SelectAll(); // Sum1�� �ִ� ��� ���� �����ϱ�
                Sum1.Focus(); // Sum1�� ��Ŀ�� �ֱ�
                return;

                // SelectAll()�� Focus()�� �̿��� ����ڿ��� ���� ����� ������ �� ����.
            }

            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2�� ���ڸ� �Է����ּ���."); // �޼����ڽ��� ����
                return; // �Լ� ����������
            }

            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2�� ���ڰ� ���Խ��ϴ�. ���ڸ� �Է����ּ���.");
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
