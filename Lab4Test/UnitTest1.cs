using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using Laba4;

namespace Lab4Test
{
    public class TestTriangle
    {
        [Test]
        public void TestTriangleMove()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
            Triangle triangle = new Triangle(vertices, Color.Red);

            triangle.Move(2, 3);
            Assert.Multiple(() =>
            {
                Assert.That(triangle.Vertices[0], Is.EqualTo(new Point(2, 3)));
                Assert.That(triangle.Vertices[1], Is.EqualTo(new Point(3, 3)));
                Assert.That(triangle.Vertices[2], Is.EqualTo(new Point(2, 4)));
            });
        }

        [Test]
        public void TestTriangleResize()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
            Triangle triangle = new Triangle(vertices, Color.Red);

            triangle.Resize(2);
            Assert.Multiple(() =>
            {
                Assert.That(triangle.Vertices[0], Is.EqualTo(new Point(0, 0)));
                Assert.That(triangle.Vertices[1], Is.EqualTo(new Point(2, 0)));
                Assert.That(triangle.Vertices[2], Is.EqualTo(new Point(0, 2)));
            });
        }

        [Test]
        public void TestTriangleChangeColor()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
            Triangle triangle = new Triangle(vertices, Color.Red);

            triangle.ChangeColor(Color.Blue);

            Assert.That(triangle.Color, Is.EqualTo(Color.Blue));
        }
    }

    public class TestQuadrilateral
    {
        [Test]
        public void TestQuadrilateralMove()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1) };
            Quadrilateral quadrilateral = new Quadrilateral(vertices, Color.Red);

            quadrilateral.Move(2, 3);
            Assert.Multiple(() =>
            {
                Assert.That(quadrilateral.Vertices[0], Is.EqualTo(new Point(2, 3)));
                Assert.That(quadrilateral.Vertices[1], Is.EqualTo(new Point(3, 3)));
                Assert.That(quadrilateral.Vertices[2], Is.EqualTo(new Point(3, 4)));
                Assert.That(quadrilateral.Vertices[3], Is.EqualTo(new Point(2, 4)));
            });
        }

        [Test]
        public void TestQuadrilateralResize()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1) };
            Quadrilateral quadrilateral = new Quadrilateral(vertices, Color.Red);

            quadrilateral.Resize(2);
            Assert.Multiple(() =>
            {
                Assert.That(quadrilateral.Vertices[0], Is.EqualTo(new Point(0, 0)));
                Assert.That(quadrilateral.Vertices[1], Is.EqualTo(new Point(2, 0)));
                Assert.That(quadrilateral.Vertices[2], Is.EqualTo(new Point(2, 2)));
                Assert.That(quadrilateral.Vertices[3], Is.EqualTo(new Point(0, 2)));
            });
        }

        [Test]
        public void TestQuadrilateralChangeColor()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1) };
            Quadrilateral quadrilateral = new Quadrilateral(vertices, Color.Red);

            quadrilateral.ChangeColor(Color.Blue);

            Assert.That(quadrilateral.Color, Is.EqualTo(Color.Blue));
        }
    }   

    public class TestPentagon
    {
        [Test]
        public void TestPentagonMove()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1), new Point(0, 2) };
            Pentagon pentagon = new Pentagon(vertices, Color.Red);

            pentagon.Move(2, 3);
            Assert.Multiple(() =>
            {
                Assert.That(pentagon.Vertices[0], Is.EqualTo(new Point(2, 3)));
                Assert.That(pentagon.Vertices[1], Is.EqualTo(new Point(3, 3)));
                Assert.That(pentagon.Vertices[2], Is.EqualTo(new Point(3, 4)));
                Assert.That(pentagon.Vertices[3], Is.EqualTo(new Point(2, 4)));
                Assert.That(pentagon.Vertices[4], Is.EqualTo(new Point(2, 5)));
            });
        }

        [Test]
        public void TestPentagonResize()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1), new Point(0, 2) };
            Pentagon pentagon = new Pentagon(vertices, Color.Red);

            pentagon.Resize(2);
            Assert.Multiple(() =>
            {
                Assert.That(pentagon.Vertices[0], Is.EqualTo(new Point(0, 0)));
                Assert.That(pentagon.Vertices[1], Is.EqualTo(new Point(2, 0)));
                Assert.That(pentagon.Vertices[2], Is.EqualTo(new Point(2, 2)));
                Assert.That(pentagon.Vertices[3], Is.EqualTo(new Point(0, 2)));
                Assert.That(pentagon.Vertices[4], Is.EqualTo(new Point(0, 4)));
            });
        }

        [Test]
        public void TestPentagonChangeColor()
        {
            List<Point> vertices = new List<Point> { new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1), new Point(0, 2) };
            Pentagon pentagon = new Pentagon(vertices, Color.Red);

            pentagon.ChangeColor(Color.Blue);

            Assert.That(pentagon.Color, Is.EqualTo(Color.Blue));
        }   
    }
}