using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtrGiuaKy
{
    public class KhuPho
    {
        public List<HoGiaDinh> DanhSachHoGiaDinh { get; set; }

        public KhuPho() { }

        public KhuPho(List<HoGiaDinh> danhSachHoGiaDinh)
        {
            DanhSachHoGiaDinh = danhSachHoGiaDinh;
        }
    }

}
