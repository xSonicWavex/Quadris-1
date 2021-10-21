using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quadris {
  public partial class FrmMain : Form {
    private const int BOARD_COLS = 10;
    private const int BOARD_ROWS = 20;

    private const int CELL_WIDTH = 20;
    private const int CELL_HEIGHT = 20;

    private static readonly Color EMPTY_CELL_COLOR = Color.FromArgb(0, 0, 255);
    private static readonly Color FILLED_CELL_COLOR = Color.FromArgb(200, 200, 200);

    private Label[,] gridControls;
    private Board board;

    public FrmMain() {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e) {
      board = new Board();
      Piece piece = Piece.MakePiece(PieceType.I);
      board.ActivePiece = piece;
      CreateGrid();
    }

    private void CreateGrid() {
      panBoard.Width = CELL_WIDTH * BOARD_COLS;
      panBoard.Height = CELL_HEIGHT * BOARD_ROWS;
      gridControls = new Label[BOARD_ROWS, BOARD_COLS];
      panBoard.Controls.Clear();
      for (int col = 0; col < BOARD_COLS; col++) {
        for (int row = 0; row < BOARD_ROWS; row++) {
          Label lblCell = MakeGridCell(row, col);
          panBoard.Controls.Add(lblCell);
          gridControls[row, col] = lblCell;
        }
      }
    }

    private void UpdateGrid() {
      for (int col = 0; col < BOARD_COLS; col++) {
        for (int row = 0; row < BOARD_ROWS; row++) {
          if (board.Grid[row, col]) {
            gridControls[row, col].BackColor = FILLED_CELL_COLOR;
          }
          else {
            gridControls[row, col].BackColor = EMPTY_CELL_COLOR;
          }
        }
      }
    }

    private Label MakeGridCell(int row, int col) {
      return new Label() {
        Text = "",
        BackColor = (board.Grid[row, col] ? FILLED_CELL_COLOR : EMPTY_CELL_COLOR),
        Width = CELL_WIDTH,
        Height = CELL_HEIGHT,
        FlatStyle = FlatStyle.Flat,
        Top = row * CELL_HEIGHT,
        Left = col * CELL_WIDTH
      };
    }

    private void tmrFps_Tick(object sender, EventArgs e) {
      board.Update();
      UpdateGrid();
    }
  }
}
