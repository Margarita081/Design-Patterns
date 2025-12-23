using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_03
{
    public interface IVisitor
    {
        void Visit(Sphere sphere);
        void Visit(Torus torus);
        void Visit(Cube cube);
        void Visit(Parallelepiped parallelepiped);
    }

    public interface IShape
    {
        void Result(IVisitor visitor);
    }

    public class Sphere : IShape
    {
        public double Radius { get; }
        public Sphere(double radius) => Radius = radius;
        public void Result(IVisitor visitor) => visitor.Visit(this);
    }

    public class Parallelepiped : IShape
    {
        public double Lenth { get; }
        public double Width { get; }
        public double Height { get; }
        public Parallelepiped(double l, double w, double h)
        {
            Lenth = l;
            Width = w;
            Height = h;
        }
        public void Result(IVisitor visitor) => visitor.Visit(this);

    }

    public class Torus : IShape
    {
        public double MajorRadius { get; }
        public double MinorRadius { get; }
        public Torus(double r1, double r2)
        {
            MajorRadius = r1;
            MinorRadius = r2;
        }
        public void Result(IVisitor visitor) => visitor.Visit(this);

    }

    public class Cube : IShape
    {
        public double Side { get; }
        public Cube(double side) => Side = side;
        public void Result(IVisitor visitor) => visitor.Visit(this);
    }

    public class Calculator : IVisitor
    {
        public double Formula { get; private set; }
        public void Visit(Sphere sphere)
        {
            Formula = (4.0 / 3.0) * Math.PI * Math.Pow(sphere.Radius, 3);
        }
        public void Visit(Cube cube)
        {
            Formula = Math.Pow(cube.Side, 3);
        }

        public void Visit(Parallelepiped parallelepiped)
        {
            Formula = parallelepiped.Lenth * parallelepiped.Width * parallelepiped.Height;
        }

        public void Visit(Torus torus)
        {
            Formula = (2 * Math.PI * torus.MajorRadius) * (Math.PI * Math.Pow(torus.MinorRadius, 2));
        }
    }

}
