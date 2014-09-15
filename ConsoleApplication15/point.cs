using System;


namespace ConsoleApplication15
{
    public class point : shape
    {
        private double x;
        private double y;
        public double hoanh_do
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double tung_do
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public point()
        { }
        public point(double a,double b)
        {
            this.x=a;
            this.y=b;
        }
        public override void noti()
        {
            Console.WriteLine("Toa do diem vua nhap [{0:0.0};{1:0.0}]",this.x,this.y);
        }

    }
}
