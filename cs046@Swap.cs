// Swap
// 1. int형 Swap(int a, int b) 를 작성.
// 2. int[]형 Swap(int[] arrayA, int[] arrayB)를 작성. 배열 사이즈가 다른경우 호출자에게 알림.
// 3. Book(멤버가 Title, Price)형 Swap(Book a, Book b)를 작성
// 4. 하나의 int[]를 주어졌을 때 min, max 값을 서로 swap 시키는 SwapMinMax(int[] array)를 작성.

using System;

class Book {
    public string Title { get; set; }
    public int Price { get; set; }

    public Book( string _title , int _price ) {
        Title = _title;
        Price = _price;
    }


}

class MainClass {
    public static string Stringify( int [] arr ) {
        string str = "";
        return str;
    }

    public static void Swap( ref int a , ref int b ) {
        int temp = a;
        a = b;
        b = temp;
    }
    public static bool Swap( int [] a , int [] b ) {
        int temp;
        if ( a.Length != b.Length ) {
            return false;
        }
        for ( int i = 0 ; i < a.Length ; i++ ) {
            temp = a [ i ];
            a [ i ] = b [ i ];
            b [ i ] = temp;
        }
        return true;
    }
    public static void Swap( Book a , Book b ) {
        string tempStr;
        int tempInt;

        tempStr = a.Title;
        a.Title = b.Title;
        b.Title = tempStr;

        tempInt = a.Price;
        a.Price = b.Price;
        b.Price = tempInt;
    }

    public static void SwapMinMax( int [] arr ) {
        int max = arr [ 0 ];
        int min = arr [ 0 ];
        int indexMax = 0;
        int indexMin = 0;
        for ( int i = 0 ; i < arr.Length ; i++ ) {
            if ( arr [ i ] > max ) {
                max = arr [ i ];
                indexMax = i;
            }
            if ( arr [ i ] < min ) {
                min = arr [ i ];
                indexMin = i;
            }
        }
        arr [ indexMax ] = min;
        arr [ indexMin ] = max;
    }

    public static void Main( string [] args ) {
        //1
        int a = 1; int b = 2;
        Swap ( ref a , ref b );
        Console.WriteLine ( a == 2 && b == 1 );

        //2
        int [] arrA = new int [] { 1 , 2 };
        int [] arrB = new int [] { 11 , 12 };
        int [] arrC = new int [] { 1 , 2 , 3 };

        Swap ( arrA , arrB );
        Console.WriteLine ( arrA [ 0 ] == 11 && arrB [ 0 ] == 1 );
        Console.WriteLine ( Swap ( arrA , arrC ) == false );

        //3
        Book bookA = new Book ( "TITLE" , 1000 );
        Book bookB = new Book ( "BOOK" , 2000 );

        Swap ( bookA , bookB );
        Console.WriteLine ( bookA.Title == "BOOK" && bookB.Title == "TITLE" );
        //Console.WriteLine(bookA.Price == 2000 && bookB.Price == 1000 );

        //4
        SwapMinMax ( arrC );
        Console.WriteLine ( arrC [ 0 ] == 3 && arrC [ 2 ] == 1 );

    }
}













