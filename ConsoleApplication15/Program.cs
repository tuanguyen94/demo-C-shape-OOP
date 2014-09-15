using System;


namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            double hd;
            double td;
            double bk;
            double cc;
            int i;
            Console.WriteLine("Chon doi tuong :");
            Console.WriteLine("1. Diem");
            Console.WriteLine("2. Hinh tron");
            Console.WriteLine("3. Hinh tru");
            i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                    {
                        Console.WriteLine("Nhap vao hoanh do cua diem: ");
                        hd = double.Parse(Console.ReadLine());
                        Console.WriteLine("nhap vao tung do cua diem: ");
                        td = double.Parse(Console.ReadLine());
                        point p = new point(hd, td);
                        p.noti();
                    }break;
                case 2:
                    {
                        Console.WriteLine("Nhap vao hoanh do cua tam: ");
                        hd = double.Parse(Console.ReadLine());
                        Console.WriteLine("nhap vao tung do cua tam: ");
                        td = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao ban kinh kinh tron: ");
                        bk = double.Parse(Console.ReadLine());
                        circle c = new circle(hd, td, bk);
                        c.noti();
                    }break;
                case 3:
                    {
                        Console.WriteLine("Nhap vao hoanh do cua tam day: ");
                        hd = double.Parse(Console.ReadLine());
                        Console.WriteLine("nhap vao tung do cua tam day: ");
                        td = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao ban kinh day: ");
                        bk = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap vao chieu cao hinh tru: ");
                        cc = double.Parse(Console.ReadLine());
                        cylinder cy = new cylinder(hd, td, bk, cc);
                        cy.noti();
                    }break;
            }
            Console.ReadLine();

        }
    }
}
