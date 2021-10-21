namespace Quadris {
  public enum PieceType {
    L,
    J,
    Z,
    S,
    I,
    T,
    O,
  }
  public class Piece {
    // TODO: change bool to int 
    public bool[,] layout { get; private set; }
    public int gridRow { get; private set; }
    public int gridCol { get; private set; }

    public Piece(string strLayout) {
      layout = new bool[4, 4];
      for (int c = 0; c < 4; c++) {
        for (int r = 0; r < 4; r++) {
          layout[r, c] = (strLayout[r * 4 + c] == '1');
        }
      }
    }

    public static Piece MakePiece(PieceType type) {
      Piece piece = null;
      switch (type) {
        case PieceType.I:
          piece = new Piece("0010001000100010");
          break;
      }
      return piece;
    }

    public void MoveDown() {
      if (gridRow < 20 - 4) {
        gridRow++;
      }
    }
  }
}
