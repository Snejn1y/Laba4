using System;
using System.Collections.Generic;
using System.Drawing;

namespace Laba4
{
    public abstract class Polygon
    {
        protected List<Point> vertices;
        protected Color color;

        public Polygon(List<Point> vertices, Color color)
        {
            this.vertices = vertices;
            this.color = color;
        }

        public abstract void Move(int deltaX, int deltaY);
        public abstract void Resize(double scaleFactor);
        public abstract void ChangeColor(Color newColor);

        public List<Point> Vertices => vertices;
        public Color Color => color;
    }
}
