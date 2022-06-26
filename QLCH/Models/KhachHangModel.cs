using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH.Models
{
    public class KhachHangModel
    {
        private KhachHangg md = new KhachHangg();

        private static KhachHangModel _Instance;
        public static KhachHangModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangModel();
                }
                return _Instance;

            }
            private set { }
        }
        public List<KhachHang> GetDSKH()
        {
            List<KhachHang> list = new List<KhachHang>();
            var l = from p in md.KhachHangs
                    select p;
            list = l.ToList();
            return list;
        }
        public void Add_KhachHang(KhachHang kh)
        {
            md.KhachHangs.Add(kh);
            md.SaveChanges();
        }
        public void Del_KhachHang(int MaKH)
        {
            var kh = md.KhachHangs.Find(MaKH);
            md.KhachHangs.Remove(kh);
            md.SaveChanges();
        }
        public void UpDate_KhachHang(KhachHang kh)
        {
            try
            {
                var s = md.KhachHangs.Where(x => x.MaKH == kh.MaKH).FirstOrDefault();

                s.HoVaTenKH = kh.HoVaTenKH;
                s.GioiTinhKH = kh.GioiTinhKH;
                s.NgaySinhKH = kh.NgaySinhKH;
                s.EmailKH = kh.EmailKH;
                s.SĐTKH = kh.SĐTKH;
                s.DiaChi = kh.DiaChi;
                md.SaveChanges();
            }
            catch (Exception res)
            {
                Console.WriteLine(res.Message);
            }

        }
    }
}
