using Microsoft.AspNetCore.mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controllers
    {
      [Route("/form")]
      public ActionResult Form() { return View(); }
    }

}