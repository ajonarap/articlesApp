using ArticleApp.DTO;
using ClientArticleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.Mappers
{
    public class ArticleMapper
    {
        private ModelArticleApp dbContext;
        private TagMapper tagMapper = new TagMapper();
        public ArticleMapper(ModelArticleApp dbContext)
        {
            this.dbContext = dbContext;
        }

        public ArticleDTO Map(ArticleModel articleModel)
        {
            ArticleDTO articleDto = new ArticleDTO();
            articleDto.ArticleId = articleModel.ArticleId;
            articleDto.CategoryId = articleModel.CategoryId;
            articleDto.Content = articleModel.Content;
            articleDto.Lead = articleModel.Lead;
            articleDto.Published = articleModel.Published;
            articleDto.Tags = articleModel.Tags.Select(t => tagMapper.Map(t)).ToList();
            articleDto.Title = articleModel.Title;
            return articleDto;
        }

        public ArticleModel Map(AddArticleDTO articleDto)
        {
            var listIntTag = articleDto.Tags.Where(x => x.Selected == true).Select(x => x.TagId).ToList();

            ArticleModel articleModel = new ArticleModel
            {
                ArticleId = articleDto.ArticleId,
                CategoryId = articleDto.CategoryId,
                Content = articleDto.Content,
                Lead = articleDto.Lead,
                Published = articleDto.Published,
                Tags = dbContext.Tags.Where(t => listIntTag.Contains(t.TagId)).ToArray(),
                Title = articleDto.Title
            };
            return articleModel;
        }

        public AddArticleDTO MapToAdd(ArticleModel articleModel)
        {
            var TagsToSelect = articleModel.Tags.Select(t => t.TagId);
            AddArticleDTO articleDto = new AddArticleDTO();
            articleDto.ArticleId = articleModel.ArticleId;
            articleDto.CategoryId = articleModel.CategoryId;
            articleDto.Content = articleModel.Content;
            articleDto.Lead = articleModel.Lead;
            articleDto.Published = articleModel.Published;
            articleDto.Tags = dbContext.Tags.ToList().ConvertAll(new Converter<TagModel, AddArticleTagDTO>(tagMapper.MapToEmptyTags));
            foreach (AddArticleTagDTO tag in articleDto.Tags)
            {
                if (TagsToSelect.Contains(tag.TagId))
                {
                    tag.Selected = true;
                }
            }
            articleDto.Title = articleModel.Title;
            return articleDto;
        }

        public ArticleModel Map(AddArticleDTO editedArticleDto, ArticleModel currentModel)
        {
            var listIntTag = editedArticleDto.Tags.Where(x => x.Selected == true).Select(x => x.TagId).ToList();
            var tagsToAdd = dbContext.Tags.Where(t => listIntTag.Contains(t.TagId)).ToArray();

            currentModel.ArticleId = editedArticleDto.ArticleId;
            currentModel.CategoryId = editedArticleDto.CategoryId;
            currentModel.Content = editedArticleDto.Content;
            currentModel.Lead = editedArticleDto.Lead;
            currentModel.Published = editedArticleDto.Published;
            currentModel.Tags.Clear();
            foreach (TagModel tag in tagsToAdd)
            {
                currentModel.Tags.Add(tag);
            }
            currentModel.Title = editedArticleDto.Title;
            return currentModel;
        }

    }
}