using System;

delegate int Callback( int i , int j );

class MainClass {
    static int sum( int i , int j ) {
        return i + j;
    }

    public static void Main( string [] args ) {
        Console.WriteLine ( "Lambda Expression: �͸��Լ� ǥ�����̴�!" );

        Callback cb = sum; // or new Callback(sum);

    }
}