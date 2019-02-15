using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WissenMVCProject.Models
{
    public class DenemeForm
    {
        [Required(ErrorMessage ="{0} alanı gereklidir.")]
        [MaxLength(50, ErrorMessage ="{0} alanı en fazla {1} karakter uzunluğunda olabilir.")]
        [Display(Name ="Ad")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olabilir.")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [EmailAddress]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olabilir.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        [Phone]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olabilir.")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

    }
}