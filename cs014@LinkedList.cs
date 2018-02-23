using System;

class Node {
    public string data;
    public Node next;
}

class LinkedList {
    private Node tail;
    private Node head;

    public LinkedList() {
        tail = null;
        head = null;
        Count = 0;
    }

    public int Count { get; private set; }

    public void AddLast( string value ) {
        Node newNode = new Node ();
        newNode.data = value;
        Count++;

        if ( tail == null ) {
            tail = newNode;
            head = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }
    }

    public string Stringify() {
        string val = "";
        Node curNode = head;

        while ( curNode != null ) {
            val += curNode.data;
            curNode = curNode.next;
        }

        return val;
    }

    public string RemoveFirst() {
        if ( head != null ) {
            Node curNode = head;
            string delData = curNode.data;
            curNode = null;
            head = head.next;
            Count--;
            return delData;

            // string v = head.data;
            // head = head.next;
            // Count--;
            // return v;
        } else {
            Console.WriteLine ( "nothing" );
            //return string.Empty; //아무것도 없는 스트링 ""
            return "";
        }


    }

    public void AddFirst( string value ) {
        Node newNode = new Node ();
        newNode.data = value;

        if ( head == null ) {
            tail = newNode;
        } else {
            newNode.next = head;
        }
        head = newNode;

        Count++;
    }

}

class MainClass {
    public static void Main( string [] args ) {
        LinkedList list = new LinkedList ();

        Console.WriteLine ( list.Count == 0 );
        list.AddLast ( "one" );
        Console.WriteLine ( list.Count == 1 );
        list.AddLast ( "two" );
        Console.WriteLine ( list.Count == 2 );
        Console.WriteLine ( list.Stringify () == "onetwo" );
        list.AddLast ( "three" );
        Console.WriteLine ( list.Stringify () == "onetwothree" );
        Console.WriteLine ( list.Count == 3 );

        Console.WriteLine ( list.RemoveFirst () == "one" );
        Console.WriteLine ( list.Stringify () == "twothree" );
        list.AddFirst ( "il" );
        Console.WriteLine ( list.Stringify () == "iltwothree" );
    }
}





