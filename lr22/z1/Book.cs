using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Book
    {
        string Name;
        string Autor;
        int CountPages;
        
        //конструктор класса
        public Book(string name, string autor, int countPages)
        {
            this.Name = name;
            this.Autor = autor;
            this.CountPages = countPages;
        }
        //свойство для доступа к имю книги
        public string name
        {
            get { return Name; } //получить y
            set { Name = value; } //установить y
        }
        public string autor
        {
            get { return Autor; } //получить y
            set { Autor = value; } //установить y
        }
        public int countPages
        {
            get { return CountPages; } //получить y
            set { CountPages = value; } //установить y
        }
    }
}
