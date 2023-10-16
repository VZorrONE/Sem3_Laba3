using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_6_1
{
    //nothing more
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //TextBox2.Text = "Характерный размер фигуры = " + "\n";
            double len = Convert.ToDouble(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                Circle c = new Circle(len);
                richTextBox1.Text = ("Площадь окружности = " + Math.Round(c.area(), 3) + "\n" + "Периметр окружности = " + Math.Round(c.perimeter(), 3));
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Square d = new Square(len);
                richTextBox1.Text = ("Площадь квадрата = " + Math.Round(d.area(), 3) + "\n" + "Периметр квадрата = " + Math.Round(d.perimeter(), 3));
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Triangle ee = new Triangle(len);
                richTextBox1.Text = ("Площадь треугольника = " + Math.Round(ee.area(), 3) + "\n" + "Периметр треугольника = " + Math.Round(ee.perimeter(), 3));
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Hexagon f = new Hexagon(len);
                richTextBox1.Text = ("Площадь шестиугольника = " + Math.Round(f.area(), 3) + "\n" + "Периметр шестиугольника = " + Math.Round(f.perimeter(), 3));
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
    abstract class Figure
    {
        public double Length { get; set; }
        protected double Area;
        protected double Perimeter;
        //public static string str;
        public Figure(double len)
        {
            this.Length = len;
            Area = area();
            Perimeter = perimeter();
        }
        
        /*public string InfoFigure()
        {
           string str;
           str = (string)(": площадь =" + Math.Round(Area, 3) +  "периметр =" + Math.Round(Perimeter, 3));
            Console.WriteLine(str);
           return str;
        }
        */
        public abstract double area();
        public abstract double perimeter();

    }
    //квадрат
    class Square : Figure
    {
        public Square(double len) : base(len) { }
        public override double area()
        {
            Area = Length * Length;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 4 * Length;
            return Perimeter;
        }
    }
    //Треугольник
    class Triangle : Figure
    {
        public Triangle(double len) : base(len) { }
        public override double area()
        {
            Area = Length * Length * Math.Sqrt(3) / 4;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 3 * Length;
            return Perimeter;
        }
    }
    //круг
    class Circle : Figure
    {
        public Circle(double len) : base(len) { }
        public override double area()
        {
            Area = Math.PI * Length * Length;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 2 * Math.PI * Length;
            return Perimeter;
        }
    }
    //шестиугольник
    class Hexagon : Figure
    {
        public Hexagon(double len) : base(len) { }
        public override double area()
        {
            Area = Length * Length * 3 * Math.Sqrt(3) / 2;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 6 * Length;
            return Perimeter;
        }
    }
}
