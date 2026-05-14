namespace Libraro.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public string ResimYolu { get; set; }
        public string Aciklama { get; set; }
        public bool IsFavorite { get; set; }
    }
}

