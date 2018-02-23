using System;

interface IEquatable {
    bool Equals( Car car ); // 기본 public
}

interface ICloneable {
    Car Clone();
}

interface IStrable {
    string Stringify();
}

class Car : IEquatable, ICloneable, IStrable {
    public string Make { get; set; }  // 속성
                                      /*
                                      private string make;
                                      public string Make {
                                        get {
                                          return make;
                                        }
                                        set {
                                          make = value;
                                        }
                                      }*/
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

    public string Stringify() {
        string str = Make + ", " + Model + ", " + Year;
        return str;
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Car car = new Car ();
        car.Make = "BMW";
        car.Model = "Mini";
        car.Year = "2018";

        Car car2 = new Car ();
        car2.Make = "Tesla";
        car2.Model = "x";
        car2.Year = "2018";

        Console.WriteLine ( car == car2 ); // 주소값 비교
        Console.WriteLine ( car.Equals ( car2 ) );  // 메소드값 비교

        Car car3 = car.Clone ();
        Console.WriteLine ( car.Equals ( car3 ) );

        Console.WriteLine ( car.Stringify () == "BMW, Mini, 2018" );
    }
}









