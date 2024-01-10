using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class ProductDal : IProductDal
    {
        Context c = new Context();
        public void Delete(Product p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public List<Product> GetList()
        {
            return c.Products.ToList();
        }

        public void Insert(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
        }

        public void Update(Product p)
        {
            c.Products.Update(p);
            c.SaveChanges();
        }
    }
}
