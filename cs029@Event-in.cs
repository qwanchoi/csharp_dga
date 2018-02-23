using System;

delegate void Event();

class Mob {
    public event Event OnDeath;
    // event : ����(����� ��)������ ��밡�� (�ܺο��� ���ϰų� ���ų� ����) event 
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




















