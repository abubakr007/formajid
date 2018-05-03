using QuestionsPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestionsPro.Controllers
{
    public class QuestionsController : Controller
    {
        //
        // GET: /Questions/
        public ActionResult Index()
        {
            Question q = new Question();

            return View(q.getTitles());
        }
        public ActionResult Show(int? id)
        {
            if (id == null)
                return new RedirectResult("Index");

            Question q = new Question();
            StackExchange.StacMan.Question qq =  q.getQuestionById(id);
            return View(qq);
        }
	}
}