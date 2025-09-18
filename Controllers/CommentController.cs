using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CsrfVulnApp.Controllers
{
    public class CommentController : Controller
    {
        public static List<string> Comments = new List<string>();

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Comments = Comments;
            return View();
        }

        [HttpPost]
        // ❌ Pas de [ValidateAntiForgeryToken] → vulnérabilité CSRF
        public IActionResult Add(string content)
        {
            Comments.Add(content);
            return RedirectToAction("Add");
        }
    }
}
