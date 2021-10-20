using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadris {
  public class Board {
    public bool[,] Grid { get; private set; }
    private Piece activePiece;

    private int cr;
    private int cc;

    public Board() {
      Grid = new bool[20, 10];
      cr = 0;
      cc = 0;
      Grid[cr, cc] = true;
    }

    public void Update() {
      Grid[cr, cc] = false;
      cc++;
      if (cc >= Grid.GetLength(1)) {
        cr++;
        cc = 0;
        if (cr >= Grid.GetLength(0)) {
          cr = 0;
          cc = 0;
        }
      }
      Grid[cr, cc] = true;
    }
  }
}
