using System;

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

  public enum PieceColor {
    NONE,
    BLUE,
    RED,
    WHITE,
    CYAN,
    GREEN,
    MAGENTA,
    ORANGE,
    PURPLE,
    YELLOW,
    FIRE,
    ICE,
    GROUND,
    DARK
  }

  public class Piece {
    private const int LAYOUT_ROWS = 4;
    private const int LAYOUT_COLS = 4;

    private static readonly Random rand;

    // TODO: change bool to int 
    public bool[,] Layout { get; private set; }
    public int GridRow { get; private set; }
    public int GridCol { get; private set; }
    public PieceType Type { get; private set; }
    public PieceColor Color { get; private set; }

    static Piece() {
      rand = new Random();
    }

    public Piece(string strLayout, PieceColor color) {
      Color = color;
      Layout = new bool[LAYOUT_ROWS, LAYOUT_COLS];
      for (int c = 0; c < LAYOUT_COLS; c++) {
        for (int r = 0; r < LAYOUT_ROWS; r++) {
          Layout[r, c] = (strLayout[r * LAYOUT_COLS + c] == '1');
        }
      }
    }

    public static Piece GetRandPiece() {
      int pieceNum = rand.Next(Enum.GetValues(typeof(PieceType)).Length);
      return MakePiece((PieceType)pieceNum);
    }

    public static Piece MakePiece(PieceType type) {
      Piece piece = null;
      switch (type) {
        case PieceType.L: piece = new Piece("0000010001000110", PieceColor.RED); break;
        case PieceType.J: piece = new Piece("0000001000100110", PieceColor.WHITE); break;
        case PieceType.Z: piece = new Piece("0000011000110000", PieceColor.GROUND); break;
        case PieceType.S: piece = new Piece("0000011011000000", PieceColor.ICE); break;
        case PieceType.I: piece = new Piece("0010001000100010", PieceColor.DARK); break;
        case PieceType.T: piece = new Piece("0000001001110000", PieceColor.FIRE); break;
        case PieceType.O: piece = new Piece("0000011001100000", PieceColor.PURPLE); break;
      }
      return piece;
    }

    public void MoveDown() {
      if (GridRow < 20) {
        GridRow++;
      }
    }
  }
}
