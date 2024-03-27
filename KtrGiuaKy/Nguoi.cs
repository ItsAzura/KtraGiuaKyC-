using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtrGiuaKy
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string NgheNghiep { get; set; }
        public string SoCMND { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, int tuoi, string ngheNghiep, string soCMND)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            NgheNghiep = ngheNghiep;
            SoCMND = soCMND;
        }
    }

}
