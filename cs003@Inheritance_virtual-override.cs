using System;

class A {
    public virtual string bye() {
        return "A";
    }
}

class B : A { // A로부터 상속
    public override string bye() {
        return base.bye () + "B";
        //기존 상속받던 함수를 사용;
    }
}

class C : B {
    public override string bye() {
        return "C";
    }
}



class MainClass {
    public static void Main( string [] args ) {

        A a = new A ();
        Console.WriteLine ( a.bye () == "A" );
        B b = new B ();
        Console.WriteLine ( b.bye () == "AB" );
        C c = new C ();
        Console.WriteLine ( c.bye () == "C" );

        A aa = new B ();
        Console.WriteLine ( aa.bye () == "AB" );
        B bb = new C ();
        Console.WriteLine ( bb.bye () == "C" );
        //C cc = new A(); // A에 없는것이 C에 있을 수 있기때문에 에러
        //Console.WriteLine(cc.bye() == "C");

    }
}















