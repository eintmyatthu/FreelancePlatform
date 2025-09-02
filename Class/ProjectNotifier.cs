using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Class
{
    public class ProjectNotifier : ISubject
    {
        private List<IProjectObserver> observers = new List<IProjectObserver>();

        public void RegisterObserver(IProjectObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IProjectObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
