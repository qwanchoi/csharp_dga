using System;

abstract class Animal { // 추상 클래스
    public string anme;
    public abstract void Cry(); // 추상 필수 구현
    public void Move() {
        Console.WriteLine ( "Move()" );
    }
}

class Dog : Animal {
    public override void Cry() {
        Console.WriteLine ( "wal" );
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Animal myDog = new Dog ();
        myDog.Cry ();

    }
}