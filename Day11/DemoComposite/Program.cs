using System;

namespace DemoComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            File sysbin = new File("System.bin", 300);
            File asm1 = new File("AS1.docx", 500);
            File asmppt = new File("AS1.pptx", 700);
            File spider = new File("Spider man.mp4", 10000);
            File xmen = new File("X-men.mp4", 20000);

            Directory documents = new Directory("Documents");
            documents.Add(asm1);
            documents.Add(asmppt);

            Directory movies = new Directory("Movies");
            movies.Add(spider);
            movies.Add(xmen);

            Directory c = new Directory("C");
            c.Add(sysbin);
            c.Add(documents);
            c.Add(movies);

            c.Show();
        }
    }
}
