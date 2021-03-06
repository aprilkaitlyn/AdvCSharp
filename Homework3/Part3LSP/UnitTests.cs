using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW3part3.Test
{
    [TestClass]
    public class CalculateAreaShouldReturn //none of this changes
    {
        [TestMethod]
        public void SixFor2X3Rectangle() //passes
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, AreaCalculator.CalculateArea(myRectangle));
        }

        [TestMethod]
        public void NineFor3X3Square() //passes
        {
            var mySquare = new Square() { Height = 3 };
            Assert.AreEqual(9, AreaCalculator.CalculateArea(mySquare));
        }

        [TestMethod]
        public void TwentyFor4X5RectangleFromSquare() //now passes
        {
            Rectangle newRectangle = new Square();
            newRectangle.Width = 4;
            newRectangle.Height = 5;
            Assert.AreEqual(20, AreaCalculator.CalculateArea(newRectangle)); //original -- expected 20, actual 25
        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangle() //passes
        {
            Shape myShape = new Rectangle() { Height = 4, Width = 5 };
            Assert.AreEqual(20, myShape.Area());
        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square() //passes
        {
            var shapes = new List<Shape>
                             {
                                new Rectangle {Height = 4, Width = 5},
                                new Square {SideLength = 3}
                             };
            var areas = new List<int>();
            foreach (Shape shape in shapes)
            {
                areas.Add(shape.Area());
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]); //original -- expected 9, actual 0 (square)
        } 
    }

    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    }

    public class Shape //new parent class
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public virtual int SideLength { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }

    public class Rectangle : Shape //now implements Shape
    {
        public override int Height { get; set; }
        public override int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;
        private int _side; //added

        public override int Width
        {
            get { return _width; }
            set { _width = value; }  //removed _height
        }

        public override int Height
        {
            get { return _height; }
            set { _height = value; }  //removed _width
        }

        public override int SideLength //added, side length = width & height
        {
            get { return _side; }
            set { _side = value;
                _height = value;
                 _width = value; }
        }
    }
}
