using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCH.DTO;
using QLCH.Models;

namespace QLCH.Controller
{
    public class QLSanPhamController
    {
        private static QLSanPhamController _Instance;
        public static QLSanPhamController Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLSanPhamController();
                }
                return _Instance;

            }
            private set { }
        }
        public List<SanPhamView> GetAllSP()
        {
            //return Models.QLSP_Model.Instance.SanPhams.Select(p => new SanPham { MaSP=p.MaSP,TenSP=p.TenSP,MaHSX=p.MaHSX,DonGia=p.DonGia,MoTa=p.MoTa,
            //TinhTrang=p.TinhTrang,BaoHanh=p.BaoHanh,SoLuong=p.SoLuong,HangSanXuat=p.HangSanXuat.TenHSX}).ToList();
            return SanPhamm.Instance.SanPhams.Select(p => new SanPhamView
            {
                MaSP = p.MaSP,
                TenSP = p.TenSP,
                MaHSX = p.MaHSX,
                DonGia = p.DonGia,
                MoTa = p.MoTa,
                //KichCo = p.KichCo,
                SoLuong = (int)p.SoLuong,
                HangSanXuat = p.HangSanXuat.TenHSX
            }).ToList();
        }
        public List<SanPhamView> Search_SP(string txt)
        {
            List<SanPhamView> list = new List<SanPhamView>();
            list = SanPhamm.Instance.SanPhams.Where(p => p.TenSP.Contains(txt)).Select(p => new SanPhamView
            {
                MaSP = p.MaSP,
                TenSP = p.TenSP,
                MaHSX = p.MaHSX,
                DonGia = p.DonGia,
                MoTa = p.MoTa,
            //    KichCo = p.KichCo,
                SoLuong = (int)p.SoLuong,
                HangSanXuat = p.HangSanXuat.TenHSX
            }).ToList();
            return list;
        }
        public List<ComboboxItem> GetCBB()
        {
            List<ComboboxItem> list = new List<ComboboxItem>();
            foreach (HangSanXuat i in SanPhamm.Instance.HangSanXuats)
            {
                list.Add(new ComboboxItem { Text = i.TenHSX, Value = i.MaHSX });
            }
            return list;
        }
        public void AddSP(SanPham sp)
        {
            SanPhamm.Instance.SanPhams.Add(sp);
            SanPhamm.Instance.SaveChanges();
        }
        public void UpdateSP(SanPham sp)
        {
            var data = SanPhamm.Instance.SanPhams.Find(sp.MaSP);
            data.TenSP = sp.TenSP;
            data.MaHSX = sp.MaHSX;
            data.DonGia = sp.DonGia;
            data.MoTa = sp.MoTa;
          //  data.KichCo = sp.KichCo;
            data.SoLuong = sp.SoLuong;
            SanPhamm.Instance.SaveChanges();
        }
        public void Del_SP(string MSSP)
        {
            var data = SanPhamm.Instance.SanPhams.Find(Convert.ToInt32(MSSP));
            SanPhamm.Instance.SanPhams.Remove(data);
            SanPhamm.Instance.SaveChanges();
        }
    }
}
