using pieceClasses;

namespace pieceClasses
{

    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King,
        Null
    };

    class Piece
    {
        private bool isWhite;
        private bool isTaken;
        private PieceType type;

        public Piece(PieceType type, bool isWhite)
        {
            this.isWhite = isWhite;
            this.isTaken = false;
            this.type = type;
        }
        public bool IsWhite()
        {
            return isWhite;
        }

        public bool IsTaken()
        {
            return isTaken;
        }

        public PieceType GetPieceType()
        {
            return type;
        }

        public void takePiece()
        {
            isTaken = true;
        }
    };

    class KingRook : Piece
    { // Both king and rook have normal moves besides castling

        private bool canCastle;
        public KingRook(PieceType pieceType, bool isWhite) : base(pieceType, isWhite)
        {

            this.canCastle = true;
        }

        public bool CanCastle()
        {
            return canCastle;
        }

        public void setCanCastle(bool canCastle)
        {
            this.canCastle = canCastle;
        }
    };

    class Pawn : Piece
    { // TODO: Add En Passant
        public bool hasMoved;
        public Pawn(PieceType pieceType, bool isWhite) : base(pieceType, isWhite)
        {
            this.hasMoved = false;
        }

        public bool HasMoved()
        {
            return hasMoved;
        }

        public void setHasMoved(bool hasMoved)
        {
            this.hasMoved = hasMoved;
        }
    };

}

namespace boardClass
{
    class Board
    {
        private Piece[,] boardState;
        private Piece rook1;
        private PieceType[,] defaultBoard = {{PieceType.Rook,PieceType.Knight,PieceType.Bishop,PieceType.King,PieceType.Queen,PieceType.Bishop,PieceType.Knight,PieceType.Rook},
                                                {PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn},
                                                {PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null},
                                                {PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null},
                                                {PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null},
                                                {PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null,PieceType.Null},
                                                {PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn,PieceType.Pawn},
                                                {PieceType.Rook,PieceType.Knight,PieceType.Bishop,PieceType.Queen,PieceType.King,PieceType.Bishop,PieceType.Knight,PieceType.Rook}};

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j =0; j < 8; j++){
                    switch (defaultBoard[i,j]){
                        case PieceType.Rook:
                            Console.WriteLine("ROOK");
                            break;
                        case PieceType.Pawn:
                            Console.WriteLine("PAWN");
                            break;
                        case PieceType.Knight:
                            Console.WriteLine("KNIGHT");
                            break;
                        case PieceType.Bishop:
                            Console.WriteLine("BISHOP");
                            break;
                        case PieceType.King:
                            Console.WriteLine("KING");
                            break;
                        case PieceType.Queen:
                            Console.WriteLine("QUEEN");
                            break;
                        default:
                            Console.WriteLine("NO PIECE");
                            break;
                            
                        }
                    }
            }
        }
    }

}