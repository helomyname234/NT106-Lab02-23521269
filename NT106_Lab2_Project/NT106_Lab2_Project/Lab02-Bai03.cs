using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab2_Project
{
    public partial class Lab02_Bai03 : Form
    {
        private readonly string inputFilePath;
        private readonly string outputFilePath;

        public Lab02_Bai03()
        {
            InitializeComponent();
            string startupPath = Application.StartupPath;
            inputFilePath = Path.Combine(startupPath, "input3.txt");
            outputFilePath = Path.Combine(startupPath, "output3.txt");

            LoadInputFromFile();
        }

        private void LoadInputFromFile()
        {
            try
            {
                if (File.Exists(inputFilePath))
                {
                    txtInput3.Text = File.ReadAllText(inputFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải file input: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetOperatorPrecedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return -1;
        }

        private double ApplyOperation(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException("Lỗi chia cho 0.");
                    return a / b;
            }
            return 0;
        }

        private double EvaluateExpression(string expression)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();
            expression = expression.Replace(" ", "");

            for (int i = 0; i < expression.Length; i++)
            {
                char token = expression[i];

                if (char.IsDigit(token) || (token == '-' && (i == 0 || "+-*/(".Contains(expression[i - 1].ToString()))))
                {
                    string numStr = token.ToString();
                    i++;
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        numStr += expression[i];
                        i++;
                    }
                    i--;
                    values.Push(double.Parse(numStr));
                }
                else if (token == '(')
                {
                    ops.Push(token);
                }
                else if (token == ')')
                {
                    while (ops.Count > 0 && ops.Peek() != '(')
                    {
                        values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    if (ops.Count > 0) ops.Pop();
                }
                else
                {
                    while (ops.Count > 0 && GetOperatorPrecedence(ops.Peek()) >= GetOperatorPrecedence(token))
                    {
                        values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(token);
                }
            }

            while (ops.Count > 0)
            {
                values.Push(ApplyOperation(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = txtInput3.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                var results = new List<string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        results.Add("");
                        continue;
                    }

                    try
                    {
                        double result = EvaluateExpression(line);
                        results.Add($"{line} = {result}");
                    }
                    catch (Exception ex)
                    {
                        results.Add($"{line} = LỖI ({ex.Message})");
                    }
                }

                txtOuput3.Text = string.Join(Environment.NewLine, results);

                File.WriteAllText(inputFilePath, txtInput3.Text);
                File.WriteAllText(outputFilePath, txtOuput3.Text);

                MessageBox.Show("Đã tính toán và lưu kết quả thành công!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
