// https://msdn.microsoft.com/library/6sh2ey19.aspx

// LINQ: Language INtegrated Query
// 일종의 쿼리 표현식
// 컴파일러가 알아서 함수형식으로 변경 시킴

// IEnumerable Extension Method로 정의 되어 있음
// using System.Linq 네임스페이스를 가짐

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Student {
    public string Name { get; set; }
    public int Height { get; set; }
    public List<int> Scores { get; set; }

    public override string ToString() { return Name; }
}

public static class Exclass {
    public static string Stringify<T>( this IEnumerable<T> list ) {
        string s = String.Empty;
        foreach ( var v in list )
            s += v.ToString () + " ";
        if ( s.Length > 0 )
            s = s.Substring ( 0 , s.Length - 1 );
        return s;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        List<Student> list = new List<Student> {
      new Student() { Name = "ctkim", Height=175, Scores = new List<int>() { 100, 70, 90, 77, 88 } },
      new Student() { Name = "Steve", Height=167, Scores = new List<int>() { 77, 60, 90, 77, 55 } },
      new Student() { Name = "Brown", Height=180, Scores = new List<int>() { 30, 61, 91, 100, 57 } },
      new Student() { Name = "Won", Height=171, Scores = new List<int>() { 100, 100, 91, 100, 100 } },
      new Student() { Name = "JJ", Height=165, Scores = new List<int>() { 10, 100, 9, 100, 100 } }
    };

        Console.WriteLine ( list.Stringify () == "ctkim Steve Brown Won JJ" );


        var ss6 = from student in list
                  where student.Height < 175
                  orderby student.Height
                  select new { Name = student.Name , InchHeight = student.Height * 0.393 };
        foreach ( var s in ss6 )
            Console.WriteLine ( s.Name + " " + s.InchHeight );
        Console.WriteLine ();


        int [] numbers = { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };
        var evens = from n in numbers
                    where n % 2 == 0
                    select n;

        Console.WriteLine ( evens.Stringify () == "2 4 6 8 10" );

    }
}