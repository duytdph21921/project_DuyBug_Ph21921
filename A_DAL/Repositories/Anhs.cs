using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A_DAL.Repositories
{
    public class Anhs : IAnh
    {
        public XeMayDbConText _dbcontext = new XeMayDbConText();
        public bool add(Anh anh)
        {
            try
            {
                if (anh == null) return false;
                
                _dbcontext.Anhs.Add(anh);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
               //
                return false;
            }
          
        }

        public bool delete(Anh anh)
        {
            try
            {
                if (anh.id == null) return false;
                {
                  
                    _dbcontext.Anhs.Remove(_dbcontext.Anhs.FirstOrDefault(c => c.id == anh.id));
                    _dbcontext.SaveChanges();
                    return true;
                }
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
                
            }
          

        }

        public List<Anh> GetAll()
        {
            var getall = _dbcontext.Anhs.ToList();
            return getall;
        }

        public bool update(Anh anh)
        {
            try
            {
                if (anh.id == null) return false;
                {
                    var cv = _dbcontext.Anhs.FirstOrDefault(c => c.id == anh.id);
                    cv.Ma = anh.Ma;
                    cv.Ten = anh.Ten;
                    cv.Link =anh.Link;

                    _dbcontext.Anhs.Update(cv);
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
