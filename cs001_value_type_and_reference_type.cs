using System;

class Cake {
    public string name;
    public int price;

    public Cake Clone() {
        Cake cakeA = new Cake ();
        cakeA.name = name;
        cakeA.price = price;

        return cakeA;
    }
}


class MainClass {
    public static void Main( string [] args ) {
        Cake cake = new Cake ();
        cake.name = "apple";
        cake.price = 10000;

        Cake cakeA = new Cake ();
        cakeA.name = "rice";
        cakeA.price = 12000;

        Cake cakeB = cake.Clone ();
        cakeB.name = "berry";


        Console.WriteLine ( cakeB.name );
        Console.WriteLine ( cake.price == cakeB.price );
    }
}