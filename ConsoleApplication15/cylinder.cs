using System;

namespace ConsoleApplication15
{
    public class cylinder:circle
    {
        private double h;
        private double tmp;
        public double chieu_cao
        {
            get
            {
                return this.h;
            }
            set
            {
                this.h = value;
            }
        }
        public cylinder()
        { }
        public cylinder(double a,double b, double r,double h):base(a,b,r)
        {
            this.h = h;
        }
        public override double volume()
        {
            tmp = this.area() * h;
            return tmp;
        }
        public override void noti()
        {
            Console.WriteLine("Hinh tru co tam day tai [{0:0.0};{1:0.0}];\nDien tich day la {2:0.0}\nThe tich la: {3:0.0}", this.hoanh_do, this.tung_do, this.area(), this.volume());
        }
    }
}
