using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Square square = new Square(10, 10);
            Square s2 = new Square(20);
            Triangle triangle = new Triangle(100, 50);

            GeometricFigure[] shape = new GeometricFigure[] { rectangle, square, s2, triangle };

            foreach (GeometricFigure Shape in shape)
            {
                DisplayShapeData(Shape);
            }
            ReadLine();
        }

        private static void DisplayShapeData(GeometricFigure Shape)
        {
            WriteLine("Shape: {0}\nWidth: {1} cm\nHeight: {2} cm\nArea: {3} cm^2\n",
                Shape.GetType().ToString().Substring(Shape.GetType().ToString().IndexOf(".") + 1),
                Shape.Width, Shape.Height, Shape.Area);
        }
    }
    abstract class GeometricFigure
    {
        private float _width;
        private float _height;
        protected float _area;

        public float Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                this.ComputeArea();
            }
        }

        public float Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                this.ComputeArea();
            }
        }

        public float Area
        {
            get
            {
                return this._area;
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
            this._area = this.Width * this.Height;
        }
    }
    class Square : Rectangle
    {
        public Square(int w, int h) : base(w, w)
        {
        }

        public Square(int w) : this(w, w)
        {
        }
    }
    class Triangle : GeometricFigure
    {
        public Triangle(int w, int h) : base(w, h)
        {
        }

        public override void ComputeArea()
        {
            this._area = this.Width * this.Height / 2;
        }
    }
}


