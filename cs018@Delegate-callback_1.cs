using System;

delegate int Callback( int a , int b );
// �Լ� (2 args, int return)�� ���� �� �ִ� ������ ����
// �� �Լ��� ���� �� �ִ� ������ ���� ��.

class MainClass {
    static int sum( int i , int j ) {
        return i + j;
    }

    public static void Main( string [] args ) {

        Callback cb = sum; // or new Callback(sum);
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = delegate ( int i , int j ) { return i + j; };  //�͸� �Լ�
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = ( int i , int j ) => { return i + j; }; // ���ٽ�
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = ( i , j ) => i + j;
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );  // ���ٽ�

        Console.WriteLine ( sum ( 10 , 20 ) == 30 );

    }
}