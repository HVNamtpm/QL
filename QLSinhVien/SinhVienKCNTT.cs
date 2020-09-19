using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class SinhVienKCNTT
    {
        
        string mssv, hoten, diachi;
        DateTime ngaysinh;
        double diemCS414, diemIS311, diemCS311;

        public SinhVienKCNTT() { }

        public SinhVienKCNTT(string mssv, string hoten, string diachi, DateTime ngaysinh, double diemCS414, double diemIS311, double diemCS311)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.diemCS414 = diemCS414;
            this.diemIS311 = diemIS311;
            this.diemCS311 = diemCS311;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double DiemCS414 { get => diemCS414; set => diemCS414 = value; }
        public double DiemIS311 { get => diemIS311; set => diemIS311 = value; }
        public double DiemCS311 { get => diemCS311; set => diemCS311 = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao ma so sinh vien");
             this.Mssv= Console.ReadLine();
            Console.WriteLine("Nhap vao ho ten");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi");
            this.Diachi = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh");
            string temp = Console.ReadLine();
            while (true)
            {
                DateTime d;
                bool check = DateTime.TryParseExact(temp, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                if (check == true)
                {
                    this.Ngaysinh = DateTime.Parse(temp);
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai format ngay, vui long nhap lai:");
                    temp = Console.ReadLine();
                }
            }
            
            Console.WriteLine("Nhap vao diem CS 414");
            this.DiemCS414 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem IS 311");
            this.DiemIS311 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem CS 311");
            this.DiemCS311 = double.Parse(Console.ReadLine());
        }
        public double DiemTB()
        {
            return (this.DiemCS311 + this.DiemCS414 + this.DiemIS311) / 3;
        }
        public void Xeploai()
        {
            if (this.DiemTB() >= 8)
            {
                Console.WriteLine("Xep loai gioi");
            }
            if (this.DiemTB() >= 6.5)
            {
                Console.WriteLine("Xep loai kha");
            }
            if (this.DiemTB() >= 5)
            {
                Console.WriteLine("Xep loai trung binh");
            }
            else
            {
                Console.WriteLine("Xep loai Yeu");
            }
        }
        public void Xuat()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ma so sinh vien la " + Mssv);
            Console.WriteLine("Ho ten sinh vien la " + Hoten);
            Console.WriteLine("Dia chi sinh vien la " +Diachi);
            Console.WriteLine("Diem TB la " + this.DiemTB());
            Console.Write("Xep loai " );
            Xeploai();
        }



    }
}
