using System;
using System.Collections.Generic;

namespace ShapeProject
{
    public class ShapeManager
    {
        private List<Shape> shapes;
        private const int CIRCLE = 1;
        private const int RECTANGLE = 2;
        private const int SQUARE = 3;
        private const int SEARCH = 4;
        private const int EXIT = 0;

        public ShapeManager()
        {
            shapes = new List<Shape>();
        }
        // public void Run()
        // {
        //     bool running = true;
        //     while (running)
        //     {
        //         PrintMenu();
        //         int choice = GetChoice();
        //         DoTask(choice);
        //         running = choice == 0;
        //     }
        // }
    }
}