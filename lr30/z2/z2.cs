using System;
using System.Windows.Forms;

namespace z2
{
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double side1, side2, side3, angle1, angle2, angle3, area;
                side1 = double.Parse(textBox1.Text);
                side2 = double.Parse(textBox2.Text);
                if (rb3Side.Checked)
                {
                    side3 = double.Parse(textBox3.Text);
                    angle1 = calcAngle(side2, side3, side1);
                    angle2 = calcAngle(side1, side3, side2);
                    angle3 = 180 - angle1 - angle2;
                }
                else
                {
                    angle3 = double.Parse(textBox3.Text);
                    side3 = side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angle3/180*Math.PI);
                    angle1 = calcAngle(side2, side3, side1);
                    angle2 = 180 - angle1 - angle3;
                }
                area = side1 * side2 * Math.Sin(angle3/180*Math.PI)/2;
                txtInfo.Text = $"Длинны сторон: {side1} {side2} {side3}\r\n" +
                    $"Углы: {angle1} {angle2} {angle3}\r\n" +
                    $"Площадь: {area}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        double calcAngle(double s1, double s2, double s3)
        {
            return 180*Math.Acos((s1*s1+s2*s2-s3*s3)/(2*s1*s2))/Math.PI;
        }

        private void rb3Side_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Сторона 3";
        }

        private void rb2Side1Angle_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Угол";
        }
    }
}