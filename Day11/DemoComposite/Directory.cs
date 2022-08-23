using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class Directory : AbstractFile
    {
        public const int FOLDER_SIZE = 32;
        private List<AbstractFile> children;

        public Directory(string name) : base(name, FOLDER_SIZE)
        {
            children = new List<AbstractFile>();
        }

        public override void Show()
        {
            Console.WriteLine(String.Format("{0, 5}{1, 25}{2, 10}", "+", Name, GetSize()));
            Console.WriteLine("----------------------------------------------");
            foreach (AbstractFile f in children)
            {
                f.Show();
            }
        }

        public override int GetSize()
        {
            int sum = 0;
            foreach (AbstractFile f in children)
                sum += f.GetSize();
            
            return size + sum;
        }

        public void Add(AbstractFile f)
        {
            children.Add(f);
        }
        public void Del(AbstractFile f)
        {
            children.Remove(f);
        }
    }
}