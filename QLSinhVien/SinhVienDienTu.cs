using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class SinhVienDienTu
    {
        string mssv, hoten, diachi;
        DateTime ngaysinh;
        double diemEE200, diemEE201, diemEE205;

        public SinhVienDienTu() { }

        public SinhVienDienTu(string mssv, string hoten, string diachi, DateTime ngaysinh, double diemEE200, double diemEE201, double diemEE205)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.diemEE200 = diemEE200;
            this.diemEE201 = diemEE201;
            this.diemEE205 = diemEE205;
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double DiemEE200 { get => diemEE200; set => diemEE200 = value; }
        public double DiemEE201 { get => diemEE201; set => diemEE201 = value; }
        public double DiemEE205 { get => diemEE205; set => diemEE205 = value; }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao ma so sinh vien");
            this.Mssv = Console.ReadLine();
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

            Console.WriteLine("Nhap vao diem EE 200");
            this.DiemEE200 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem EE 201");
            this.DiemEE201 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem CS 311");
            this.DiemEE205 = double.Parse(Console.ReadLine());
        }
        public double DiemTB()
        {
            return (this.DiemEE200 + this.DiemEE201 + this.DiemEE205) / 3;
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
            Console.WriteLine("Dia chi sinh vien la " + Diachi);
            Console.WriteLine("Diem TB la " + this.DiemTB());
            Console.Write("Xep loai ");
            Xeploai();
        }


    }
}
