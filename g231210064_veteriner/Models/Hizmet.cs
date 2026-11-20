using System.ComponentModel.DataAnnotations;

namespace g231210064_veteriner.Models
{
    public class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }

        [Required(ErrorMessage = "Hizmet adı alanı zorunludur.")]
        [StringLength(120, ErrorMessage = "Hizmet adı alanında maksimum karakter sayısı 120'dir.")]

        public string HizmetAdi { get; set; }

        [Required(ErrorMessage = "Bu alanı doldurmak zorunludur.")]
        [Range(2,400, ErrorMessage = "En az 2 en çok 400 dakika girilebilir.")]
        public int SureDakika { get; set; }

        public float Ucret {  get; set; }


    }
}
