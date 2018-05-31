using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClientArticleApp.Controllers
{
    public class ArticleController : Controller
    {
        private localhost.WebServiceArticleApp webSer = new localhost.WebServiceArticleApp();
        public ActionResult Index()
        {
            return View(webSer.DisplayArticles());
        }

        public ActionResult ListPublished()
        {
            return View(webSer.ListPublishedArticles());
        }

        public ActionResult Published(int id)
        {
            webSer.PublishedArticle(id);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            return View(webSer.GetEmptyArticle());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(localhost.AddArticleDTO article)
        {
            if (ModelState.IsValid)
            {
                webSer.AddArticle(article);
                return RedirectToAction("Index");
            }
            return View(article);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            localhost.AddArticleDTO articleModel = webSer.FindArticleToEdit(id);
            if (articleModel == null)
            {
                return HttpNotFound();
            }
            return View(articleModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArticleId,Title,Lead,Content,CategoryId,Tags")] localhost.AddArticleDTO article)
        {
            if (ModelState.IsValid)
            {
                webSer.EditArticle(article);
                return RedirectToAction("Index");
            }
            return View(article);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            localhost.ArticleDTO articleModel = webSer.FindArticle(id);
            if (articleModel == null)
            {
                return HttpNotFound();
            }
            return View(articleModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            webSer.DeleteArticle(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            localhost.ArticleDTO articleModel = webSer.FindArticle(id);
            if (articleModel == null)
            {
                return HttpNotFound();
            }
            return View(articleModel);
        }
    }
}
