using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Rectangle 
    {
        private double length;
        private double width;
        public Rectangle()
        {
            length = 1.0;
            width = 1.0;
        }
        public Rectangle(double Length, double Width)
        {
            this.length = Length;
            this.width = Width;
        }
        public void setLength(double Length)
        {
            this.length = Length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double Width)
        {
            this.width = Width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length * width;
        }
        public double findPerimeter()
        {
            return (length + width) * 2;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1;
            Rectangle r2;
            r1 = new Rectangle();
            Console.Write("Cho Biet Chieu Dai: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Cho Biet Chieu Rong: ");
            double width = double.Parse(Console.ReadLine());
            r2 = new Rectangle(length, width);
            Console.WriteLine("------Thong Tin Hinh Chu Nhat r1------");
            Console.WriteLine("Chieu dai: {0} \nChieu Rong: {1}\nDien Tich: {2}ChuVi: {3}", r1.getLength(), r1.getWidth(), r1.findArea(), r1.findPerimeter()) ;
            Console.WriteLine("------Thong Tin Hinh Chu Nhat r2------");
            Console.WriteLine("Chieu dai: {0} \nChieu Rong: {1}\nDien Tich: {2}ChuVi: {3}", r2.getLength(), r2.getWidth(), r1.findArea(), r2.findPerimeter());
            Console.ReadLine();
        }
    }
}
