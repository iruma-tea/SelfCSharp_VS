﻿namespace SelfCSharp.Chap07.Practice
{
    internal class Circle
    {
        double radius;

        public Circle(double radius = 1)
        {
            this.radius = radius;
        }

        //public Circle() : this(1) { }

        public double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }
    }

    internal class PCircle
    {
        static void Main(string[] args)
        {
            var c = new Circle(10);
            //var c = new Circle();
            Console.WriteLine(c.GetArea());
        }

    }
}
