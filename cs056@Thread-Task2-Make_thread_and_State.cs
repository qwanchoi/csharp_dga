
// Thread states in C#
// http://www.albahari.com/threading/part2.aspx

using System;
using System.Threading;


class MainClass {
    public static void Todo() {
        for ( int i = 0 ; i < 5 ; i++ ) {
            Thread.Sleep ( 500 );
            Console.WriteLine ( "in Todo() : " + Thread.CurrentThread.ManagedThreadId );
        }
    }

    public static void Main( string [] args ) {
        Thread t = new Thread ( new ThreadStart ( Todo ) );

        Console.WriteLine ( "befor running, Thread state: " + t.ThreadState );
        Thread.Sleep ( 500 );
        t.Start ();
        Console.WriteLine ( "after running, Thread state: " + t.ThreadState );

        t.Join ();
        Console.WriteLine ( "after join, Thread state: " + t.ThreadState );
    }
}