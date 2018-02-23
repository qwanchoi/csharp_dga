// Critical section(CS): �� ���� �ϳ��� thread�� ���� ������ �ڵ� ����, ���⼭�� Increase() ��
// lock�� ����ϸ� �� �Ǵ� object
// 1. this
// 2. GetType()�� �����: Type��
// 3. string

using System;
using System.Threading;

class Counter {
    public int Count { get; set; }
    private readonly object thisLock = new object ();
    public void Increase() {
        lock ( thisLock ) { // ���� �����尡 ���� �� �� ���� �۾��� �Ϸ�Ǳ���� ���
            int temp = Count;
            Console.WriteLine ( "Thread {0} : {1} " , Thread.CurrentThread.ManagedThreadId , temp );
            temp = temp + 1;
            Thread.Sleep ( 1 );
            Count = temp;
        }
    }
}
class MainClass {
    public static void Main( string [] args ) {
        Counter c = new Counter ();
        Thread t = new Thread ( new ThreadStart ( c.Increase ) );
        Thread t2 = new Thread ( new ThreadStart ( c.Increase ) );
        Thread t3 = new Thread ( new ThreadStart ( c.Increase ) );

        t.Start ();
        t2.Start ();
        t3.Start ();

        t.Join ();
        t2.Join ();
        t3.Join ();

        Console.WriteLine ( c.Count );
    }
}

// using System;
// using System.Threading;

// class Counter {
//   public int Count { get; set; }
//   private readonly object thisLock = new object();
//   public void Increase() { 
//     lock( thisLock ) {
//       int temp = Count;
//       Console.WriteLine("Thread {0} : {1} ", Thread.CurrentThread.ManagedThreadId, temp);
//       temp = temp + 1;
//       Thread.Sleep(1);
//       Count = temp;
//     }
//   }
// }



// class Counter {
//   public int Count { get; set; }
//   public void Increase() { 
//     Count++;
//   }
// }

// class MainClass {
//   public static void Main (string[] args) {
//     Counter c = new Counter();
//     Thread t = new Thread(new ThreadStart(c.Increase));
//     Thread t2 = new Thread(new ThreadStart(c.Increase));
//     Thread t3 = new Thread(new ThreadStart(c.Increase));

//     t.Start();
//     t2.Start();
//     t3.Start();

//     t.Join();
//     t2.Join();
//     t3.Join();

//     Console.WriteLine(c.Count);
//   }
// }
