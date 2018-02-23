// FizzBuss
// 1. �־��� ���� ������ ���� 3�� ����̸� "Fizz", 5�� ����̸� "Buzz", �Ѵ� �����̸� FizzBuzz�� �����ϴ� FizzBuzz()�� �ۼ��Ͻÿ�.
//2. 1~100���� �׽�Ʈ ����� ����ϼ���

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












