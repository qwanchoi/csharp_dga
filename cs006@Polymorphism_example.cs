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

        // Polymorphism #1 : Shape형으로 자동 캐스팅된다.
        Shape [] shapes = new Shape [] {
      new Rectangle(),
      new Triangle(),
      new Circle()
    };

        // Polymorphism #2 : base 의 draw()아니라 하위의 draw()가 호출된다.
        foreach ( Shape shape in shapes )
            shape.Draw ();
    }
}


















