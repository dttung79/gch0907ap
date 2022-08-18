using System;

namespace DemoTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Applicant john = new Applicant("John", 5.0, 2.5);
            RecruitmentProcess p = new DevRecruitment();
            if (p.Recruit(john))
            {
                Console.WriteLine("{0} is qualified. Welcome to our company.", john.Name);
            }
            else
            {
                Console.WriteLine("{0} is not qualified. Wish you luck next time.", john.Name);
            }

            // TODO: Tạo 1 list các ứng viên. Với mỗi ứng viên hỏi muốn ứng tuyển vị trí nào
            // TODO: tạo process tương ứng để ứng tuyển, nếu đạt thì đưa vào list nhân viên mới.
            // TODO: in danh sách nhân viên mới ra màn hình.
        }
    }
}
