using System;

class A {
    public string bye() {
        return "A";

    }
}

class B : A { // A로부터 상속
    public string bye() {
        return "B";
    }
}

class C : B {
    public string bye() {
        return "C";
    }
}



class MainClass {
    public static void Main( string [] args ) {

        A a = new A ();
        Console.WriteLine ( a.bye () == "A" );
        B b = new B ();
        Console.WriteLine ( b.bye () == "B" );
        C c = new C ();
        Console.WriteLine ( c.bye () == "C" );

        A aa = new B ();
        Console.WriteLine ( aa.bye () == "A" );
        B bb = new C (); // 타입을 따라간다
        Console.WriteLine ( bb.bye () == "B" );
        //C cc = new A(); // A에 없는것이 C에 있을 수 있기때문에 에러
        //Console.WriteLine(cc.bye() == "C");

    }
}
