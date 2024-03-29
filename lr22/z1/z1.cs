﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace z1
{
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }
        /*
        /// <summary>
        /// Это наша функция для АДАДАД
        /// </summary>*/
        List<Book> books = new List<Book>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string autor = txtAutor.Text;
                int countPages = int.Parse(txtCountPages.Text);
                Book book = new Book(name, autor, countPages);
                books.Add(book);
                txtName.Text = "";
                txtAutor.Text = "";
                txtCountPages.Text = "";
            }
            catch
            {
                MessageBox.Show("Не корректный ввод");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            txtBooks.Text = "";
            foreach(Book book in books)
            {
                if (book.autor.ToLower().Contains("пушкин"))
                    txtBooks.Text += $"{book.name} {book.autor} {book.countPages}\r\n";
            }
        }
    }
}
