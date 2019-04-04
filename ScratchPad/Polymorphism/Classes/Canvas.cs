using System;
using System.Collections.Generic;

namespace Polymorphism.Classes
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
               shape.Draw();
            }
        }

    }
}