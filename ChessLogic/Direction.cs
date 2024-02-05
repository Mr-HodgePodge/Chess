namespace ChessLogic
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;

        public int RankDelta { get; }
        public int FileDelta { get; }

        public Direction(int rankDelta, int fileDelta)
        {
            RankDelta = rankDelta;
            FileDelta = fileDelta;
        }

        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RankDelta + dir2.RankDelta, dir1.FileDelta + dir2.FileDelta);
        }

        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RankDelta, scalar * dir.FileDelta);
        }
    }
}
