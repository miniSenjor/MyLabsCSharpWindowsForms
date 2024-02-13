using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Point : IComparable
    {
        float X; //координаты точки
        float Y;
        //конструктор класса
        public Point(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        //свойство для доступа к координате х
        public float x
        {
            get { return X; } //получить х
            set { X = value; } //установить х
        }
        //свойство для доступа к координате y
        public float y
        {
            get { return Y; } //получить y
            set { Y = value; } //установить y
        }
        //установить способ сравнения объектов-точек
        public int CompareTo(object obj)
        {
            //преобразуем параметр obj к типу точки
            Point p = (Point)obj;
            if (x > p.x) //сравниваем координаты х
                return 1; //и возвращаем либо положительное,
            if (x == p.x)
                return 0; //либо нулевое,
            return -1; //либо отрицательное значение
        }
    }
}
