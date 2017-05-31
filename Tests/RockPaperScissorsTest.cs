using Xunit;
using System;
using System.Collections.Generic;
using RockPaperScissorsGame.Objects;

namespace RockPaperScissorsTester
{
  public class RockPaperScissorsTester
  {

    [Fact]
    public void GameisDraw_CheckGameOutcome()
    {
      Console.WriteLine("GameIsDraw");
      //arrange
      string player1Selection = "Rock";
      string player2Selection = "Rock";
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.CheckGameOutcome(player1Selection, player2Selection);
      //Assert
      Assert.Equal("Draw", result);
    }
    [Fact]
    public void RockBeatsScissors_CheckGameOutcome()
    {
      Console.WriteLine("RockBeatsScissors");
      //arrange
      string player1Selection = "Rock";
      string player2Selection = "Scissors";
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.CheckGameOutcome(player1Selection, player2Selection);
      //Assert
      Assert.Equal(player1Selection, result);
    }
  }
}
