using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EntityModel
{
    /// <summary>
    /// Observes the properties changes and notifies all observers that registering this notifications.
    /// </summary>
    public interface IObservable
        : INotifyPropertyChanged
    {
    }
}
