/*
주어진 password 문자열이 다음 규칙을 만족하는지 알려주는 CheckPassword(string password) 작성하세요.
1. 6~15 자리까지
2. 연속적으로 동일 문자가 나오지 않아야함
3. 적어도 하나의 소문자
4. 적어도 하나의 대문자
5. 적어도 하나의 특수문자 !@#$%^
6. 공백 (white space) 포함 불가

<보강>
string Escaping : http://csharpindepth.com/Articles/General/Strings.aspx 

*/

using System;


class MainClass {
    public static void Main( string [] args ) {
        Console.WriteLine ( CheckPassword ( "asd!fa@sdasdfasdfasdf" ) == false ); //자릿수
        Console.WriteLine ( CheckPassword ( "aF" ) == false ); //자릿수
        Console.WriteLine ( CheckPassword ( "as!fsaa" ) == false ); //연속동일문자
        Console.WriteLine ( CheckPassword ( "ABC%SDEF" ) == false ); //소문자X 
        Console.WriteLine ( CheckPassword ( "@bc$rtef" ) == false ); //대문자X 
        Console.WriteLine ( CheckPassword ( "aAB S^A" ) == false ); //공백
        Console.WriteLine ( CheckPassword ( "aABSEKA" ) == false ); //공백
        Console.WriteLine ( CheckPassword ( "aA@BS^A" ) == true ); //공백


    }

    public static bool CheckPassword( string password ) {
        // 자릿수
        if ( 6 > password.Length || password.Length > 15 ) {
            //Console.Write("length:");
            return false;
        }
        // 연속 동일 문자
        for ( int i = 0 ; i < password.Length - 1 ; i++ ) {
            if ( password [ i ] == password [ i + 1 ] ) {
                //Console.Write("twins:");
                return false;
            }
        }

        // 소문자
        for ( int i = 0 ; i < password.Length ; i++ ) {
            if ( password [ i ] >= 'a' && password [ i ] <= 'z' ) {
                goto lowC;
            }
        }
        //Console.Write("nLoC:"); 
        return false;
        lowC:;


        // 대문자
        for ( int i = 0 ; i < password.Length ; i++ ) {
            if ( password [ i ] >= 'A' && password [ i ] <= 'Z' ) {
                goto uppC;
            }
        }
        //Console.Write("nUpC:");
        return false;
        uppC:;

        // 특수문자 || 공백
        for ( int i = 0 ; i < password.Length ; i++ ) {
            if ( password [ i ] == ' ' ) {
                //Console.Write("whiteS:");
                return false;
            } else if (
                password [ i ] == '!' || password [ i ] == '@' || password [ i ] == '#' ||
                password [ i ] == '$' || password [ i ] == '%' || password [ i ] == '^' ||
                password [ i ] == '\"' || password [ i ] == '\'' || password [ i ] == '\\' ) {
                goto speC;
            }
        }
        //Console.Write("speC:");
        return false;
        speC:;

        return true;
    }

}