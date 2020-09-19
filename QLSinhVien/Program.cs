using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySV qlsv = new QuanLySV();
            qlsv.Nhap();
            qlsv.Xuat();
            Console.ReadKey();
        }
    }
}
