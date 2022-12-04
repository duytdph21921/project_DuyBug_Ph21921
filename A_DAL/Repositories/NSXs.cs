using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NSXs : INSX
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(NSX nSX)
        {
            if (nSX == null) return false;
            _dbcontext.NSXes.Add(nSX);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool delete(NSX nSX)
        {
            if (nSX == null) return false;
            var nsx = _dbcontext.NSXes.FirstOrDefault(c => c.id == nSX.id);
            _dbcontext.NSXes.Remove(nsx);
            _dbcontext.SaveChanges();
            return true;
        }

        

        public List<NSX> GetAll()
        {
            return _dbcontext.NSXes.ToList();
        }

        public bool update(NSX nSX)
        {
            if (nSX == null) return false;
            var nhasx = _dbcontext.NSXes.FirstOrDefault(c => c.id == nSX.id);
            nhasx.Ma = nSX.Ma; 
            nhasx.Ten = nSX.Ten;
            _dbcontext.NSXes.Update(nhasx);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
