using System;

public class Stack {
    public int top = 0;
    private int max;
    int [] arr;

    public Stack( int len ) {
        arr = new int [ len ];
        max = len;
    }

    public void Push( int x ) {
        if ( top < max ) {
            arr [ top ] = x;
            top += 1;
        } else {
            Console.WriteLine ( "Error!" );
        }
    }

    public int Pop() {
        int val = 0;
        if ( top != 0 ) {
            val = arr [ top - 1 ];
            top -= 1;
            return val;
        } else {
            return -1;
        }

    }

    public int Count {
        get {
            return top;
        }
        set {
            Console.WriteLine ( "Error!" );
        }
    }

}

class MainClass {
    public static void Main( string [] args ) {
        Stack s = new Stack ( 3 );
        Console.WriteLine ( s.Count == 0 );
        s.Push ( 10 );
        Console.WriteLine ( s.Count == 1 );
        s.Push ( 20 );
        Console.WriteLine ( s.Count == 2 );
        s.Push ( 30 );
        Console.WriteLine ( s.Count == 3 );
        s.Push ( 40 );
        Console.WriteLine ( s.Count == 3 );
        Console.WriteLine ( s.Pop () == 30 );
        Console.WriteLine ( s.Pop () == 20 );
        Console.WriteLine ( s.Pop () == 10 );
        Console.WriteLine ( s.Count == 0 );
        Console.WriteLine ( s.Pop () == -1 ); // empty

        //s.Count = 10; // error!
    }
}













