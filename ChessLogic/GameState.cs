namespace ChessLogic
{
    public class GameState
    {
        public Player CurrentPlayer { get; private set; }
        public Board Board { get; }

        public GameState(Player player, Board board)
        {
            CurrentPlayer = player;
            Board = board;
        }
    }
}
