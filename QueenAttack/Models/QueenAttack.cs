using System;

namespace QueenAttack
{
  public class QueenAttack
  {
    public bool CheckIfAttackable(int queenX, int queenY, int opponentX, int opponentY)
    {
      if(queenY == opponentY)
    {
      return true;
    }
      else if(queenX == opponentX)
      {
        return true;
      }
      else if(Math.Abs(queenX - opponentX) == Math.Abs(queenY-opponentY))
      {
        return true;
      }
    return false;
    }
  }
}
