using System;

delegate int Callback( int a , int b );

class MainClass {
    static int Sum( int i , int j ) {
        Console.WriteLine ( "Sum" );
        return i + j;
    }

    static int Multiply( int i , int j ) {
        Console.WriteLine ( "Multiply" );
        return i * j;
    }

    static int Power( int i , int j ) {
        Console.WriteLine ( "Power" );
        return ( int ) Math.Pow ( ( double ) i , ( double ) j );
    }

    public static void Main( string [] args ) {
        Callback cb = Sum; // new Callback(Sum);
        Console.WriteLine ( cb ( 1 , 2 ) == 3 );

        cb = delegate ( int i , int j ) { return i + j; }; // 익명함수
        Console.WriteLine ( cb ( 2 , 3 ) == 5 );

        cb = ( int i , int j ) => { return i + j; }; // 람다식
        Console.WriteLine ( cb ( 4 , 5 ) == 9 );

        cb = ( i , j ) => i + j;
        Console.WriteLine ( cb ( 6 , 7 ) == 13 ); // 람다식

        Console.WriteLine ( "\tChain" );
        cb = Sum;
        cb += Multiply;
        cb += Power;

        Console.WriteLine ( cb ( 2 , 3 ) == 8 );

        cb -= Power;

        Console.WriteLine ( cb ( 3 , 2 ) == 6 );
    }
}