using System;

class MainClass {
    public static void Main( string [] args ) {
        Random rnd = new Random ();
        int a = rnd.Next ( 1 , 30 );
        Console.WriteLine ( "Input(1 ~ 30): " );

        while ( true ) {
            string s = Console.ReadLine ();
            if ( s == "" ) {
                Console.WriteLine ( "Exit!" );
                break;
            }

            int n = 0;
            try {
                n = int.Parse ( s ); //Parse : 문자열을 숫자로 변환 예외를 throw
                                     //TryParse : 예외를 false를 반환
            } catch ( FormatException e ) {
                Console.WriteLine ( e.Message );
                Console.WriteLine ( "Input(1 ~ 30): " );
                continue;
            }

            if ( n == a ) {
                Console.WriteLine ( "Equal!" );
                break;
            } else if ( n > a ) {
                Console.WriteLine ( "too Big!!" );
            } else {
                Console.WriteLine ( "too Small!!" );
            }

        }
    }
}