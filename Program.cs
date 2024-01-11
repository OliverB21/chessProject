// Make a chess engine
using System.Runtime.InteropServices;
using pieceClasses;

class main{
    public static int Main(){

        Pawn pawn1 = pieceClasses.Pawn.createPawn(true);
        KingRook king1 = pieceClasses.KingRook.createKingRook(false, pieceClasses.PieceType.King);

        string txt1 = "";
        string txt2 = "";
        Piece pieceToAnalyse;

        pieceToAnalyse = king1;

        if(pieceToAnalyse.isTaken == false){
            txt1 = "not ";
        }
        if(pieceToAnalyse.isWhite == true){
            txt2 = "white";
        } else {
            txt2 = "black";
        }

        pieceToAnalyse = king1;


        Console.WriteLine($"This is a {pieceToAnalyse.type}. It has {txt1}been taken. It's colour is {txt2}!" );

        return 0;
    }
}