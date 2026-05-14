namespace Libraro.Models
{
public class IletisimMesaj
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Email { get; set; }
    public string Konu { get; set; }
    public string Telefon { get; set; }
    public string Mesaj { get; set; }
    public DateTime GonderimTarihi { get; set; } = DateTime.Now;
}
}