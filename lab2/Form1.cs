namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * RecursiveFactorial(n - 1);
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        public double RecursivePower(double n, int p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p < 0)
            {
                return 1 / RecursivePower(n, p);
            }

            return n * RecursivePower(n, p - 1);
        }

        public int RecursiveFibonacci(int n)
        {

            if (n <= 1)
            {
                return n;
            }

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textInput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial of {number} is {result}";
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(",").Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum is : {result}";
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInputFibonnaci.Text);
            int result = RecursiveFibonacci(n);
            lblResultFibonacci.Text = $"The Fibonnaci number is: {result}";
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInputBase.Text);
            int p = int.Parse(txtInputPower.Text);
            double result = RecursivePower(n, p);
            lblResultPower.Text = $"The resulting number is: {result}";
        }
    }
}
