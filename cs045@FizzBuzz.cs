// FizzBuss
// 1. 주어진 양의 정수에 대해 3의 배수이면 "Fizz", 5의 배수이면 "Buzz", 둘다 만족이면 FizzBuzz를 리턴하는 FizzBuzz()를 작성하시오.
//2. 1~100까지 테스트 결과를 출력하세요

using System;

class MainClass {
    public static string FizzBuzz( int i ) {
        if ( i % 3 == 0 && i % 5 == 0 )
            return "FizzBuzz";
        else if ( i % 3 == 0 )
            return "Fizz";
        else if ( i % 5 == 0 )
            return "Buzz";
        else
            return "";
    }

    public static void Main( string [] args ) {

        Console.WriteLine ( FizzBuzz ( 2 ) == "" );
        Console.WriteLine ( FizzBuzz ( 3 ) == "Fizz" );
        Console.WriteLine ( FizzBuzz ( 5 ) == "Buzz" );
        Console.WriteLine ( FizzBuzz ( 15 ) == "FizzBuzz" );

        for ( int i = 1 ; i <= 100 ; i++ ) {
            Console.WriteLine ( i + ": " + FizzBuzz ( i ) );
        }

    }
}












