﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel
{
    /// <summary>
    /// A base class for persistent entities.
    /// </summary>
    /// <typeparam name="TKey">Type of identifier for this entity.</typeparam>
    [Serializable]
    public abstract class BaseEntity<TKey>
    {
        /// <summary>
        /// 
        /// </summary>
        private TKey id;
        private bool assignedId = false;

        /// <summary>
        /// Gets and sets the identifier of the calling entity.
        /// </summary>
        public virtual TKey ID
        {
            get { return this.id; }
            protected set
            {
                this.id = value;
                this.assignedId = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj != null && obj is BaseEntity<TKey>)
            {
                return this.GetHashCode() == obj.GetHashCode();
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            TKey key = default(TKey);
            return 7 * (key.Equals(ID) ? key.GetHashCode() : this.ID.GetHashCode());
        }

        /// <summary>
        /// It rappresents information about the current state of the calling entity.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Entity Name: {0}, ID: {1}", this.GetType().Name, this.assignedId ? this.ID.ToString() : "[no set]");
        }
    }
}
