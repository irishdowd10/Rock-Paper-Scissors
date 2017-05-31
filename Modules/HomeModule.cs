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
        RockPaperScissors newGame = new RockPaperScissors();
        string result = newGame.CheckGameOutcome(Request.Form["Player1-Selection"],
                                          Request.Form["Player2-Selection"]);
        return View["Winner.cshtml", result];
      };

      Post["/new-game"] = _ => {
        RockPaperScissors newGame = new RockPaperScissors();
        rndmOption = ComputerChooses();
        string result = newGame.CheckGameOutcome(Request.Form["Player1-Selection"],
                                          rndmOption]);
        return View["Winner.cshtml", result];
      };
    }
  }
}
