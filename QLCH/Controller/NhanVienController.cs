using QLCH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH.Controller
{
    public class NhanVienController
    {

        private static NhanVienController _Instance;
        public static NhanVienController Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienController();
                }
                return _Instance;

            }
            private set { }
        }
        public List<NhanVien> GetDSNV()
        {
            List<NhanVien> dsNV = new List<NhanVien>();
            dsNV = NhanVienModel.Instance.GetDSNV();
            return dsNV;
        }
        public void Add_NhanVien(NhanVien nv)
        {
            NhanVienModel.Instance.Add_NhanVien(nv);
        }
        public void Del_NV(int MaNV)
        {
            NhanVienModel.Instance.Del_NhanVien(MaNV);
        }
        public void Update_NV(NhanVien nv)
        {
            NhanVienModel.Instance.UpDate_NhanVien(nv);
        }
    }
}
