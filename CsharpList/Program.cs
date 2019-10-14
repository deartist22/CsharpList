using System;
using System.Reflection;
using System.Collections.Generic;

namespace CsharpList
{

    class Shapes
    {
        private int sides, width, height;

        public Shapes()
        {
        }

        public Shapes(int s, int w, int h)
        {
            sides = s;
            width = w;
            height = h;
        }

        public int Sides
        {
            get
            {
                return sides;
            }
            set
            {
                sides = value;
            }
        }

        public int Width
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

        public int Height
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

    }

    class Triangle : Shapes
    {


        public Triangle(int s, int w, int h)
            : base(s, w, h) { }

        public void triangleareaCalculation(double userInput)
        {
            Console.WriteLine("Please enter the base length");
            userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of the triangle is: {0}", triangleFormula(userInput));
        }

        private double triangleFormula(double ground)
        {
            double total = ground * Height / 2.0;
            //Convert.ToDecimal(string.Format("{0:F2}", Debitvalue));
            //decimal f = Decimal.Parse(total.ToString("0.00"));
            //int i = 7122960;
            double d = (double)total / 100;
            return total;
        }
    }

    class Square : Shapes
    {
        public Square(int s, int w, int h)
            :base(s, w, h)
        {

        }

        public void squareareaCalculation()
        {
            Console.WriteLine("The area of a square is: {0}", squareFormula());
        }

        private int squareFormula()
        {
            return Height * Width;
        }
    }

    class Circle : Shapes
    {
        private int radius;

        public Circle(int r)
            : base()
        {
            radius = r;
        }

        public void circleareaFormula()
        {
            Console.WriteLine("The circle radius is {0} and the diameter is {1}", radius, diameterFormula());
        }

        private int diameterFormula()
        {
            return radius * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapeList = new List<Shapes>() ;
            Triangle t1 = new Triangle(3, 4, 5);
            t1.triangleareaCalculation(5);
            Square s1 = new Square(4, 3, 5);
            s1.squareareaCalculation();
            Circle c1 = new Circle(3);
            c1.circleareaFormula();
            shapeList.Add(t1);
            shapeList.Add(s1);
            shapeList.Add(c1);
            Console.WriteLine();

            foreach(Shapes shape in shapeList)
            {
                Console.WriteLine(shape);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
