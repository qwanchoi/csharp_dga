/*
�־��� password ���ڿ��� ���� ��Ģ�� �����ϴ��� �˷��ִ� CheckPassword(string password) �ۼ��ϼ���.
1. 6~15 �ڸ�����
2. ���������� ���� ���ڰ� ������ �ʾƾ���
3. ��� �ϳ��� �ҹ���
4. ��� �ϳ��� �빮��
5. ��� �ϳ��� Ư������ !@#$%^
6. ���� (white space) ���� �Ұ�

<����>
string Escaping : http://csharpindepth.com/Articles/General/Strings.aspx 

*/

using System;


class MainClass {
    public static void Main( string [] args ) {
        Console.WriteLine ( CheckPassword ( "asd!fa@sdasdfasdfasdf" ) == false ); //�ڸ���
        Console.WriteLine ( CheckPassword ( "aF" ) == false ); //�ڸ���
        Console.WriteLine ( CheckPassword ( "as!fsaa" ) == false ); //���ӵ��Ϲ���
        Console.WriteLine ( CheckPassword ( "ABC%SDEF" ) == false ); //�ҹ���X 
        Console.WriteLine ( CheckPassword ( "@bc$rtef" ) == false ); //�빮��X 
        Console.WriteLine ( CheckPassword ( "aAB S^A" ) == false ); //����
        Console.WriteLine ( CheckPassword ( "aABSEKA" ) == false ); //����
        Console.WriteLine ( CheckPassword ( "aA@BS^A" ) == true ); //����


    }

    public static bool CheckPassword( string password ) {
        // �ڸ���
        if ( 6 > password.Length || password.Length > 15 ) {
            //Console.Write("length:");
            return false;
        }
        // ���� ���� ����
        for ( int i = 0 ; i < password.Length - 1 ; i++ ) {
            if ( password [ i ] == password [ i + 1 ] ) {
                //Console.Write("twins:");
                return false;
            }
        }

        // �ҹ���
        for ( int i = 0 ; i < password.Length ; i++ ) {
            if ( password [ i ] >= 'a' && password [ i ] <= 'z' ) {
                goto lowC;
            }
        }
        //Console.Write("nLoC:"); 
        return false;
        lowC:;


        // �빮��
        for ( int i = 0 ; i < password.Length ; i++ ) {
            if ( password [ i ] >= 'A' && password [ i ] <= 'Z' ) {
                goto uppC;
            }
        }
        //Console.Write("nUpC:");
        return false;
        uppC:;

        // Ư������ || ����
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