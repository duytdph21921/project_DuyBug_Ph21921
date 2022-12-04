using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class DongCos : IDongCo
    {
        XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(dongCo dongCo)
        {
            try
            {
                if (dongCo == null) return false;

                _dbcontext.DongCos.Add(dongCo);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                //
                return false;
            }
           
        }

        public bool delete(dongCo dongCo)
        {
            try
            {
                if (dongCo.id == null) return false;
                {
                      var dc = _dbcontext.DongCos.FirstOrDefault(c => c.id == dongCo.id); 
                 
                    _dbcontext.DongCos.Remove(_dbcontext.DongCos.FirstOrDefault(c => c.id == dongCo.id));
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }

        public List<dongCo> GetAll()
        {
            return _dbcontext.DongCos.ToList();
        }

        public bool update(dongCo dongCo)
        {
            try
            {
                if (dongCo.id == null) return false;
                {
                    var dc = _dbcontext.DongCos.FirstOrDefault(c => c.id == dongCo.id);
                    dc.Ma = dongCo.Ma;
                    dc.Ten = dongCo.Ten;
                    _dbcontext.DongCos.Update(dc);
                    _dbcontext.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {

                return false;

            }
        }
    }
}
