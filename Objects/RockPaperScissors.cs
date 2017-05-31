using System;
using System.Collections.Generic;

namespace RockPaperScissorsGame.Objects
{
  public class RockPaperScissors
  {

    public string CheckGameOutcome(string player1, string player2)
    {
      if (player1 == "Rock" && player2 == "Scissors")
      {
        return player1;
      }
      else if (player1 == player2)
      {
        return "Draw";
      }
      else
      {
        return "John";
      }
    }
  }
}
