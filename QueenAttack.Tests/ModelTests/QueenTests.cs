using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTests
  {
    [TestMethod]
    public void QueenConstructor_CreateInstanceOfQueen_Queen()
    {
      Queen newQueen = new Queen(4);
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }

    [TestMethod]
    public void GetRankCoordinate_ReturnRankCoordinate_Int()
    {
      Queen newQueen = new Queen(4);
      int rank = 4;
      Assert.AreEqual(rank, newQueen.RankCoord);
    }
  }
}