using Microsoft.AspNetCore.Mvc;
using Libraro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Libraro.Controllers
{
    public class AccountController : Controller
    {
        private static List<Kullanici> _kullanicilar = new List<Kullanici>();

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        public static string AktifKullanici = null; 
        [HttpPost]
        public IActionResult Login(string email, string sifre)
        {
            var kullanici = _kullanicilar.FirstOrDefault(u => u.Email == email && u.Sifre == sifre);

            if (kullanici != null)
            {
                AktifKullanici = kullanici.AdSoyad; 
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Logout()
        {
            AktifKullanici = null; 
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Register(Kullanici yeniKullanici)
        {
            if (yeniKullanici != null)
            {
                _kullanicilar.Add(yeniKullanici);
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}