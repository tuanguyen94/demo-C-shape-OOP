using System;


namespace ConsoleApplication15
{
    public class circle : point
    {
        private double r;
        private double tmp;
        public double ban_kinh
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }
        public circle():base()
        { }
        public circle(double a,double b,double r):base(a,b)
        {
            this.r = r;
        }
        public override double area()
        {
            tmp=r*r*Math.PI;
            return tmp;
        }
        public override void noti()
        {
            Console.WriteLine("Hinh tron co tam [{0:0.0};{1:0.0}], ban kinh {2:0.0} va dien tich la: {3:0.0}",this.hoanh_do,this.tung_do,this.r,area());
        }
    }
}
