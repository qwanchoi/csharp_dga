using System;

public static class Exclass { // ������ �ִ� Ŭ������ ���� Ȯ��
    public static string Stringify( this int [] list , int a ) {
        string str = ""; // String.Empty;
        for ( int i = 0 ; i < list.Length ; i++ ) {
            str += i < list.Length - 1 ? list [ i ] + " " : list [ i ].ToString ();
        }
        return str;
    }
}

class MainClass {
    public static string Stringify( int [] list , int a ) {
        string str = ""; // String.Empty;
        for ( int i = 0 ; i < list.Length ; i++ ) {
            str += i < list.Length - 1 ? list [ i ] + " " : list [ i ].ToString ();
        }
        return str;
    }

    public static void Main( string [] args ) {
        int [] arrayA = new int [] { 8 , 3 , 2 };

        Console.WriteLine ( Stringify ( arrayA , 10 ) == "8 3 2" );

        Console.WriteLine ( arrayA.Stringify ( 10 ) == "8 3 2" );
        // Ŭ���� Ȯ��
    }
}