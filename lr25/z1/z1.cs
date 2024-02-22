using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьВКонецСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьСтрокуИзСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbSentence.Items.RemoveAt(lbSentence.SelectedIndex);
        }

        private void изменитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbSentence.Items.Clear();
        }

        private void очиститьОкноВыводаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSentence.Text = "";
        }

        private void скопироватьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        ListBox nowList;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSentence.Text=="" || txtSentence.Text=="$")
            {
                MessageBox.Show("Введите строку");
                return;
            }
            lbSentence.Items.Add(txtSentence.Text);
            listOfList[selectedList].Add(txtSentence.Text);
            saveFile(listOfList);
        }

        private void btnChangeStr_Click(object sender, EventArgs e)
        {
            if (txtSentence.Text == "" || txtSentence.Text == "$")
            {
                MessageBox.Show("Введите строку");
                return;
            }
            nowList.Items[nowList.SelectedIndex] = txtSentence.Text;
            listOfList[selectedList][nowList.SelectedIndex] = txtSentence.Text;
            saveFile(listOfList);
        }

        private void btnGenerateOn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            txtSentence.Text = lbVerbs.Items[rand.Next(lbVerbs.Items.Count)].ToString()+" ";
            txtSentence.Text += lbAdjectives.Items[rand.Next(lbAdjectives.Items.Count)].ToString()+" ";
            txtSentence.Text += lbNouns.Items[rand.Next(lbNouns.Items.Count)].ToString();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtSentence.Text = "";
        }

        private void lbSentence_MouseClick(object sender, MouseEventArgs e)
        {
            nowList = lbSentence;
            selectedList = 3;
        }

        private void lbVerbs_MouseClick(object sender, MouseEventArgs e)
        {
            nowList = lbVerbs;
            selectedList = 0;
        }

        private void lbAdjectives_MouseClick(object sender, MouseEventArgs e)
        {
            nowList = lbAdjectives;
            selectedList = 1;
        }

        private void lbNouns_MouseClick(object sender, MouseEventArgs e)
        {
            nowList = lbNouns;
            selectedList = 2;
        }

        List <List<string>>  listOfList = new List<List<string>>() { new List<string>() };
        int selectedList = 0;
        private void z1_Load(object sender, EventArgs e)
        {
            string[] list = File.ReadAllLines("C:/Users/Пользователь/Documents/КУСТ/wf/All/lr25/z1/Lists.txt");
            int k = 0;
            for (int i=0; i<list.Length; i++)
            {
                if (list[i]=="$")
                {
                    listOfList.Add(new List<string>());
                    k++;
                    continue;
                }
                listOfList[k].Add(list[i]);
            }


            foreach (string str in listOfList[0])
            {
                lbVerbs.Items.Add(str);
            }
            foreach (string str in listOfList[1])
            {
                lbAdjectives.Items.Add(str);
            }
            foreach (string str in listOfList[2])
            {
                lbNouns.Items.Add(str);
            }
            if (listOfList.Count > 3)
                foreach (string str in listOfList[3])
                {
                    lbSentence.Items.Add(str);
                }
        }

        private void saveFile(List<List<string>> lst)
        {
            int lengthArrStr = lst.Count-1;
            for (int i=0; i<lst.Count; i++)
            {
                for (int j = 0; j < lst[i].Count; j++)
                    lengthArrStr++;
            }
            int k = 0;
            string[] arrStr = new string[lengthArrStr];
            foreach (List<string> l in lst)
            {
                foreach (string str in l)
                {
                    arrStr[k] = str;
                    k++;
                }
                if (k<lengthArrStr)
                arrStr[k] = "$";
                k++;
            }
            File.WriteAllLines("C:/Users/Пользователь/Documents/КУСТ/wf/All/lr25/z1/Lists.txt", arrStr);
        }
    }
}
