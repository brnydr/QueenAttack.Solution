using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
      Queen newQueen = new Queen(4, 7);
      Assert.AreEqual(typeof(Queen), newQueen.GetType());
    }

    [TestMethod]
    public void GetRankCoordinate_ReturnRankCoordinate_Int()
    {
      Queen newQueen = new Queen(4, 7);
      int rank = 4;
      Assert.AreEqual(rank, newQueen.RankCoord);
    }

    [TestMethod]
    public void GetFileCoordinate_ReturnFileCoordinate_Int()
    {
      Queen newQueen = new Queen(4, 7);
      int file = 7;
      Assert.AreEqual(file, newQueen.FileCoord);
    }

    [TestMethod]
    public void CanAttack_ReturnTrueIfQueenCanAttack_True()
    {
      Queen newQueen = new Queen(4, 7);
      Queen newPiece = new Queen(4, 5);
      Assert.AreEqual(true, newQueen.CanAttack(newPiece));
    }
  }
}