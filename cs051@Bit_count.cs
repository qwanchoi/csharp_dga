/* Bit count
양의 정수를 이진수로 표현했을 때 1의 수를 카운트 하는 Bitcount(uint n) 작성 하세요. 즉 켜진 비트가 몇 개인지 구하세요.
*/

using System;

class MainClass {
    public static void Main( string [] args ) {

        Console.WriteLine ( Bitcount ( 3 ) == 2 );
        Console.WriteLine ( Bitcount ( 7 ) == 3 );
        Console.WriteLine ( Bitcount ( 8 ) == 1 );
        Console.WriteLine ( Bitcount ( 15 ) == 4 );
        Console.WriteLine ( Bitcount ( ( uint ) int.MaxValue ) == 31 );
        //Console.WriteLine( Bitcount(uint.MaxValue) == 32 );

    }

    public static int Bitcount( uint n ) {
        int count = 0;
        for ( int i = ( int ) n ; i >= 1 ; i = i >> 1 ) {
            if ( ( i & 1 ) == 1 ) {
                count++;
            }
        }

        return count;
    }

}












