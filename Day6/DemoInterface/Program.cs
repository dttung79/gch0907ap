﻿using System;
using ShapeProject;
using System.Collections.Generic;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawingObjects = new List<IDrawable>();
            drawingObjects.Add(new Rectangle("Rectangle", 5, 2));
            drawingObjects.Add(new Text("Hello World"));

            foreach (IDrawable obj in drawingObjects)
            {
                obj.Draw();
            }
        }
    }
}
