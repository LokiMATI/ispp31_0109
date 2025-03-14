// Задания 4
using Task4;

Subject subject = new Subject();

Observer BinObserver = new BinaryObserver(subject);
Observer OctObserver = new OctalObserver(subject);
Observer HexObserver = new HexaObserver(subject);

Console.WriteLine("First state change: 15");
subject.SetState(15);

Console.WriteLine();

Console.WriteLine("Second state change: 10");
subject.SetState(10);