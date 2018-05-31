using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.DTO
{
    public class AddArticleTagDTO
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}