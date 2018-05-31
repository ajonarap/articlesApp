using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Entity;
using System.Data;
using ClientArticleApp.Models;
using ArticleApp.Mappers;
using ArticleApp.DTO;

namespace ArticleApp
{
    /// <summary>
    /// Opis podsumowujący dla WebServiceArticleApp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Aby zezwalać na wywoływanie tej usługi sieci Web ze skryptu za pomocą kodu ASP.NET AJAX, usuń znaczniki komentarza z następującego wiersza. 
    // [System.Web.Script.Services.ScriptService]

    public class WebServiceArticleApp : System.Web.Services.WebService
    {
        private static ModelArticleApp dbContext = new ModelArticleApp();
        private ArticleMapper articleMapper = new ArticleMapper(dbContext);
        private TagMapper tagMapper = new TagMapper();
        
        [WebMethod]
        public List<ArticleDTO> DisplayArticles()
        {
            return dbContext.Articles.Where(x => x.Published.Equals(false)).ToList().ConvertAll(new Converter<ArticleModel, ArticleDTO>(articleMapper.Map));
        }

        [WebMethod]
        public AddArticleDTO GetEmptyArticle()
        {
            AddArticleDTO addArticleDTO = new AddArticleDTO();
            addArticleDTO.Tags = dbContext.Tags.ToList().ConvertAll(new Converter<TagModel, AddArticleTagDTO>(tagMapper.MapToEmptyTags));
            return addArticleDTO;
        }

        [WebMethod]
        public void AddArticle(AddArticleDTO article)
        {
            dbContext.Articles.Add(articleMapper.Map(article));
            dbContext.SaveChanges();
        }

        [WebMethod]
        public AddArticleDTO EditArticle(AddArticleDTO article)
        {
            ArticleModel articleModel = articleMapper.Map(article, dbContext.Articles.Find(article.ArticleId));
            dbContext.Entry(articleModel).State = EntityState.Modified;
            dbContext.SaveChanges();
            return article;
        }

        [WebMethod]
        public ArticleDTO FindArticle(int? idArticle)
        {
            return articleMapper.Map(dbContext.Articles.Find(idArticle));
        }

        [WebMethod]
        public AddArticleDTO FindArticleToEdit(int? idArticle)
        {
            return articleMapper.MapToAdd(dbContext.Articles.Find(idArticle));
        }

        [WebMethod]
        public void DeleteArticle(int id)
        {
            ArticleModel article = dbContext.Articles.Find(id);
            dbContext.Articles.Remove(article);
            dbContext.SaveChanges();
        }

        [WebMethod]
        public void PublishedArticle(int id)
        {
            ArticleModel article = dbContext.Articles.Find(id);
            article.Published = true;
            dbContext.Entry(article).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        [WebMethod]
        public List<ArticleDTO> ListPublishedArticles()
        {
            return dbContext.Articles.ToList().Where(x => x.Published.Equals(true)).Select(a=>articleMapper.Map(a)).ToList();
        }
    }
}
