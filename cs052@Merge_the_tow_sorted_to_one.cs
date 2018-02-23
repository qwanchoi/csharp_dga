/*
두 개의 이미 정렬된 int[] 주어졌을 때 하나로 합쳐주는 MergeArrays(int[] A, int[] B)함수를 작성하라.
함수 결과물은 int[] 이다.
이미 정렬되었다는 이점을 이용해서 즉 소팅 함수를 사용하지 않고 작성.
*/

using System;
using System.Collections.Generic;

public static class ExClass {
    public static string Stringify<T>( this IEnumerable<T> list ) {
        string s = "";
        foreach ( var v in list ) {
            s += v.ToString () + " ";
        }
        if ( s.Length > 0 )
            s = s.Substring ( 0 , s.Length - 1 );

        return s;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        int [] arrA = new int [] { 1 , 2 , 3 , 5 , 10 , 14 , 20 , 40 }; //len:8
        int [] arrB = new int [] { 5 , 9 , 30 , 31 , 33 , 34 , 35 , 36 , 45 , 50 }; // len:10
        int [] arrC = new int [] { 2 , 9 , 36 , 51 }; // len:4
        int [] arrD = new int [] { 11 , 19 , 21 , 22 , 23 , 26 , 31 }; // len:7

        Console.WriteLine ( MergeArrays ( arrA , arrB ).Stringify () == "1 2 3 5 5 9 10 14 20 30 31 33 34 35 36 40 45 50" ); // len:18
        Console.WriteLine ( MergeArrays ( arrC , arrB ).Stringify () == "2 5 9 9 30 31 33 34 35 36 36 45 50 51" ); // len:14
        Console.WriteLine ( MergeArrays ( arrB , arrD ).Stringify () == "5 9 11 19 21 22 23 26 30 31 31 33 34 35 36 45 50" ); // len:17
        Console.WriteLine ( MergeArrays ( new int [] { } , arrC ).Stringify () == "2 9 36 51" );
        Console.WriteLine ( MergeArrays ( new int [] { } , new int [] { } ).Stringify () == "" );

    }
    // 배열이 한쪽만 있을경우 에러 발생
    // public static int[] MergeArrays(int[] A, int[] B) {
    //   int arrLen = A.Length+B.Length;
    //   int[] result = new int[arrLen];

    //   int indexA = 0;
    //   int indexB = 0;

    //   for(int i = 0; i < arrLen; i++){

    //     if( A[indexA] >= B[indexB] ) {
    //       result[i] = B[indexB];
    //       if(indexB < B.Length-1) {
    //         indexB++;
    //       } else {
    //         for(int j=i+1; j < arrLen; j++) {
    //           result[j] = A[indexA++];
    //         }
    //         break;
    //       }
    //     } else if( A[indexA] < B[indexB] ) {
    //       result[i] = A[indexA];
    //       if(indexA < A.Length-1) {
    //         indexA++;
    //       } else {
    //         for(int j=i+1; j < arrLen; j++) {
    //           result[j] = B[indexB++];
    //         }
    //         break;
    //       }
    //     }

    //   }
    //   //Console.WriteLine(result.Stringify()); // 결과 출력
    //   return result;
    // }
    public static int [] MergeArrays( int [] A , int [] B ) {
        int arrLen = A.Length + B.Length;
        int [] result = new int [ arrLen ];

        int indexA = 0;
        int indexB = 0;

        for ( int i = 0 ; i < arrLen ; i++ ) {

            if ( indexA == A.Length ) {
                result [ i ] = B [ indexB ];
                indexB++;
                continue;
            }

            if ( indexB == B.Length ) {
                result [ i ] = A [ indexA ];
                indexA++;
                continue;
            }

            if ( A [ indexA ] >= B [ indexB ] ) {
                result [ i ] = B [ indexB ];
                indexB++;
            } else {
                result [ i ] = A [ indexA ];
                indexA++;
            }


        }

        return result;
    }

}
