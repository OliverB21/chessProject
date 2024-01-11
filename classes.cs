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
        private bool isWhite;
        private bool isTaken;
        private PieceType type;

        public Piece(PieceType type, bool isWhite){
            this.isWhite = isWhite;
            this.isTaken = false;
            this.type = type;
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

        private bool canCastle;
        public KingRook(PieceType pieceType, bool isWhite):base(pieceType, isWhite){

            this.canCastle = true;    
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
        public Pawn(PieceType pieceType, bool isWhite):base(pieceType, isWhite){
            this.hasMoved = false;
        }

        public bool HasMoved(){
            return hasMoved;
        }

        public void setHasMoved(bool hasMoved){
            this.hasMoved = hasMoved;
        }
    };

}