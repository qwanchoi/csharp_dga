using System;
using System.Collections.Generic;

public static class Exclass {
    public static string Stringify( this List<int> list ) {
        string str = ""; // String.Empty;
        for ( int i = 0 ; i < list.Count ; i++ ) {
            str += i < list.Count - 1 ? list [ i ] + " " : list [ i ].ToString ();
        }
        return str;
    }

    public static string Stringify( this List<Student> list ) {
        string str = ""; // String.Empty;
        for ( int i = 0 ; i < list.Count ; i++ ) {
            str += i < list.Count - 1 ? list [ i ].Name + " " : list [ i ].Name.ToString ();
        }
        return str;
    }

    // public static string Stringify<T>(this List<T> list) {
    //   string str = ""; // String.Empty;
    //   for(int i = 0; i < list.Count ; i++){
    //     str += i < list.Count-1 ? list[i].Name + " " : list[i].Name.ToString();
    //   }
    //   return str;
    // }
}
public class Student {
    public string Name { get; set; }
    public List<int> Scores { get; set; }
    public Student( string name , List<int> scores ) {
        Name = name;
        Scores = scores;
    }
}

class MainClass {

    public static void Main( string [] args ) {
        // 60점 미만의 낙제생 리스트(이름) 구하기: 
        // 낙제생이 아닌 사람들 리스트(이름) 구하기: 
        List<Student> nonRepeaters = new List<Student> ();
        List<Student> repeaters = new List<Student> ();

        List<Student> students = new List<Student> ();

        students.Add ( new Student ( "ctkim" , new List<int> () { 90 , 90 , 90 } ) );
        students.Add ( new Student ( "Won" , new List<int> () { 80 , 80 , 80 } ) );
        students.Add ( new Student ( "Steve" , new List<int> () { 90 , 50 , 50 } ) );
        students.Add ( new Student ( "Brown" , new List<int> () { 50 , 50 , 90 } ) );

        // for( int i = 0 ; i < students.Count ; i++ ) {
        //   if( students[i].Scores.Exists( x=> x <= 60 ) ) {
        //     repeaters.Add(students[i]);
        //   } else {
        //     nonRepeaters.Add(students[i]);
        //   }
        // }

        nonRepeaters =
          students.FindAll ( s => s.Scores.TrueForAll ( x => x >= 60 ) );
        repeaters =
          students - nonRepeaters;
      // nonRepeaters = 
      //   students.FindAll(student => student.Scores.TrueForAll(score => score >= 60));
      // repeaters =
      //   students.FindAll(student => !student.Scores.TrueForAll(score => score >= 60));


        Console.WriteLine ( nonRepeaters.Stringify () == "ctkim Won" );
        Console.WriteLine ( repeaters.Stringify () == "Steve Brown" );
    }
}










