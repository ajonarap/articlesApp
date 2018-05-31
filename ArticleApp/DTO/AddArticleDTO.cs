using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.DTO
{
    public class AddArticleDTO
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Lead { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public virtual List<AddArticleTagDTO> Tags { get; set; }
        public bool Published { get; set; }
    }
}