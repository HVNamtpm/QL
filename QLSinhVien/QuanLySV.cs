using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class QuanLySV
    {
        Dictionary<string, SinhVienKCNTT> dssv;
        Dictionary<string, SinhVienDienTu> dssvdt;
        public QuanLySV()
        {
            dssv = new Dictionary<string, SinhVienKCNTT>();
            dssvdt = new Dictionary<string, SinhVienDienTu>();

        }
        public void Nhap()
        {
            char c = ' ';
            Console.WriteLine("Bam phim (T) de nhap sinh vien Khoa CNTT, (D) de nhap sinh vien khoa DT");
            c = char.Parse(Console.ReadLine().PadLeft(1).ToUpper());
            while (c == 'T' || c == 'D')
            {
                switch (c)
                {
                    case 'T':
                        {
                            SinhVienKCNTT svtt = new SinhVienKCNTT();
                            svtt.Nhap();
                            dssv.Add(svtt.Mssv, svtt);
                            break;
                        }
                    case 'D':
                        {
                            SinhVienDienTu svdt = new SinhVienDienTu();
                            svdt.Nhap();
                            dssvdt.Add(svdt.Mssv,svdt);
                            break;
                        }
                }
                Console.WriteLine("Bam phim (T) de nhap sinh vien Khoa CNTT, (D) de nhap sinh vien khoa DT");
                c = char.Parse(Console.ReadLine().PadLeft(1).ToUpper());
            }
            
        }
        public void Xuat()
        {
            foreach (var item in dssv.Values)
            {
                item.Xuat();
                Console.WriteLine("----------------------------");
            }
            foreach (var item in dssvdt.Values)
            {
                item.Xuat();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
