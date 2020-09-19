using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class QLSinhVien
    {

        Dictionary<string, SinhVienKCNTT> dssv;
        Dictionary<string, SinhVienDT> dssvdt;
        public QLSinhVien()
        {
            dssv = new Dictionary<string, SinhVienKCNTT>();
            dssvdt = new Dictionary<string, SinhVienDT>();

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
                            dssv.Add(svtt.MSSV, svtt);
                            break;
                        }
                    case 'D':
                        {
                            SinhVienDT svdt = new SinhVienDT();
                            svdt.Nhap();
                            dssvdt.Add(svdt.MSSV, svdt);
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

        public void DemXepLoaiSV()
        {
            int gioi = 0, kha = 0, tb = 0, yeu = 0;
            //Dem Sinh Vien Dien Tu
            foreach(var sv1 in dssvdt.Values)
            {
                string temp = sv1.Xeploai();
                if (temp == "GIOI")
                {
                    gioi++;
                }
                if (temp == "KHA")
                {
                    kha++;
                }
                if (temp == "TB")
                {
                    tb++;
                }
                if (temp == "YEU")
                {
                    yeu++;
                }
            }

            //Dem Sinh Vien CNTT

            foreach (var sv1 in dssv.Values)
            {
                string temp = sv1.Xeploai();
                if (temp == "GIOI")
                {
                    gioi++;
                }
                if (temp == "KHA")
                {
                    kha++;
                }
                if (temp == "TB")
                {
                    tb++;
                }
                if (temp == "YEU")
                {
                    yeu++;
                }
            }

            Console.WriteLine("So hoc sinh gioi la:" + gioi);
            Console.WriteLine("So hoc sinh kha la:" + kha);
            Console.WriteLine("So hoc sinh tb la:" + tb);
            Console.WriteLine("So hoc sinh yeu la:" + yeu);
        }

    }
}
