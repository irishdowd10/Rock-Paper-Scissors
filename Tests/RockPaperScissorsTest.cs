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
      string player1Selection = "Scissors";
      string player2Selection = "Rock";
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.CheckGameOutcome(player1Selection, player2Selection);
      //Assert
      Assert.Equal("Rock", result);
    }

    [Fact]
    public void ScissorsBeatsPaper_CheckGameOutcome()
    {
      Console.WriteLine("ScissorsBeatsPaper");
      //arrange
      string player1Selection = "Scissors";
      string player2Selection = "Paper";
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.CheckGameOutcome(player1Selection, player2Selection);
      //Assert
      Assert.Equal("Scissors", result);
    }

    [Fact]
    public void PaperBeatsRock_CheckGameOutcome()
    {
      Console.WriteLine("PaperBeatsRock");
      //arrange
      string player1Selection = "Paper";
      string player2Selection = "Rock";
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.CheckGameOutcome(player1Selection, player2Selection);
      //Assert
      Assert.Equal("Paper", result);
    }

    [Fact]
    public void RandomOption_ComputerChooses()
    {
      Console.WriteLine("RandomOption");
      //arrange
      RockPaperScissors newGame = new RockPaperScissors();
      //act
      string result = newGame.ComputerChooses();
      //Assert
      Assert.Equal("Paper", result);
    }

  }
}
