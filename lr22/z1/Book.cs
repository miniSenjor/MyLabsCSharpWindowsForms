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
            get { return name; } //получить y
            set { Name = value; } //установить y
        }
        public string autor
        {
            get { return autor; } //получить y
            set { Autor = value; } //установить y
        }
        public int countPages
        {
            get { return countPages; } //получить y
            set { CountPages = value; } //установить y
        }
        /*установить способ сравнения объектов-точек
        public int CompareTo(object obj)
        {
            //преобразуем параметр obj к типу точки
            Point p = (Point)obj;
            if (x > p.x) //сравниваем координаты х
                return 1; //и возвращаем либо положительное,
            if (x == p.x)
                return 0; //либо нулевое,
            return -1; //либо отрицательное значение
        }*/
    }
}
