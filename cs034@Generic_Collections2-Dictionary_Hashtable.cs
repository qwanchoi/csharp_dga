using System;
using System.Collections;
using System.Collections.Generic;

class User {
    public string Name { get; set; }
    public int Age { get; set; }
    public User( string name , int age ) {
        Name = name;
        Age = age;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Dictionary<string , string> ht = new Dictionary<string , string> ();

        ht.Add ( "txt" , "notepad.exe" );
        ht.Add ( "bmp" , "paint.exe" );
        ht.Add ( "dib" , "paint.exe" );
        ht.Add ( "rtf" , "wordpad.exe" );
        Console.WriteLine ( ht.Count == 4 );

        try {
            ht.Add ( "txt" , "winword.exe" );
        } catch {
            Console.WriteLine ( "The Key = \"text\" already exists. " );
        }
        Console.WriteLine ( ht.Count == 4 );

        ht [ "max" ] = "3dsmax.exe";
        Console.WriteLine ( ht.Count == 5 );

        Console.WriteLine ( ht.ContainsKey ( "bmp" ) == true );

        ht.Remove ( "bmp" );
        Console.WriteLine ( ht.ContainsKey ( "bmp" ) == false );


        // 숙제 : (주민번호, User) 로 hashtable 만들기
        Console.WriteLine ( "\t Hashtable - ID" );
        Hashtable users = new Hashtable ();

        User hong = new User ( "Hong" , 99 );
        User choi = new User ( "Choi" , 26 );
        User ahn = new User ( "Ahn" , 21 );
        User kim = new User ( "Kim" , 30 );
        User lee = new User ( "Lee" , 25 );
        //

        User kim2 = kim;

        users.Add ( 10236 , hong );
        users.Add ( 16254 , choi );
        users.Add ( 26201 , ahn );
        users.Add ( 13254 , kim ); // users[3254] = kim;
        Console.WriteLine ( users.Count == 4 );

        try {
            users.Add ( 16254 , lee );
        } catch {
            Console.WriteLine ( "The Key = \"text\" already exists. " );
        }
        Console.WriteLine ( users.Count == 4 );

        users [ 23333 ] = lee;
        Console.WriteLine ( users.Count == 5 );

        Console.WriteLine ( users.ContainsKey ( 13254 ) == true );
        Console.WriteLine ( users.ContainsValue ( kim2 ) == true );
        // 레퍼 타입
        users.Remove ( 13254 );

        Console.WriteLine ( users.ContainsKey ( 13254 ) == false );
        Console.WriteLine ( users.Count == 4 );

    }
}









