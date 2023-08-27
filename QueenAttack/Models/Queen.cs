

using System.Data;
using System.Runtime.CompilerServices;

namespace QueenAttack.Models
{
  public class Queen
  {
    public int RankCoord { get; }
    public int FileCoord { get; }
  
  
    public Queen(int rC, int fC)
    {
      RankCoord = rC;
      FileCoord = fC;
    }
  }
}