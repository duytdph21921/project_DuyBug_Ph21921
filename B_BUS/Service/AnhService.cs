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
    public class AnhService : IAnhService
    {
        IAnh _IAnh;
        public AnhService()
        {
            _IAnh = new Anhs();
        }
        public string add(AnhViewModel anhViewModel)
        {
            try
            {
                if (anhViewModel == null) return " thêm thất bại";
                // khởi tạo 1 đối tượng ở domainclass để gọi các thuộc tính của đối tượng đấy 
                // gán từng đối tượng đấy cho anhviewmodel khi nhận dữ liệu từ viewmodel và ngược lại
                // tăng độ chính xác
                // đây là việc khởi tạo mới 1 đối tượng 
               // quá trình yêu cầu tạo ra một object của class tương ứng
               // trên vùng nhớ heap và lấy địa chỉ của object gán cho một biến
               // nếu không khởi tạo sẽ mang giá trị mặc định 
                Anh anh = new Anh()
                {
                    Ma = anhViewModel.Ma,
                    Ten = anhViewModel.Ten,
                    Link= anhViewModel.Link,
                };
                if (_IAnh.add(anh))
                {
                    return " thêm thành công";
                }
               
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " thêm thất bại";
        }

        public string delete(AnhViewModel anhViewModel)
        {
            try
            {
                if (anhViewModel == null) return " xóa thất bại";
                Anh anh = new Anh()
                {
                    id = anhViewModel.id,
                    Ma = anhViewModel.Ma,
                    Ten = anhViewModel.Ten,
                   
                };
                if (_IAnh.delete(anh))
               
                return "xóa thành công";
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return " xóa thất bại";
        }

        

        public List<AnhViewModel> GetAll()
        {
            var HtAnh = (from a in _IAnh.GetAll()
                         select new AnhViewModel() // đây là câu lệnh truy vấn  hiển thị nhưng thứ được gọi ra
                                                   // .tolist() chuyển đổi các tập hợp thành danh sách
                         
                         {
                             id= a.id,
                             Ma = a.Ma,
                             Ten = a.Ten,
                             Link = a.Link,

                         }
                         ).ToList();
            return HtAnh;
        }   

        public string update(AnhViewModel anhViewModel)
        {
           if (anhViewModel == null) return " thêm thất bại";
                Anh anh = new Anh()
                {
                    id  =anhViewModel.id,
                    Ma = anhViewModel.Ma,
                    Ten = anhViewModel.Ten,
                    Link = anhViewModel.Link,
                };
            if (_IAnh.update(anh)) ;
                
                    return " sửa thành công";

            return " sửa thành công";

        }
    }
}
