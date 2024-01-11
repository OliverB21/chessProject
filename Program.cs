// Make a chess engine
using System.Runtime.InteropServices;
using pieceClasses;

class main{
    public static int Main(){

        Pawn pawn1 = new Pawn(pieceClasses.PieceType.Pawn, true);
        KingRook king1 = new KingRook(pieceClasses.PieceType.King, false);

        string txt1 = "";
        string txt2 = "";
        Piece pieceToAnalyse;

        pieceToAnalyse = king1;

        if(pieceToAnalyse.IsTaken() == false){
            txt1 = "not ";
        }
        if(pieceToAnalyse.IsWhite() == true){
            txt2 = "white";
        } else {
            txt2 = "black";
        }

        pieceToAnalyse = king1;


        Console.WriteLine($"This is a {pieceToAnalyse.GetPieceType()}. It has {txt1}been taken. It's colour is {txt2}!" );

        return 0;
    }
}