using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadris {
  public class Board {
    // TODO: add non-display buffer to top 4 rows
    // TODO: change bool to int
    // TODO: on rotate, recalculate detection pieces

    public bool[,] Grid { get; private set; }
    public Piece ActivePiece { get; set; }

    private int cr;
    private int cc;

    public Board() {
      Grid = new bool[20, 10];
      cr = 0;
      cc = 0;
      Grid[8, 3] = true;
    }

    public void Update() {
      bool[,] activePieceLayout = ActivePiece.layout;
      for (int r = 0; r < activePieceLayout.GetLength(0); r++) {
        for (int c = 0; c < activePieceLayout.GetLength(1); c++) {
          if (activePieceLayout[r, c]) {
            Grid[r + ActivePiece.gridRow, c + ActivePiece.gridCol] = false;
          }
        }
      }
      ActivePiece.MoveDown();
      for (int r = 0; r < activePieceLayout.GetLength(0); r++) {
        for (int c = 0; c < activePieceLayout.GetLength(1); c++) {
          if (activePieceLayout[r, c]) {
            Grid[r + ActivePiece.gridRow, c + ActivePiece.gridCol] = true;
          }
        }
      }
    }
  }
}
