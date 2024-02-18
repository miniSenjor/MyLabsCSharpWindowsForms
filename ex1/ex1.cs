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

        }
    }
    //сигнатура метода - имя тип параметров метода
    abstract class TwoDShape
    {
        double pri_width; // Закрытый член,
        double pri_height; // Закрытый член,
        string pri_name; // Закрытый член.
        public TwoDShape()
        {// Конструктор по умолчанию,
            width = height = 0.0;
            name = "null";
        }
        // Конструктор с параметрами.
        public TwoDShape(double w, double h, string n)
        {
            width = w; height = h; name = n;
        }
        // Создаем объект, у которого ширина равна высоте,
        public TwoDShape(double x, string n)
        {
            width = height = x; name = n;
        }
        // Создаем объект из объекта,
        public TwoDShape(TwoDShape ob)
        {
            width = ob.width; height = ob.height; name = ob.name;
        }
        // Свойства width, height и name,
        public double width
        {
            get { return pri_width; }
            set { pri_width = value; }
        }
        public double height
        {
            get { return pri_height; }
            set { pri_height = value; }
        }
        public string name
        {
            get { return pri_name; }
            set { pri_name = value; }
        }
        public void showDim()
        {
            Console.WriteLine("Ширина и высота равны " + width + " и " + height);
        }
        // Теперь метод аrеа() абстрактный,
        public abstract double area();
    }
    // Класс треугольников, производный от класса TwoDShape.
    class Triangle : TwoDShape
    {
        string style; // Закрытый член.
                      // Конструктор по умолчанию,
        public Triangle()
        {
            style = "null";
        }
        // Конструктор с параметрами.
        public Triangle(string s, double w, double h) :
        base(w, h, "triangle")
        {
            style = s;
        }
        // Создаем равнобедренный треугольник.
        public Triangle(double x) : base(x, "треугольник")
        {
            style = "равнобедренный";
        }
        // Создаем объект из объекта. ,
        public Triangle(Triangle ob) : base(ob)
        {
            style = ob.style;
        }
        // Переопределяем метод аrеа() для класса Triangle,
        public override double area() { return width * height / 2; }
        // Отображаем тип треугольника,
        public void showStyle()
        {
            Console.WriteLine("Треугольник " + style);
        }
    }
        //Класс прямоугольников, производный от класса TwoDShape.
    class Rectangle : TwoDShape
    {
        // Конструктор с параметрами.
        public Rectangle(double w, double h) :
        base(w, h, "прямоугольник")
        { }
        // Создаем квадрат.
        public Rectangle(double x) : base(x, "прямоугольник") { }
        // Создаем объект из объекта.
        public Rectangle(Rectangle ob) : base(ob) { }
        // Метод возвращает значение true, если
        // прямоугольник является квадратом,
        public bool isSquare()
        {
            if (width == height) return true;
            return false;
        }
        // Переопределяем метод аrеа() для класса Rectangle,
        public override double area()
        {
            return width * height;
        }
    }
    class AbsShape
    {
        public static void Main()
        {
            TwoDShape[] shapes = new TwoDShape[4];
            shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объектом является " + shapes[i].name);
                Console.WriteLine("Площадь равна " + shapes[i].area());
                Console.WriteLine("gotovo");
            }
        }
    }

}
