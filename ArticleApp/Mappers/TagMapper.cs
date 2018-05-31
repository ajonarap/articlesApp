using ArticleApp.DTO;
using ClientArticleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.Mappers
{
    public class TagMapper
    {
        public ArticleTagDTO Map(TagModel tagModel)
        {
            ArticleTagDTO tagDto = new ArticleTagDTO
            {
                TagId = tagModel.TagId,
                Name = tagModel.Name
            };
            return tagDto;
        }

        public AddArticleTagDTO MapToEmptyTags(TagModel tagModel)
        {
            AddArticleTagDTO tagDto = new AddArticleTagDTO
            {
                TagId = tagModel.TagId,
                Name = tagModel.Name,
                Selected = false
            };
            return tagDto;
        }
    }
}