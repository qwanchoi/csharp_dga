using System;
using System.Collections.Generic;

public static class Exclass {

    public static string Stringify<T>( this IEnumerable<T> list ) {
        string s = "";
        foreach ( var v in list ) {
            s += v.ToString () + " ";
        }
        if ( s.Length > 0 )
            s = s.Substring ( 0 , s.Length - 1 );

        return s;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        int [] [] image = new int [] [] {
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0}
    };

        // Console.WriteLine( "TEST : " +image[1][2] );

        FoolFill ( image , 2 , 3 , 7 );
        Console.WriteLine ( image [ 0 ].Stringify () == "0 0 0 0 0 0 0" );
        Console.WriteLine ( image [ 1 ].Stringify () == "0 0 1 1 1 0 0" );
        Console.WriteLine ( image [ 2 ].Stringify () == "0 0 1 7 1 0 0" );
        Console.WriteLine ( image [ 3 ].Stringify () == "0 0 1 7 1 0 0" );
        Console.WriteLine ( image [ 4 ].Stringify () == "0 0 1 7 1 0 0" );
        Console.WriteLine ( image [ 5 ].Stringify () == "0 0 1 1 1 0 0" );
        Console.WriteLine ( image [ 6 ].Stringify () == "0 0 0 0 0 0 0" );

        FoolFill ( image , 1 , 1 , 2 );
        Console.WriteLine ( image [ 0 ].Stringify () == "2 2 2 2 2 2 2" );
        Console.WriteLine ( image [ 1 ].Stringify () == "2 2 1 1 1 2 2" );
        Console.WriteLine ( image [ 2 ].Stringify () == "2 2 1 7 1 2 2" );
        Console.WriteLine ( image [ 3 ].Stringify () == "2 2 1 7 1 2 2" );
        Console.WriteLine ( image [ 4 ].Stringify () == "2 2 1 7 1 2 2" );
        Console.WriteLine ( image [ 5 ].Stringify () == "2 2 1 1 1 2 2" );
        Console.WriteLine ( image [ 6 ].Stringify () == "2 2 2 2 2 2 2" );

        image = new int [] [] {
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 1, 1, 1, 1, 0, 0},
      new int[] {0, 0, 0, 0, 0, 1, 0},
      new int[] {0, 1, 1, 1, 1, 0, 0},
      new int[] {1, 0, 0, 0, 0, 0, 0},
      new int[] {1, 0, 0, 0, 0, 0, 1},
      new int[] {0, 1, 1, 1, 1, 1, 0}
    };

        FoolFill ( image , 1 , 1 , 2 );
        Console.WriteLine ( image [ 0 ].Stringify () == "0 0 0 0 0 0 0" );
        Console.WriteLine ( image [ 1 ].Stringify () == "0 2 2 2 2 0 0" );
        Console.WriteLine ( image [ 2 ].Stringify () == "0 0 0 0 0 2 0" );
        Console.WriteLine ( image [ 3 ].Stringify () == "0 2 2 2 2 0 0" );
        Console.WriteLine ( image [ 4 ].Stringify () == "2 0 0 0 0 0 0" );
        Console.WriteLine ( image [ 5 ].Stringify () == "2 0 0 0 0 0 2" );
        Console.WriteLine ( image [ 6 ].Stringify () == "0 2 2 2 2 2 0" );

        FoolFill ( image , 0 , 0 , 8 );
        Console.WriteLine ( image [ 0 ].Stringify () == "8 8 8 8 8 8 8" );
        Console.WriteLine ( image [ 1 ].Stringify () == "8 2 2 2 2 8 8" );
        Console.WriteLine ( image [ 2 ].Stringify () == "8 8 8 8 8 2 8" );
        Console.WriteLine ( image [ 3 ].Stringify () == "8 2 2 2 2 8 8" );
        Console.WriteLine ( image [ 4 ].Stringify () == "2 8 8 8 8 8 8" );
        Console.WriteLine ( image [ 5 ].Stringify () == "2 8 8 8 8 8 2" );
        Console.WriteLine ( image [ 6 ].Stringify () == "8 2 2 2 2 2 8" );

        FoolFill ( image , 0 , 0 , 7 );
        FoolFill ( image , 1 , 1 , 7 );
        Console.WriteLine ( image [ 0 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 1 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 2 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 3 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 4 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 5 ].Stringify () == "7 7 7 7 7 7 7" );
        Console.WriteLine ( image [ 6 ].Stringify () == "7 7 7 7 7 7 7" );
    }

    public static void FoolFill( int [] [] _img , int y , int x , int _color , bool _flag = false ) {
        int prevColor = _img [ y ] [ x ];
        Queue<Position> myQueue = new Queue<Position> ();
        Position position = new Position ( y , x );

        myQueue.Enqueue ( position );

        while ( myQueue.Count > 0 ) {
            position = myQueue.Dequeue ();
            _img [ position.y ] [ position.x ] = _color;

            //ÁÂ
            if ( ( position.x - 1 >= 0 )
              && ( _img [ position.y ] [ position.x - 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y , position.x - 1 ) );
            }
            //»ó
            if ( ( position.y - 1 >= 0 )
              && ( _img [ position.y - 1 ] [ position.x ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y - 1 , position.x ) );
            }
            //¿ì
            if ( ( position.x + 1 < _img [ 0 ].Length )
              && ( _img [ position.y ] [ position.x + 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y , position.x + 1 ) );
            }
            //ÇÏ
            if ( ( position.y + 1 < _img.Length )
              && ( _img [ position.y + 1 ] [ position.x ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y + 1 , position.x ) );
            }

            //ÁÂ»ó
            if ( ( position.x - 1 >= 0 ) && ( position.y - 1 >= 0 )
              && ( _img [ position.y - 1 ] [ position.x - 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y - 1 , position.x - 1 ) );
            }
            //¿ì»ó
            if ( ( position.x + 1 < _img [ 0 ].Length ) && ( position.y - 1 >= 0 )
              && ( _img [ position.y - 1 ] [ position.x + 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y - 1 , position.x + 1 ) );
            }
            //¿ìÇÏ
            if ( ( position.x + 1 < _img [ 0 ].Length ) && ( position.y + 1 < _img.Length )
              && ( _img [ position.y + 1 ] [ position.x + 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y + 1 , position.x + 1 ) );
            }
            //ÁÂÇÏ
            if ( ( position.x - 1 >= 0 ) && ( position.y + 1 < _img.Length )
              && ( _img [ position.y + 1 ] [ position.x - 1 ] == prevColor ) ) {
                myQueue.Enqueue ( new Position ( position.y + 1 , position.x - 1 ) );
            }

        }

    }

}

public class Position {
    public int y { get; set; }
    public int x { get; set; }

    public Position( int _y , int _x ) {
        x = _x;
        y = _y;
    }
}