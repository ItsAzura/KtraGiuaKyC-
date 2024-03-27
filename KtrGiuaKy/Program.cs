using System;
using System.Collections.Generic;
using System.Linq;

namespace KtrGiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập n hộ dân
            int n = int.Parse(Console.ReadLine());
            KhuPho khuPho = new KhuPho(new List<HoGiaDinh>());

            for (int i = 0; i < n; i++)
            {
                int soNha = int.Parse(Console.ReadLine());
                int soThanhVien = int.Parse(Console.ReadLine());
                int soConTrai = int.Parse(Console.ReadLine());
                int soConGai = soThanhVien - soConTrai;
                HoGiaDinh hoGiaDinh = new HoGiaDinh(soNha, soThanhVien, soConTrai, soConGai);

                for (int j = 0; j < soThanhVien; j++)
                {
                    string hoTen = Console.ReadLine();
                    int tuoi = int.Parse(Console.ReadLine());
                    string ngheNghiep = Console.ReadLine();
                    string soCMND = Console.ReadLine();
                    Nguoi nguoi = new Nguoi(hoTen, tuoi, ngheNghiep, soCMND);
                    hoGiaDinh.DanhSachThanhVien.Add(nguoi);
                }

                khuPho.DanhSachHoGiaDinh.Add(hoGiaDinh);
            }

            foreach (HoGiaDinh hoGiaDinh in khuPho.DanhSachHoGiaDinh)
            {
                Console.WriteLine("Số nhà: " + hoGiaDinh.SoNha);
                Console.WriteLine("Số thành viên: " + hoGiaDinh.SoThanhVien);
                Console.WriteLine("Số con trai: " + hoGiaDinh.SoConTrai);
                Console.WriteLine("Số con gái: " + hoGiaDinh.SoConGai);

                foreach (Nguoi nguoi in hoGiaDinh.DanhSachThanhVien)
                {
                    Console.WriteLine("Họ tên: " + nguoi.HoTen);
                    Console.WriteLine("Tuổi: " + nguoi.Tuoi);
                    Console.WriteLine("Nghề nghiệp: " + nguoi.NgheNghiep);
                    Console.WriteLine("Số CMND: " + nguoi.SoCMND);
                }
            }

            // Tìm hộ gia đình có số con trai >=2; tìm hộ gia đình có số con từ 5 đến 10
            Console.WriteLine("\nHộ gia đình có số con trai >=2:");
            var hoGiaDinhCoSoConTrai = khuPho.DanhSachHoGiaDinh.Where(h => h.SoConTrai >= 2);
            foreach (var hoGiaDinh in hoGiaDinhCoSoConTrai)
            {
                Console.WriteLine("Số nhà: " + hoGiaDinh.SoNha + ", Số con trai: " + hoGiaDinh.SoConTrai);
            }

            Console.WriteLine("\nHộ gia đình có số con từ 5 đến 10:");
            var hoGiaDinhCoSoConTu5Den10 = khuPho.DanhSachHoGiaDinh.Where(h => h.SoThanhVien >= 5 && h.SoThanhVien <= 10);
            foreach (var hoGiaDinh in hoGiaDinhCoSoConTu5Den10)
            {
                Console.WriteLine("Số nhà: " + hoGiaDinh.SoNha + ", Số con: " + hoGiaDinh.SoThanhVien);
            }

            // Tính tổng số thành viên trong khu phố
            int tongSoThanhVien = khuPho.DanhSachHoGiaDinh.Sum(h => h.SoThanhVien);
            Console.WriteLine("\nTổng số thành viên trong khu phố: " + tongSoThanhVien);

            // Tìm các hộ gia đình có người tên "Hùng"
            Console.WriteLine("\nCác hộ gia đình có người tên 'Hùng':");
            var hoGiaDinhCoNguoiTenHung = khuPho.DanhSachHoGiaDinh.Where(h => h.DanhSachThanhVien.Any(n => n.HoTen.Contains("Hùng")));
            foreach (var hoGiaDinh in hoGiaDinhCoNguoiTenHung)
            {
                Console.WriteLine("Số nhà: " + hoGiaDinh.SoNha);
            }

            // Thống kê số con nam, nữ trong khu phố
            int tongSoConNam = khuPho.DanhSachHoGiaDinh.Sum(h => h.SoConTrai);
            int tongSoConNu = khuPho.DanhSachHoGiaDinh.Sum(h => h.SoConGai);
            Console.WriteLine("\nSố con nam, nữ trong khu phố:");
            Console.WriteLine("Số con nam: " + tongSoConNam);
            Console.WriteLine("Số con nữ: " + tongSoConNu);

            Console.ReadLine();
        }
        
    }
}