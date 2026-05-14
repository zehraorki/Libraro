using Libraro.Models;

namespace Libraro.Services
{
    public class UrunServisi
    {
        private List<Urun> _urunler = new List<Urun>();
        private List<int> _favoriIdler = new List<int>();

        public void FavoriEkleCikar(int urunId)
        {
            if (_favoriIdler.Contains(urunId))
                _favoriIdler.Remove(urunId);
            else
                _favoriIdler.Add(urunId);
        }

        public List<int> FavorileriGetir() => _favoriIdler;
    }
}