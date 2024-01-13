using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic interface'den miras alarak onun içinde bulunduğu tüm değerleri kullanabilir
    public interface ICustomerDal : IGenericDal<Customer>
    {
        //Sadece bu interfacede uygulanacağı için GenericDal içinde değilde bu interface içinde kullanıldı
        List<Customer> GetCustomerListWithJob();
    }
}
