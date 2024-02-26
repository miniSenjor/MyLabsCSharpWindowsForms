﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }

        string fName="";

        private void z1_Load(object sender, EventArgs e)
        {
            string[] month = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            foreach(string str in month)
            {
                TabPage tabP = new TabPage(str);
                ListBox lb = new ListBox();
                lb.Size = new Size(390, 200);
                tabP.Controls.Add(lb);
                tabControl1.TabPages.Add(tabP);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            
            fName = openFileDialog1.FileName;
            string[] notes = File.ReadAllLines(fName);
            int indexTab = 0;

            foreach (TabPage tabPage in tabControl1.TabPages)
                if (tabPage.Controls[0] is ListBox lb)
                    lb.Items.Clear();

            for(int i = 0; i<notes.Length; i++)
            {
                if (notes[i] == "$")
                    indexTab++;
                else
                {
                    Control control = tabControl1.TabPages[indexTab].Controls[0];
                    if (control is ListBox list)
                        list.Items.Add(notes[i]);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fName == "")
            {
                MessageBox.Show("Файл не выбран");
                return;
            }

            int lengthNotes = 11;
            foreach (TabPage tabP in tabControl1.TabPages)
                if (tabP.Controls[0] is ListBox lb)
                    lengthNotes += lb.Items.Count;
            string[] notes = new string[lengthNotes];
            int index = 0;
            foreach (TabPage tabP in tabControl1.TabPages)
            {
                if (tabP.Controls[0] is ListBox lb)
                {
                    foreach (string note in lb.Items)
                    {
                        notes[index]=note;
                        index++;
                    }
                    if (index<lengthNotes)
                        notes[index++] = "$";
                }
            }
            
            File.WriteAllLines(fName, notes);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = tabControl1.SelectedTab.Controls[0];
            if (control is ListBox lb)
            {
                lb.Items.Add(txtNote.Text);
                txtNote.Text = "";
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = tabControl1.SelectedTab.Controls[0];
            if (control is ListBox lb)
            {
                try
                {
                    int selectIndex = lb.SelectedIndex;
                    lb.Items.Insert(selectIndex, txtNote.Text);
                    lb.Items.RemoveAt(selectIndex + 1);
                    txtNote.Text = "";
                }
                catch { }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = tabControl1.SelectedTab.Controls[0];
            if (control is ListBox lb)
            {
                try
                {
                    lb.Items.RemoveAt(lb.SelectedIndex);
                }
                catch { }
            }
        }
    }
}
