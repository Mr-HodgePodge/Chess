namespace ChessLogic
{
    public class Position
    {
        public int Rank { get; }
        public int File { get; }

        public Position(int rank, int file)
        {
            Rank = rank;
            File = file;
        }

        public Player SquareColour()
        {
            if ((Rank + File) % 2 == 0)
            {
                return Player.White;
            }

            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Rank == position.Rank &&
                   File == position.File;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rank, File);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.Rank + dir.RankDelta, pos.File + dir.FileDelta);
        }
    }
}
