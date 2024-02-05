namespace ChessLogic
{
    // The Player enum will also be used to represent the colour of the squares on the board
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
