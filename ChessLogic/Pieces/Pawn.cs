﻿namespace ChessLogic
{
    public class Pawn : Piece
    {
        public override PieceType Type => PieceType.Pawn;
        public override Player Colour { get; }

        public Pawn(Player colour)
        {
            this.Colour = colour;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
