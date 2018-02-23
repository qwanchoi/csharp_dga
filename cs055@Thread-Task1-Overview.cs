/*
Thread Programming
Process : ���� ������ ������ �Ǿ� �޸𸮿� ����� �ν��Ͻ��� ���̹�, word.exe�� ��üȭ
Process�� �ϳ� �̻��� Thread�� ����.
���ݱ����� �ϳ��� process�� �ϳ��� thread�� �������� �ۼ��ߴ�.
�ϳ��� thread������ �� �� �ִ� ���� �������̴�. ū ������ ���糪 �ٿ�ε��� ���� thread �ʿ��ϴ�.
���ÿ� ���� thread�� �̿��ؼ� ���α׷����� �ϸ� Multi-thread Programming �̶� �Ѵ�.

���� : ������, �ڿ� ����, ������(light)
���� : debugging, Context switching
*/

using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
    public static void Main( string [] args ) {
        Console.WriteLine ( "Thread Id:" + Thread.CurrentThread.ManagedThreadId );
    }
}