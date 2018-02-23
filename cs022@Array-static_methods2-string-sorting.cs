using System;

class User {
    public string Name { get; set; }
    public int Age { get; set; }

    public User( string user , int age ) {
        Name = user;
        Age = age;
    }
}

class MainClass {
    static string Stringify( string [] str ) {
        string result = "";

        for ( int i = 0 ; i < str.Length ; i++ ) {
            if ( i != str.Length - 1 ) {
                result += str [ i ] + " ";
            } else {
                result += str [ i ];
            }
        }
        return result;

    }

    //static 

    public static void Main( string [] args ) {
        string [] names = new string [] { "c" , "b" , "a" , "d" };

        Console.WriteLine ( names.GetType ().ToString () == "System.String[]" );
        Console.WriteLine ( names.GetType ().BaseType.ToString () == "System.Array" );

        Console.WriteLine ( Stringify ( new string [] { "a" } ) == "a" );
        Console.WriteLine ( Stringify ( new string [] { } ) == string.Empty );
        Console.WriteLine ( Stringify ( names ) == "c b a d" );



        // Sorting : 오름차순(Ascending order)


        User [] users = new User [ 3 ] {  new User("Betty", 23),
      new User("Susan", 20),
      new User("Lisa", 25) };
        Array.Sort ( users , ( user1 , user2 ) => user1.Age.CompareTo ( user2.Age ) );
        // (user1.Age - user2.Age)

        foreach ( User user in users ) {
            Console.Write ( user.Name + user.Age + " " );
        }
        Console.WriteLine ();

        Array.Sort ( users , ( user1 , user2 ) => user1.Name.CompareTo ( user2.Name ) );

        foreach ( User user in users ) {
            Console.Write ( user.Name + user.Age + " " );
        }
        Console.WriteLine ();

    }
}


















