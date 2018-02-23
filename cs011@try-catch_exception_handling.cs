using System;

class Calc {
    public float divide( int x , int y ) {
        float z = 0;
        try {
            z = x / y;
            return z;
        } catch ( Exception e ) {
            Console.WriteLine ( e.Message );
            return z;
        }
    }
}

class Array {
    public float select( int x ) {
        int [] i = new int [ 3 ] { 1 , 2 , 3 };
        int j = 0;
        try {
            j = i [ x ];
            return j;
        } catch ( Exception e ) {
            Console.WriteLine ( e.Message );
            return j;
        }
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Calc c = new Calc ();
        Console.WriteLine ( c.divide ( 10 , 1 ) == 10 );
        c.divide ( 10 , 0 );

        Array ar = new Array ();
        Console.WriteLine ( ar.select ( 10 ) );
    }
}