/* Bit count
���� ������ �������� ǥ������ �� 1�� ���� ī��Ʈ �ϴ� Bitcount(uint n) �ۼ� �ϼ���. �� ���� ��Ʈ�� �� ������ ���ϼ���.
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












