using System;

class MainClass {
    public static void Main( string [] args ) {
        // http://www.csharp-examples.net/string-format-double/
        Console.WriteLine ( String.Format ( "{0,5}" , 15 ) );
        Console.WriteLine ( String.Format ( "{0:0.00}" , 123.1 ) );
        Console.WriteLine ( "{0:0.#}" , 10.023 );
        Console.WriteLine ( "{0:0.#}" , 10.173 );

        string s;

        s = "ABC";
        Console.WriteLine ( s.Length == 3 );

        s = string.Empty;
        Console.WriteLine ( s == "" );

        s = "ABCDEF";
        Console.WriteLine ( s.IndexOf ( "S" ) ); // 찾을수 없다 : -1;

        s = "1000,2000,3000";
        string [] prices = s.Split ( ',' );
        foreach ( string price in prices )
            Console.WriteLine ( price );

        s = "1000, 2000, 3000";
        prices = s.Replace ( " " , "" ).Split ( ',' );
        foreach ( string price in prices )
            Console.WriteLine ( price );

        s = "ABCDEF";
        Console.WriteLine ( s.Substring ( 1 , 3 ) == "BCD" );
    }
}








