using System;

class Shape {
    public virtual void Draw() {
        Console.WriteLine ( "base.draw()" );
    }
}

class Rectangle : Shape {
    public override void Draw() {
        Console.WriteLine ( "Drawing a rectangle" );
        base.Draw ();
    }
}

class Triangle : Shape {
    public override void Draw() {
        Console.WriteLine ( "Drawing a triangle" );
        base.Draw ();
    }
}

class Circle : Shape {
    public override void Draw() {
        Console.WriteLine ( "Drawing a Circle" );
        base.Draw ();
    }
}

class MainClass {
    public static void Main( string [] args ) {

        // Polymorphism #1 : Shape������ �ڵ� ĳ���õȴ�.
        Shape [] shapes = new Shape [] {
      new Rectangle(),
      new Triangle(),
      new Circle()
    };

        // Polymorphism #2 : base �� draw()�ƴ϶� ������ draw()�� ȣ��ȴ�.
        foreach ( Shape shape in shapes )
            shape.Draw ();
    }
}


















