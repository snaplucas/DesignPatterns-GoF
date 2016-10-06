using System.Collections.Generic;

namespace Observer.Subject
{
	public abstract class Subject
	{
		public List<Observer.Observer> _observers = new List<Observer.Observer>();

		public void Attach(Observer.Observer observer)
		{
			_observers.Add(observer);
		}

		public void Detach(Observer.Observer observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (Observer.Observer o in _observers)
			{
				o.Update();
			}
		}
	}
}
