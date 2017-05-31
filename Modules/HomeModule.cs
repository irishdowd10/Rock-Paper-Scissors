using Nancy;
using RockPaperScissorsGame.Objects;
using System.Collections.Generic;

namespace RockPaperScissorsGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/two-player"] = _ => {
        return View["Two-Player.cshtml"];
      };

      Get["/one-player"] = _ => {
        return View["One-Player.cshtml"];
      };

      Post["/new-game"] = _ => {

      };
    }
  }
}
