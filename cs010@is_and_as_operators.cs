using System;

interface IEquatable {
    bool Equals( Car car ); // 기본 public
}

interface ICloneable {
    Car Clone();
}

class Car : IEquatable, ICloneable {
    public string Make { get; set; }  // 속성
    public string Model { get; set; }
    public string Year { get; set; }

    public bool Equals( Car value ) {
        if ( Make == value.Make && Model == value.Model && Year == value.Year )
            return true;
        else
            return false;
    }

    public Car Clone() {
        Car carA = new Car ();
        carA.Make = Make;
        carA.Model = Model;
        carA.Year = Year;

        return carA;
    }
}

class Cake {

}

class MainClass {
    public static void Main( string [] args ) {
        Car car = new Car ();
        car.Make = "BMW";
        car.Model = "Mini";
        car.Year = "2018";

        Console.WriteLine ( car is int == false );
        Console.WriteLine ( car is Cake == false );
        Console.WriteLine ( car is Car == true );
        Console.WriteLine ( car is IEquatable == true );
        Console.WriteLine ( car is ICloneable == true );
        Console.WriteLine ( car is object == true );

        ICloneable ic = car as ICloneable; // type 변환
        Console.WriteLine ( ic != null );
        Console.WriteLine ( ic.GetType ().Name == "Car" );

        Cake cake = new Cake ();
        //Cake cake = car as Cake;
        //Console.WriteLine(cake == null);

    }
}















