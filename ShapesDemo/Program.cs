using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Square sq1 = new Square(15, 15);
            Square sq2 = new Square(20);
            Triangle triangle = new Triangle(80, 50);

            GeometricFigure[] shapes = new GeometricFigure[] { rectangle, sq2, triangle, sq1 };

            foreach (GeometricFigure shapeData in shapes)
            {
                DisplayShapeData(shapeData);
            }
            ReadKey();
        }
        private static void DisplayShapeData(GeometricFigure shapeData)
        {
            WriteLine("Shape:  {0}\nWidth:  {1} cm\nHeight:  {2} cm\nArea:  {3} cm^2\n",
                shapeData.GetType().ToString().Substring(shapeData.GetType().ToString().IndexOf(".") + 1),
                shapeData.Width, shapeData.Height, shapeData.Area);
        }
    }
    abstract class GeometricFigure
    {
        private float width;
        private float height;
        protected float area;
        public float Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
                this.ComputeArea();
            }
        }
        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
                this.ComputeArea();
            }
        }
        public float Area
        {
            get
            {
                return this.area;
            }
        }
        public GeometricFigure(float w, float h)
        {
            this.Width = w;
            this.Height = h;
        }
        public abstract void ComputeArea();
    }
    class Rectangle : GeometricFigure
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }
        public override void ComputeArea()
        {
            this.area = this.Width * this.Height;
        }
    }
    class Square : Rectangle
    {
        public Square(int w, int h) : base(w, h)
        {
        }
        public Square(int w) : this(w, w)
        {
        }
        public override void ComputeArea()
        {
            this.area = this.Width * this.Height;
        }
    }
    class Triangle : GeometricFigure
    {
        public Triangle(int w, int h) : base(w, h)
        {
        }
        public override void ComputeArea()
        {
            this.area = this.Width * this.Height / 2;
        }
    }
}


    
