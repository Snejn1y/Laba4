using System;
using System.Collections.Generic;
using System.Drawing;

namespace Laba4
{
    public class Quadrilateral : Polygon
    {
        public Quadrilateral(List<Point> vertices, Color color) : base(vertices, color)
        {
            if (vertices.Count != 4)
                throw new ArgumentException("A quadrilateral must have 4 vertices.");
        }

        public override void Move(int deltaX, int deltaY)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point(vertices[i].X + deltaX, vertices[i].Y + deltaY);
            }
        }

        public override void Resize(double scaleFactor)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point((int)(vertices[i].X * scaleFactor), (int)(vertices[i].Y * scaleFactor));
            }
        }

        public override void ChangeColor(Color newColor)
        {
            color = newColor;
        }
    }
}
