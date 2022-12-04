using A_DAL.DomaninClass;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IAnhService
    {
        public string add(AnhViewModel anhViewModel);
        public string update(AnhViewModel anhViewModel);
        public string delete(AnhViewModel anhViewModel);
        public List<AnhViewModel> GetAll();
        // lấy dữ liệu để hiển thị đã khai báo bên ViewModel
    }
}
