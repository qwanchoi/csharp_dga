using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
    public static void Main( string [] args ) {

        Task<string> task = new Task<string> ( () => { // Func<string> delegate ��
            Thread.Sleep ( 100 );
            Console.WriteLine ( "in Task: " + Thread.CurrentThread.ManagedThreadId );
            return "Task result";
        } );
        task.Start ();
        Console.WriteLine ( "in Main" );

        // task.Wait(); ���� ����
        Console.WriteLine ( task.Result == "Task result" );

        Task<string> task2 = new Task<string> ( () => { // Func<string> delegate ��
            Thread.Sleep ( 100 );
            Console.WriteLine ( "in Task: " + Thread.CurrentThread.ManagedThreadId );
            return "Task2 result";
        } );
        task2.Start ();
        Console.WriteLine ( "in Main" );

        //task.Wait(); ���� ����
        Console.WriteLine ( task2.Result == "Task2 result" );

    }
}

