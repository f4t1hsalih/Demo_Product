using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                //ilk değer kullanıcı adı
                //ikinci değer şifre
                //üçüncü değer kullanıcı bilgilerini hatırla
                //dördüncü değer yanlış şifre girmede(5 defa) banlama olayı
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Product");
                }
                else 
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre");
                }
            }
            return View();
        }
    }
}
