using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr12
{
    public partial class FormMas : Form
    {
        public FormMas()
        {
            InitializeComponent();
        }

        private void btnCreateMas_Click(object sender, EventArgs e)
        {
            txtMas.Text = "";
            txtMasRev.Text = "";
            txtMasOdd.Text = "";
            txtMasEven.Text = "";
            try
            {
                Random rand = new Random();
                int[] mas = new int[Convert.ToInt32(txtN.Text)];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rand.Next(20);
                    //2-ой текст массив
                    txtMas.Text += $"{mas[i]} ";
                }

                //3-ий текст Обратный массив
                mas.Reverse();
                for (int i = 0; i < mas.Length; i++)
                    txtMasRev.Text += $"{mas[i]} ";

                //4-ый текст нечетный
                mas.Reverse();
                int qOdd = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] % 2 == 1)
                    {
                        txtMasOdd.Text += $"{mas[i]} ";
                        qOdd++;
                    }
                    lblQuantOdd.Text = "кол-во:" + qOdd;
                }

                //5-ый текст четный
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] % 2 == 0)
                        txtMasEven.Text += $"{mas[i]} ";
                    lblQuantEven.Text = "кол-во:" + (mas.Length - qOdd);
                }
            }
            catch
            {
                MessageBox.Show("Введите кол-во элементов");
            }
        }
    }
}
