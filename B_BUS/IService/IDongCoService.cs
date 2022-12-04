using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IDongCoService
    {
        public string add(DongCoviewmodel dongCoviewmodel);
        public string update(DongCoviewmodel dongCoviewmodel);
        public string delete(DongCoviewmodel dongCoviewmodel);
        public List<DongCoviewmodel> Getall();
    }
}
