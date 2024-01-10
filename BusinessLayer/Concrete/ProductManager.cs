using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product t)
        {
            //Kaydetme işlemi yapılmadan önce business kaymanında şartlar kontrol edilir ve şartları karşılıyor ise kaydetme işlemi yapar
            if (t.Name.Length >= 5 && t.Price >= 1 && t.Name != null)
            {
                _productDal.Insert(t);
            }
            //Aksi takdirde hata mesaı verilebilir
            else
            {
                //Hata Mesajları
            }
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
