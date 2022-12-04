using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface INsxService
    {
        public string add(NSXViewModel nSXViewModel);
        public string update(NSXViewModel nSXViewModel);
        public string delete(NSXViewModel nSXViewModel);
        public List<NSXViewModel> GetAll();
       
    }
}
