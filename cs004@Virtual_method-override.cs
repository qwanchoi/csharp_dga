using System;

class LivingEntity {
    public float health = 100;

    public virtual void TakeDamage( float damage ) {
        health -= damage;
        Console.WriteLine ( "HP : " + health );
    }
}

class Enemy : LivingEntity {
    public override void TakeDamage( float damage ) {
        if ( damage >= health ) {
            Console.WriteLine ( "Add user's xp point" );
            Console.WriteLine ( "Death Effect" );
            health = 0;
        } else {
            base.TakeDamage ( damage );
        }
    }
}

class Player : LivingEntity {
    public override void TakeDamage( float damage ) {
        if ( damage >= health ) {
            Console.WriteLine ( "Revive" );
            health = 100;
        } else {
            base.TakeDamage ( damage );
        }
    }
}

class MainClass {
    public static void Main( string [] args ) {

        Player player = new Player ();
        Enemy enemy = new Enemy ();

        enemy.TakeDamage ( 10 );
        Console.WriteLine ( enemy.health == 90 );
        player.TakeDamage ( 100 );
        Console.WriteLine ( player.health == 100 );


        //foreach (LivingEntity le

    }
}





















