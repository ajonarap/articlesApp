namespace ArticleApp
{
    using ClientArticleApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelArticleApp : DbContext
    {
        public ModelArticleApp()
            : base("name=ModelArticleApp")
        {
        }
        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<TagModel> Tags { get; set; }
    }
}