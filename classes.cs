namespace pieceClasses{

    public enum PieceType{
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    };

    class Piece {
        public bool isWhite;
        public bool isTaken;
        public PieceType type;

        public static Piece CreatePiece(PieceType type, bool isWhite){
            Piece piece = new Piece();
            piece.isWhite = isWhite;
            piece.isTaken = false;
            piece.type = type;
            return piece;
        }

        public bool IsWhite(){
            return isWhite;
        }

        public bool IsTaken(){
            return isTaken;
        }

        public PieceType GetPieceType(){
            return type;
        }

        public void takePiece(){
            isTaken = true;
        }
    };

    class KingRook : Piece { // Both king and rook have normal moves besides castling

        public bool canCastle;
        public static KingRook createKingRook(bool isWhite, PieceType pieceType){

            KingRook kingRook = new KingRook();
            kingRook.isWhite = isWhite;
            kingRook.isTaken = false;
            kingRook.type = pieceType;
            kingRook.canCastle = true;    

            return kingRook;
        }

        public bool CanCastle(){
            return canCastle;
        }

        public void setCanCastle(bool canCastle){
            this.canCastle = canCastle;
        }
    };

    class Pawn : Piece { // TODO: Add En Passant
        public bool hasMoved;
        public static Pawn createPawn(bool isWhite){
            Pawn pawn = new Pawn();
            pawn.isWhite = isWhite;
            pawn.isTaken = false;
            pawn.type = PieceType.Pawn;
            pawn.hasMoved = false;

            return pawn;
        }

        public bool HasMoved(){
            return hasMoved;
        }

        public void setHasMoved(bool hasMoved){
            this.hasMoved = hasMoved;
        }
    };

}