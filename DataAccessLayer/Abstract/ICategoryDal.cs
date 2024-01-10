using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic interface'den miras alarak onun içinde bulunduğu tüm değerleri kullanabilir
    public interface ICategoryDal : IGenericDal<Category>
    {
    }
}
