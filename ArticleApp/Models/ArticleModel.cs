using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClientArticleApp.Models
{
    [Table("Articles")]
    public class ArticleModel
    {
        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Lead { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<TagModel> Tags { get; set; }
        public bool Published { get; set; }

    }
}