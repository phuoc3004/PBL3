using QLCH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH.Controller
{
    public class KhachHangController
    {
        private static KhachHangController _Instance;
        public static KhachHangController Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangController();
                }
                return _Instance;

            }
            private set { }
        }
        public List<KhachHang> GetDSKH()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            dsKH = KhachHangModel.Instance.GetDSKH();
            return dsKH;
        }
        public void Add_KhachHang(KhachHang kh)
        {
            KhachHangModel.Instance.Add_KhachHang(kh);
        }
        public void Del_KhachHang(int MaKH)
        {
            KhachHangModel.Instance.Del_KhachHang(MaKH);
        }
        public void Update_KhachHang(KhachHang kh)
        {
            KhachHangModel.Instance.UpDate_KhachHang(kh);
        }
    }
}
