using System;


namespace ConsoleApplication15
{
    public abstract class shape
    {
        public virtual double area()
        {
            return 0.0;
        }
        public virtual double volume()
        {
            return 0.0;
        }
        public virtual void noti()
        {
            Console.WriteLine("Notifications about shape ");
        }

    }


}
