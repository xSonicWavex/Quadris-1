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
    public bool[] layout { get; private set; }
    public int gridRow { get; private set; }
    public int gridCol { get; private set; }

    public Piece() {

    }

    public static Piece makeLinePiece() {
      return null;
    }
  }
}