using ChessLogic;
using System.Windows;
using System.Windows.Controls;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Image[,] pieceImages = new Image[8, 8];

        private GameState gameState;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();

            gameState = new GameState(Player.White, Board.Initial());
            DrawBoard(gameState.Board);
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                for (int f = 0; f < 8; f++)
                {
                    Image image = new Image();
                    pieceImages[r, f] = image;
                    PieceGrid.Children.Add(image);
                }
            }
        }

        private void DrawBoard(Board board)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int f = 0; f < 8; f++)
                {
                    Piece piece = board[r, f];
                    pieceImages[r, f].Source = Images.GetImage(piece);
                }
            }
        }
    }
}
