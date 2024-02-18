using System;
using System.Drawing;
using System.Windows.Forms;

namespace ex1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        //TwoDShape twoDShape = new TwoDShape(10, "suh");
        TwoDShape twoDShape;
        private void btnArea_Click(object sender, EventArgs e)
        {
            if (rbTriangle.Checked)
            {
                //Triangle triangle;
                if (cBIsosceles.Checked)
                    twoDShape = new Triangle(double.Parse(txtHeight.Text));
                else
                    twoDShape = new Triangle("", double.Parse(txtWidth.Text), double.Parse(txtHeight.Text));
                txtArea.Text = twoDShape.area().ToString();
            }
            else
            {
                //Rectangle rectangle;
                if (cBSquare.Checked)
                    twoDShape = new Rectangle(double.Parse(txtHeight.Text));
                else
                    twoDShape = new Rectangle(double.Parse(txtWidth.Text), double.Parse(txtHeight.Text));
                txtArea.Text = twoDShape.area().ToString();
            }
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            cBIsosceles.Visible = true;
            cBSquare.Visible = false;
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            cBIsosceles.Visible = false;
            cBSquare.Visible = true;
        }

        private void ex1_Load(object sender, EventArgs e)
        {
            cBSquare.Location = new Point(6, 19);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = twoDShape.name;
            }
            catch { }
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
        public Rectangle(double x) : base(x, "квадрат") { }
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
}
