using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibs(string pluralNoun1, string pluralNoun2, string pluralNoun3, string celebrity, string articleOfClothing1, string articleOfClothing2, string adjective1, string adjective2, string adjective3, string verb1, string verb2, string typeOfLiquid1, string typeOfLiquid2, string noun1, string noun2, string noun3)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.PluralNoun1 = pluralNoun1;
      myMadLibsVariable.PluralNoun2 = pluralNoun2;
      myMadLibsVariable.PluralNoun3 = pluralNoun3;
      myMadLibsVariable.Celebrity = celebrity;
      myMadLibsVariable.ArticleOfClothing1 = articleOfClothing1;
      myMadLibsVariable.ArticleOfClothing2 = articleOfClothing2;
      myMadLibsVariable.Adjective1 = adjective1;
      myMadLibsVariable.Adjective2 = adjective2;
      myMadLibsVariable.Adjective3 = adjective3;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.Verb2 = verb2;
      myMadLibsVariable.TypeOfLiquid1 = typeOfLiquid1;
      myMadLibsVariable.TypeOfLiquid2 = typeOfLiquid2;
      myMadLibsVariable.Noun1 = noun1;
      myMadLibsVariable.Noun2 = noun2;
      myMadLibsVariable.Noun3 = noun3;
      return View(myMadLibsVariable);
    }
  }
}