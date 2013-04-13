﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EntityModel.Notifiers
{
    /// <summary>
    /// An observable entity which notifies all changes about its state.
    /// </summary>
    /// <typeparam name="TKey">Indicates the type of identity.</typeparam>
    public abstract class ObservableEntity<TKey>
        : BaseEntity<TKey>, IObservable
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies properties changes to listeners.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
