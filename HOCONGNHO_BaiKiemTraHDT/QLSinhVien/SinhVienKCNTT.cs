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
        private string Mssv;
        private string hoTen, diaChi;
        private DateTime ngaySinh;
        private float diemCS414, diemIS311, diemCS311;

        public string MSSV
        {
            get
            {
                return Mssv;
            }

            set
            {
                Mssv = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public float DiemCS414
        {
            get
            {
                return diemCS414;
            }

            set
            {
                diemCS414 = value;
            }
        }

        public float DiemIS311
        {
            get
            {
                return diemIS311;
            }

            set
            {
                diemIS311 = value;
            }
        }

        public float DiemCS311
        {
            get
            {
                return diemCS311;
            }

            set
            {
                diemCS311 = value;
            }
        }

        public double DiemTB()
        {
            return (this.DiemCS311 + this.DiemCS414 + this.DiemIS311) / 3;
        }


        public void Nhap()
        {
            Console.WriteLine("Nhap vao ma so sinh vien");
            this.Mssv = Console.ReadLine();
            Console.WriteLine("Nhap vao ho ten");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi");
            this.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh dinh dang yyy-MM-dd");
            string temp = Console.ReadLine();
            while (true)
            {
                DateTime d;
                bool check = DateTime.TryParseExact(temp, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                DateTimeStyles.None, out d);
                if (check == true)
                {
                    this.NgaySinh = DateTime.Parse(temp);
                    break;
                }  else
                {
                    Console.WriteLine("Nhap sai format ngay, vui long nhap lai:");
                    temp = Console.ReadLine();
                }

            }
            Console.WriteLine("Nhap vao diem CS 414");
            this.DiemCS414 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem IS 311");
            this.DiemIS311 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem CS 311");
            this.DiemCS311 = float.Parse(Console.ReadLine());
        }

        public string Xeploai()
        {
            string temp;
            if (this.DiemTB() >= 8)
            {
                temp = "GIOI";
            } else if (this.DiemTB() >= 6.5)
            {
                temp = "KHA";
            } else if (this.DiemTB() >= 5)
            {
                temp = "TB";
            }
            else
            {
                temp = "YEU";
            }
            return temp;
        }

        public void Xuat()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ma so sinh vien la: " + this.MSSV);
            Console.WriteLine("Ho ten sinh vien la: " + this.HoTen);
            Console.WriteLine("Dia chi sinh vien la: " + this.DiaChi);
            Console.WriteLine("Ngay sinh cua sinh vien la :" + this.NgaySinh);
            Console.WriteLine("Diem TB la: " + this.DiemTB());
            Console.WriteLine("Xep loai "+ this.Xeploai());
            Xeploai();
        }

    }
}
