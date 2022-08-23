using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public abstract class AbstractFile
    {
        public string Name { get; set; }
        protected int size;

        public AbstractFile(string name, int size)
        {
            Name = name;
            this.size =size;
        }
        public abstract void Show();
        public abstract int GetSize();
    }
}