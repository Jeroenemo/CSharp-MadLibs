using Microsoft.AspNetCore.mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controllers
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(string pluralNoun1, string pluralNoun2, string pluralNoun3, string celebrity, string articleOfClothing1, string articleOfClothing2, string Adjective1, string Adjective2, string adjective3, string verb1, string verb2, string typeOfLiquid1, string typeOfLiquid2, string noun1, string noun2, string noun3)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.PluralNoun1 = pluralNoun1;
      myMadLibVariable.PluralNoun2 = pluralNoun2;
      myMadLibVariable.PluralNoun3 = pluralNoun3;
      myMadLibVariable.Celebrity = celebrity;
      myMadLibVariable.ArticleOfClothing1 = articleOfClothing1;
      myMadLibVariable.ArticleOfClothing2 = articleOfClothing2;
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Adjective3 = adjective3;
      myMadLibVariable.Verb1 = verb1;
      myMadLibVariable.Verb2 = verb2;
      myMadLibVariable.TypeOfLiquid1 = typeOfLiquid1;
      myMadLibVariable.TypeOfLiquid2 = typeOfLiquid2;
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.Noun3 = noun3;
    }
  }
}