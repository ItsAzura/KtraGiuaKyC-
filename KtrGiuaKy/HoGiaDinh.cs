using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtrGiuaKy
{
    public class HoGiaDinh
    {
        public int SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public int SoConTrai { get; set; }
        public int SoConGai { get; set; }
        public List<Nguoi> DanhSachThanhVien { get; set; }

        public HoGiaDinh() { }

        public HoGiaDinh(int soNha, int soThanhVien, int soConTrai, int soConGai)
        {
            SoNha = soNha;
            SoThanhVien = soThanhVien;
            SoConTrai = soConTrai;
            SoConGai = soConGai;
            DanhSachThanhVien = new List<Nguoi>();
        }
    }

}
