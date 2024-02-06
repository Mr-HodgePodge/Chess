namespace ChessLogic
{
    public class Bishop : Piece
    {
        // expression-bodied member syntax to more concisely represent that the getter method will return PieceType.Bishop
        public override PieceType Type => PieceType.Bishop;
        public override Player Colour { get; }
        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.NorthEast,
            Direction.NorthWest,
            Direction.SouthEast,
            Direction.SouthWest
        };

        public Bishop(Player colour)
        {
            this.Colour = colour;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
