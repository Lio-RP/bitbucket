using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DocsManagement.Models
{
    public class Documents
    {
        [Key]
        public int RegistrationNomer { get; set; }
<<<<<<< HEAD
        public String RegistrationDate { get; set; }
=======
        [Required]
        [Display(Name = "Дата Регистрация Документа")]
        public System.DateTime RegistrationData { get; set; }
        [Required]
        [Display(Name = "Вид Документа")]
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
        public String TypeDocument { get; set; }
        [Required]
        [Display(Name = "Состояния Документа")]
        public String StateDocument { get; set; }
        [Required]
        [Display(Name = "Введите, кто создал")]
        public String CreatedUser { get; set; }
        [Required]
        [Display(Name = "Введите, кто подписал")]
        public String SignedUser { get; set; }
        [Range(1, int.MaxValue)]
        [Display(Name = "Количество Листов")]
        public Nullable<int> NumberSheets { get; set; }
        [Display(Name = "Кроткое Содержание")]
        public String Summary { get; set; }
        //public HttpPostedFileBase File { get; set; }

    }
}
