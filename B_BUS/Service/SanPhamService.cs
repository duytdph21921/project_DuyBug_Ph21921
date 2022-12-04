using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B_BUS.Service
{
    public class SanPhamService : ISanPhamService
    {
        ISanPham _ISanPham;
        public SanPhamService()
        {
            _ISanPham = new SanPhams();
        }
        public string add(SanPhamViewModel sanPhamViewModel)
        {
            try
            {
                if (sanPhamViewModel == null) return "thêm thất bại";
                sanPham sanPham = new sanPham()
                {
                    id= sanPhamViewModel.id,
                    Ma = sanPhamViewModel.Ma,
                    Ten = sanPhamViewModel.Ten,
                };
                if (_ISanPham.add(sanPham)) return " thêm thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " thêm thất bại";
        }

        public string delete(SanPhamViewModel sanPhamViewModel)
        {
            try
            {
                if (sanPhamViewModel == null) return "xóa thất bại";
                sanPham sanPham = new sanPham()
                {
                    id = sanPhamViewModel.id,
                    Ma = sanPhamViewModel.Ma,
                    Ten = sanPhamViewModel.Ten,
                };
                if (_ISanPham.delete(sanPham)) return " xóa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " xóa thất bại";
        }

        public List<SanPhamViewModel> Getall()
        {
            var hienthi = (from n in _ISanPham.getAll()
                           select new SanPhamViewModel()
                           {
                               id = n.id,
                               Ma = n.Ma,
                               Ten = n.Ten,
                           }).ToList();
            return hienthi;
        }

        public string update(SanPhamViewModel sanPhamViewModel)
        {
            try
            {
                if (sanPhamViewModel == null) return "sửa thất bại";
                sanPham sanPham = new sanPham()
                {
                    id = sanPhamViewModel.id,
                    Ma = sanPhamViewModel.Ma,
                    Ten = sanPhamViewModel.Ten,
                };
                if (_ISanPham.update(sanPham)) return " sửa thành công";


            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " sửa thất bại";
        }
    }
}
