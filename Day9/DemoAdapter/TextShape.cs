using System;

namespace DemoAdapter
{
    public class TextShape : Shape
    {
        private FancyText text;

        public TextShape(char decor, string content)
        {
            text = new FancyText(decor, content);
        }

        public override void Draw()
        {
            text.Display();
        }
    }
}