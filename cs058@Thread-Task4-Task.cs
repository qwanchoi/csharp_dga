// Task: �񵿱� �ڵ带 ���� �ۼ��ϱ� ���� ���̺귯��
// ���ӽ����̽��� �� �� �ֵ��� �Ϻδ� Thread�� �����Ǿ� �ִ�.
// using System.Threading.Tasks;


using System;
using System.Threading;
using System.Threading.Tasks;


class MainClass {
    public static void Main( string [] args ) {

        DateTime startTime = DateTime.Now;

        // 1
        Task task = new Task ( () => {
            Thread.Sleep ( 1000 );
            Console.WriteLine ( "in Task: " + Thread.CurrentThread.ManagedThreadId );
        } );
        task.Start ();

        // 2
        Task task1 = new Task ( ( param ) => {
            Thread.Sleep ( 1500 );
            Console.WriteLine ( "in Task({0}): {1}" , param , Thread.CurrentThread.ManagedThreadId );
        } , "hello task" );

        task1.Start ();
        // task1.RunSynchronously();   // ��������� �۵��ϰ�, task1 thread�� ������ ����� ������ ���

        // 3
        Task task2 = Task.Run ( () => {
            for ( int i = 0 ; i < 5 ; i++ ) {
                Thread.Sleep ( 500 );
                Console.WriteLine ( "in Task2: " + Thread.CurrentThread.ManagedThreadId );
            }
        } );



        // 4
        Task task3 = Task.Factory.StartNew ( () => Console.WriteLine ( "Hello from task3" ) );


        DateTime endTime = DateTime.Now;
        TimeSpan elapsed = endTime - startTime;
        Console.WriteLine ( elapsed );


        task.Wait ();

        task1.Wait ();

        task2.Wait ();

        task3.Wait ();

        Console.WriteLine ( "after Waiting" );
    }
}
