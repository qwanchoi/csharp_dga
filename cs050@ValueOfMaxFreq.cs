/*
ValueOfMaxFreq()의 내부 구현을 Dictionary<>를 이용하도록 변경하세요.
*/

using System;
using System.Collections.Generic;

class MainClass {
    public static void Main( string [] args ) {
        int [] intArr = new int [] { 1 , 2 , 3 , 1 , 2 , 1 };
        Console.WriteLine ( ValueOfMaxFreq ( intArr ) == 1 );

        intArr = new int [] { 1 , 2 , 2 , 3 , 2 , 3 , 4 , 1 , 3 };
        Console.WriteLine ( ValueOfMaxFreq ( intArr ) == 2 );

    }

    public static int ValueOfMaxFreq( int [] _intArr ) {
        int bigIndex = -1;
        int bigValue = -1;

        Dictionary<int , int> dict = new Dictionary<int , int> ();

        for ( int i = 0 ; i < _intArr.Length ; i++ ) {
            if ( dict.ContainsKey ( _intArr [ i ] ) ) {
                dict [ _intArr [ i ] ] += 1; // += 구현되어 있음.
                int temp = dict [ _intArr [ i ] ];
                // dict.Remove(_intArr[i]);
                // dict.Add(_intArr[i], ++temp);

                if ( temp > bigValue ) {
                    bigIndex = _intArr [ i ];
                    bigValue = temp;
                }
            } else {
                dict.Add ( _intArr [ i ] , 1 );
            }
        }

        return bigIndex;
    }
}













