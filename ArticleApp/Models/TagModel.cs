using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientArticleApp.Models
{
    [Table("Tags")]
    public class TagModel
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ArticleModel> Articles { get; set; }
    }
}