using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class PhotoDemo
    {
        static void Main()
        {
            Photo photoGraphs1 = new Photo(10, 8);
            MattedPhoto photoGraphs2 = new MattedPhoto("blue");
            FramedPhoto photoGraphs3 = new FramedPhoto("Silver", "Modern");

            photoGraphs2.Height = 12;
            photoGraphs2.Width = 10;
            photoGraphs3.Height = 18;
            photoGraphs3.Width = 16;

            WriteLine(photoGraphs1.ToString());
            WriteLine(photoGraphs2.ToString());
            WriteLine(photoGraphs3.ToString());
            Read();
        }
    }
    class Photo
    {
        private double width;
        private double height;
        protected double price;

        //properties
        public double Width
        {
            
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public double Height
        {

            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        //Constructors
        public Photo()
        {

        }
        public Photo(double h, double w)
        {
            height = h;
            width = w;

            if (w == 8 && h == 10)
            {
                price = 3.99;
            }
            else if (w == 10 && h == 12)
            {
                price = 5.99;
            }
            else 
            {
                price = 9.99;
            }
        }
        //To String Override
        public override string ToString()
        {            
            return  "Type:" + GetType() + "\n  Width: " + width + "  Height: " + height + "  Price: "
                + price;            
        }
    }
    class MattedPhoto : Photo
    {
        public string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        //Constructors
        public MattedPhoto(string c)
        {
            color = c;
            if (Width == 8 && Height == 10)
            {
                price = 3.99 + 10.00;
            }
            else if (Width == 10 && Height == 12)
            {
                price = 5.99 + 10.00;
            }
            else
            {
                price = 9.99 + 10.00;
            }
        }
        public MattedPhoto(double w, double h, string c)
        {
            Width = w;
            Height = h;
            color = c;
        }
        public override string ToString()
        {
            return  "Type:" + GetType() + "\n  Width: " + Width + "  Height: " + Height + "  Color: " + Color + "  Price: "
                + price;            
        }
    }
    class FramedPhoto : Photo
    {
        public string frameMaterial;
        public string frameStyle;

        //Properties
        public string FrameMaterial
        {
            get
            {
                return frameMaterial;
            }
            set
            {
                frameMaterial = value;
            }
        }
        public string FrameStyle
        {
            get
            {
                return frameStyle;
            }
            set
            {
                frameStyle = value;
            }
        }

        //Constructors
        public FramedPhoto()
        {

        }
        public FramedPhoto(string silver, string modern)
        {
            frameMaterial = silver;
            frameStyle = modern;

            if (Width == 8 && Height == 10)
            {
                price = 3.99 + 25.00;
            }
            else if (Width == 10 && Height == 12)
            {
                price = 5.99 + 25.00;
            }
            else
            {
                price = 9.99 + 25.00;
            }
        }
        public FramedPhoto(double w, double h, string silver, string modern)
        {
            frameMaterial = silver;
            frameStyle = modern;

            if (w == 8 && h == 10)
            {
                price = 3.99 + 25.00;
            }
            else if (w == 10 && h == 12)
            {
                price = 5.99 + 25.00;
            }
            else
            {
                price = 9.99 + 25.00;
            }
        }
        public override string ToString()
        {
            return  "Type:" + GetType() + "\n  Width: " + Width + "  Height: " + Height + "" +
                "  frameMaterial: " + frameMaterial + "  frameStyle: " + frameStyle + "  Price: "
                + price;
        }
    }
}
