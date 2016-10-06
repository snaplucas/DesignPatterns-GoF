using Observer.Observer;
using Observer.Subject;
using System;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			var subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject, "X"));
			subject.Attach(new ConcreteObserver(subject, "Y"));
			subject.Attach(new ConcreteObserver(subject, "Z"));

			subject.subjectState = "ABC";
			subject.Notify();

			Console.ReadKey();
		}
	}
}
