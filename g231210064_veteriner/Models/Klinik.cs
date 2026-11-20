using System.ComponentModel.DataAnnotations;

namespace g231210064_veteriner.Models
{
    public class Klinik
    {
        //farklı klinikler için oluşturulan class
        [Key]
        public int KlinikId {  get; set; }

        [Required(ErrorMessage = "Klinik adını girmek zorunludur lütfen boş bırakmayınız.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Klinik adı için en az 2 en fazla 100 karakter girebilirsiniz.")]
        public string KlinikAdi {  get; set; } = string.Empty; //uyarı vermemesi için ekledik
        [Required(ErrorMessage = "Telefon alanı zorunludur!")]
        [RegularExpression(@"0\d{10}$", ErrorMessage = "Telefon numaranızın başına 0 koyarak giriniz. Maksimum 11 hane girilebilir")]
        //regularexpression phone dan daha iyi olduğu öğrendim phone +- gibi operatörleri alabiliyormuş
        //^ ve $ baştan sona tüm metin eşleşmeli
        // ilk karakter 0 olacak
        //ardından 10 adet sayı gelecek 
        [Display(Name = "Telefon")]
        public string Telefon { get; set; } = string.Empty;

        public TimeOnly AcilisSaati { get; set; }

        public TimeOnly KapanisSaati { get; set; }


    }
}
