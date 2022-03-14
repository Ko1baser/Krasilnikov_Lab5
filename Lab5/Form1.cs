using System;
using System.Windows.Forms;
using MyLib;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbx_permission.Checked)
                {
                    Math_Calculation calculation = new Math_Calculation();
                    double result = calculation.Addidion(double.Parse(first_number.Text), double.Parse(second_number.Text));
                    MessageBox.Show($"Результат сложения: {result}");
                }
                else
                {
                    MessageBox.Show("Вы не подключили соответсвующую библиотеку", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода чисел");
            }
        }

        private void btnSubstraction_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbx_permission.Checked)
                {
                    Math_Calculation calculation = new Math_Calculation();
                    double result = calculation.Substraction(double.Parse(first_number.Text), double.Parse(second_number.Text));
                    MessageBox.Show($"Результат вычитания: {result}");
                }
                else
                {
                    MessageBox.Show("Вы не подключили соответсвующую библиотеку", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода чисел");
            }
        }

        private void btnMultiplication_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbx_permission.Checked)
                {
                    Math_Calculation calculation = new Math_Calculation();
                    double result = calculation.Multiplication(double.Parse(first_number.Text), double.Parse(second_number.Text));
                    MessageBox.Show($"Результат умножения: {result}");
                }
                else
                {
                    MessageBox.Show("Вы не подключили соответсвующую библиотеку", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода чисел");
            }
        }

        private void btnDivision_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cbx_permission.Checked)
                {
                    if (double.Parse(second_number.Text) != 0)
                    {
                        Math_Calculation calculation = new Math_Calculation();
                        double result = calculation.Multiplication(double.Parse(first_number.Text),double.Parse(second_number.Text));
                        MessageBox.Show($"Результат умножения: {result}");
                    }
                    else
                    {
                        MessageBox.Show("Число B не может быть равно 0");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не подключили соответсвующую библиотеку", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода чисел");
            }
        }

        private void first_number_TextChanged(object sender, System.EventArgs e)
        {
            foreach (char symbol in first_number.Text)
            {
                if (char.IsLetter(symbol))
                {
                    MessageBox.Show("Ошибка ввода числа A", "Error");
                    break;
                }
            }
        }

        private void second_number_TextChanged(object sender, System.EventArgs e)
        {
            foreach (char symbol in second_number.Text)
            {
                if (char.IsLetter(symbol))
                {
                    MessageBox.Show("Ошибка ввода числа B", "Error");
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cbx_permission_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
