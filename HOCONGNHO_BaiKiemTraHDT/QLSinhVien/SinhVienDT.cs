using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class SinhVienDT
    {
        private string Mssv;
        private string hoTen, diaChi;
        private DateTime ngaySinh;
        private float diemEE201, diemEE200, diemEE205;

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

        public float DiemEE201
        {
            get
            {
                return diemEE201;
            }

            set
            {
                diemEE201 = value;
            }
        }

        public float DiemEE205
        {
            get
            {
                return diemEE205;
            }

            set
            {
                diemEE205 = value;
            }
        }

        public float DiemEE200
        {
            get
            {
                return diemEE200;
            }

            set
            {
                diemEE200 = value;
            }
        }

        public double DiemTB()
        {
            return (this.DiemEE200 + this.DiemEE201 + this.DiemEE205) / 3;
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
                }
                else
                {
                    Console.WriteLine("Nhap sai format ngay, vui long nhap lai:");
                    temp = Console.ReadLine();
                }

            }
            Console.WriteLine("Nhap vao diem EE 201");
            this.DiemEE201 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem EE 205");
            this.DiemEE205 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem EE 200");
            this.DiemEE200 = float.Parse(Console.ReadLine());
        }

        public string Xeploai()
        {
            string temp;
            if (this.DiemTB() >= 8)
            {
                temp = "GIOI";
            }
             else if (this.DiemTB() >= 6.5)
            {
                temp = "KHA";
            }
            else if (this.DiemTB() >= 5)
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
            Console.WriteLine("Xep loai " + this.Xeploai());
            Xeploai();
        }

    }
}
