using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleEvent
{   class Observable
    {
        public event EventHandler SomethingHappened;
        public void DoSomething()
        { EventHandler handler = SomethingHappened;
            if (handler != null)
            { handler(this, EventArgs.Empty);
              
            }
        }
    }

    class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        { Debug.WriteLine("Something happened to " + sender); }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Observable observable = new Observable();
            Observer observer = new Observer();
            observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();
        }
    }
}
