using System;
using System.Collections.Generic;

namespace RockPaperScissorsGame.Objects
{
  public class RockPaperScissors
  {

    public string CheckGameOutcome(string player1, string player2)
    {
      if ((player1 == "Rock" && player2 == "Scissors") || (player1 == "Scissors" && player2 == "Rock"))
      {
        return "Rock";
      }
      else if ((player1 == "Paper" && player2 == "Scissors") || (player1 == "Scissors" && player2 == "Paper"))
      {
        return "Scissors";
      }
      else if ((player1 == "Paper" && player2 == "Rock") ||( player1 == "Rock" && player2 == "Paper"))
      {
        return "Paper";
      }
      else
      {
        return "Draw";
      }
    }

    public string ComputerChooses()
    {
      string[] options = new string[] {"Rock", "Paper", "Scissors"};
      Random rndm = new Random();
      int rndmInt = rndm.Next(0,3);
      return options[rndmInt];
    }
  }
}
