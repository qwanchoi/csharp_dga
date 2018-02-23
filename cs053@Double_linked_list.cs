/*
Double linked list
1. 기존의 linked list를 double linked list로 변경하세요.
2. 관련 함수 모두 수정ㅎ세요 : AddLast(), AddFirst(), RemoveFirst()
3. RemoveLast() 추가로 구현하세요! 제거된 값을 돌려줘야 합니다.
4. 기존의 Count 속성을 제거하세요. 노드를 모두 순회해서 갯수를 알아내는 Count() 만드세요.
*/

using System;

class MainClass {
    public static void Main( string [] args ) {
        LinkedList list = new LinkedList ();

        list.AddLast ( 10 );
        list.AddLast ( 20 );
        list.AddFirst ( 15 );
        list.AddFirst ( 5 );

        Console.WriteLine ( list.Count () == 4 );
        Console.WriteLine ( list.RemoveLast () == 20 );
        Console.WriteLine ( list.RemoveLast () == 10 );
        Console.WriteLine ( list.Count () == 2 );
        Console.WriteLine ( list.RemoveFirst () == 5 );
        Console.WriteLine ( list.RemoveFirst () == 15 );
        Console.WriteLine ( list.RemoveFirst () == -1 );
        Console.WriteLine ( list.Count () == 0 );

        list.AddFirst ( 100 );
        list.AddFirst ( 80 );
        list.AddFirst ( 70 );
        list.AddFirst ( 10 );

        Console.WriteLine ( list.Count () == 4 );
        Console.WriteLine ( list.RemoveLast () == 100 );
        Console.WriteLine ( list.Count () == 3 );

        list.AddLast ( 50 );
        list.AddLast ( 60 );

        Console.WriteLine ( list.Count () == 5 );
        Console.WriteLine ( list.RemoveFirst () == 10 );
        Console.WriteLine ( list.Count () == 4 );
    }
}

public class Node {
    public int data { get; set; }
    public Node next { get; set; }
    public Node prev { get; set; }

    public Node( int _data ) {
        data = _data;
    }
}

public class LinkedList {
    Node head;
    Node tail;

    public LinkedList() {
        head = tail = null;
    }

    public void AddLast( int _data ) {
        Node newNode = new Node ( _data );
        if ( tail == null ) {
            head = tail = newNode;
        } else {
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
            tail.next = null;
        }
    }

    public void AddFirst( int _data ) {
        Node newNode = new Node ( _data );
        if ( head == null ) {
            head = tail = newNode;
        } else {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            head.prev = null;
        }
    }

    public int RemoveFirst() {
        if ( head == null ) {
            return -1;
        } else if ( head == tail ) {
            int temp = head.data;
            head = tail = null;
            return temp;
        } else {
            Node tempNode = head.next;
            tempNode.prev = null;
            int temp = head.data;
            head = tempNode;
            return temp;
        }
    }

    public int RemoveLast() {
        if ( tail == null ) {
            return -1;
        } else if ( head == tail ) {
            int temp = tail.data;
            head = tail = null;
            return temp;
        } else {
            Node tempNode = tail.prev;
            tempNode.next = null;
            int temp = tail.data;
            tail = tempNode;
            return temp;
        }
    }

    public int Count() {
        Node curNode = null;
        int count = 0;
        if ( !( head == null ) ) {
            curNode = head;
            count++;
            while ( !( curNode.next == null ) ) {
                curNode = curNode.next;
                count++;
            }
            return count;
        }
        return 0;
    }

}












