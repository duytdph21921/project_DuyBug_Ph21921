using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_BUS.IService
{
    public interface IMauSacService
    {
        public string add(MauSacViewModel mauSacViewModel);
        public string update(MauSacViewModel mauSacViewModel);
        public string delete(MauSacViewModel mauSacViewModel);
        public List<MauSacViewModel> GetAll();
    }
}
