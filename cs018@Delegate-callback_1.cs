using System;

delegate int Callback( int a , int b );
// 함수 (2 args, int return)를 담을 수 있는 변수형 선언
// ㄴ 함수를 담을 수 있는 변수를 만든 것.

class MainClass {
    static int sum( int i , int j ) {
        return i + j;
    }

    public static void Main( string [] args ) {

        Callback cb = sum; // or new Callback(sum);
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = delegate ( int i , int j ) { return i + j; };  //익명 함수
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = ( int i , int j ) => { return i + j; }; // 람다식
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );

        cb = ( i , j ) => i + j;
        Console.WriteLine ( cb ( 10 , 20 ) == 30 );  // 람다식

        Console.WriteLine ( sum ( 10 , 20 ) == 30 );

    }
}