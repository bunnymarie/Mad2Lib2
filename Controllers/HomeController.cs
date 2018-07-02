using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Madlib()
        {
            return View();
        }
        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }
        [Route("/my_mad_libs")]
        public ActionResult MyMadLib()
        {
            MadlibVariable myMadLibVariable = new MadlibVariable();
            myMadLibVariable.SetPersonOne(Request.Query["person-one"]);
            myMadLibVariable.SetPersonTwo(Request.Query["person-two"]);
            myMadLibVariable.SetPlaceOne(Request.Query["place-one"]);
            myMadLibVariable.SetPlaceTwo(Request.Query["place-two"]);
            myMadLibVariable.SetObject(Request.Query["object-one"]);
            myMadLibVariable.SetAnimal(Request.Query["animal-one"]);
            myMadLibVariable.SetExclamation(Request.Query["exclamation-one"]);
            myMadLibVariable.SetActivity(Request.Query["activity-one"]);

        }
    }
}
