using FreelancePlatform.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancePlatform.Class
{
    public interface IProjectObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void RegisterObserver(IProjectObserver observer);
        void RemoveObserver(IProjectObserver observer);
        void NotifyObservers(string message);
    }
}

