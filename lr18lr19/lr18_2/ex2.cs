using System;
using System.Windows.Forms;

namespace lr18_2
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnNewStringEvenIndex_Click(object sender, EventArgs e)
        {
            //исходная строка
            string s1 = txtString.Text;
            string s2 = "";
            //просмотр символов исходной строки
            for (int i = 0; i < s1.Length; i++)
                //если выполняются заданные условия,
                if (i % 2 != 0 && !char.IsDigit(s1[i]))
                    //то добавляем символ в новую строку
                    s2 += s1[i];
            txtNewString.Text = s2;
        }
    }
}
