using System;

class Car {
    //public var name; // Error , var type �� ���������θ� ��밡��
}

class MainClass {
    public static void Main( string [] args ) {
        var price = 10000; // => int price = 10000; value type <<
                           // ������ ������ �ڵ����� ����

        Console.WriteLine ( price == 10000 );
        Console.WriteLine ( price.GetType ().ToString () == "System.Int32" );

        Int32 i32 = 10000;
        Console.WriteLine ( i32.GetType ().ToString () == "System.Int32" );

        object obj = 70;  // ref type <<
        Console.WriteLine ( obj.GetType ().ToString () == "System.Int32" );
    }
}