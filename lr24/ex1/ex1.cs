using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcDemo1.Fun(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcDemo2.Fun(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcDemo3.Fun(textBox3);
        }
    }

    class ExcDemo1
    {
        public static void Fun(TextBox textBox)
        {
            int[] nums = new int[4];
            try
            {
                textBox.Text = "Перед генерированием исключения.\r\n";
                // Генерируем исключение, связанное с попаданием
                // индексавнедиапазона,
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    textBox.Text+=$"nums[{i}]: {nums[i]}\r\n";
                }
                textBox.Text+="Этот текст не отображается.\r\n";
            }
            catch (IndexOutOfRangeException)
            {
                // Перехватываем исключение.
                textBox.Text+="Индекс вне диапазона!\r\n";
            }
            textBox.Text+="После catch-инструкции.\r\n";
        }
    }

    class ExcDemo2
    {
        public static void Fun(TextBox textBox)
        {
            textBox.Text = "";
            // Здесь массив numer длинне массива denom.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    textBox.Text+=numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i];
                }
                catch (DivideByZeroException)
                {// Перехватываем исключение
                    textBox.Text+="Делитьнанульнельзя!";
                }
                catch (IndexOutOfRangeException)
                {
                    // Перехватываем исключение.
                    textBox.Text+="Нет соответствующего элемента.";
                }
            }
        }
    }

    class ExcDemo3
    {
        public static void Fun(TextBox textBox)
        {
            textBox.Text = "";
            // Здесь массив numer длиннее массива denoiti.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                }
                catch
                {
                    Console.WriteLine("Произошло некоторое исключение.");
                }
            }
        }
    }
}
