using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal:ICategoryDal
    {
        Context c = new Context();

        public void Delete(Category p)
        {
            c.Categories.Remove(p);
            c.SaveChanges();
        }

        public List<Category> GetList()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category p)
        {
            c.Categories.Add(p);
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            c.Categories.Update(p);
            c.SaveChanges();
        }
    }
}
