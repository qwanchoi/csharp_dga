using System;

delegate void Event();

class Mob {
    public event Event OnDeath;
    // event : 내부(선언된 곳)에서만 사용가능 (외부에서 더하거나 빼거나 가능) event 
    public void TakeDamage( int damage ) {
        Console.WriteLine ( "TakeDamaged!!" );
        OnDeath ();
    }
}

class Player {

    public void Attack( Mob mob ) {
        Console.WriteLine ( "Attack" );
        mob.TakeDamage ( 120 );
    }

    public void IncreaseExp() {
        Console.WriteLine ( "IncreaseExp()" );
    }
}

class GameUI {

    public void UpdateMinimap() {
        Console.WriteLine ( "UpdateMinimap()" );
    }
}

class MainClass {
    public static void Main( string [] args ) {
        Mob mob = new Mob ();
        Player player = new Player ();
        GameUI ui = new GameUI ();

        mob.OnDeath += player.IncreaseExp;
        mob.OnDeath += ui.UpdateMinimap;

        player.Attack ( mob );

    }
}




















