/*
Remove duplicate chars
1. �־��� ���ڿ����� �ߺ��Ǵ� ���ڸ� �����ؼ� �����ִ� RemoveDuplicateChars
(string str) �����
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
