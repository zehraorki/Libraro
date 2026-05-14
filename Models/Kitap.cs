namespace Libraro.Models
{
    public class Kitap : Urun
    {
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }

        public string BasimYili { get; set; }

        public int SayfaSayisi { get; set; }
    }
}