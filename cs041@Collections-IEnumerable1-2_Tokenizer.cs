using System;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;

class Tokens : IEnumerable<string> {
    private List<string> list;
    public Tokens( string _str , char [] chars ) {
        //list = _str.Split(chars).ToList(); >> Linq;
        list = new List<string> ( _str.Split ( chars ) );
    }

    public IEnumerator<string> GetEnumerator() { return list.GetEnumerator (); }

    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator (); }
}

class MainClass {
    public static void Main( string [] args ) {
        Tokens f = new Tokens ( "this is a sample sentence." , new char [] { ' ' , '-' } );

        foreach ( string item in f ) {
            Console.WriteLine ( item );
        }

    }
}