﻿namespace ChessLogic
{
    public class Knight : Piece
    {
        public override PieceType Type => PieceType.Knight;
        public override Player Colour { get; }

        public Knight(Player colour)
        {
            this.Colour = colour;
        }

        public override Piece Copy()
        {
            Knight copy = new Knight(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
