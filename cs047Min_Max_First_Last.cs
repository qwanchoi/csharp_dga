// Min, Max, First, Last, Sum and Average of array 
// �־��� int[]���� array ������ ����
// 1. array.Min() ���·� �Լ��� ȣ���ؼ� ����� �� �ְ� int[]class 

using System;
using System.Collections;

public static class Exclass {

    public static int First( this int [] arr ) {
        return arr [ 0 ];
    }
    public static int Last( this int [] arr ) {
        return arr [ arr.Length - 1 ];
    }
    public static int Min( this int [] arr ) {
        int temp = arr [ 0 ];
        for ( int i = 1 ; i < arr.Length ; i++ ) {
            if ( arr [ i ] < temp ) temp = arr [ i ];
        }
        return temp;
    }
    public static int Max( this int [] arr ) {
        int temp = arr [ 0 ];
        for ( int i = 1 ; i < arr.Length ; i++ ) {
            if ( arr [ i ] > temp ) temp = arr [ i ];
        }
        return temp;
    }
    public static int Sum( this int [] arr ) {
        int temp = 0;
        for ( int i = 0 ; i < arr.Length ; i++ )
            temp += arr [ i ];

        return temp;
    }
    public static double Average( this int [] arr ) {
        int temp = 0;
        for ( int i = 0 ; i < arr.Length ; i++ )
            temp += arr [ i ];

        return temp / ( double ) arr.Length;
    }

}

class MainClass {
    public static void Main( string [] args ) {
        int [] arr = { 30 , 40 , 70 , 100 , 10 , 20 };

        Console.WriteLine ( arr.First () == 30 );
        Console.WriteLine ( arr.Last () == 20 );
        Console.WriteLine ( arr.Min () == 10 );
        Console.WriteLine ( arr.Max () == 100 );
        Console.WriteLine ( arr.Sum () == ( 30 + 40 + 70 + 100 + 10 + 20 ) );
        Console.WriteLine ( arr.Average () == arr.Sum () / 6 );
    }
}