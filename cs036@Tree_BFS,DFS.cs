using System;
using System.Collections.Generic;

// 트리 자료구조
//             root
//           /   |   \
//         a     b    c
//        / \   / \
//       d   e f   g 
//                / \
//               h   i
//
// BFS : 넓이 탐색 배열
// root a b c d e f g h i
//
// DFS : 깊이 탐색 배열
// root a d e b f g h i c

public class TreeNode {
    public string Name { get; set; }
    public List<TreeNode> children;
    public TreeNode( string name ) {
        Name = name;
        children = new List<TreeNode> ();
    }
    public void AddChild( TreeNode c ) {
        children.Add ( c );
    }
}

public class Tree {
    public TreeNode Root { get; set; }

    public string BFS( TreeNode node , Action<string> action ) {
        string s = String.Empty;
        Queue<TreeNode> q = new Queue<TreeNode> ();
        q.Enqueue ( node );

        while ( q.Count > 0 ) {
            TreeNode n = q.Dequeue ();
            s += n.Name + " ";
            action ( n.Name );
            foreach ( var c in n.children ) // var : 컴파일 시점에 결정됨.
                q.Enqueue ( c );
        }
        return s;
    }

    public string IterativeDFS( TreeNode node ) { // 반복적
        string s = String.Empty;
        Stack<TreeNode> stack = new Stack<TreeNode> ();
        stack.Push ( node );

        while ( stack.Count > 0 ) {
            TreeNode n = stack.Pop ();
            s += n.Name + " ";
            //Console.WriteLine(n.Name);

            for ( int i = n.children.Count - 1 ; i >= 0 ; i-- ) {
                stack.Push ( n.children [ i ] );
            }
        }
        return s;
    }

    public string RecursiveDFS( TreeNode node ) { //재귀적
        string s = node.Name + " ";
        foreach ( var n in node.children )
            s += RecursiveDFS ( n );

        return s;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Tree tree = new Tree ();
        TreeNode root = new TreeNode ( "root" );
        TreeNode a = new TreeNode ( "a" );
        TreeNode b = new TreeNode ( "b" );
        TreeNode c = new TreeNode ( "c" );
        TreeNode d = new TreeNode ( "d" );
        TreeNode e = new TreeNode ( "e" );
        TreeNode f = new TreeNode ( "f" );
        TreeNode g = new TreeNode ( "g" );
        TreeNode h = new TreeNode ( "h" );
        TreeNode i = new TreeNode ( "i" );

        root.AddChild ( a ); root.AddChild ( b ); root.AddChild ( c );
        a.AddChild ( d ); a.AddChild ( e );
        b.AddChild ( f ); b.AddChild ( g );
        g.AddChild ( h ); g.AddChild ( i );

        Console.WriteLine ( tree.BFS ( root , ( x ) => { } ) == "root a b c d e f g h i " );
        Console.WriteLine ( tree.IterativeDFS ( root ) == "root a d e b f g h i c " );
        Console.WriteLine ( tree.RecursiveDFS ( root ) == "root a d e b f g h i c " );

        Console.WriteLine ( root.Name + " " +
                            tree.RecursiveDFS ( a ) +
                            tree.RecursiveDFS ( b ) +
                            tree.RecursiveDFS ( c ) == "root a d e b f g h i c " );
    }
}













