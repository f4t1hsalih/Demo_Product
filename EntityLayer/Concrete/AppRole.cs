using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Oluşturduğumuz bu sınıf ile identitydbcontext sınıfına doğrudan müdahale edebildik bu sınıfta bulunan proplar
    //identitydbcontext sınıfına dahil oldu(AspNetRoles bölümüne)
    public class AppRole:IdentityRole<int>
    {
    }
}
