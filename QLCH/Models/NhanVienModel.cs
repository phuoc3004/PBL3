using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH.Models
{
    
    public class NhanVienModel
    {
        private NhanVienn nv = new NhanVienn();
        private static NhanVienModel _Instance;
        public static NhanVienModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienModel();
                }
                return _Instance;

            }
            private set { }
        }

        public List<NhanVien> GetDSNV()
        {
            List<NhanVien> list = new List<NhanVien>();
            var l = from p in nv.NhanViens
                    select p;
            list = l.ToList();
            return list;
        }
        public void Add_NhanVien(NhanVien i)
        {
            nv.NhanViens.Add(i);
            nv.SaveChanges();
        }
        public void Del_NhanVien(int MaNV)
        {
            var i = nv.NhanViens.Find(MaNV);
            nv.NhanViens.Remove(i);
            nv.SaveChanges();
        }
        public void UpDate_NhanVien(NhanVien i)
        {
            try
            {
                var s = nv.NhanViens.Where(x => x.MaNV == i.MaNV).FirstOrDefault();

                s.HoVaTenNV = i.HoVaTenNV;
                s.GioiTinhNV = i.GioiTinhNV;
                s.NgaySinhNV = i.NgaySinhNV;
                s.ChucVuNV = i.ChucVuNV;
                s.LuongNV = i.LuongNV;
                s.NgayBatDauLamNV = i.NgayBatDauLamNV;
                s.EmailNV = i.EmailNV;
                s.SĐTNV = i.SĐTNV;
                s.QueQuanNV = i.QueQuanNV;
                nv.SaveChanges();
            }
            catch (Exception res)
            {
                Console.WriteLine(res.Message);
            }

        }
    }
}
