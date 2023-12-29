using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoa01
{
    class DIEM 
    {
        public int x;
        public int y;
    
        public void NhapToaDo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Nhap hoanh do x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap tung do y: ");
            y = int.Parse(Console.ReadLine());
        }
        public double TinhKhoangCach(DIEM p)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double kc;
            kc = Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
            return kc;
        }
    }
    class Progam
    {
        static void Main(string[] args)
        {
            DIEM A, B;
            A = new DIEM();
            B = new DIEM();
            Console.WriteLine("Nhap toa do diem A: ");
            A.NhapToaDo();
            Console.WriteLine("Nhap toa do diem B: ");
            B.NhapToaDo();
            double kq = A.TinhKhoangCach(B);
            Console.WriteLine("Khoang cach 2 diem: {0}", kq);
            Console.ReadLine();
        }
    }

}
