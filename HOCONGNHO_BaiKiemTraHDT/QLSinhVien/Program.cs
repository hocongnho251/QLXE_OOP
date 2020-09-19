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
            QLSinhVien qlsv = new QLSinhVien();
            qlsv.Nhap();
            qlsv.Xuat();
            qlsv.DemXepLoaiSV();            Console.ReadKey();
        }
    }
}
