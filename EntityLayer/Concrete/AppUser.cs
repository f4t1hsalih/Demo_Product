using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{

    //Oluşturduğumuz bu sınıf ile identitydbcontext sınıfına doğrudan müdahale edebildik bu sınıfta bulunan proplar
    //identitydbcontext sınıfına dahil oldu(AspNetUsers bölümüne)
    public class AppUser:IdentityUser<int>
    {

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
    }
}
