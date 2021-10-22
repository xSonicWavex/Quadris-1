namespace Quadris {
  public enum CellState {
    EMPTY,
    OCCUPIED_PREVIOUSLY,
    OCCUPIED_ACTIVE_PIECE,
    COLLISION
  }

  public class GridCellInfo {
    public PieceColor Color { get; set; }
    public CellState State { get; set; }

    public GridCellInfo() {
      Reset();
    }

    public void Reset() {
      Color = PieceColor.NONE;
      State = CellState.EMPTY;
    }
  }

  public class Board {
    // TODO: on rotate, recalculate detection pieces

    public GridCellInfo[,] Grid { get; private set; }
    public Piece ActivePiece { get; set; }

    public Board() {
      Grid = new GridCellInfo[24, 10];
      for (int i = 0; i < Grid.GetLength(0); i++) {
        for (int j = 0; j < Grid.GetLength(1); j++) {
          Grid[i, j] = new GridCellInfo();
        }
      }
    }

    public void Update() {
      bool[,] activePieceLayout = ActivePiece.Layout;
      int centerCol = Grid.GetLength(1) / 2 - activePieceLayout.GetLength(1) / 2;
      for (int r = 0; r < activePieceLayout.GetLength(0); r++) {
        for (int c = 0; c < activePieceLayout.GetLength(1); c++) {
          if (activePieceLayout[r, c]) {
            Grid[r + ActivePiece.GridRow, c + ActivePiece.GridCol + centerCol].Reset();
          }
        }
      }
      ActivePiece.MoveDown();
      for (int r = 0; r < activePieceLayout.GetLength(0); r++) {
        for (int c = 0; c < activePieceLayout.GetLength(1); c++) {
          if (activePieceLayout[r, c]) {
            GridCellInfo cellInfo = Grid[r + ActivePiece.GridRow, c + ActivePiece.GridCol + centerCol];
            cellInfo.State = CellState.OCCUPIED_ACTIVE_PIECE;
            cellInfo.Color = ActivePiece.Color;
          }
        }
      }
    }
  }
}
