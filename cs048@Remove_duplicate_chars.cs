/*
Remove duplicate chars
1. 주어진 문자열에서 중복되는 문자를 제거해서 돌려주는 RemoveDuplicateChars
(string str) 만들기
2. Console.WriteLine( RemoveDuplicateChars("abcdabe") == "abcde" );
*/

using System;

class MainClass {
    public static string RemoveDuplicateChars( string _str ) {
        // string result = "";
        //
        // foreach (char c in _str) {
        //   foreach (char c2 in result) {
        //     if(c == c2) goto Point;
        //   }
        //   result += c;
        //   Point:;
        // }

        // Console.WriteLine(result);
        // return result;

        //////////////////////////////////////////////////////////////

        string result = "";

        foreach ( char c in _str ) {
            if ( result.IndexOf ( c ) == -1 ) {
                result += c;
            }
        }
        return result;
    }

    public static void Main( string [] args ) {

        Console.WriteLine ( RemoveDuplicateChars ( "abcdabe" ) == "abcde" );
        Console.WriteLine ( RemoveDuplicateChars ( "aaavvavbbsx" ) == "avbsx" );
    }
}
