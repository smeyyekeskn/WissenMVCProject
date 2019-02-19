﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenMVCProject.Model
{
    public class Post:BaseEntity
    {
        [Display(Name ="Başlık")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        
        public string Description { get; set; }

        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }

        [Display(Name = "Kategori")]
        public virtual Category Category { get; set; }
    }
}
