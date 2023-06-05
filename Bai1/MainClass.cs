using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    enum UserAction
    {
        Add,
        Find,
        Print,
        Quit
    }
    class MainClass
    {
        public static void Main(String[] args)
        {
            QLCB qLCB = new QLCB();
            
            bool quitting = false;
            start:
            Console.WriteLine(
@"Đây là chương trình quản lý cán bộ.
Nhập Add để thêm cán bộ.
Nhập Find để bắt đầu tìm kiếm.
Nhập Print để hiển thị thông tin danh sách các cán bộ nhân viên.
Nhập Quit để thoát chương trình.");
            string input = Console.ReadLine();
            UserAction action;
            if (!Enum.TryParse(input,true,out action))
            {
                Console.WriteLine("Vui lòng nhập đúng 1 trong các thao tác Add, Find, Print, Quit");
                goto start;
            }
            switch (action)
            {
                case UserAction.Add:
                    qLCB.AddCanBo();

                    break;


                case UserAction.Find:
                    Console.WriteLine("Nhập tên cán bộ cần tìm:");
                    string query = Console.ReadLine();
                    qLCB.Print(qLCB.FindCanBo(query));
                    break;
                case UserAction.Print:
                    Console.WriteLine("Đây là danh sách các nhân viên trong công ty:");
                    qLCB.Print(qLCB.ListCanBo());
                    break;
                case UserAction.Quit:
                    qLCB.Quit();
                    quitting = true;
                    break;

            }
            if (!quitting) goto start;
        }
    }
}

