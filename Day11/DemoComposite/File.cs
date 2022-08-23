using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class File : AbstractFile
    {
        public File(string name, int size) : base(name, size)
        {}

        public override void Show()
        {
            Console.WriteLine(String.Format("{0,5}{1, 25}{2, 10}", "-", Name, size));
        }

        public override int GetSize()
        {
            return size;
        }
    }
}