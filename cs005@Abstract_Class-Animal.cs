using System;

abstract class Animal { // �߻� Ŭ����
    public string anme;
    public abstract void Cry(); // �߻� �ʼ� ����
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