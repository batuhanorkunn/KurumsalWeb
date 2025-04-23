using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 Karakter Olmalıdır")]
        public string KategoriAd { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
//Bir Kategori birden fazla Blog içerebilir. (One-to-Many). (int? olduğundan dolayı blog kısmında ondan dolayı içerebilir dedik.)
//Her bir Blog, isteğe bağlı olarak (int? sayesinde) bir Kategori'ye ait olabilir.