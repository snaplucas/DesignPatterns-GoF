using Observer.Subject;
using System;

namespace Observer.Observer
{
	public class ConcreteObserver : Observer
	{
		private string _name;
		private string _observerState;
		public ConcreteSubject _subject { get; set; }

		public ConcreteObserver(ConcreteSubject subject, string name)
		{
			_subject = subject;
			_name = name;
		}

		public override void Update()
		{
			_observerState = _subject.subjectState;
			Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
		}
	}
}
